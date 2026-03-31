namespace DOTNET
{
    partial class InternshipDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOpen = new System.Windows.Forms.TabPage();
            this.tabMine = new System.Windows.Forms.TabPage();
            this.dgvOpenInternships = new System.Windows.Forms.DataGridView();
            this.dgvMyApplications = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOpenCount = new System.Windows.Forms.Label();
            this.lblApproved = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.lblRejected = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            // ==================== panelHeader (Modern Dark) ====================
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 70;
            this.panelHeader.Controls.Add(this.lblTitle);

            // ==================== lblTitle ====================
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Text = "Internship Portal";

            // ==================== tabControl ====================
            this.tabControl1.Location = new System.Drawing.Point(20, 90);
            this.tabControl1.Size = new System.Drawing.Size(840, 340);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl1.TabPages.Add(this.tabOpen);
            this.tabControl1.TabPages.Add(this.tabMine);

            // ==================== tabOpen (Available) ====================
            this.tabOpen.Text = "Browse Jobs";
            this.tabOpen.BackColor = System.Drawing.Color.White;
            this.tabOpen.Controls.Add(this.lblOpenCount);
            this.tabOpen.Controls.Add(this.dgvOpenInternships);

            this.lblOpenCount.Location = new System.Drawing.Point(10, 10);
            this.lblOpenCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblOpenCount.ForeColor = System.Drawing.Color.Gray;
            this.lblOpenCount.Text = "Loading positions...";

            this.dgvOpenInternships.Location = new System.Drawing.Point(10, 35);
            this.dgvOpenInternships.Size = new System.Drawing.Size(810, 260);
            this.ApplyGridStyle(this.dgvOpenInternships, System.Drawing.Color.FromArgb(9, 132, 227));

            // ==================== tabMine (Applications) ====================
            this.tabMine.Text = "My Status";
            this.tabMine.BackColor = System.Drawing.Color.White;
            this.tabMine.Controls.Add(this.lblApproved);
            this.tabMine.Controls.Add(this.lblPending);
            this.tabMine.Controls.Add(this.lblRejected);
            this.tabMine.Controls.Add(this.dgvMyApplications);

            this.lblApproved.Location = new System.Drawing.Point(10, 10);
            this.lblApproved.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.lblApproved.Text = "✔ Approved: 0";
            this.lblApproved.AutoSize = true;

            this.lblPending.Location = new System.Drawing.Point(130, 10);
            this.lblPending.ForeColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.lblPending.Text = "⏳ Pending: 0";
            this.lblPending.AutoSize = true;

            this.lblRejected.Location = new System.Drawing.Point(240, 10);
            this.lblRejected.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.lblRejected.Text = "✖ Rejected: 0";
            this.lblRejected.AutoSize = true;

            this.dgvMyApplications.Location = new System.Drawing.Point(10, 35);
            this.dgvMyApplications.Size = new System.Drawing.Size(810, 260);
            this.ApplyGridStyle(this.dgvMyApplications, System.Drawing.Color.FromArgb(108, 92, 231));

            // ==================== Action Buttons ====================
            // Standardizing button sizes and flat style
            this.btnApply.Location = new System.Drawing.Point(25, 445);
            this.btnApply.Size = new System.Drawing.Size(140, 40);
            this.btnApply.Text = "Apply Now";
            this.ApplyButtonStyle(this.btnApply, System.Drawing.Color.FromArgb(9, 132, 227));
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);

            this.btnRefresh.Location = new System.Drawing.Point(175, 445);
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.Text = "Refresh";
            this.ApplyButtonStyle(this.btnRefresh, System.Drawing.Color.FromArgb(178, 190, 195));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.Location = new System.Drawing.Point(740, 445);
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.Text = "Exit";
            this.ApplyButtonStyle(this.btnClose, System.Drawing.Color.FromArgb(225, 112, 85));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // ==================== Form Setup ====================
            this.ClientSize = new System.Drawing.Size(880, 510);
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.InternshipDashboard_Load);

            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);

            this.ResumeLayout(false);
        }

        // Helper to keep the code DRY and clean
        private void ApplyButtonStyle(System.Windows.Forms.Button btn, System.Drawing.Color color)
        {
            btn.BackColor = color;
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
        }

        private void ApplyGridStyle(System.Windows.Forms.DataGridView dgv, System.Drawing.Color headerColor)
        {
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.EnableHeadersVisualStyles = false;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersHeight = 35;
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOpen;
        private System.Windows.Forms.TabPage tabMine;
        private System.Windows.Forms.DataGridView dgvOpenInternships;
        private System.Windows.Forms.DataGridView dgvMyApplications;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOpenCount;
        private System.Windows.Forms.Label lblApproved;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblRejected;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelHeader;
    }
}