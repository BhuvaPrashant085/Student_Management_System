using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DOTNET
{
    public partial class UploadCIA2 : Form
    {
        // Connection string for the database
        string connectionString = "Data Source=.;Initial Catalog=SMS;Integrated Security=True";

        // Constructor
        public UploadCIA2()
        {
            InitializeComponent();
        }

        // Load event handler to load student data
        private void UploadCIA2_Load(object sender, EventArgs e)
        {
            LoadStudents();  // Load students into ComboBox
        }

        // Load the students into the ComboBox
        private void LoadStudents()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT StudentID, Name FROM Students";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbStudents.DataSource = dt;
                cmbStudents.DisplayMember = "Name";
                cmbStudents.ValueMember = "StudentID";
            }
        }

        // Update Button Click event handler for CIA2 marks
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedValue == null)
            {
                MessageBox.Show("Select Student");
                return;
            }

            int studentId = Convert.ToInt32(cmbStudents.SelectedValue);
            decimal cia2 = Convert.ToDecimal(txtCIA2.Text); // Capture CIA2 marks

            decimal dmdwMarks = Convert.ToDecimal(txtDMDW.Text);
            decimal dotNetMarks = Convert.ToDecimal(txtDotNet.Text);
            decimal ccMarks = Convert.ToDecimal(txtCC.Text);
            decimal aiMarks = Convert.ToDecimal(txtAI.Text);
            decimal atMarks = Convert.ToDecimal(txtAT.Text);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // ============================
                    // 1️⃣ Update CIA2 Marks in SubjectMarks Table
                    // ============================
                    string updateQuery = @"
IF EXISTS (SELECT 1 FROM SubjectMarks WHERE StudentID=@id)
    UPDATE SubjectMarks
    SET 
        DMDW = @dmdwMarks,
        DotNet = @dotNetMarks,
        CC = @ccMarks,
        AI = @aiMarks,
        AT = @atMarks,
        CIA2 = @cia2
    WHERE StudentID=@id
ELSE
    INSERT INTO SubjectMarks (StudentID, StudentName, DMDW, DotNet, CC, AI, AT, CIA2)
    VALUES (@id, @name, @dmdwMarks, @dotNetMarks, @ccMarks, @aiMarks, @atMarks, @cia2)";

                    SqlCommand subCmd = new SqlCommand(updateQuery, con, transaction);
                    subCmd.Parameters.AddWithValue("@id", studentId);
                    subCmd.Parameters.AddWithValue("@name", cmbStudents.Text);  // Getting student's name
                    subCmd.Parameters.AddWithValue("@dmdwMarks", dmdwMarks);
                    subCmd.Parameters.AddWithValue("@dotNetMarks", dotNetMarks);
                    subCmd.Parameters.AddWithValue("@ccMarks", ccMarks);
                    subCmd.Parameters.AddWithValue("@aiMarks", aiMarks);
                    subCmd.Parameters.AddWithValue("@atMarks", atMarks);
                    subCmd.Parameters.AddWithValue("@cia2", cia2); // Now passing CIA2 marks
                    subCmd.ExecuteNonQuery();

                    // ============================
                    // 2️⃣ Calculate Total From All Subjects
                    // ============================
                    string totalQuery = @"
SELECT 
    ISNULL((SELECT DMDW + DotNet + CC + AI + AT FROM SubjectMarks WHERE StudentID=@id),0)";

                    SqlCommand totalCmd = new SqlCommand(totalQuery, con, transaction);
                    totalCmd.Parameters.AddWithValue("@id", studentId);

                    int totalPoints = Convert.ToInt32(totalCmd.ExecuteScalar());

                    // ============================
                    // 3️⃣ Update Leaderboard
                    // ============================
                    string leaderboardQuery = @"
IF EXISTS (SELECT 1 FROM Leaderboard WHERE StudentID=@id)
    UPDATE Leaderboard
    SET TotalPoints=@total
    WHERE StudentID=@id
ELSE
    INSERT INTO Leaderboard (StudentID, TotalPoints)
    VALUES (@id, @total)";

                    SqlCommand lbCmd = new SqlCommand(leaderboardQuery, con, transaction);
                    lbCmd.Parameters.AddWithValue("@id", studentId);
                    lbCmd.Parameters.AddWithValue("@total", totalPoints);
                    lbCmd.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            MessageBox.Show("CIA2 Marks Updated Successfully!");
        }

        // Close Button Click event handler
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}