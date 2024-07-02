using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace StockController.Shared
{
    public class ExportExcel
    {
        public static void ExportDataGridViewToExcel(DataGridView dgv)
        {
            using (var sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Sheet1");

                            // Cabeçalho
                            for (int i = 0; i < dgv.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;
                            }

                            // Dados
                            for (int i = 0; i < dgv.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgv.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dgv.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            workbook.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show("Dados exportados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao exportar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
