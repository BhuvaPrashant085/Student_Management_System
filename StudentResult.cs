using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DOTNET
{
    public partial class StudentResult : Form
    {
        private int studentId;

        public StudentResult(int id)
        {
            InitializeComponent();
            studentId = id;
            LoadResult();
        }

        private void LoadResult()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=SMS;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Variables to store subject marks
                int dmdw = 0, dotNet = 0, cc = 0, ai = 0, at = 0, cia1 = 0, cia2 = 0, num1 = 0;

                // SQL Query to get all subject marks and CIA marks
                string query = @"
                    SELECT 
                        ISNULL(DMDW, 0) AS DMDW, 
                        ISNULL(DotNet, 0) AS DotNet, 
                        ISNULL(CC, 0) AS CC, 
                        ISNULL(AI, 0) AS AI, 
                        ISNULL(AT, 0) AS AT, 
                        ISNULL(CIA1, 0) AS CIA1, 
                        ISNULL(CIA2, 0) AS CIA2 
                    FROM SubjectMarks 
                    WHERE StudentId=@id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", studentId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Fetch subject marks and CIA marks
                    dmdw = Convert.ToInt32(reader["DMDW"]);
                    dotNet = Convert.ToInt32(reader["DotNet"]);
                    cc = Convert.ToInt32(reader["CC"]);
                    ai = Convert.ToInt32(reader["AI"]);
                    at = Convert.ToInt32(reader["AT"]);
                    cia1 = Convert.ToInt32(reader["CIA1"]);
                    cia2 = Convert.ToInt32(reader["CIA2"]);
                }
                reader.Close();

                // Calculate subject total (sum of all subjects)
                int num2 = dmdw + dotNet + cc + ai + at;
                MessageBox.Show("value "+num2);
                double subjectTotal = ((double)num2 / 300) * 100;
                MessageBox.Show("value " + subjectTotal);
                // Display subject marks, CIA marks, and grand total
                lblSubjectTotal.Text = "Subject Total: " + subjectTotal;
                lblCIA1.Text = "CIA 1: " + cia1;
                lblCIA2.Text = "CIA 2: " + cia2;
                lblGrandTotal.Text = "Grand Total: " + subjectTotal;

                // Total possible marks (maximum marks for each subject)
                  // Sum of max marks
                num1 = ((cia1 + cia2 / 2) / 60) * 100;
                
                // Calculate the final percentage
                double finalPercentage = (((double)subjectTotal+num1) / 1) ;
                lblPercentage.Text = "Final Percentage: " + finalPercentage.ToString("F2") + "%";

                // Determine the result based on the total marks
                if (subjectTotal >= (finalPercentage * 0.25))  // Pass condition (25% of total max marks)
                {
                    lblResult.Text = "Result: PASS";
                    lblResult.ForeColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    lblResult.Text = "Result: FAIL";
                    lblResult.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}