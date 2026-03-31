
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DOTNET
{
    partial class UploadCIA2
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblStudent;
        private Label lblCIA2; // Added label for CIA2
        private ComboBox cmbStudents;
        private TextBox txtCIA2; // Added TextBox for CIA2
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
            this.lblCIA2 = new System.Windows.Forms.Label(); // Label for CIA2
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.txtCIA2 = new System.Windows.Forms.TextBox(); // TextBox for CIA2
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.txtDMDW = new System.Windows.Forms.TextBox();
            this.txtDotNet = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtAI = new System.Windows.Forms.TextBox();
            this.txtAT = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(170, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "📊 Upload CIA2 Marks";

            // lblStudent
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStudent.ForeColor = System.Drawing.Color.White;
            this.lblStudent.Location = new System.Drawing.Point(120, 130);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(107, 20);
            this.lblStudent.TabIndex = 3;
            this.lblStudent.Text = "Select Student:";

            // lblCIA2 (new label for CIA2)
            this.lblCIA2.AutoSize = true;
            this.lblCIA2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCIA2.ForeColor = System.Drawing.Color.White;
            this.lblCIA2.Location = new System.Drawing.Point(120, 230);
            this.lblCIA2.Name = "lblCIA2";
            this.lblCIA2.Size = new System.Drawing.Size(90, 20);
            this.lblCIA2.TabIndex = 5;
            this.lblCIA2.Text = "CIA 2 Marks:";

            // cmbStudents
            this.cmbStudents.BackColor = System.Drawing.Color.White;
            this.cmbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudents.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbStudents.Location = new System.Drawing.Point(300, 125);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(220, 28);
            this.cmbStudents.TabIndex = 4;

            // txtCIA2 (TextBox for CIA2)
            this.txtCIA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCIA2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCIA2.Location = new System.Drawing.Point(300, 225);
            this.txtCIA2.Name = "txtCIA2";
            this.txtCIA2.Size = new System.Drawing.Size(220, 27);
            this.txtCIA2.TabIndex = 6;

            // btnUpdate
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

            // btnClose
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

            // Final Form Setup
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(861, 626);
            this.Controls.Add(this.lblCIA2); // Added Label for CIA2
            this.Controls.Add(this.txtCIA2); // Added TextBox for CIA2
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UploadCIA2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload CIA2 Marks";
            this.Load += new System.EventHandler(this.UploadCIA2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
