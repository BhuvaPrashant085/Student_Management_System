using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DOTNET
{
    public partial class UploadCIA : Form
    {
        string connectionString =
            "Data Source=.\\SQLEXPRESS;Initial Catalog=SMS;Integrated Security=True";
       

        public UploadCIA()
        {
            InitializeComponent();
        }

        private void UploadCIA_Load(object sender, EventArgs e)
        {
            LoadStudents();  // Load students into ComboBox
        }

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedValue == null)
            {
                MessageBox.Show("Select Student");
                return;
            }

            int studentId = Convert.ToInt32(cmbStudents.SelectedValue);

            // Get all the data from the form
            decimal cia1 = Convert.ToDecimal(txtCIA1.Text);
            decimal cia2 = Convert.ToDecimal(txtCIA2.Text);
            decimal dmdwMarks = Convert.ToDecimal(txtDMDW.Text);
            decimal dotNetMarks = Convert.ToDecimal(txtDotNet.Text);
            decimal ccMarks = Convert.ToDecimal(txtCC.Text);
            decimal aiMarks = Convert.ToDecimal(txtAI.Text);
            decimal atMarks = Convert.ToDecimal(txtAT.Text);
            string studentName = cmbStudents.Text; // Assuming student name is in the ComboBox

            decimal totalPoints = dmdwMarks + dotNetMarks + ccMarks + aiMarks + atMarks + cia1 + cia2;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // ============================
                    // 1️⃣ Update or Insert into SubjectMarks Table
                    // ============================
                    string updateQuery = @"
IF EXISTS (SELECT 1 FROM SubjectMarks WHERE StudentID=@id)
    UPDATE SubjectMarks
    SET 
        StudentName = @name,
        DMDW = @dmdwMarks,
        DotNet = @dotNetMarks,
        CC = @ccMarks,
        AI = @aiMarks,
        AT = @atMarks,
        CIA1 = @cia1, 
        CIA2 = @cia2,
        TotalPoints = @totalPoints
    WHERE StudentID=@id
ELSE
    INSERT INTO SubjectMarks (StudentID, StudentName, DMDW, DotNet, CC, AI, AT, CIA1, CIA2, TotalPoints)
    VALUES (@id, @name, @dmdwMarks, @dotNetMarks, @ccMarks, @aiMarks, @atMarks, @cia1, @cia2, @totalPoints)";

                    SqlCommand subCmd = new SqlCommand(updateQuery, con, transaction);
                    subCmd.Parameters.AddWithValue("@id", studentId);
                    subCmd.Parameters.AddWithValue("@name", studentName);
                    subCmd.Parameters.AddWithValue("@dmdwMarks", dmdwMarks);
                    subCmd.Parameters.AddWithValue("@dotNetMarks", dotNetMarks);
                    subCmd.Parameters.AddWithValue("@ccMarks", ccMarks);
                    subCmd.Parameters.AddWithValue("@aiMarks", aiMarks);
                    subCmd.Parameters.AddWithValue("@atMarks", atMarks);
                    subCmd.Parameters.AddWithValue("@cia1", cia1);
                    subCmd.Parameters.AddWithValue("@cia2", cia2);
                    subCmd.Parameters.AddWithValue("@totalPoints", totalPoints);
                    subCmd.ExecuteNonQuery();

                    // Commit the transaction if all commands succeed
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Rollback the transaction in case of an error
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Notify user about the successful update
            MessageBox.Show("Marks Updated Successfully!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCIA2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
