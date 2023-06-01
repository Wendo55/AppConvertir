using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Word;
using Document = iTextSharp.text.Document;
using Paragraph = iTextSharp.text.Paragraph;

namespace AppConvertir
{
    public partial class frmJson : Form
    {
        private List<Persona> personas;
        //private List<string> datosJson;
        private ExportFormat formatoExportacion;
        private List<dynamic> datosJson;
        private string jsonContent;

        public frmJson()
        {
            InitializeComponent();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            personas = new List<Persona>();

            for (int i = 1; i <= 10; i++)
            {
                Persona persona = new Persona
                {
                    Nombre = "Persona " + i,
                    Edad = i * 10,
                    Ciudad = "Ciudad " + i
                };

                personas.Add(persona);
            }

            string json = JsonConvert.SerializeObject(personas);

            txtJson.Text = json;
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            string json = txtJson.Text;

            personas = JsonConvert.DeserializeObject<List<Persona>>(json);

            // Mostrar los datos en el control ListView
            listViewPersonas.Items.Clear();

            foreach (Persona persona in personas)
            {
                ListViewItem item = new ListViewItem(persona.Nombre);
                item.SubItems.Add(persona.Edad.ToString());
                item.SubItems.Add(persona.Ciudad);
                listViewPersonas.Items.Add(item);
            }
        }

        private void btnExportarWord_Click(object sender, EventArgs e)
        {
            if (personas != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Word Document (*.docx)|*.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                    Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Add();

                    // Crear la tabla
                    Microsoft.Office.Interop.Word.Table table = wordDoc.Tables.Add(wordDoc.Range(), personas.Count + 1, 3);

                    // Escribir encabezados
                    table.Cell(1, 1).Range.Text = "Nombre";
                    table.Cell(1, 2).Range.Text = "Edad";
                    table.Cell(1, 3).Range.Text = "Ciudad";

                    // Escribir datos
                    for (int i = 0; i < personas.Count; i++)
                    {
                        table.Cell(i + 2, 1).Range.Text = personas[i].Nombre;
                        table.Cell(i + 2, 2).Range.Text = personas[i].Edad.ToString();
                        table.Cell(i + 2, 3).Range.Text = personas[i].Ciudad;
                    }

                    // Guardar y cerrar el archivo
                    wordDoc.SaveAs2(filePath);
                    wordDoc.Close();
                    wordApp.Quit();

                    MessageBox.Show("Los datos se han exportado a Word exitosamente.");
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar. Por favor, primero realiza la deserialización.");
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (personas != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Add();
                    Excel.Worksheet worksheet = workbook.ActiveSheet;

                    // Escribir encabezados
                    worksheet.Cells[1, 1] = "Nombre";
                    worksheet.Cells[1, 2] = "Edad";
                    worksheet.Cells[1, 3] = "Ciudad";

                    // Escribir datos
                    for (int i = 0; i < personas.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1] = personas[i].Nombre;
                        worksheet.Cells[i + 2, 2] = personas[i].Edad;
                        worksheet.Cells[i + 2, 3] = personas[i].Ciudad;
                    }

                    // Guardar y cerrar el archivo
                    workbook.SaveAs(filePath);
                    workbook.Close();
                    excelApp.Quit();

                    MessageBox.Show("Los datos se han exportado a Excel exitosamente.");
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar. Por favor, primero realiza la deserialización.");
            }
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            if (personas != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                    document.Open();

                    // Crear la tabla
                    PdfPTable table = new PdfPTable(3);

                    // Escribir encabezados
                    table.AddCell("Nombre");
                    table.AddCell("Edad");
                    table.AddCell("Ciudad");

                    // Escribir datos
                    foreach (Persona persona in personas)
                    {
                        table.AddCell(persona.Nombre);
                        table.AddCell(persona.Edad.ToString());
                        table.AddCell(persona.Ciudad);
                    }

                    // Agregar tabla al documento
                    document.Add(table);

                    document.Close();
                    writer.Close();

                    MessageBox.Show("Los datos se han exportado a PDF exitosamente.");
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar. Por favor, primero realiza la deserialización.");
            }

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Archivos JSON (*.json)|*.json";
            //openFileDialog.Title = "Abrir archivo JSON";

            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string archivo = openFileDialog.FileName;
            //    string contenido = File.ReadAllText(archivo);

            //    try
            //    {
            //        jsonData = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(contenido);
            //        listViewJson.Items.Clear();
            //        foreach (var item in jsonData)
            //        {
            //            ListViewItem listItem = new ListViewItem(item.Values.ToArray());
            //            listViewJson.Items.Add(listItem);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error al cargar el archivo JSON: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Ciudad { get; set; }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (datosJson != null)
            {
                if (radioButtonExcel.Checked)
                {
                    formatoExportacion = ExportFormat.Excel;
                    ExportarAExcel();
                }
                else if (radioButtonWord.Checked)
                {
                    formatoExportacion = ExportFormat.Word;
                    ExportarAWord();
                }
                else if (radioButtonPDF.Checked)
                {
                    formatoExportacion = ExportFormat.PDF;
                    ExportarAPDF();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un formato de exportación.");
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar. Por favor, primero abra un archivo JSON.");
            }
        }

        private void ExportarAExcel()
        {
            if (!string.IsNullOrEmpty(jsonContent))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Add();
                    Excel.Worksheet worksheet = workbook.ActiveSheet;

                    // Escribir el contenido del JSON en la celda A1
                    worksheet.Cells[1, 1] = jsonContent;

                    // Guardar y cerrar el archivo
                    workbook.SaveAs(filePath);
                    workbook.Close();
                    excelApp.Quit();

                    MessageBox.Show("Los datos se han exportado a Excel exitosamente.");
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar. Por favor, primero abre un archivo JSON.");
            }
        }

        private void ExportarAWord()
        {
            if (!string.IsNullOrEmpty(jsonContent))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Word Document (*.docx)|*.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                    Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Add();

                    // Agregar el contenido del JSON al documento Word
                    wordDoc.Content.Text = jsonContent;

                    // Guardar y cerrar el archivo
                    wordDoc.SaveAs2(filePath);
                    wordDoc.Close();
                    wordApp.Quit();

                    MessageBox.Show("Los datos se han exportado a Word exitosamente.");
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar. Por favor, primero abre un archivo JSON.");
            }
        }

        private void ExportarAPDF()
        {
            if (!string.IsNullOrEmpty(jsonContent))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                    document.Open();

                    // Agregar el contenido del JSON al documento PDF
                    document.Add(new Paragraph(jsonContent));

                    document.Close();
                    writer.Close();

                    MessageBox.Show("Los datos se han exportado a PDF exitosamente.");
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar. Por favor, primero abre un archivo JSON.");
            }
        }
    }

    public enum ExportFormat
    {
        Excel,
        Word,
        PDF
    }
}
