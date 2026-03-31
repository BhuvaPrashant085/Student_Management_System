using System;
using System.Drawing;
using System.Windows.Forms;

namespace DOTNET
{
    partial class MyCIA
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblDMDW;
        private Label lblDotNet;
        private Label lblCC;
        private Label lblAI;
        private Label lblAT;
        private Label lblCIA1;
        private Label lblCIA2;
        private Label lblTotalPoints;
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // Method to initialize components
        protected void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblDMDW = new Label();
            this.lblDotNet = new Label();
            this.lblCC = new Label();
            this.lblAI = new Label();
            this.lblAT = new Label();
            this.lblCIA1 = new Label();
            this.lblCIA2 = new Label();
            this.lblTotalPoints = new Label();
            this.btnClose = new Button();

            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(120, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Your Marks";
            // 
            // lblDMDW
            // 
            this.lblDMDW.AutoSize = true;
            this.lblDMDW.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDMDW.ForeColor = System.Drawing.Color.White;
            this.lblDMDW.Location = new System.Drawing.Point(60, 100);
            this.lblDMDW.Name = "lblDMDW";
            this.lblDMDW.Size = new System.Drawing.Size(58, 20);
            this.lblDMDW.TabIndex = 1;
            this.lblDMDW.Text = "DMDW: ";
            // 
            // lblDotNet
            // 
            this.lblDotNet.AutoSize = true;
            this.lblDotNet.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDotNet.ForeColor = System.Drawing.Color.White;
            this.lblDotNet.Location = new System.Drawing.Point(60, 140);
            this.lblDotNet.Name = "lblDotNet";
            this.lblDotNet.Size = new System.Drawing.Size(66, 20);
            this.lblDotNet.TabIndex = 2;
            this.lblDotNet.Text = ".NET: ";
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCC.ForeColor = System.Drawing.Color.White;
            this.lblCC.Location = new System.Drawing.Point(60, 180);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(34, 20);
            this.lblCC.TabIndex = 3;
            this.lblCC.Text = "CC: ";
            // 
            // lblAI
            // 
            this.lblAI.AutoSize = true;
            this.lblAI.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAI.ForeColor = System.Drawing.Color.White;
            this.lblAI.Location = new System.Drawing.Point(60, 220);
            this.lblAI.Name = "lblAI";
            this.lblAI.Size = new System.Drawing.Size(35, 20);
            this.lblAI.TabIndex = 4;
            this.lblAI.Text = "AI: ";
            // 
            // lblAT
            // 
            this.lblAT.AutoSize = true;
            this.lblAT.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAT.ForeColor = System.Drawing.Color.White;
            this.lblAT.Location = new System.Drawing.Point(60, 260);
            this.lblAT.Name = "lblAT";
            this.lblAT.Size = new System.Drawing.Size(36, 20);
            this.lblAT.TabIndex = 5;
            this.lblAT.Text = "AT: ";
            // 
            // lblCIA1
            // 
            this.lblCIA1.AutoSize = true;
            this.lblCIA1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCIA1.ForeColor = System.Drawing.Color.White;
            this.lblCIA1.Location = new System.Drawing.Point(60, 300);
            this.lblCIA1.Name = "lblCIA1";
            this.lblCIA1.Size = new System.Drawing.Size(59, 20);
            this.lblCIA1.TabIndex = 6;
            this.lblCIA1.Text = "CIA 1: ";
            // 
            // lblCIA2
            // 
            this.lblCIA2.AutoSize = true;
            this.lblCIA2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCIA2.ForeColor = System.Drawing.Color.White;
            this.lblCIA2.Location = new System.Drawing.Point(60, 340);
            this.lblCIA2.Name = "lblCIA2";
            this.lblCIA2.Size = new System.Drawing.Size(59, 20);
            this.lblCIA2.TabIndex = 7;
            this.lblCIA2.Text = "CIA 2: ";
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.AutoSize = true;
            this.lblTotalPoints.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTotalPoints.ForeColor = System.Drawing.Color.White;
            this.lblTotalPoints.Location = new System.Drawing.Point(60, 380);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(103, 20);
            this.lblTotalPoints.TabIndex = 8;
            this.lblTotalPoints.Text = "Total Points: ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(170, 420);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ViewMarksForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.lblTitle);   
            this.Controls.Add(this.lblDMDW);
            this.Controls.Add(this.lblDotNet);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.lblAI);
            this.Controls.Add(this.lblAT);
            this.Controls.Add(this.lblCIA1);
            this.Controls.Add(this.lblCIA2);
            this.Controls.Add(this.lblTotalPoints);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ViewMarksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Marks";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}