using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DOTNET
{
    public partial class SignupForm : Form
    {
        string connectionString =
            @"Data Source=.\SQLEXPRESS02;Initial Catalog=SMS;Integrated Security=True;Encrypt=False";

        public SignupForm()
        {
            InitializeComponent();
        }
        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click_1(object sender, EventArgs e)
        {
        

            
            string username = txtUsername.Text.Trim();
            string enrollment = txtEnrollmentno.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            if (username == "" || enrollment == "" || password == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            int newStudentId = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
        INSERT INTO Students (EnrollmentNo, Name, Password)
        VALUES (@enroll, @name, @pass);
        SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@enroll", enrollment);
                cmd.Parameters.AddWithValue("@name", username);
                cmd.Parameters.AddWithValue("@pass", password);

                con.Open();

                newStudentId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            MessageBox.Show("Signup Successful!");

            // Open Dashboard with studentId
            MainForm dash = new MainForm(newStudentId);
            dash.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

