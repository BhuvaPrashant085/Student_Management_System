// ============================================================
// Teacher_Dashboard.cs  (UPDATED)
// Replace the existing Teacher_Dashboard.cs with this file
// Changes: btnInternship and btnProjects buttons open real forms
// ============================================================

using StudentManagementSystem;
using System;
using System.Windows.Forms;

namespace DOTNET
{
    public partial class Teacher_Dashboard : Form
    {
        string connectionString = "Data Source=UGB2-10-50;Initial Catalog=SMS;Integrated Security=True";

        public Teacher_Dashboard()
        {
            InitializeComponent();
        }

        private void Teacher_Dashboard_Load(object sender, EventArgs e) { }

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

        // ── NEW: Opens Internship Manager ────────────────────
        private void btnManageInternships_Click(object sender, EventArgs e)
        {
            TeacherInternshipManager mgr = new TeacherInternshipManager();
            mgr.Show();
        }

        // ── NEW: Opens Projects & Assignments Manager ────────
        private void btnManageProjects_Click(object sender, EventArgs e)
        {
            TeacherProjectsManager mgr = new TeacherProjectsManager();
            mgr.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}
