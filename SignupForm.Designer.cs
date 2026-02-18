using System;
using System.Windows.Forms;

namespace DOTNET
{
    public partial class DashboardControl : UserControl
    {
        private string username;

        public DashboardControl(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + username;
        }
    }
}
"""

dashboard_designer = """
namespace DOTNET
{
    partial class DashboardControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblCount1;
        private System.Windows.Forms.Label lblCount2;
        private System.Windows.Forms.Label lblCount3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblCount1 = new System.Windows.Forms.Label();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.lblCount3 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblWelcome.Location = new System.Drawing.Point(30, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(120, 26);
            this.lblWelcome.Text = "Welcome";

            // lblCount1
            this.lblCount1.AutoSize = true;
            this.lblCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCount1.Location = new System.Drawing.Point(30, 80);
            this.lblCount1.Name = "lblCount1";
            this.lblCount1.Size = new System.Drawing.Size(100, 20);
            this.lblCount1.Text = "Students: 0";

            // lblCount2
            this.lblCount2.AutoSize = true;
            this.lblCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCount2.Location = new System.Drawing.Point(30, 120);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(90, 20);
            this.lblCount2.Text = "Courses: 0";

            // lblCount3
            this.lblCount3.AutoSize = true;
            this.lblCount3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCount3.Location = new System.Drawing.Point(30, 160);
            this.lblCount3.Name = "lblCount3";
            this.lblCount3.Size = new System.Drawing.Size(120, 20);
            this.lblCount3.Text = "Enrollments: 0";

            // DashboardControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblCount1);
            this.Controls.Add(this.lblCount2);
            this.Controls.Add(this.lblCount3);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(500, 300);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}