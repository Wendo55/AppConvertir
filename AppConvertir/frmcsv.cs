using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;

namespace AppConvertir
{
    public partial class frmcsv : Form
    {
        public frmcsv()
        {
            InitializeComponent();
            lstvDatos.View = View.Details;
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            lstvDatos.Clear();
            string rutaArchivo = dialogo.FileName;
            StreamReader sr = new StreamReader(rutaArchivo, Encoding.GetEncoding(1252));
            string columnas = sr.ReadLine();// asass//as//
            string[] columna = columnas.Split('|');
            for (int i = 0; i < columna.Length; i++)
            {
                lstvDatos.Columns.Add(columna[i]);
            }
            string renglon;
            while ((renglon = sr.ReadLine()) != null)
            {
                string[] datos = renglon.Split('|');
                ListViewItem item = new ListViewItem(datos[0]);
                for (int i = 1; i < datos.Length; i++)
                {
                    item.SubItems.Add(datos[i]);
                }
                lstvDatos.Items.Add(item);
            }
            sr.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV|*.csv| txt|*.txt";
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            StreamWriter sw = new StreamWriter(sfd.FileName);
            foreach (ListViewItem item in lstvDatos.Items)
            {
                int i = 1;
                foreach (ListViewItem.ListViewSubItem sub in item.SubItems)
                {
                    if (i == lstvDatos.Columns.Count)
                    {
                        sw.Write(sub.Text);
                        sw.WriteLine();
                        i = 0;
                    }
                    else
                    {
                        sw.Write(sub.Text + ",");
                        i++;
                    }
                }
            }
            sw.Close();
        }
    }
}
