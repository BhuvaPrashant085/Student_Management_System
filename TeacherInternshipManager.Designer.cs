// ============================================================
// TeacherInternshipManager.Designer.cs
// ============================================================

namespace DOTNET
{
    partial class TeacherInternshipManager
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
            this.tabApplications    = new System.Windows.Forms.TabPage();
            this.tabSummary         = new System.Windows.Forms.TabPage();
            this.tabInternships     = new System.Windows.Forms.TabPage();
            this.dgvApplications    = new System.Windows.Forms.DataGridView();
            this.dgvSummary         = new System.Windows.Forms.DataGridView();
            this.dgvInternships     = new System.Windows.Forms.DataGridView();
            this.btnApprove         = new System.Windows.Forms.Button();
            this.btnReject          = new System.Windows.Forms.Button();
            this.btnPostInternship  = new System.Windows.Forms.Button();
            this.btnRefresh         = new System.Windows.Forms.Button();
            this.btnClose           = new System.Windows.Forms.Button();
            this.lblTitle           = new System.Windows.Forms.Label();
            this.panelTop           = new System.Windows.Forms.Panel();

            System.Drawing.Color teal    = System.Drawing.Color.FromArgb(0, 121, 107);
            System.Drawing.Color red     = System.Drawing.Color.FromArgb(183, 28, 28);
            System.Drawing.Color orange  = System.Drawing.Color.FromArgb(230, 81, 0);
            System.Drawing.Color blue    = System.Drawing.Color.FromArgb(21, 101, 192);

            // panelTop
            this.panelTop.BackColor = teal;
            this.panelTop.Dock      = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height    = 60;
            this.panelTop.Controls.Add(this.lblTitle);

            this.lblTitle.Text      = "👩‍🏫  Teacher - Internship Manager";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location  = new System.Drawing.Point(15, 12);
            this.lblTitle.AutoSize  = true;

            // tabControl
            this.tabControl1.Location = new System.Drawing.Point(10, 70);
            this.tabControl1.Size     = new System.Drawing.Size(1020, 420);
            this.tabControl1.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.TabPages.AddRange(new System.Windows.Forms.TabPage[] {
                this.tabApplications, this.tabSummary, this.tabInternships });

            // Tab: Applications
            this.tabApplications.Text    = "📋  Student Applications";
            this.tabApplications.Padding = new System.Windows.Forms.Padding(5);
            this.tabApplications.Controls.Add(this.dgvApplications);
            SetupGrid(this.dgvApplications, new System.Drawing.Point(8, 8), new System.Drawing.Size(1000, 370), teal,
                System.Drawing.Color.FromArgb(224, 242, 241));

            // Tab: Summary
            this.tabSummary.Text    = "📊  Application Summary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(5);
            this.tabSummary.Controls.Add(this.dgvSummary);
            SetupGrid(this.dgvSummary, new System.Drawing.Point(8, 8), new System.Drawing.Size(1000, 370), blue,
                System.Drawing.Color.FromArgb(227, 242, 253));

            // Tab: My Internships
            this.tabInternships.Text    = "🏢  Posted Internships";
            this.tabInternships.Padding = new System.Windows.Forms.Padding(5);
            this.tabInternships.Controls.Add(this.dgvInternships);
            SetupGrid(this.dgvInternships, new System.Drawing.Point(8, 8), new System.Drawing.Size(1000, 370), orange,
                System.Drawing.Color.FromArgb(255, 243, 224));

            // Buttons
            int btnY = 500;

            this.btnApprove.Text      = "✅  Approve";
            this.btnApprove.Location  = new System.Drawing.Point(10, btnY);
            this.btnApprove.Size      = new System.Drawing.Size(130, 38);
            StyleButton(this.btnApprove, teal);
            this.btnApprove.Click    += new System.EventHandler(this.btnApprove_Click);

            this.btnReject.Text       = "❌  Reject";
            this.btnReject.Location   = new System.Drawing.Point(155, btnY);
            this.btnReject.Size       = new System.Drawing.Size(130, 38);
            StyleButton(this.btnReject, red);
            this.btnReject.Click     += new System.EventHandler(this.btnReject_Click);

            this.btnPostInternship.Text      = "➕  Post Internship";
            this.btnPostInternship.Location  = new System.Drawing.Point(300, btnY);
            this.btnPostInternship.Size      = new System.Drawing.Size(170, 38);
            StyleButton(this.btnPostInternship, orange);
            this.btnPostInternship.Click    += new System.EventHandler(this.btnPostInternship_Click);

            this.btnRefresh.Text      = "🔄  Refresh";
            this.btnRefresh.Location  = new System.Drawing.Point(485, btnY);
            this.btnRefresh.Size      = new System.Drawing.Size(130, 38);
            StyleButton(this.btnRefresh, blue);
            this.btnRefresh.Click    += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.Text      = "🚪  Close";
            this.btnClose.Location  = new System.Drawing.Point(630, btnY);
            this.btnClose.Size      = new System.Drawing.Size(120, 38);
            StyleButton(this.btnClose, System.Drawing.Color.FromArgb(69, 90, 100));
            this.btnClose.Click    += new System.EventHandler(this.btnClose_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(1045, 555);
            this.Text                = "Teacher - Internship Manager";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor           = System.Drawing.Color.WhiteSmoke;
            this.Font                = new System.Drawing.Font("Segoe UI", 9F);
            this.Load               += new System.EventHandler(this.TeacherInternshipManager_Load);

            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnPostInternship);
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
        private System.Windows.Forms.TabPage tabApplications;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.TabPage tabInternships;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.DataGridView dgvInternships;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnPostInternship;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTop;
    }
}
