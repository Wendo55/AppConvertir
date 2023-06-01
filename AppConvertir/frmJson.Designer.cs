namespace AppConvertir
{
    partial class frmJson
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnSerializar = new System.Windows.Forms.Button();
            this.btnDeserializar = new System.Windows.Forms.Button();
            this.btnExportarWord = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.txtJson = new System.Windows.Forms.TextBox();
            this.listViewPersonas = new System.Windows.Forms.ListView();
            this.columnHeaderNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEdad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCiudad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAbrir = new System.Windows.Forms.Button();
            this.listViewJson = new System.Windows.Forms.ListView();
            this.radioButtonWord = new System.Windows.Forms.RadioButton();
            this.radioButtonPDF = new System.Windows.Forms.RadioButton();
            this.radioButtonExcel = new System.Windows.Forms.RadioButton();
            this.btnExportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSerializar
            // 
            this.btnSerializar.Location = new System.Drawing.Point(12, 12);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(150, 23);
            this.btnSerializar.TabIndex = 0;
            this.btnSerializar.Text = "Serializar";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // btnDeserializar
            // 
            this.btnDeserializar.Location = new System.Drawing.Point(12, 41);
            this.btnDeserializar.Name = "btnDeserializar";
            this.btnDeserializar.Size = new System.Drawing.Size(150, 23);
            this.btnDeserializar.TabIndex = 1;
            this.btnDeserializar.Text = "Deserializar";
            this.btnDeserializar.UseVisualStyleBackColor = true;
            this.btnDeserializar.Click += new System.EventHandler(this.btnDeserializar_Click);
            // 
            // btnExportarWord
            // 
            this.btnExportarWord.Location = new System.Drawing.Point(12, 70);
            this.btnExportarWord.Name = "btnExportarWord";
            this.btnExportarWord.Size = new System.Drawing.Size(150, 23);
            this.btnExportarWord.TabIndex = 2;
            this.btnExportarWord.Text = "Exportar a Word";
            this.btnExportarWord.UseVisualStyleBackColor = true;
            this.btnExportarWord.Click += new System.EventHandler(this.btnExportarWord_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(12, 99);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(150, 23);
            this.btnExportarExcel.TabIndex = 3;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.Location = new System.Drawing.Point(12, 128);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(150, 23);
            this.btnExportarPDF.TabIndex = 4;
            this.btnExportarPDF.Text = "Exportar a PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = true;
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
            // 
            // txtJson
            // 
            this.txtJson.Location = new System.Drawing.Point(168, 12);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.ReadOnly = true;
            this.txtJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJson.Size = new System.Drawing.Size(300, 139);
            this.txtJson.TabIndex = 5;
            // 
            // listViewPersonas
            // 
            this.listViewPersonas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNombre,
            this.columnHeaderEdad,
            this.columnHeaderCiudad});
            this.listViewPersonas.FullRowSelect = true;
            this.listViewPersonas.HideSelection = false;
            this.listViewPersonas.Location = new System.Drawing.Point(12, 173);
            this.listViewPersonas.Name = "listViewPersonas";
            this.listViewPersonas.Size = new System.Drawing.Size(456, 175);
            this.listViewPersonas.TabIndex = 6;
            this.listViewPersonas.UseCompatibleStateImageBehavior = false;
            this.listViewPersonas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNombre
            // 
            this.columnHeaderNombre.Text = "Nombre";
            this.columnHeaderNombre.Width = 150;
            // 
            // columnHeaderEdad
            // 
            this.columnHeaderEdad.Text = "Edad";
            this.columnHeaderEdad.Width = 80;
            // 
            // columnHeaderCiudad
            // 
            this.columnHeaderCiudad.Text = "Ciudad";
            this.columnHeaderCiudad.Width = 150;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(612, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(99, 23);
            this.btnAbrir.TabIndex = 8;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // listViewJson
            // 
            this.listViewJson.HideSelection = false;
            this.listViewJson.Location = new System.Drawing.Point(612, 41);
            this.listViewJson.Name = "listViewJson";
            this.listViewJson.Size = new System.Drawing.Size(359, 324);
            this.listViewJson.TabIndex = 9;
            this.listViewJson.UseCompatibleStateImageBehavior = false;
            // 
            // radioButtonWord
            // 
            this.radioButtonWord.AutoSize = true;
            this.radioButtonWord.Location = new System.Drawing.Point(612, 371);
            this.radioButtonWord.Name = "radioButtonWord";
            this.radioButtonWord.Size = new System.Drawing.Size(48, 17);
            this.radioButtonWord.TabIndex = 10;
            this.radioButtonWord.TabStop = true;
            this.radioButtonWord.Text = "word";
            this.radioButtonWord.UseVisualStyleBackColor = true;
            // 
            // radioButtonPDF
            // 
            this.radioButtonPDF.AutoSize = true;
            this.radioButtonPDF.Location = new System.Drawing.Point(735, 371);
            this.radioButtonPDF.Name = "radioButtonPDF";
            this.radioButtonPDF.Size = new System.Drawing.Size(46, 17);
            this.radioButtonPDF.TabIndex = 11;
            this.radioButtonPDF.TabStop = true;
            this.radioButtonPDF.Text = "PDF";
            this.radioButtonPDF.UseVisualStyleBackColor = true;
            // 
            // radioButtonExcel
            // 
            this.radioButtonExcel.AutoSize = true;
            this.radioButtonExcel.Location = new System.Drawing.Point(678, 371);
            this.radioButtonExcel.Name = "radioButtonExcel";
            this.radioButtonExcel.Size = new System.Drawing.Size(51, 17);
            this.radioButtonExcel.TabIndex = 12;
            this.radioButtonExcel.TabStop = true;
            this.radioButtonExcel.Text = "Excel";
            this.radioButtonExcel.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(812, 368);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(99, 23);
            this.btnExportar.TabIndex = 13;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 463);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.radioButtonExcel);
            this.Controls.Add(this.radioButtonPDF);
            this.Controls.Add(this.radioButtonWord);
            this.Controls.Add(this.listViewJson);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.listViewPersonas);
            this.Controls.Add(this.txtJson);
            this.Controls.Add(this.btnExportarPDF);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnExportarWord);
            this.Controls.Add(this.btnDeserializar);
            this.Controls.Add(this.btnSerializar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmJson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertir XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerializar;
        private System.Windows.Forms.Button btnDeserializar;
        private System.Windows.Forms.Button btnExportarWord;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.TextBox txtJson;
        private System.Windows.Forms.ListView listViewPersonas;
        private System.Windows.Forms.ColumnHeader columnHeaderNombre;
        private System.Windows.Forms.ColumnHeader columnHeaderEdad;
        private System.Windows.Forms.ColumnHeader columnHeaderCiudad;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ListView listViewJson;
        private System.Windows.Forms.RadioButton radioButtonWord;
        private System.Windows.Forms.RadioButton radioButtonPDF;
        private System.Windows.Forms.RadioButton radioButtonExcel;
        private System.Windows.Forms.Button btnExportar;
    }
}
