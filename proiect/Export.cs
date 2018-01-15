using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }

        private void btPDF_Click(object sender, EventArgs e)
        {

        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            using (var context = new LinkedinEntities5())
            {
                var queryResult = (from c in context.Client
                                   select new
                                   {
                                       Username = c.Username,
                                       LastName = c.Nume,
                                       FirstName = c.Prenume,
                                       Email = c.Email,
                                       skill = c.Aptitudini
                                   }).Distinct().ToList();

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                xlApp.Visible = true;

                if (xlApp == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }


                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;

                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Cells[1, 1] = "Friends report for user " + context.Client.ToString();
                xlWorkSheet.Cells[2, 1] = "Username";
                xlWorkSheet.Cells[2, 2] = "LastName";
                xlWorkSheet.Cells[2, 3] = "FirstName";
                xlWorkSheet.Cells[2, 4] = "E-mail";
                xlWorkSheet.Cells[2, 5] = "Skills";


                for (int i = 0; i < queryResult.Count; i++)
                {
                    xlWorkSheet.Cells[i + 3, 1] = queryResult[i].Username;
                    xlWorkSheet.Cells[i + 3, 2] = queryResult[i].LastName;
                    xlWorkSheet.Cells[i + 3, 3] = queryResult[i].FirstName;
                    xlWorkSheet.Cells[i + 3, 4] = queryResult[i].Email;
                    xlWorkSheet.Cells[i + 3, 5] = queryResult[i].skill;
                }


                xlWorkBook.SaveAs("D:\\csharp-Excel.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);

                MessageBox.Show("Excel file created , you can find the file D:\\csharp-Excel.xls");
            }
        }

        private void btCSV_Click(object sender, EventArgs e)
        {
            var csv = new StringBuilder();
            using (var context = new LinkedinEntities5())
            {

                var query = from c in context.Client
                            select new
                            {
                                c.Username,
                                c.Nume,
                                c.Prenume,
                                c.Email,
                                c.Aptitudini
                            };


                foreach (var row in query)
                {
                    var newline = string.Format("{0},{1},{2},{3},{4}", row.Username.ToString().Trim(),
                        row.Nume.ToString().Trim(),
                        row.Prenume.ToString().Trim(),
                        row.Email.ToString().Trim(),
                        row.Aptitudini.ToString().Trim());
                    csv.AppendLine(newline);
                }
                File.WriteAllText("D:\\csharp-Csv.cvs", csv.ToString());
            }
        }
    }
}
