namespace AppConvertir
{
    partial class frmApi
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
            this.lbSerie = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSerie
            // 
            this.lbSerie.AutoSize = true;
            this.lbSerie.Location = new System.Drawing.Point(15, 57);
            this.lbSerie.Name = "lbSerie";
            this.lbSerie.Size = new System.Drawing.Size(31, 13);
            this.lbSerie.TabIndex = 0;
            this.lbSerie.Text = "Serie";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(15, 87);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(37, 13);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.Text = "Fecha";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(15, 114);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(37, 13);
            this.lbPrecio.TabIndex = 2;
            this.lbPrecio.Text = "Precio";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(112, 129);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 3;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 163);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbSerie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSerie;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Button BtnConsultar;
    }
}
