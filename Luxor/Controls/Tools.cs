using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luxor.Controls
{
    class Tools
    {
        public void ExportToExcel(DataGridView dgv)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Clientes";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;
                int columnasVisibles = 0;
                //Loop through each row and read value from each column. 
                for (int i = -1; i < dgv.Rows.Count; i++)
                {

                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Columns[j].Visible == true)
                        {
                            columnasVisibles++;
                            if (cellRowIndex == 1)
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv.Columns[j].HeaderText;

                            }
                            else
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv.Rows[i].Cells[j].Value;
                            }

                            cellColumnIndex++;
                        }

                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                int column = dgv.Columns.Count;
                Microsoft.Office.Interop.Excel.Range rng = (Microsoft.Office.Interop.Excel.Range)worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, column]].Cells;
                rng.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.WhiteSmoke);
                rng.Cells.Font.Bold = true;
                rng.EntireColumn.AutoFit();

                worksheet.Rows.Font.Name = "Tahoma";
                worksheet.Rows.Font.Size = 10;

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("El archivo se exporto correctamente");
                }
            }
            catch
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
        public DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
