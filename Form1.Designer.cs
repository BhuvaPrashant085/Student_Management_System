namespace StudentManagementSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtEnroll = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEnroll = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEnroll
            // 
            this.txtEnroll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnroll.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEnroll.Location = new System.Drawing.Point(370, 178);
            this.txtEnroll.Name = "txtEnroll";
            this.txtEnroll.Size = new System.Drawing.Size(250, 29);
            this.txtEnroll.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(370, 228);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 29);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPassword.Location = new System.Drawing.Point(250, 230);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 21);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // lblEnroll
            // 
            this.lblEnroll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnroll.AutoSize = true;
            this.lblEnroll.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEnroll.Location = new System.Drawing.Point(250, 180);
            this.lblEnroll.Name = "lblEnroll";
            this.lblEnroll.Size = new System.Drawing.Size(89, 21);
            this.lblEnroll.TabIndex = 1;
            this.lblEnroll.Text = "Enrollment:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(200, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(531, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Student Management";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(300, 310);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignup.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(470, 310);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(140, 45);
            this.btnSignup.TabIndex = 6;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEnroll);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEnroll);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSignup);
            this.MinimumSize = new System.Drawing.Size(650, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnroll;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEnroll;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignup;
    }
}