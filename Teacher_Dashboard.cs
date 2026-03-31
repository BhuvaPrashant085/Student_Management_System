using StudentManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DOTNET
{
    public partial class Teacher_Dashboard : Form
    {
        string connectionString =
            "Data Source=.\\SQLEXPRESS;Initial Catalog=SMS;Integrated Security=True";

        public Teacher_Dashboard()
        {
            InitializeComponent();
        }

        private void Teacher_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnUploadCIA1_Click(object sender, EventArgs e)
        {
            UploadCIA form = new UploadCIA();
            form.Show();
        }

        private void btnUploadCIA2_Click(object sender, EventArgs e)
        {
            UploadCIA2 form = new UploadCIA2();
            form.Show();
        }

        private void btnUploadResult_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Result Upload Form");
        }

        private void btnUpdateLeaderboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Leaderboard Page");
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View Students List");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}