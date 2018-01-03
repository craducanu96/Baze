namespace proiect
{
    partial class Log_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_page));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassoword = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btLogIn = new System.Windows.Forms.Button();
            this.lbNewClient = new System.Windows.Forms.LinkLabel();
            this.lbForgotPass = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNewCompany = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(149, 132);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(205, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPassoword
            // 
            this.txtPassoword.Location = new System.Drawing.Point(149, 180);
            this.txtPassoword.Name = "txtPassoword";
            this.txtPassoword.PasswordChar = '*';
            this.txtPassoword.Size = new System.Drawing.Size(205, 20);
            this.txtPassoword.TabIndex = 1;
            this.txtPassoword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(212, 107);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(88, 13);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Username or mail";
            this.lbUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(225, 161);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // btLogIn
            // 
            this.btLogIn.Location = new System.Drawing.Point(215, 222);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(75, 23);
            this.btLogIn.TabIndex = 4;
            this.btLogIn.Text = "Log In";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // lbNewClient
            // 
            this.lbNewClient.AutoSize = true;
            this.lbNewClient.Location = new System.Drawing.Point(158, 351);
            this.lbNewClient.Name = "lbNewClient";
            this.lbNewClient.Size = new System.Drawing.Size(57, 13);
            this.lbNewClient.TabIndex = 5;
            this.lbNewClient.TabStop = true;
            this.lbNewClient.Text = "New client";
            this.lbNewClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbSignIn_LinkClicked);
            // 
            // lbForgotPass
            // 
            this.lbForgotPass.AutoSize = true;
            this.lbForgotPass.Location = new System.Drawing.Point(207, 248);
            this.lbForgotPass.Name = "lbForgotPass";
            this.lbForgotPass.Size = new System.Drawing.Size(91, 13);
            this.lbForgotPass.TabIndex = 6;
            this.lbForgotPass.TabStop = true;
            this.lbForgotPass.Text = "Forgot password?";
            this.lbForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Not a member?";
            // 
            // lbNewCompany
            // 
            this.lbNewCompany.AutoSize = true;
            this.lbNewCompany.Location = new System.Drawing.Point(279, 351);
            this.lbNewCompany.Name = "lbNewCompany";
            this.lbNewCompany.Size = new System.Drawing.Size(75, 13);
            this.lbNewCompany.TabIndex = 8;
            this.lbNewCompany.TabStop = true;
            this.lbNewCompany.Text = "New company";
            this.lbNewCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbNewCompany_LinkClicked);
            // 
            // Log_page
            // 
            this.AcceptButton = this.btLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 423);
            this.Controls.Add(this.lbNewCompany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbForgotPass);
            this.Controls.Add(this.lbNewClient);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtPassoword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.txtUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Log_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Log_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassoword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.LinkLabel lbNewClient;
        private System.Windows.Forms.LinkLabel lbForgotPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbNewCompany;
    }
}

