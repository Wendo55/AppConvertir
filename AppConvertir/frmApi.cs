using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConvertir
{
    public partial class frmApi : Form
    {
        public frmApi()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Response response = read();
            Serie serie = response.seriesResponse.series[0];
            lbSerie.Text = "Serie: " + serie.Title;
            foreach (DataSerie dataSerie in serie.Data)
            {
                if (dataSerie.Data.Equals("N/E")) continue;
                lbFecha.Text = "Fecha: " + dataSerie.Date;
                lbPrecio.Text = "Precio: " + dataSerie.Data;
            }
            Console.ReadLine();
        }
        private static Response read()
        {
            try
            {
                string url = "https://www.banxico.org.mx/SieAPIRest/service/v1/series/SF43718/datos/2023-01-31/2023-01-31";
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Accept = "application/json";
                request.Headers["Bmx-Token"] = "69260904c3e398685c78e54928e7129fb21c7f79443e3c8b59e5c91f8319ef47";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception(String.Format(
                    "Server error (HTTP {0}: {1}).",
                    response.StatusCode,
                    response.StatusDescription));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
                object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                Response jsonResponse = objResponse as Response;
                return jsonResponse;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
    }
}

