namespace ETicketDesktopClient
{
    partial class MainWindow
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
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.loginBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTb
            // 
            this.usernameTb.AccessibleName = "";
            this.usernameTb.Location = new System.Drawing.Point(216, 105);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(419, 20);
            this.usernameTb.TabIndex = 0;
            // 
            // passwordTb
            // 
            this.passwordTb.AccessibleName = "";
            this.passwordTb.Location = new System.Drawing.Point(216, 166);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(419, 20);
            this.passwordTb.TabIndex = 1;
            // 
            // loginBt
            // 
            this.loginBt.AccessibleName = "";
            this.loginBt.Location = new System.Drawing.Point(283, 225);
            this.loginBt.Name = "loginBt";
            this.loginBt.Size = new System.Drawing.Size(266, 107);
            this.loginBt.TabIndex = 2;
            this.loginBt.Text = "Login ya bitch";
            this.loginBt.UseVisualStyleBackColor = true;
            this.loginBt.Click += new System.EventHandler(this.loginBt_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginBt);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.usernameTb);
            this.Name = "MainWindow";
            this.Text = "ETicket - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Button loginBt;
    }
}

