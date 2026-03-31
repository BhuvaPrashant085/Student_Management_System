namespace DOTNET
{
    partial class ProjectsAssignmentsDashboard
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
            this.tabControl1          = new System.Windows.Forms.TabControl();
            this.tabProjects          = new System.Windows.Forms.TabPage();
            this.tabAssignments       = new System.Windows.Forms.TabPage();
            this.tabMyProjects        = new System.Windows.Forms.TabPage();
            this.tabMyAssignments     = new System.Windows.Forms.TabPage();
            this.dgvProjects          = new System.Windows.Forms.DataGridView();
            this.dgvAssignments       = new System.Windows.Forms.DataGridView();
            this.dgvMyProjects        = new System.Windows.Forms.DataGridView();
            this.dgvMyAssignments     = new System.Windows.Forms.DataGridView();
            this.lblTitle             = new System.Windows.Forms.Label();
            this.lblProjectCount      = new System.Windows.Forms.Label();
            this.lblAssignCount       = new System.Windows.Forms.Label();
            this.lblNotesHint         = new System.Windows.Forms.Label();
            this.txtNotes             = new System.Windows.Forms.TextBox();
            this.btnSubmitProject     = new System.Windows.Forms.Button();
            this.btnSubmitAssignment  = new System.Windows.Forms.Button();
            this.btnRefresh           = new System.Windows.Forms.Button();
            this.btnClose             = new System.Windows.Forms.Button();
            this.panelHeader          = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            // ==================== panelHeader ====================
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            this.panelHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height    = 65;
            this.panelHeader.Controls.Add(this.lblTitle);

            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location  = new System.Drawing.Point(200, 14);
            this.lblTitle.Text      = "📚 Projects & Assignments Dashboard";

            // ==================== tabControl ====================
            this.tabControl1.Location = new System.Drawing.Point(15, 80);
            this.tabControl1.Size     = new System.Drawing.Size(855, 330);
            this.tabControl1.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.TabPages.Add(this.tabProjects);
            this.tabControl1.TabPages.Add(this.tabAssignments);
            this.tabControl1.TabPages.Add(this.tabMyProjects);
            this.tabControl1.TabPages.Add(this.tabMyAssignments);

            // ==================== tabProjects ====================
            this.tabProjects.Text    = "  Projects  ";
            this.tabProjects.Padding = new System.Windows.Forms.Padding(5);
            this.tabProjects.Controls.Add(this.lblProjectCount);
            this.tabProjects.Controls.Add(this.dgvProjects);

            this.lblProjectCount.AutoSize  = true;
            this.lblProjectCount.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProjectCount.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.lblProjectCount.Location  = new System.Drawing.Point(8, 8);

            SetupGrid(this.dgvProjects,
                new System.Drawing.Point(8, 30),
                new System.Drawing.Size(835, 265),
                System.Drawing.Color.FromArgb(0, 120, 215),
                System.Drawing.Color.FromArgb(235, 245, 255));

            // ==================== tabAssignments ====================
            this.tabAssignments.Text    = "  Assignments  ";
            this.tabAssignments.Padding = new System.Windows.Forms.Padding(5);
            this.tabAssignments.Controls.Add(this.lblAssignCount);
            this.tabAssignments.Controls.Add(this.dgvAssignments);

            this.lblAssignCount.AutoSize  = true;
            this.lblAssignCount.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAssignCount.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblAssignCount.Location  = new System.Drawing.Point(8, 8);

            SetupGrid(this.dgvAssignments,
                new System.Drawing.Point(8, 30),
                new System.Drawing.Size(835, 265),
                System.Drawing.Color.SeaGreen,
                System.Drawing.Color.FromArgb(235, 250, 240));

            // ==================== tabMyProjects ====================
            this.tabMyProjects.Text    = "  My Project Submissions  ";
            this.tabMyProjects.Padding = new System.Windows.Forms.Padding(5);
            this.tabMyProjects.Controls.Add(this.dgvMyProjects);

            SetupGrid(this.dgvMyProjects,
                new System.Drawing.Point(8, 8),
                new System.Drawing.Size(835, 290),
                System.Drawing.Color.DarkOrange,
                System.Drawing.Color.FromArgb(255, 248, 235));

            // ==================== tabMyAssignments ====================
            this.tabMyAssignments.Text    = "  My Assignment Submissions  ";
            this.tabMyAssignments.Padding = new System.Windows.Forms.Padding(5);
            this.tabMyAssignments.Controls.Add(this.dgvMyAssignments);

            SetupGrid(this.dgvMyAssignments,
                new System.Drawing.Point(8, 8),
                new System.Drawing.Size(835, 290),
                System.Drawing.Color.MidnightBlue,
                System.Drawing.Color.FromArgb(235, 238, 255));

            // ==================== Notes label + textbox ====================
            this.lblNotesHint.AutoSize  = true;
            this.lblNotesHint.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNotesHint.ForeColor = System.Drawing.Color.DimGray;
            this.lblNotesHint.Location  = new System.Drawing.Point(15, 422);
            this.lblNotesHint.Text      = "Submission Notes / Answer:";

            this.txtNotes.Location      = new System.Drawing.Point(15, 442);
            this.txtNotes.Size          = new System.Drawing.Size(555, 65);
            this.txtNotes.Multiline     = true;
            this.txtNotes.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNotes.ScrollBars    = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.BackColor     = System.Drawing.Color.White;

            // ==================== btnSubmitProject ====================
            this.btnSubmitProject.Location         = new System.Drawing.Point(585, 422);
            this.btnSubmitProject.Size             = new System.Drawing.Size(135, 40);
            this.btnSubmitProject.Text             = "Submit Project";
            this.btnSubmitProject.Font             = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmitProject.BackColor        = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSubmitProject.ForeColor        = System.Drawing.Color.White;
            this.btnSubmitProject.FlatStyle        = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitProject.FlatAppearance.BorderSize = 0;
            this.btnSubmitProject.UseVisualStyleBackColor   = false;
            this.btnSubmitProject.Click           += new System.EventHandler(this.btnSubmitProject_Click);

            // ==================== btnSubmitAssignment ====================
            this.btnSubmitAssignment.Location         = new System.Drawing.Point(585, 470);
            this.btnSubmitAssignment.Size             = new System.Drawing.Size(135, 40);
            this.btnSubmitAssignment.Text             = "Submit Assignment";
            this.btnSubmitAssignment.Font             = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmitAssignment.BackColor        = System.Drawing.Color.SeaGreen;
            this.btnSubmitAssignment.ForeColor        = System.Drawing.Color.White;
            this.btnSubmitAssignment.FlatStyle        = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitAssignment.FlatAppearance.BorderSize = 0;
            this.btnSubmitAssignment.UseVisualStyleBackColor   = false;
            this.btnSubmitAssignment.Click           += new System.EventHandler(this.btnSubmitAssignment_Click);

            // ==================== btnRefresh ====================
            this.btnRefresh.Location         = new System.Drawing.Point(735, 422);
            this.btnRefresh.Size             = new System.Drawing.Size(130, 40);
            this.btnRefresh.Text             = "Refresh";
            this.btnRefresh.Font             = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.BackColor        = System.Drawing.Color.DarkOrange;
            this.btnRefresh.ForeColor        = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle        = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.UseVisualStyleBackColor   = false;
            this.btnRefresh.Click           += new System.EventHandler(this.btnRefresh_Click);

            // ==================== btnClose ====================
            this.btnClose.Location         = new System.Drawing.Point(735, 470);
            this.btnClose.Size             = new System.Drawing.Size(130, 40);
            this.btnClose.Text             = "Close";
            this.btnClose.Font             = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.BackColor        = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btnClose.ForeColor        = System.Drawing.Color.White;
            this.btnClose.FlatStyle        = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.UseVisualStyleBackColor   = false;
            this.btnClose.Click           += new System.EventHandler(this.btnClose_Click);

            // ==================== Form ====================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.WhiteSmoke;
            this.ClientSize          = new System.Drawing.Size(900, 530);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox         = false;
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "Projects & Assignments Dashboard";
            this.Load               += new System.EventHandler(this.ProjectsAssignmentsDashboard_Load);

            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblNotesHint);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnSubmitProject);
            this.Controls.Add(this.btnSubmitAssignment);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Helper used only inside InitializeComponent
        private void SetupGrid(
            System.Windows.Forms.DataGridView dgv,
            System.Drawing.Point loc,
            System.Drawing.Size sz,
            System.Drawing.Color headerColor,
            System.Drawing.Color altColor)
        {
            dgv.Location                = loc;
            dgv.Size                    = sz;
            dgv.AutoSizeColumnsMode     = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode           = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly                = true;
            dgv.AllowUserToAddRows      = false;
            dgv.BackgroundColor         = System.Drawing.Color.White;
            dgv.RowHeadersVisible       = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgv.EnableHeadersVisualStyles               = false;
            dgv.RowTemplate.Height                      = 28;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = altColor;
            dgv.DefaultCellStyle.Font                   = new System.Drawing.Font("Segoe UI", 9F);
        }

        #endregion

        private System.Windows.Forms.TabControl    tabControl1;
        private System.Windows.Forms.TabPage       tabProjects;
        private System.Windows.Forms.TabPage       tabAssignments;
        private System.Windows.Forms.TabPage       tabMyProjects;
        private System.Windows.Forms.TabPage       tabMyAssignments;
        private System.Windows.Forms.DataGridView  dgvProjects;
        private System.Windows.Forms.DataGridView  dgvAssignments;
        private System.Windows.Forms.DataGridView  dgvMyProjects;
        private System.Windows.Forms.DataGridView  dgvMyAssignments;
        private System.Windows.Forms.Label         lblTitle;
        private System.Windows.Forms.Label         lblProjectCount;
        private System.Windows.Forms.Label         lblAssignCount;
        private System.Windows.Forms.Label         lblNotesHint;
        private System.Windows.Forms.TextBox       txtNotes;
        private System.Windows.Forms.Button        btnSubmitProject;
        private System.Windows.Forms.Button        btnSubmitAssignment;
        private System.Windows.Forms.Button        btnRefresh;
        private System.Windows.Forms.Button        btnClose;
        private System.Windows.Forms.Panel         panelHeader;
    }
}
