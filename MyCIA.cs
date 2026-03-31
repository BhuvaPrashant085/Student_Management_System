using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DOTNET
{
    public partial class MyCIA : Form
    {
        private int studentId;

        public MyCIA(int id)
        {
            InitializeComponent();
            studentId = MainForm.LoggedInStudentId; // Get the logged-in student ID from the global state
            MessageBox.Show("Student ID passed: " + studentId);
            Console.WriteLine("Student ID passed: " + studentId); // Debug line
            LoadMarks(); // Load student marks using the studentId
        }

        private void LoadMarks()
        {
            Console.WriteLine("Fetching marks for Student ID: " + studentId); // Debug line

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SMS;Integrated Security=True"))
            {
                string query = @"
        SELECT 
            DMDW, 
            DotNet, 
            CC, 
            AI, 
            AT, 
            CIA1, 
            CIA2, 
            TotalPoints
        FROM SubjectMarks 
        WHERE StudentID = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", studentId);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Check if data is returned
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Debug: Check values retrieved
                            Console.WriteLine("DMDW: " + reader["DMDW"]);
                            Console.WriteLine("DotNet: " + reader["DotNet"]);
                            Console.WriteLine("CC: " + reader["CC"]);
                            Console.WriteLine("AI: " + reader["AI"]);
                            Console.WriteLine("AT: " + reader["AT"]);
                            Console.WriteLine("CIA1: " + reader["CIA1"]);
                            Console.WriteLine("CIA2: " + reader["CIA2"]);
                            Console.WriteLine("TotalPoints: " + reader["TotalPoints"]);

                            // Assign values to the labels, checking for DBNull
                            lblDMDW.Text = "DMDW: " + (reader["DMDW"] == DBNull.Value ? "N/A" : reader["DMDW"].ToString());
                            lblDotNet.Text = ".NET: " + (reader["DotNet"] == DBNull.Value ? "N/A" : reader["DotNet"].ToString());
                            lblCC.Text = "CC: " + (reader["CC"] == DBNull.Value ? "N/A" : reader["CC"].ToString());
                            lblAI.Text = "AI: " + (reader["AI"] == DBNull.Value ? "N/A" : reader["AI"].ToString());
                            lblAT.Text = "AT: " + (reader["AT"] == DBNull.Value ? "N/A" : reader["AT"].ToString());
                            lblCIA1.Text = "CIA 1: " + (reader["CIA1"] == DBNull.Value ? "N/A" : reader["CIA1"].ToString());
                            lblCIA2.Text = "CIA 2: " + (reader["CIA2"] == DBNull.Value ? "N/A" : reader["CIA2"].ToString());
                            lblTotalPoints.Text = "Total Points: " + (reader["TotalPoints"] == DBNull.Value ? "N/A" : reader["TotalPoints"].ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("No marks found for the selected student. "+ studentId);
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching data: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}