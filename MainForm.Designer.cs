using System;
using System.Drawing;
using System.Windows.Forms;

namespace DOTNET
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Button btnLeaderboard;
        private Button btnCIA1;
        private Button btnResults;
        private Button btnInternship;
        private Button btnProjects;
        private Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.btnCIA1 = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnInternship = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(280, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🎓 Student Dashboard";
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnLeaderboard.FlatAppearance.BorderSize = 0;
            this.btnLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaderboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLeaderboard.ForeColor = System.Drawing.Color.White;
            this.btnLeaderboard.Location = new System.Drawing.Point(150, 120);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(230, 90);
            this.btnLeaderboard.TabIndex = 1;
            this.btnLeaderboard.Text = "🏆 Leaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = false;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // btnCIA1
            // 
            this.btnCIA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCIA1.FlatAppearance.BorderSize = 0;
            this.btnCIA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCIA1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCIA1.ForeColor = System.Drawing.Color.White;
            this.btnCIA1.Location = new System.Drawing.Point(318, 245);
            this.btnCIA1.Name = "btnCIA1";
            this.btnCIA1.Size = new System.Drawing.Size(230, 90);
            this.btnCIA1.TabIndex = 3;
            this.btnCIA1.Text = "📊 CIA  Marks";
            this.btnCIA1.UseVisualStyleBackColor = false;
            this.btnCIA1.Click += new System.EventHandler(this.btnCIA1_Click);
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnResults.FlatAppearance.BorderSize = 0;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnResults.ForeColor = System.Drawing.Color.White;
            this.btnResults.Location = new System.Drawing.Point(150, 360);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(230, 90);
            this.btnResults.TabIndex = 5;
            this.btnResults.Text = "📄 Results";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnInternship
            // 
            this.btnInternship.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnInternship.FlatAppearance.BorderSize = 0;
            this.btnInternship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInternship.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnInternship.ForeColor = System.Drawing.Color.White;
            this.btnInternship.Location = new System.Drawing.Point(500, 120);
            this.btnInternship.Name = "btnInternship";
            this.btnInternship.Size = new System.Drawing.Size(230, 90);
            this.btnInternship.TabIndex = 2;
            this.btnInternship.Text = "💼 Internship";
            this.btnInternship.UseVisualStyleBackColor = false;
            this.btnInternship.Click += new System.EventHandler(this.btnInternship_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnProjects.FlatAppearance.BorderSize = 0;
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjects.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnProjects.ForeColor = System.Drawing.Color.White;
            this.btnProjects.Location = new System.Drawing.Point(500, 360);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(230, 90);
            this.btnProjects.TabIndex = 6;
            this.btnProjects.Text = "📚 Projects & Assignments";
            this.btnProjects.UseVisualStyleBackColor = false;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(780, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 35);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.btnInternship);
            this.Controls.Add(this.btnCIA1);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnProjects);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Dashboard";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}