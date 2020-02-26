namespace SignUp
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.forgetPasswordLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(237, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(312, 84);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(199, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(237, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(312, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(199, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(313, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login your Account";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Blue;
            this.checkBox1.Location = new System.Drawing.Point(312, 145);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Remember me?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.loginButton.ForeColor = System.Drawing.Color.Blue;
            this.loginButton.Location = new System.Drawing.Point(312, 179);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(199, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            this.loginButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.loginButton.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // forgetPasswordLabel
            // 
            this.forgetPasswordLabel.AutoSize = true;
            this.forgetPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgetPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.forgetPasswordLabel.ForeColor = System.Drawing.Color.Blue;
            this.forgetPasswordLabel.Location = new System.Drawing.Point(376, 215);
            this.forgetPasswordLabel.Name = "forgetPasswordLabel";
            this.forgetPasswordLabel.Size = new System.Drawing.Size(135, 15);
            this.forgetPasswordLabel.TabIndex = 4;
            this.forgetPasswordLabel.Text = "Forget your Password ?";
            this.forgetPasswordLabel.Click += new System.EventHandler(this.label4_Click);
            this.forgetPasswordLabel.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            this.forgetPasswordLabel.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.signUpButton.ForeColor = System.Drawing.Color.Blue;
            this.signUpButton.Location = new System.Drawing.Point(436, 264);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpButton.TabIndex = 5;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.button2_Click);
            this.signUpButton.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.signUpButton.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(315, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Not have Account ?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.forgetPasswordLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label forgetPasswordLabel;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label label5;
    }
}