using System.Drawing;
using System.Windows.Forms;

namespace DOTNET
{
    partial class Student_Leaderboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvLeaderboard;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            this.SuspendLayout();

            // =========================
            // FORM SETTINGS
            // =========================
            this.BackColor = Color.FromArgb(25, 25, 25);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1000, 600);
            this.MinimumSize = new Size(800, 500);
            this.Text = "Student Leaderboard";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // =========================
            // TITLE
            // =========================
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.Gold;
            this.lblTitle.Location = new Point(330, 30);
            this.lblTitle.Text = "🏆 Student Leaderboard";
            this.lblTitle.Anchor = AnchorStyles.Top;

            // =========================
            // DATAGRIDVIEW
            // =========================
            this.dgvLeaderboard.Location = new Point(80, 120);
            this.dgvLeaderboard.Size = new Size(840, 350);
            this.dgvLeaderboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvLeaderboard.ReadOnly = true;
            this.dgvLeaderboard.AllowUserToAddRows = false;
            this.dgvLeaderboard.AllowUserToResizeRows = false;
            this.dgvLeaderboard.AllowUserToResizeColumns = false;
            this.dgvLeaderboard.BorderStyle = BorderStyle.None;
            this.dgvLeaderboard.BackgroundColor = Color.FromArgb(40, 40, 40);
            this.dgvLeaderboard.GridColor = Color.FromArgb(60, 60, 60);
            this.dgvLeaderboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaderboard.RowHeadersVisible = false;

            // Header Style
            this.dgvLeaderboard.EnableHeadersVisualStyles = false;
            this.dgvLeaderboard.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            this.dgvLeaderboard.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvLeaderboard.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.dgvLeaderboard.ColumnHeadersHeight = 40;

            // Row Style
            this.dgvLeaderboard.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            this.dgvLeaderboard.DefaultCellStyle.ForeColor = Color.White;
            this.dgvLeaderboard.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136);
            this.dgvLeaderboard.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dgvLeaderboard.DefaultCellStyle.Font = new Font("Segoe UI", 11F);
            this.dgvLeaderboard.RowTemplate.Height = 35;

            // Alternating Row Color
            this.dgvLeaderboard.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);

            // =========================
            // CLOSE BUTTON
            // =========================
            this.btnClose.Location = new Point(430, 500);
            this.btnClose.Size = new Size(140, 45);
            this.btnClose.Text = "Close";
            this.btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.BackColor = Color.FromArgb(220, 53, 69);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Anchor = AnchorStyles.Bottom;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // =========================
            // ADD CONTROLS
            // =========================
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvLeaderboard);
            this.Controls.Add(this.btnClose);

            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}