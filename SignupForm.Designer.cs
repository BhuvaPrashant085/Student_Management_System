namespace DOTNET
{
    partial class SignupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtEnrollmentno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // ================= FORM SETTINGS =================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Text = "Student Signup";
            this.Load += new System.EventHandler(this.SignupForm_Load);

            // ================= TITLE =================
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(300, 60);
            this.label1.Text = "Create Account";
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;

            // ================= USERNAME =================
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(250, 170);
            this.label2.Text = "Username:";
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;

            this.txtUsername.Location = new System.Drawing.Point(420, 168);
            this.txtUsername.Size = new System.Drawing.Size(250, 30);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;

            // ================= ENROLLMENT =================
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(250, 220);
            this.label5.Text = "Enrollment No:";
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Click += new System.EventHandler(this.label5_Click);

            this.txtEnrollmentno.Location = new System.Drawing.Point(420, 218);
            this.txtEnrollmentno.Size = new System.Drawing.Size(250, 30);
            this.txtEnrollmentno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEnrollmentno.Anchor = System.Windows.Forms.AnchorStyles.None;

            // ================= PASSWORD =================
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(250, 270);
            this.label3.Text = "Password:";
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;

            this.txtPassword.Location = new System.Drawing.Point(420, 268);
            this.txtPassword.Size = new System.Drawing.Size(250, 30);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;

            // ================= CONFIRM PASSWORD =================
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(250, 320);
            this.label4.Text = "Confirm Password:";
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Click += new System.EventHandler(this.label4_Click);

            this.txtConfirm.Location = new System.Drawing.Point(420, 318);
            this.txtConfirm.Size = new System.Drawing.Size(250, 30);
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirm.UseSystemPasswordChar = true;
            this.txtConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;

            // ================= SIGNUP BUTTON =================
            this.btnSignup.Location = new System.Drawing.Point(400, 390);
            this.btnSignup.Size = new System.Drawing.Size(160, 45);
            this.btnSignup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSignup.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click_1);

            // ================= ADD CONTROLS =================
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEnrollmentno);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.btnSignup);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtEnrollmentno;
    }
}