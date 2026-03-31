using System.Drawing;
using System.Windows.Forms;

namespace DOTNET
{
    partial class StudentResult
    {
        private Label lblTitle;
        private Label lblSubjectTotal;
        private Label lblCIA1;
        private Label lblCIA2;
        private Label lblGrandTotal;
        private Label lblResult;
        private Label lblPercentage;
        private Button btnClose;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubjectTotal = new System.Windows.Forms.Label();
            this.lblCIA1 = new System.Windows.Forms.Label();
            this.lblCIA2 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(90, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Result";
            // 
            // lblSubjectTotal
            // 
            this.lblSubjectTotal.AutoSize = true;
            this.lblSubjectTotal.ForeColor = System.Drawing.Color.White;
            this.lblSubjectTotal.Location = new System.Drawing.Point(60, 100);
            this.lblSubjectTotal.Name = "lblSubjectTotal";
            this.lblSubjectTotal.Size = new System.Drawing.Size(0, 13);
            this.lblSubjectTotal.TabIndex = 1;
            // 
            // lblCIA1
            // 
            this.lblCIA1.AutoSize = true;
            this.lblCIA1.ForeColor = System.Drawing.Color.White;
            this.lblCIA1.Location = new System.Drawing.Point(60, 140);
            this.lblCIA1.Name = "lblCIA1";
            this.lblCIA1.Size = new System.Drawing.Size(0, 13);
            this.lblCIA1.TabIndex = 2;
            // 
            // lblCIA2
            // 
            this.lblCIA2.AutoSize = true;
            this.lblCIA2.ForeColor = System.Drawing.Color.White;
            this.lblCIA2.Location = new System.Drawing.Point(60, 180);
            this.lblCIA2.Name = "lblCIA2";
            this.lblCIA2.Size = new System.Drawing.Size(0, 13);
            this.lblCIA2.TabIndex = 3;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.ForeColor = System.Drawing.Color.White;
            this.lblGrandTotal.Location = new System.Drawing.Point(60, 220);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(0, 13);
            this.lblGrandTotal.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(60, 260);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 21);
            this.lblResult.TabIndex = 5;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPercentage.Location = new System.Drawing.Point(80, 300);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(0, 21);
            this.lblPercentage.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);  // Dark button background
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(130, 340);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);  // Slightly bigger button for a better look
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.FlatAppearance.BorderSize = 0;  // Remove border
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 50); // Hover effect
                                                                                                         // 
                                                                                                         // StudentResult

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(400, 450);  // Increased size for better layout
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubjectTotal);
            this.Controls.Add(this.lblCIA1);
            this.Controls.Add(this.lblCIA2);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "StudentResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;  // Fixed size to prevent resizing
            this.MaximizeBox = false;  // Disable maximize
            this.MinimizeBox = false;  // Disable minimize
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}