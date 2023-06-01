namespace AppConvertir
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.previewWebBrowser = new System.Windows.Forms.WebBrowser();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.bnSerApi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(364, 479);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(499, 49);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(75, 23);
            this.btnWord.TabIndex = 2;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(499, 138);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 23);
            this.btnPdf.TabIndex = 1;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(499, 92);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // previewWebBrowser
            // 
            this.previewWebBrowser.Location = new System.Drawing.Point(12, 49);
            this.previewWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.previewWebBrowser.Name = "previewWebBrowser";
            this.previewWebBrowser.Size = new System.Drawing.Size(470, 438);
            this.previewWebBrowser.TabIndex = 3;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(389, 9);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 4;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click_1);
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(499, 268);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(75, 23);
            this.btnGraficar.TabIndex = 6;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(50, 12);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(285, 20);
            this.contentTextBox.TabIndex = 5;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(499, 317);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Formatos";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // bnSerApi
            // 
            this.bnSerApi.Location = new System.Drawing.Point(804, 12);
            this.bnSerApi.Name = "bnSerApi";
            this.bnSerApi.Size = new System.Drawing.Size(75, 43);
            this.bnSerApi.TabIndex = 9;
            this.bnSerApi.Text = "API";
            this.bnSerApi.UseVisualStyleBackColor = true;
            this.bnSerApi.Click += new System.EventHandler(this.bnSerApi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 527);
            this.Controls.Add(this.bnSerApi);
            this.Controls.Add(this.previewWebBrowser);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnExcel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.WebBrowser previewWebBrowser;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button bnSerApi;
    }
}

