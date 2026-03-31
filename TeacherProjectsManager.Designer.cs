// ============================================================
// TeacherProjectsManager.Designer.cs
// ============================================================

namespace DOTNET
{
    partial class TeacherProjectsManager
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1        = new System.Windows.Forms.TabControl();
            this.tabProjSubs        = new System.Windows.Forms.TabPage();
            this.tabAssignSubs      = new System.Windows.Forms.TabPage();
            this.tabProjects        = new System.Windows.Forms.TabPage();
            this.tabAssignments     = new System.Windows.Forms.TabPage();
            this.dgvProjectSubs     = new System.Windows.Forms.DataGridView();
            this.dgvAssignSubs      = new System.Windows.Forms.DataGridView();
            this.dgvProjects        = new System.Windows.Forms.DataGridView();
            this.dgvAssignments     = new System.Windows.Forms.DataGridView();
            this.btnGradeProject    = new System.Windows.Forms.Button();
            this.btnGradeAssignment = new System.Windows.Forms.Button();
            this.btnRefresh         = new System.Windows.Forms.Button();
            this.btnClose           = new System.Windows.Forms.Button();
            this.lblTitle           = new System.Windows.Forms.Label();
            this.lblPendingProj     = new System.Windows.Forms.Label();
            this.lblPendingAssign   = new System.Windows.Forms.Label();
            this.panelTop           = new System.Windows.Forms.Panel();

            System.Drawing.Color deepBlue   = System.Drawing.Color.FromArgb(13, 71, 161);
            System.Drawing.Color deepGreen  = System.Drawing.Color.FromArgb(27, 94, 32);
            System.Drawing.Color amber      = System.Drawing.Color.FromArgb(255, 111, 0);
            System.Drawing.Color indigo     = System.Drawing.Color.FromArgb(49, 27, 146);

            // panelTop
            this.panelTop.BackColor = deepBlue;
            this.panelTop.Dock      = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height    = 60;
            this.panelTop.Controls.Add(this.lblTitle);
            this.lblTitle.Text      = "👨‍🏫  Teacher - Projects & Assignments Manager";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location  = new System.Drawing.Point(15, 15);
            this.lblTitle.AutoSize  = true;

            // tabControl
            this.tabControl1.Location = new System.Drawing.Point(10, 70);
            this.tabControl1.Size     = new System.Drawing.Size(1050, 440);
            this.tabControl1.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.TabPages.AddRange(new System.Windows.Forms.TabPage[] {
                this.tabProjSubs, this.tabAssignSubs, this.tabProjects, this.tabAssignments });

            // Tab: Ungraded Projects
            this.tabProjSubs.Text    = "📂  Grade Projects";
            this.tabProjSubs.Padding = new System.Windows.Forms.Padding(5);
            this.tabProjSubs.Controls.Add(this.lblPendingProj);
            this.tabProjSubs.Controls.Add(this.dgvProjectSubs);
            this.lblPendingProj.Location  = new System.Drawing.Point(8, 8);
            this.lblPendingProj.AutoSize  = true;
            this.lblPendingProj.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPendingProj.ForeColor = amber;
            SetupGrid(this.dgvProjectSubs, new System.Drawing.Point(8, 32), new System.Drawing.Size(1030, 360), deepBlue,
                System.Drawing.Color.FromArgb(227, 242, 253));

            // Tab: Ungraded Assignments
            this.tabAssignSubs.Text    = "📝  Grade Assignments";
            this.tabAssignSubs.Padding = new System.Windows.Forms.Padding(5);
            this.tabAssignSubs.Controls.Add(this.lblPendingAssign);
            this.tabAssignSubs.Controls.Add(this.dgvAssignSubs);
            this.lblPendingAssign.Location  = new System.Drawing.Point(8, 8);
            this.lblPendingAssign.AutoSize  = true;
            this.lblPendingAssign.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPendingAssign.ForeColor = amber;
            SetupGrid(this.dgvAssignSubs, new System.Drawing.Point(8, 32), new System.Drawing.Size(1030, 360), deepGreen,
                System.Drawing.Color.FromArgb(232, 245, 233));

            // Tab: All Projects
            this.tabProjects.Text    = "🗂️  All Projects";
            this.tabProjects.Padding = new System.Windows.Forms.Padding(5);
            this.tabProjects.Controls.Add(this.dgvProjects);
            SetupGrid(this.dgvProjects, new System.Drawing.Point(8, 8), new System.Drawing.Size(1030, 390), indigo,
                System.Drawing.Color.FromArgb(237, 231, 246));

            // Tab: All Assignments
            this.tabAssignments.Text    = "📋  All Assignments";
            this.tabAssignments.Padding = new System.Windows.Forms.Padding(5);
            this.tabAssignments.Controls.Add(this.dgvAssignments);
            SetupGrid(this.dgvAssignments, new System.Drawing.Point(8, 8), new System.Drawing.Size(1030, 390), amber,
                System.Drawing.Color.FromArgb(255, 243, 224));

            // Buttons
            int btnY = 520;
            this.btnGradeProject.Text     = "✅  Grade Project";
            this.btnGradeProject.Location = new System.Drawing.Point(10, btnY);
            this.btnGradeProject.Size     = new System.Drawing.Size(160, 38);
            StyleButton(this.btnGradeProject, deepBlue);
            this.btnGradeProject.Click   += new System.EventHandler(this.btnGradeProject_Click);

            this.btnGradeAssignment.Text     = "✅  Grade Assignment";
            this.btnGradeAssignment.Location = new System.Drawing.Point(185, btnY);
            this.btnGradeAssignment.Size     = new System.Drawing.Size(175, 38);
            StyleButton(this.btnGradeAssignment, deepGreen);
            this.btnGradeAssignment.Click   += new System.EventHandler(this.btnGradeAssignment_Click);

            this.btnRefresh.Text     = "🔄  Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(375, btnY);
            this.btnRefresh.Size     = new System.Drawing.Size(130, 38);
            StyleButton(this.btnRefresh, amber);
            this.btnRefresh.Click   += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.Text     = "🚪  Close";
            this.btnClose.Location = new System.Drawing.Point(520, btnY);
            this.btnClose.Size     = new System.Drawing.Size(120, 38);
            StyleButton(this.btnClose, System.Drawing.Color.FromArgb(69, 90, 100));
            this.btnClose.Click   += new System.EventHandler(this.btnClose_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(1075, 575);
            this.Text                = "Teacher - Projects & Assignments Manager";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor           = System.Drawing.Color.WhiteSmoke;
            this.Font                = new System.Drawing.Font("Segoe UI", 9F);
            this.Load               += new System.EventHandler(this.TeacherProjectsManager_Load);

            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnGradeProject);
            this.Controls.Add(this.btnGradeAssignment);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
        }

        private void SetupGrid(System.Windows.Forms.DataGridView dgv,
            System.Drawing.Point loc, System.Drawing.Size sz,
            System.Drawing.Color headerColor, System.Drawing.Color altColor)
        {
            dgv.Location            = loc;
            dgv.Size                = sz;
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly            = true;
            dgv.BackgroundColor     = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgv.EnableHeadersVisualStyles                = false;
            dgv.RowTemplate.Height                       = 28;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = altColor;
        }

        private void StyleButton(System.Windows.Forms.Button btn, System.Drawing.Color color)
        {
            btn.BackColor = color;
            btn.ForeColor = System.Drawing.Color.White;
            btn.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProjSubs;
        private System.Windows.Forms.TabPage tabAssignSubs;
        private System.Windows.Forms.TabPage tabProjects;
        private System.Windows.Forms.TabPage tabAssignments;
        private System.Windows.Forms.DataGridView dgvProjectSubs;
        private System.Windows.Forms.DataGridView dgvAssignSubs;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.Button btnGradeProject;
        private System.Windows.Forms.Button btnGradeAssignment;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPendingProj;
        private System.Windows.Forms.Label lblPendingAssign;
        private System.Windows.Forms.Panel panelTop;
    }
}
