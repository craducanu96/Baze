namespace proiect
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.lbLastName = new System.Windows.Forms.Label();
            this.txtPhoneForgot = new System.Windows.Forms.TextBox();
            this.lbEmailForgot = new System.Windows.Forms.Label();
            this.txtEmailForgot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelForgot = new System.Windows.Forms.Panel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.txtConfirmForgotPass = new System.Windows.Forms.TextBox();
            this.lbConirmNewPass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewForgotPass = new System.Windows.Forms.TextBox();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.btOk1 = new System.Windows.Forms.Button();
            this.btOk2 = new System.Windows.Forms.Button();
            this.panelForgot.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(28, 78);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(110, 13);
            this.lbLastName.TabIndex = 11;
            this.lbLastName.Text = "Phone of the account";
            // 
            // txtPhoneForgot
            // 
            this.txtPhoneForgot.Location = new System.Drawing.Point(31, 94);
            this.txtPhoneForgot.Name = "txtPhoneForgot";
            this.txtPhoneForgot.Size = new System.Drawing.Size(107, 20);
            this.txtPhoneForgot.TabIndex = 10;
            this.txtPhoneForgot.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lbEmailForgot
            // 
            this.lbEmailForgot.AutoSize = true;
            this.lbEmailForgot.Location = new System.Drawing.Point(28, 38);
            this.lbEmailForgot.Name = "lbEmailForgot";
            this.lbEmailForgot.Size = new System.Drawing.Size(104, 13);
            this.lbEmailForgot.TabIndex = 9;
            this.lbEmailForgot.Text = "Email of the account";
            // 
            // txtEmailForgot
            // 
            this.txtEmailForgot.Location = new System.Drawing.Point(31, 54);
            this.txtEmailForgot.Name = "txtEmailForgot";
            this.txtEmailForgot.Size = new System.Drawing.Size(107, 20);
            this.txtEmailForgot.TabIndex = 8;
            this.txtEmailForgot.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // panelForgot
            // 
            this.panelForgot.Controls.Add(this.txtPhoneForgot);
            this.panelForgot.Controls.Add(this.lbLastName);
            this.panelForgot.Controls.Add(this.label1);
            this.panelForgot.Controls.Add(this.txtEmailForgot);
            this.panelForgot.Controls.Add(this.lbEmailForgot);
            this.panelForgot.Location = new System.Drawing.Point(23, 27);
            this.panelForgot.Name = "panelForgot";
            this.panelForgot.Size = new System.Drawing.Size(175, 183);
            this.panelForgot.TabIndex = 12;
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.txtConfirmForgotPass);
            this.panelPassword.Controls.Add(this.lbConirmNewPass);
            this.panelPassword.Controls.Add(this.label3);
            this.panelPassword.Controls.Add(this.txtNewForgotPass);
            this.panelPassword.Controls.Add(this.lbNewPass);
            this.panelPassword.Location = new System.Drawing.Point(279, 27);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(175, 183);
            this.panelPassword.TabIndex = 13;
            // 
            // txtConfirmForgotPass
            // 
            this.txtConfirmForgotPass.Location = new System.Drawing.Point(31, 94);
            this.txtConfirmForgotPass.Name = "txtConfirmForgotPass";
            this.txtConfirmForgotPass.Size = new System.Drawing.Size(107, 20);
            this.txtConfirmForgotPass.TabIndex = 10;
            this.txtConfirmForgotPass.TextChanged += new System.EventHandler(this.txtConfirmForgotPass_TextChanged);
            // 
            // lbConirmNewPass
            // 
            this.lbConirmNewPass.AutoSize = true;
            this.lbConirmNewPass.Location = new System.Drawing.Point(28, 78);
            this.lbConirmNewPass.Name = "lbConirmNewPass";
            this.lbConirmNewPass.Size = new System.Drawing.Size(113, 13);
            this.lbConirmNewPass.TabIndex = 11;
            this.lbConirmNewPass.Text = "Confirm new password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // txtNewForgotPass
            // 
            this.txtNewForgotPass.Location = new System.Drawing.Point(31, 54);
            this.txtNewForgotPass.Name = "txtNewForgotPass";
            this.txtNewForgotPass.Size = new System.Drawing.Size(107, 20);
            this.txtNewForgotPass.TabIndex = 8;
            this.txtNewForgotPass.TextChanged += new System.EventHandler(this.txtNewForgotPass_TextChanged);
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Location = new System.Drawing.Point(28, 38);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(77, 13);
            this.lbNewPass.TabIndex = 9;
            this.lbNewPass.Text = "New password";
            // 
            // btOk1
            // 
            this.btOk1.Location = new System.Drawing.Point(80, 226);
            this.btOk1.Name = "btOk1";
            this.btOk1.Size = new System.Drawing.Size(75, 23);
            this.btOk1.TabIndex = 14;
            this.btOk1.Text = "Ok";
            this.btOk1.UseVisualStyleBackColor = true;
            this.btOk1.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btOk2
            // 
            this.btOk2.Location = new System.Drawing.Point(325, 226);
            this.btOk2.Name = "btOk2";
            this.btOk2.Size = new System.Drawing.Size(75, 23);
            this.btOk2.TabIndex = 15;
            this.btOk2.Text = "Ok";
            this.btOk2.UseVisualStyleBackColor = true;
            this.btOk2.Click += new System.EventHandler(this.btOk2_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(512, 423);
            this.Controls.Add(this.btOk2);
            this.Controls.Add(this.btOk1);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panelForgot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.panelForgot.ResumeLayout(false);
            this.panelForgot.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox txtPhoneForgot;
        private System.Windows.Forms.Label lbEmailForgot;
        private System.Windows.Forms.TextBox txtEmailForgot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelForgot;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox txtConfirmForgotPass;
        private System.Windows.Forms.Label lbConirmNewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewForgotPass;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Button btOk1;
        private System.Windows.Forms.Button btOk2;
    }
}