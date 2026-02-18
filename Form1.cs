using DOTNET;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        // Connection string
        string connectionString = "Data Source=.;Initial Catalog=SMS;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enroll = txtEnroll.Text;
            string password = txtPassword.Text;

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "SELECT COUNT(*) FROM Students WHERE EnrollmentNo=@enroll AND Password=@pass";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@enroll", enroll);
            cmd.Parameters.AddWithValue("@pass", password);

            int count = (int)cmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Login Successful!");

                // Open dashboard
                //DashboardForm dash = new DashboardForm();
               // dash.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Enrollment or Password");
            }

            con.Close();
        }

        private void btnSignup_Click_1(object sender, EventArgs e)
        {
            SignupForm signup = new SignupForm();
            signup.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
