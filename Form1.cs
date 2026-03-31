using DOTNET;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        // Connection string
        string connectionString = @"Data Source=.\SQLEXPRESS02;Initial Catalog=SMS;Integrated Security=True;Encrypt=False";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtEnroll.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter Username and Password");
                return;
            }

            string connectionString = @"Data Source=.\SQLEXPRESS02;Initial Catalog=SMS;Integrated Security=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // 1️⃣ Check Teacher First
                string teacherQuery = "SELECT TeacherID FROM Teachers WHERE Username=@user AND Password=@pass";
                SqlCommand teacherCmd = new SqlCommand(teacherQuery, con);
                teacherCmd.Parameters.AddWithValue("@user", username);
                teacherCmd.Parameters.AddWithValue("@pass", password);

                object teacherResult = teacherCmd.ExecuteScalar();

                if (teacherResult != null)
                {
                    MessageBox.Show("Teacher Login Successful!");

                    Teacher_Dashboard teacherDash = new Teacher_Dashboard();
                    teacherDash.Show();
                    this.Hide();
                    return;
                }

                // 2️⃣ If not teacher → Check Student
                string studentQuery = "SELECT StudentID FROM Students WHERE EnrollmentNo=@user AND Password=@pass";
                SqlCommand studentCmd = new SqlCommand(studentQuery, con);
                studentCmd.Parameters.AddWithValue("@user", username);
                studentCmd.Parameters.AddWithValue("@pass", password);

                object studentResult = studentCmd.ExecuteScalar();

                if (studentResult != null)
                {
                    int studentId = Convert.ToInt32(studentResult);

                    MessageBox.Show("Student Login Successful!");

                    MainForm studentDash = new MainForm(studentId);
                    studentDash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details");
                }
            }
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
