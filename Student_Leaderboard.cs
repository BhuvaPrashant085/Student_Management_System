using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace DOTNET
{
    public partial class Student_Leaderboard : Form
    {
        string connectionString =
            "Data Source=.;Initial Catalog=SMS;Integrated Security=True";

        private int studentId;

        public Student_Leaderboard(int id)
        {
            InitializeComponent();
            studentId = id;
            LoadLeaderboard();
        }


        private void Student_Leaderboard_Load(object sender, EventArgs e)
        {

        }


        private void LoadLeaderboard()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                ROW_NUMBER() OVER (ORDER BY sm.TotalPoints DESC) AS Rank, 
                s.Name, 
                sm.TotalPoints
            FROM SubjectMarks sm
            JOIN Students s ON sm.StudentID = s.StudentID
            ORDER BY sm.TotalPoints DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvLeaderboard.DataSource = dt;

                // Highlight logged-in student
                foreach (DataGridViewRow row in dgvLeaderboard.Rows)
                {
                    if (row.Cells["Name"].Value != null)
                    {
                        string name = row.Cells["Name"].Value.ToString();

                        using (SqlConnection con2 = new SqlConnection(connectionString))
                        {
                            string getName = "SELECT Name FROM Students WHERE StudentID=@id";
                            SqlCommand cmd = new SqlCommand(getName, con2);
                            cmd.Parameters.AddWithValue("@id", studentId);
                            con2.Open();
                            string currentStudentName = cmd.ExecuteScalar()?.ToString();

                            if (name == currentStudentName)
                            {
                                row.DefaultCellStyle.BackColor = Color.LightGreen;
                            }
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}