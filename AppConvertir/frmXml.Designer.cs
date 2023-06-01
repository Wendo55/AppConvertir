namespace AppConvertir
{
    partial class frmXml
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnExportToWord = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnExportToPdf = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Abrir";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnExportToWord
            // 
            this.btnExportToWord.Location = new System.Drawing.Point(12, 41);
            this.btnExportToWord.Name = "btnExportToWord";
            this.btnExportToWord.Size = new System.Drawing.Size(120, 23);
            this.btnExportToWord.TabIndex = 1;
            this.btnExportToWord.Text = "Exportar a word";
            this.btnExportToWord.UseVisualStyleBackColor = true;
            this.btnExportToWord.Click += new System.EventHandler(this.btnExportToWord_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(12, 70);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(120, 23);
            this.btnExportToExcel.TabIndex = 2;
            this.btnExportToExcel.Text = "Exportar a Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnExportToPdf
            // 
            this.btnExportToPdf.Location = new System.Drawing.Point(12, 99);
            this.btnExportToPdf.Name = "btnExportToPdf";
            this.btnExportToPdf.Size = new System.Drawing.Size(120, 23);
            this.btnExportToPdf.TabIndex = 3;
            this.btnExportToPdf.Text = "Exportar a PDF";
            this.btnExportToPdf.UseVisualStyleBackColor = true;
            this.btnExportToPdf.Click += new System.EventHandler(this.btnExportToPdf_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(138, 1);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(400, 300);
            this.dataGridView.TabIndex = 4;
            // 
            // frmXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 324);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnExportToPdf);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnExportToWord);
            this.Controls.Add(this.btnOpen);
            this.Name = "frmXml";
            this.Text = "Lector XML";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnExportToWord;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Button btnExportToPdf;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

