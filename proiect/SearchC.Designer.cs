namespace proiect
{
    partial class SearchC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchC));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.companieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorcompanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numecompanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresacompanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailcompanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoncompanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.directorcompanieDataGridViewTextBoxColumn,
            this.numecompanieDataGridViewTextBoxColumn,
            this.adresacompanieDataGridViewTextBoxColumn,
            this.emailcompanieDataGridViewTextBoxColumn,
            this.telefoncompanieDataGridViewTextBoxColumn,
            this.usernameCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.companieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 459);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // companieBindingSource
            // 
            this.companieBindingSource.DataSource = typeof(proiect.Companie);
           
            // directorcompanieDataGridViewTextBoxColumn
            // 
            this.directorcompanieDataGridViewTextBoxColumn.DataPropertyName = "Director_companie";
            this.directorcompanieDataGridViewTextBoxColumn.HeaderText = "Director_companie";
            this.directorcompanieDataGridViewTextBoxColumn.Name = "directorcompanieDataGridViewTextBoxColumn";
            // 
            // numecompanieDataGridViewTextBoxColumn
            // 
            this.numecompanieDataGridViewTextBoxColumn.DataPropertyName = "Nume_companie";
            this.numecompanieDataGridViewTextBoxColumn.HeaderText = "Nume_companie";
            this.numecompanieDataGridViewTextBoxColumn.Name = "numecompanieDataGridViewTextBoxColumn";
            // 
            // adresacompanieDataGridViewTextBoxColumn
            // 
            this.adresacompanieDataGridViewTextBoxColumn.DataPropertyName = "Adresa_companie";
            this.adresacompanieDataGridViewTextBoxColumn.HeaderText = "Adresa_companie";
            this.adresacompanieDataGridViewTextBoxColumn.Name = "adresacompanieDataGridViewTextBoxColumn";
            // 
            // emailcompanieDataGridViewTextBoxColumn
            // 
            this.emailcompanieDataGridViewTextBoxColumn.DataPropertyName = "Email_companie";
            this.emailcompanieDataGridViewTextBoxColumn.HeaderText = "Email_companie";
            this.emailcompanieDataGridViewTextBoxColumn.Name = "emailcompanieDataGridViewTextBoxColumn";
            // 
            // telefoncompanieDataGridViewTextBoxColumn
            // 
            this.telefoncompanieDataGridViewTextBoxColumn.DataPropertyName = "Telefon_companie";
            this.telefoncompanieDataGridViewTextBoxColumn.HeaderText = "Telefon_companie";
            this.telefoncompanieDataGridViewTextBoxColumn.Name = "telefoncompanieDataGridViewTextBoxColumn";
            // 
            // usernameCDataGridViewTextBoxColumn
            // 
            this.usernameCDataGridViewTextBoxColumn.DataPropertyName = "UsernameC";
            this.usernameCDataGridViewTextBoxColumn.HeaderText = "UsernameC";
            this.usernameCDataGridViewTextBoxColumn.Name = "usernameCDataGridViewTextBoxColumn";
            // 
            // SearchC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 471);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchC";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn message;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorcompanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numecompanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresacompanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailcompanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoncompanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameCDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource companieBindingSource;
    }
}