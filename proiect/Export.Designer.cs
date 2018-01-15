namespace proiect
{
    partial class Export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export));
            this.btCSV = new System.Windows.Forms.Button();
            this.btExcel = new System.Windows.Forms.Button();
            this.btPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCSV
            // 
            this.btCSV.Location = new System.Drawing.Point(12, 70);
            this.btCSV.Name = "btCSV";
            this.btCSV.Size = new System.Drawing.Size(121, 23);
            this.btCSV.TabIndex = 5;
            this.btCSV.Text = "Export to .csv";
            this.btCSV.UseVisualStyleBackColor = true;
            this.btCSV.Click += new System.EventHandler(this.btCSV_Click);
            // 
            // btExcel
            // 
            this.btExcel.Location = new System.Drawing.Point(12, 41);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(121, 23);
            this.btExcel.TabIndex = 4;
            this.btExcel.Text = "Export to .xlsx";
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // btPDF
            // 
            this.btPDF.Location = new System.Drawing.Point(12, 12);
            this.btPDF.Name = "btPDF";
            this.btPDF.Size = new System.Drawing.Size(121, 23);
            this.btPDF.TabIndex = 3;
            this.btPDF.Text = "Export to .pdf";
            this.btPDF.UseVisualStyleBackColor = true;
            this.btPDF.Click += new System.EventHandler(this.btPDF_Click);
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 104);
            this.Controls.Add(this.btCSV);
            this.Controls.Add(this.btExcel);
            this.Controls.Add(this.btPDF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCSV;
        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.Button btPDF;
    }
}