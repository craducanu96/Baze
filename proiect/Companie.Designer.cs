namespace proiect
{
    partial class Companie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Companie));
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbDetails = new System.Windows.Forms.Label();
            this.lbCEO = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCEO = new System.Windows.Forms.TextBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.lbSkillsRequest = new System.Windows.Forms.Label();
            this.txtSkillsRequest = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picMessaging = new System.Windows.Forms.PictureBox();
            this.btLogOut = new System.Windows.Forms.Button();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMessaging)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(3, 84);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(3, 58);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(38, 13);
            this.lbPhone.TabIndex = 10;
            this.lbPhone.Text = "Phone";
            // 
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDetails.Location = new System.Drawing.Point(12, 120);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(39, 13);
            this.lbDetails.TabIndex = 12;
            this.lbDetails.Text = "Details";
            this.lbDetails.Click += new System.EventHandler(this.lbDetails_Click);
            // 
            // lbCEO
            // 
            this.lbCEO.AutoSize = true;
            this.lbCEO.Location = new System.Drawing.Point(3, 32);
            this.lbCEO.Name = "lbCEO";
            this.lbCEO.Size = new System.Drawing.Size(29, 13);
            this.lbCEO.TabIndex = 9;
            this.lbCEO.Text = "CEO";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(3, 6);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 13);
            this.lbAddress.TabIndex = 8;
            this.lbAddress.Text = "Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(64, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(64, 55);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(121, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // txtCEO
            // 
            this.txtCEO.Location = new System.Drawing.Point(64, 29);
            this.txtCEO.Name = "txtCEO";
            this.txtCEO.ReadOnly = true;
            this.txtCEO.Size = new System.Drawing.Size(121, 20);
            this.txtCEO.TabIndex = 1;
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.lbSkillsRequest);
            this.panelDetails.Controls.Add(this.txtSkillsRequest);
            this.panelDetails.Controls.Add(this.lbEmail);
            this.panelDetails.Controls.Add(this.lbPhone);
            this.panelDetails.Controls.Add(this.lbCEO);
            this.panelDetails.Controls.Add(this.lbAddress);
            this.panelDetails.Controls.Add(this.txtPhone);
            this.panelDetails.Controls.Add(this.txtCEO);
            this.panelDetails.Controls.Add(this.txtAddress);
            this.panelDetails.Controls.Add(this.txtEmail);
            this.panelDetails.Location = new System.Drawing.Point(54, 120);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(188, 186);
            this.panelDetails.TabIndex = 13;
            // 
            // lbSkillsRequest
            // 
            this.lbSkillsRequest.AutoSize = true;
            this.lbSkillsRequest.Location = new System.Drawing.Point(3, 110);
            this.lbSkillsRequest.Name = "lbSkillsRequest";
            this.lbSkillsRequest.Size = new System.Drawing.Size(58, 13);
            this.lbSkillsRequest.TabIndex = 16;
            this.lbSkillsRequest.Text = "Skills need";
            // 
            // txtSkillsRequest
            // 
            this.txtSkillsRequest.Location = new System.Drawing.Point(64, 107);
            this.txtSkillsRequest.Multiline = true;
            this.txtSkillsRequest.Name = "txtSkillsRequest";
            this.txtSkillsRequest.ReadOnly = true;
            this.txtSkillsRequest.Size = new System.Drawing.Size(121, 72);
            this.txtSkillsRequest.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(64, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(121, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(12, 26);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(89, 13);
            this.lbCompanyName.TabIndex = 11;
            this.lbCompanyName.Text = "@companyName";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(206, 76);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(62, 20);
            this.btSearch.TabIndex = 19;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(188, 20);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // picMessaging
            // 
            this.picMessaging.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMessaging.Location = new System.Drawing.Point(325, 26);
            this.picMessaging.Name = "picMessaging";
            this.picMessaging.Size = new System.Drawing.Size(50, 50);
            this.picMessaging.TabIndex = 8;
            this.picMessaging.TabStop = false;
            this.picMessaging.Click += new System.EventHandler(this.picMessaging_Click);
            // 
            // btLogOut
            // 
            this.btLogOut.Location = new System.Drawing.Point(300, 329);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(75, 23);
            this.btLogOut.TabIndex = 20;
            this.btLogOut.Text = "Log out";
            this.btLogOut.UseVisualStyleBackColor = true;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // Companie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 364);
            this.Controls.Add(this.btLogOut);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.picMessaging);
            this.Controls.Add(this.lbDetails);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.panelDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Companie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Companie";
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMessaging)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbDetails;
        private System.Windows.Forms.Label lbCEO;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCEO;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.PictureBox picMessaging;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbSkillsRequest;
        private System.Windows.Forms.TextBox txtSkillsRequest;
        private System.Windows.Forms.Button btLogOut;
    }
}