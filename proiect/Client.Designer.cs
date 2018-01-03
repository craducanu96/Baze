namespace proiect
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.picMessaging = new System.Windows.Forms.PictureBox();
            this.picRequest = new System.Windows.Forms.PictureBox();
            this.picMe = new System.Windows.Forms.PictureBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbDetails = new System.Windows.Forms.Label();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.listSkils = new System.Windows.Forms.ListBox();
            this.lbSkills = new System.Windows.Forms.Label();
            this.lbNationality = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbUniversity = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtUniversiy = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.lbRating = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.panelNotification = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMessaging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMe)).BeginInit();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.panelNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // picMessaging
            // 
            this.picMessaging.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMessaging.Location = new System.Drawing.Point(450, 12);
            this.picMessaging.Name = "picMessaging";
            this.picMessaging.Size = new System.Drawing.Size(50, 50);
            this.picMessaging.TabIndex = 0;
            this.picMessaging.TabStop = false;
            this.picMessaging.Click += new System.EventHandler(this.picMessaging_Click);
            // 
            // picRequest
            // 
            this.picRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRequest.Location = new System.Drawing.Point(394, 12);
            this.picRequest.Name = "picRequest";
            this.picRequest.Size = new System.Drawing.Size(50, 50);
            this.picRequest.TabIndex = 1;
            this.picRequest.TabStop = false;
            this.picRequest.Click += new System.EventHandler(this.picRequest_Click);
            // 
            // picMe
            // 
            this.picMe.Location = new System.Drawing.Point(12, 12);
            this.picMe.Name = "picMe";
            this.picMe.Size = new System.Drawing.Size(100, 100);
            this.picMe.TabIndex = 2;
            this.picMe.TabStop = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(-1, 115);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(131, 13);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Nume prenume(username)";
            // 
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDetails.Location = new System.Drawing.Point(12, 235);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(36, 13);
            this.lbDetails.TabIndex = 4;
            this.lbDetails.Text = "Detalii";
            this.lbDetails.Click += new System.EventHandler(this.lbDetails_Click);
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.listSkils);
            this.panelDetails.Controls.Add(this.lbSkills);
            this.panelDetails.Controls.Add(this.lbNationality);
            this.panelDetails.Controls.Add(this.lbEmail);
            this.panelDetails.Controls.Add(this.lbBirth);
            this.panelDetails.Controls.Add(this.lbStatus);
            this.panelDetails.Controls.Add(this.lbSex);
            this.panelDetails.Controls.Add(this.lbPhone);
            this.panelDetails.Controls.Add(this.lbUniversity);
            this.panelDetails.Controls.Add(this.lbAddress);
            this.panelDetails.Controls.Add(this.txtNationality);
            this.panelDetails.Controls.Add(this.txtEmail);
            this.panelDetails.Controls.Add(this.txtBirth);
            this.panelDetails.Controls.Add(this.txtStatus);
            this.panelDetails.Controls.Add(this.txtSex);
            this.panelDetails.Controls.Add(this.txtPhone);
            this.panelDetails.Controls.Add(this.txtUniversiy);
            this.panelDetails.Controls.Add(this.txtAddress);
            this.panelDetails.Location = new System.Drawing.Point(54, 214);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(188, 242);
            this.panelDetails.TabIndex = 5;
            // 
            // listSkils
            // 
            this.listSkils.FormattingEnabled = true;
            this.listSkils.Location = new System.Drawing.Point(64, 214);
            this.listSkils.Name = "listSkils";
            this.listSkils.Size = new System.Drawing.Size(120, 17);
            this.listSkils.TabIndex = 19;
            // 
            // lbSkills
            // 
            this.lbSkills.AutoSize = true;
            this.lbSkills.Location = new System.Drawing.Point(3, 214);
            this.lbSkills.Name = "lbSkills";
            this.lbSkills.Size = new System.Drawing.Size(31, 13);
            this.lbSkills.TabIndex = 17;
            this.lbSkills.Text = "Skills";
            // 
            // lbNationality
            // 
            this.lbNationality.AutoSize = true;
            this.lbNationality.Location = new System.Drawing.Point(3, 188);
            this.lbNationality.Name = "lbNationality";
            this.lbNationality.Size = new System.Drawing.Size(56, 13);
            this.lbNationality.TabIndex = 15;
            this.lbNationality.Text = "Nationality";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(3, 162);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "E-mail";
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.Location = new System.Drawing.Point(3, 136);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(45, 13);
            this.lbBirth.TabIndex = 13;
            this.lbBirth.Text = "Birthday";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(3, 110);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 12;
            this.lbStatus.Text = "Status";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(3, 84);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(25, 13);
            this.lbSex.TabIndex = 11;
            this.lbSex.Text = "Sex";
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
            // lbUniversity
            // 
            this.lbUniversity.AutoSize = true;
            this.lbUniversity.Location = new System.Drawing.Point(3, 32);
            this.lbUniversity.Name = "lbUniversity";
            this.lbUniversity.Size = new System.Drawing.Size(53, 13);
            this.lbUniversity.TabIndex = 9;
            this.lbUniversity.Text = "University";
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
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(64, 185);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.ReadOnly = true;
            this.txtNationality.Size = new System.Drawing.Size(121, 20);
            this.txtNationality.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(64, 159);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(64, 133);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.ReadOnly = true;
            this.txtBirth.Size = new System.Drawing.Size(121, 20);
            this.txtBirth.TabIndex = 5;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(64, 107);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(121, 20);
            this.txtStatus.TabIndex = 4;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(64, 81);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(121, 20);
            this.txtSex.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(64, 55);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(121, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // txtUniversiy
            // 
            this.txtUniversiy.Location = new System.Drawing.Point(64, 29);
            this.txtUniversiy.Name = "txtUniversiy";
            this.txtUniversiy.ReadOnly = true;
            this.txtUniversiy.Size = new System.Drawing.Size(121, 20);
            this.txtUniversiy.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(64, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(121, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // trackBar
            // 
            this.trackBar.Enabled = false;
            this.trackBar.Location = new System.Drawing.Point(54, 163);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(121, 45);
            this.trackBar.TabIndex = 6;
            this.trackBar.Value = 5;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lbRating
            // 
            this.lbRating.AutoSize = true;
            this.lbRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRating.Location = new System.Drawing.Point(12, 173);
            this.lbRating.Name = "lbRating";
            this.lbRating.Size = new System.Drawing.Size(38, 13);
            this.lbRating.TabIndex = 7;
            this.lbRating.Text = "Rating";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(118, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(188, 20);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(312, 42);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(62, 20);
            this.bSearch.TabIndex = 17;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // panelNotification
            // 
            this.panelNotification.Controls.Add(this.dataGridView1);
            this.panelNotification.Location = new System.Drawing.Point(264, 115);
            this.panelNotification.Name = "panelNotification";
            this.panelNotification.Size = new System.Drawing.Size(250, 362);
            this.panelNotification.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.confirm});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(247, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // confirm
            // 
            this.confirm.HeaderText = "Confirm friend";
            this.confirm.Name = "confirm";
            this.confirm.ReadOnly = true;
            // 
            // btLogOut
            // 
            this.btLogOut.Location = new System.Drawing.Point(118, 463);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(75, 23);
            this.btLogOut.TabIndex = 19;
            this.btLogOut.Text = "Log out";
            this.btLogOut.UseVisualStyleBackColor = true;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 489);
            this.Controls.Add(this.btLogOut);
            this.Controls.Add(this.panelNotification);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbRating);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.lbDetails);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.picMe);
            this.Controls.Add(this.picRequest);
            this.Controls.Add(this.picMessaging);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.picMessaging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMe)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.panelNotification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMessaging;
        private System.Windows.Forms.PictureBox picRequest;
        private System.Windows.Forms.PictureBox picMe;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbDetails;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtUniversiy;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbUniversity;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNationality;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label lbRating;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbSkills;
        private System.Windows.Forms.ListBox listSkils;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Panel panelNotification;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewButtonColumn confirm;
        private System.Windows.Forms.Button btLogOut;
    }
}