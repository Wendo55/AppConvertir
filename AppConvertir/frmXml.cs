using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AppConvertir
{
    public partial class frmXml : Form
    {
        private DataTable dataTable;

        public frmXml()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string xmlFilePath = openFileDialog.FileName;
                LoadXmlData(xmlFilePath);
            }
        }

        private void LoadXmlData(string filePath)
        {
            dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Clear();

            using (XmlReader reader = XmlReader.Create(filePath))
            {
                reader.Read();

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        string columnName = reader.Name;

                        if (!dataTable.Columns.Contains(columnName))
                        {
                            dataTable.Columns.Add(columnName);
                        }

                        reader.Read();

                        string columnValue = reader.Value;

                        DataRow row = dataTable.NewRow();
                        row[columnName] = columnValue;
                        dataTable.Rows.Add(row);
                    }
                }
            }

            dataGridView.DataSource = dataTable;
        }

        private void btnExportToWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Document (*.docx)|*.docx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToWord(filePath);
                MessageBox.Show("El archivo se ha exportado a Word exitosamente.", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportToWord(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, fileStream);
                document.Open();

                PdfPTable table = new PdfPTable(dataTable.Columns.Count);
                table.WidthPercentage = 100;

                foreach (DataColumn column in dataTable.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.ColumnName));
                    table.AddCell(headerCell);
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        PdfPCell dataCell = new PdfPCell(new Phrase(row[column].ToString()));
                        table.AddCell(dataCell);
                    }
                }

                document.Add(table);
                document.Close();
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToExcel(filePath);
                MessageBox.Show("El archivo se ha exportado a Excel exitosamente.", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportToExcel(string filePath)
        {
            using (SpreadsheetDocument document = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet()
                {
                    Id = workbookPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "Sheet1"
                };
                sheets.Append(sheet);

                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                Row headerRow = new Row();
                foreach (DataColumn column in dataTable.Columns)
                {
                    Cell cell = CreateTextCell(column.ColumnName);
                    headerRow.AppendChild(cell);
                }
                sheetData.AppendChild(headerRow);

                foreach (DataRow row in dataTable.Rows)
                {
                    Row dataRow = new Row();
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        Cell cell = CreateTextCell(row[column].ToString());
                        dataRow.AppendChild(cell);
                    }
                    sheetData.AppendChild(dataRow);
                }

                workbookPart.Workbook.Save();
                document.Close();
            }
        }

        private Cell CreateTextCell(string value)
        {
            Cell cell = new Cell();
            cell.DataType = CellValues.String;
            cell.CellValue = new CellValue(value);
            return cell;
        }

        private void btnExportToPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToPdf(filePath);
                MessageBox.Show("El archivo se ha exportado a PDF exitosamente.", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportToPdf(string filePath)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            document.Open();

            PdfPTable table = new PdfPTable(dataTable.Columns.Count);
            table.WidthPercentage = 100;

            foreach (DataColumn column in dataTable.Columns)
            {
                PdfPCell headerCell = new PdfPCell(new Phrase(column.ColumnName));
                table.AddCell(headerCell);
            }

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    PdfPCell dataCell = new PdfPCell(new Phrase(row[column].ToString()));
                    table.AddCell(dataCell);
                }
            }

            document.Add(table);
            document.Close();
        }
    }
}
