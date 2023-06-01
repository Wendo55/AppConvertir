namespace AppConvertir
{
    partial class frmMenu
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
            this.btnXml = new System.Windows.Forms.Button();
            this.btnJson = new System.Windows.Forms.Button();
            this.btncsv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(118, 138);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(137, 122);
            this.btnXml.TabIndex = 0;
            this.btnXml.Text = "XML";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnJson
            // 
            this.btnJson.Location = new System.Drawing.Point(325, 138);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(137, 122);
            this.btnJson.TabIndex = 1;
            this.btnJson.Text = "JSON";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // btncsv
            // 
            this.btncsv.Location = new System.Drawing.Point(533, 138);
            this.btncsv.Name = "btncsv";
            this.btncsv.Size = new System.Drawing.Size(137, 122);
            this.btncsv.TabIndex = 2;
            this.btncsv.Text = "CSV";
            this.btncsv.UseVisualStyleBackColor = true;
            this.btncsv.Click += new System.EventHandler(this.btncsv_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncsv);
            this.Controls.Add(this.btnJson);
            this.Controls.Add(this.btnXml);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnJson;
        private System.Windows.Forms.Button btncsv;
    }
}