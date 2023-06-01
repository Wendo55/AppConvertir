using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConvertir
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            frmXml abrir = new frmXml();
            abrir.Show();
            this.Close();
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            frmJson abrir = new frmJson();
            abrir.Show();
            this.Close();
        }

        private void btncsv_Click(object sender, EventArgs e)
        {
            frmcsv abrir = new frmcsv();
            abrir.Show();
            this.Close(); 
        }
    }
}
