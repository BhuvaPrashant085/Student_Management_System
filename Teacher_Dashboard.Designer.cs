using System;
using System.Drawing;
using System.Windows.Forms;

namespace DOTNET
{
    partial class Teacher_Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Button btnUploadCIA1;
        private Button btnUploadCIA2;
        private Button btnUploadResult;
        private Button btnUpdateLeaderboard;
        private Button btnViewStudents;
        private Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.btnUploadCIA1 = new Button();
            this.btnUploadCIA2 = new Button();
            this.btnUploadResult = new Button();
            this.btnUpdateLeaderboard = new Button();
            this.btnViewStudents = new Button();
            this.btnLogout = new Button();
            this.SuspendLayout();

            // =========================
            // FORM STYLE
            // =========================
            this.BackColor = Color.FromArgb(25, 25, 25);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ClientSize = new Size(950, 550);
            this.Text = "Teacher Dashboard";

            // =========================
            // TITLE
            // =========================
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(300, 30);
            this.lblTitle.Text = "👩‍🏫 Teacher Dashboard";

            Font btnFont = new Font("Segoe UI", 11F, FontStyle.Bold);
            Size btnSize = new Size(260, 90);

            // =========================
            // UPLOAD CIA 1
            // =========================
            this.btnUploadCIA1.Location = new Point(150, 120);
            this.btnUploadCIA1.Size = btnSize;
            this.btnUploadCIA1.Text = "📊 Upload CIA 1 Marks";
            this.btnUploadCIA1.Font = btnFont;
            this.btnUploadCIA1.FlatStyle = FlatStyle.Flat;
            this.btnUploadCIA1.FlatAppearance.BorderSize = 0;
            this.btnUploadCIA1.BackColor = Color.FromArgb(0, 120, 215);
            this.btnUploadCIA1.ForeColor = Color.White;
            this.btnUploadCIA1.Click += new EventHandler(this.btnUploadCIA1_Click);

           

            // =========================
            // UPLOAD RESULTS
            // =========================
            this.btnUploadResult.Location = new Point(150, 250);
            this.btnUploadResult.Size = btnSize;
            this.btnUploadResult.Text = "📄 Upload Results";
            this.btnUploadResult.Font = btnFont;
            this.btnUploadResult.FlatStyle = FlatStyle.Flat;
            this.btnUploadResult.FlatAppearance.BorderSize = 0;
            this.btnUploadResult.BackColor = Color.FromArgb(0, 150, 136);
            this.btnUploadResult.ForeColor = Color.White;
            this.btnUploadResult.Click += new EventHandler(this.btnUploadResult_Click);

            // =========================
            // UPDATE LEADERBOARD
            // =========================
            this.btnUpdateLeaderboard.Location = new Point(500, 250);
            this.btnUpdateLeaderboard.Size = btnSize;
            this.btnUpdateLeaderboard.Text = "🏆 Update Leaderboard";
            this.btnUpdateLeaderboard.Font = btnFont;
            this.btnUpdateLeaderboard.FlatStyle = FlatStyle.Flat;
            this.btnUpdateLeaderboard.FlatAppearance.BorderSize = 0;
            this.btnUpdateLeaderboard.BackColor = Color.FromArgb(255, 140, 0);
            this.btnUpdateLeaderboard.ForeColor = Color.White;
            this.btnUpdateLeaderboard.Click += new EventHandler(this.btnUpdateLeaderboard_Click);

            // =========================
            // VIEW STUDENTS
            // =========================
            this.btnViewStudents.Location = new Point(150, 380);
            this.btnViewStudents.Size = btnSize;
            this.btnViewStudents.Text = "👨‍🎓 View Students";
            this.btnViewStudents.Font = btnFont;
            this.btnViewStudents.FlatStyle = FlatStyle.Flat;
            this.btnViewStudents.FlatAppearance.BorderSize = 0;
            this.btnViewStudents.BackColor = Color.FromArgb(138, 43, 226);
            this.btnViewStudents.ForeColor = Color.White;
            this.btnViewStudents.Click += new EventHandler(this.btnViewStudents_Click);

            // =========================
            // LOGOUT
            // =========================
            this.btnLogout.Location = new Point(820, 20);
            this.btnLogout.Size = new Size(90, 35);
            this.btnLogout.Text = "Logout";
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.BackColor = Color.FromArgb(200, 50, 50);
            this.btnLogout.ForeColor = Color.White;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            // =========================
            // ADD CONTROLS
            // =========================
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnUploadCIA1);
            this.Controls.Add(this.btnUploadCIA2);
            this.Controls.Add(this.btnUploadResult);
            this.Controls.Add(this.btnUpdateLeaderboard);
            this.Controls.Add(this.btnViewStudents);
            this.Controls.Add(this.btnLogout);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}