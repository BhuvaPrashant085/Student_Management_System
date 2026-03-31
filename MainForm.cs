using DOTNET;
using StudentManagementSystem;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DOTNET
{
    public partial class MainForm : Form
    {
        public static int LoggedInStudentId { get; set; }
        private int id;

        public MainForm(int studentId)
        {
            InitializeComponent();
            LoggedInStudentId = studentId;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            Student_Leaderboard board = new Student_Leaderboard(LoggedInStudentId);
            board.Show();
        }

        private void btnCIA1_Click(object sender, EventArgs e)
        {
            MyCIA board = new MyCIA(LoggedInStudentId);
            board.Show();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            StudentResult board = new StudentResult(LoggedInStudentId);
            board.Show();
        }

        private void btnInternship_Click(object sender, EventArgs e)
        {
            InternshipDashboard intern = new InternshipDashboard(LoggedInStudentId);
            intern.Show();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            ProjectsAssignmentsDashboard proj = new ProjectsAssignmentsDashboard(LoggedInStudentId);
            proj.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
        }
    }
}
