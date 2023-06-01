using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace AppConvertir
{
    public partial class frmGraficar : Form
    {
        OpenFileDialog dialogo = new OpenFileDialog();
        public frmGraficar()
        {
            InitializeComponent();
            lstvDatos.View = View.Details;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            //listview

            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            tvArbol.Nodes.Clear(); // Limpiar los nodos existentes en el árbol
            tvArbol.Visible = true;
            chart1.Visible = true;
            lstvDatos.Visible = true;
            lstvDatos.Clear();
            string rutaArchivo = dialogo.FileName;
            StreamReader sr = new StreamReader(rutaArchivo, Encoding.GetEncoding(1252));
            string columnas = sr.ReadLine();
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

                //treeview
                TreeNode node = new TreeNode(datos[0]);
                for (int i = 1; i < datos.Length; i++)
                {
                    node.Nodes.Add(datos[i]);
                }
                tvArbol.Nodes.Add(node);
            }

            //graficar

            StreamReader dr = new StreamReader(rutaArchivo, Encoding.UTF8);
            string x = "";
            int y = 0;
            while ((renglon = dr.ReadLine()) != null)
            {
                string[] datos = renglon.Split('|');
                if (x != datos[0] && x != "")
                {
                    chart1.Series[0].Points.AddXY(x, y);
                    y = 0;
                }
                x = datos[0];
                y++;
            }
            chart1.Series[0].Points.AddXY(x, y);
            sr.Close();
        }
    }
}

