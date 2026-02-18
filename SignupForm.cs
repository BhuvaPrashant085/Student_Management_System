using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DOTNET
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            if (username == "" || password == "" || confirm == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            SqlConnection con = new SqlConnection(
                @"Data Source=.;Initial Catalog=StudentDB;Integrated Security=True;TrustServerCertificate=True");

            con.Open();

            SqlCommand cmd = new SqlCommand(
                "insert into logintab values(@u,@p)", con);

            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", password);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Account created successfully!");
            this.Close();
        }
    }
}
