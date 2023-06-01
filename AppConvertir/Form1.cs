using System;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Document = iTextSharp.text.Document;
using PdfWriter = iTextSharp.text.pdf.PdfWriter;

namespace AppConvertir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook|*.xlsx";

         

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                string[] lines = contentTextBox.Text.Split('\n');
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] cells = lines[i].Split('|');
                    for (int j = 0; j < cells.Length; j++)
                    {
                        worksheet.Cells[i + 1, j + 1] = cells[j];
                    }
                }

                bool isTable = IsContentTable(contentTextBox.Text);
                if (isTable)
                {
                    int numRows = lines.Length;
                    int numCols = lines[0].Split('|').Length;
                    Excel.Range range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[numRows, numCols]];
                    range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                }

                workbook.SaveAs(filePath);
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show("Text exported to Excel workbook successfully!");
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);
                    document.Open();

                    // Convertir contenido de texto a tabla
                    string[] lines = contentTextBox.Text.Split('\n');
                    PdfPTable table = new PdfPTable(lines[0].Split('|').Length);

                    foreach (string line in lines)
                    {
                        string[] cells = line.Trim().Split('|');

                        foreach (string cell in cells)
                        {
                            PdfPCell cellElement = new PdfPCell(new Phrase(cell));
                            table.AddCell(cellElement);
                        }
                    }
                    bool isTable = IsContentTable(contentTextBox.Text);
                    if (isTable)
                    {
                        table.CompleteRow(); // Completar la última fila antes de agregar la tabla al documento
                        table.HeaderRows = 1; // Marcar la primera fila como encabezado
                    }

                    document.Add(table);
                    document.Close();
                }

                MessageBox.Show("Text exported to PDF successfully!");
            }
        }
        private void btnWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Document|*.docx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Add();
                Microsoft.Office.Interop.Word.Table table = wordDoc.Tables.Add(wordDoc.Range(), contentTextBox.Lines.Length, contentTextBox.Lines[0].Split('|').Length);

                for (int i = 0; i < contentTextBox.Lines.Length; i++)
                {
                    string[] cells = contentTextBox.Lines[i].Split('|');
                    for (int j = 0; j < cells.Length; j++)
                    {
                        table.Cell(i + 1, j + 1).Range.Text = cells[j];
                    }
                }

                table.Borders.Enable = 1; // Agregar bordes a la tabla

                bool isTable = IsContentTable(contentTextBox.Text);
                if (isTable)
                {
                    table.Borders.Enable = 1; // Agregar bordes a la tabla
                }

                wordDoc.SaveAs2(filePath);
                wordDoc.Close();
                wordApp.Quit();

                MessageBox.Show("Text exported to Word document successfully!");
            }
        }
        private void btnGraficar_Click(object sender, EventArgs e)
        {

            frmGraficar abrir = new frmGraficar();
            abrir.Show();
        }

        private void btnAbrir_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            ////openFileDialog.Filter = "Text Files|.txt|JSON Files|.json|XML Files|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileContent = File.ReadAllText(filePath);
                contentTextBox.Text = fileContent;
                previewWebBrowser.DocumentText = fileContent; // Mostrar vista previa en WebBrowser
            }
        }
        private bool IsContentTable(string content)
        {
            string[] lines = content.Split('\n');
            if (lines.Length < 2)
            {
                return false;
            }

            int numCols = lines[0].Split('|').Length;
            for (int i = 1; i < lines.Length; i++)
            {
                string[] cells = lines[i].Split('|');
                if (cells.Length != numCols)
                {
                    return false;
                }
            }

            return true;


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
        }

        private void bnSerApi_Click(object sender, EventArgs e)
        {

        }
    }
}