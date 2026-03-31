using System;
using System.Drawing;
using System.Windows.Forms;

namespace DOTNET
{
    partial class UploadCIA
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblStudent;
        private Label lblCIA1;
        private ComboBox cmbStudents;
        private TextBox txtCIA1;
        private Label lblCIA2;   // Add this
        private TextBox txtCIA2; // Add this
        private Button btnUpdate;
        private Button btnClose;
        private Label lblSubject;
        private ComboBox cmbSubjects;
        private TextBox txtDMDW;
        private TextBox txtDotNet;
        private TextBox txtCC;
        private TextBox txtAI;
        private TextBox txtAT;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblCIA1 = new System.Windows.Forms.Label();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.txtCIA1 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.lblDMDW = new System.Windows.Forms.Label();
            this.txtDMDW = new System.Windows.Forms.TextBox();
            this.lblDotNet = new System.Windows.Forms.Label();
            this.txtDotNet = new System.Windows.Forms.TextBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.lblAI = new System.Windows.Forms.Label();
            this.txtAI = new System.Windows.Forms.TextBox();
            this.lblAT = new System.Windows.Forms.Label();
            this.txtAT = new System.Windows.Forms.TextBox();
            this.lblCIA2 = new System.Windows.Forms.Label();
            this.txtCIA2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(170, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "📊 Upload CIA Marks";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStudent.ForeColor = System.Drawing.Color.White;
            this.lblStudent.Location = new System.Drawing.Point(120, 130);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(107, 20);
            this.lblStudent.TabIndex = 3;
            this.lblStudent.Text = "Select Student:";
            // 
            // lblCIA1
            // 
            this.lblCIA1.AutoSize = true;
            this.lblCIA1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCIA1.ForeColor = System.Drawing.Color.White;
            this.lblCIA1.Location = new System.Drawing.Point(120, 187);
            this.lblCIA1.Name = "lblCIA1";
            this.lblCIA1.Size = new System.Drawing.Size(90, 20);
            this.lblCIA1.TabIndex = 5;
            this.lblCIA1.Text = "CIA 1 Marks:";
            // 
            // cmbStudents
            // 
            this.cmbStudents.BackColor = System.Drawing.Color.White;
            this.cmbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudents.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbStudents.Location = new System.Drawing.Point(300, 125);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(220, 28);
            this.cmbStudents.TabIndex = 4;
            // 
            // txtCIA1
            // 
            this.txtCIA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCIA1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCIA1.Location = new System.Drawing.Point(300, 182);
            this.txtCIA1.Name = "txtCIA1";
            this.txtCIA1.Size = new System.Drawing.Size(220, 27);
            this.txtCIA1.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(177, 506);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(300, 506);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(0, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(100, 23);
            this.lblSubject.TabIndex = 10;
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.Location = new System.Drawing.Point(0, 0);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(121, 21);
            this.cmbSubjects.TabIndex = 11;
            // 
            // lblDMDW
            // 
            this.lblDMDW.ForeColor = System.Drawing.Color.White;
            this.lblDMDW.Location = new System.Drawing.Point(121, 285);
            this.lblDMDW.Name = "lblDMDW";
            this.lblDMDW.Size = new System.Drawing.Size(100, 23);
            this.lblDMDW.TabIndex = 0;
            this.lblDMDW.Text = "DMW:";
            // 
            // txtDMDW
            // 
            this.txtDMDW.Location = new System.Drawing.Point(300, 282);
            this.txtDMDW.Name = "txtDMDW";
            this.txtDMDW.Size = new System.Drawing.Size(220, 20);
            this.txtDMDW.TabIndex = 1;
            // 
            // lblDotNet
            // 
            this.lblDotNet.ForeColor = System.Drawing.Color.White;
            this.lblDotNet.Location = new System.Drawing.Point(120, 329);
            this.lblDotNet.Name = "lblDotNet";
            this.lblDotNet.Size = new System.Drawing.Size(100, 23);
            this.lblDotNet.TabIndex = 2;
            this.lblDotNet.Text = ".NET:";
            // 
            // txtDotNet
            // 
            this.txtDotNet.Location = new System.Drawing.Point(300, 324);
            this.txtDotNet.Name = "txtDotNet";
            this.txtDotNet.Size = new System.Drawing.Size(220, 20);
            this.txtDotNet.TabIndex = 3;
            // 
            // lblCC
            // 
            this.lblCC.ForeColor = System.Drawing.Color.White;
            this.lblCC.Location = new System.Drawing.Point(120, 369);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(100, 23);
            this.lblCC.TabIndex = 4;
            this.lblCC.Text = "CC:";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(300, 364);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(220, 20);
            this.txtCC.TabIndex = 5;
            // 
            // lblAI
            // 
            this.lblAI.ForeColor = System.Drawing.Color.White;
            this.lblAI.Location = new System.Drawing.Point(120, 409);
            this.lblAI.Name = "lblAI";
            this.lblAI.Size = new System.Drawing.Size(100, 23);
            this.lblAI.TabIndex = 6;
            this.lblAI.Text = "AI:";
            // 
            // txtAI
            // 
            this.txtAI.Location = new System.Drawing.Point(300, 404);
            this.txtAI.Name = "txtAI";
            this.txtAI.Size = new System.Drawing.Size(220, 20);
            this.txtAI.TabIndex = 7;
            // 
            // lblAT
            // 
            this.lblAT.ForeColor = System.Drawing.Color.White;
            this.lblAT.Location = new System.Drawing.Point(120, 449);
            this.lblAT.Name = "lblAT";
            this.lblAT.Size = new System.Drawing.Size(100, 23);
            this.lblAT.TabIndex = 8;
            this.lblAT.Text = "AT:";
            // 
            // txtAT
            // 
            this.txtAT.Location = new System.Drawing.Point(300, 444);
            this.txtAT.Name = "txtAT";
            this.txtAT.Size = new System.Drawing.Size(220, 20);
            this.txtAT.TabIndex = 9;
            // 
            // lblCIA2
            // 
            this.lblCIA2.AutoSize = true;
            this.lblCIA2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCIA2.ForeColor = System.Drawing.Color.White;
            this.lblCIA2.Location = new System.Drawing.Point(120, 234);
            this.lblCIA2.Name = "lblCIA2";
            this.lblCIA2.Size = new System.Drawing.Size(90, 20);
            this.lblCIA2.TabIndex = 5;
            this.lblCIA2.Text = "CIA 2 Marks:";
            // 
            // txtCIA2
            // 
            this.txtCIA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCIA2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCIA2.Location = new System.Drawing.Point(300, 234);
            this.txtCIA2.Name = "txtCIA2";
            this.txtCIA2.Size = new System.Drawing.Size(220, 27);
            this.txtCIA2.TabIndex = 7;
            this.txtCIA2.TextChanged += new System.EventHandler(this.txtCIA2_TextChanged);
            // 
            // UploadCIA
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(861, 626);
            this.Controls.Add(this.lblDMDW);
            this.Controls.Add(this.txtDMDW);
            this.Controls.Add(this.lblDotNet);
            this.Controls.Add(this.txtDotNet);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.lblAI);
            this.Controls.Add(this.txtAI);
            this.Controls.Add(this.lblAT);
            this.Controls.Add(this.txtAT);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.lblCIA1);
            this.Controls.Add(this.txtCIA1);
            this.Controls.Add(this.lblCIA2);
            this.Controls.Add(this.txtCIA2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UploadCIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload CIA Marks";
            this.Load += new System.EventHandler(this.UploadCIA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblDMDW;
        private Label lblDotNet;
        private Label lblCC;
        private Label lblAI;
        private Label lblAT;
    }
}