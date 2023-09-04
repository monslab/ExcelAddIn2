using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelAddIn2
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnImg_Click(object sender, RibbonControlEventArgs e)
        {

            // Convert first column of selected range from GitHub issue image tag format to HTML image tags with specified pixel width and copy to clipboard
            var selectedRange = Globals.ThisAddIn.Application.Selection as Microsoft.Office.Interop.Excel.Range;
            if (selectedRange != null && selectedRange.Cells.Count > 0)
            {
                int width = 100;
                var sb = new StringBuilder();
                for (int i = 1; i <= selectedRange.Rows.Count; i++)
                {
                    var cell = selectedRange.Cells[i, 1];
                    if (cell.Value != null && cell.Value is string && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        sb.AppendLine(string.Format("<img src=\"{0}\" width=\"{1}px\" />", cell.Value.Split('(', ')')[1], width));
                    }
                }
                if (sb.Length > 0)
                {
                    Clipboard.SetText(sb.ToString());
                }
            }
        }

        private void btnTable_Click(object sender, RibbonControlEventArgs e)
        {

            // Convert selected range from GitHub markdown table format to standard markdown table format with header row and copy to clipboard
            var selectedRange = Globals.ThisAddIn.Application.Selection as Microsoft.Office.Interop.Excel.Range;
            if (selectedRange != null && selectedRange.Cells.Count > 0)
            {
                var sb = new StringBuilder();

                // Add separator line after header row
                sb.AppendLine("|");
                for (int i = 1; i <= selectedRange.Columns.Count; i++)
                {
                    var cell = selectedRange.Cells[1, i];
                    if (cell.Value != null && cell.Value is string && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        sb.Append(string.Format("{0} |", cell.Value.Replace("\n", "<br>")));
                    }
                }

                // Add separator line after header row
                sb.AppendLine();
                sb.Append("|");
                for (int i = 1; i <= selectedRange.Columns.Count; i++)
                {
                    sb.Append(" --- |");
                }
                sb.AppendLine();

                // Add data rows
                for (int i = 2; i <= selectedRange.Rows.Count; i++)
                {
                    sb.Append("|");
                    for (int j = 1; j <= selectedRange.Columns.Count; j++)
                    {
                        var cell = selectedRange.Cells[i, j];
                        if (cell.Value != null && cell.Value is string && !string.IsNullOrEmpty(cell.Value.ToString()))
                        {
                            sb.Append(string.Format(" {0} |", cell.Value.Replace("\n", "<br>")));
                        }
                    }
                    sb.AppendLine();
                }
                if (sb.Length > 0)
                {
                    Clipboard.SetText(sb.ToString());
                }
            }
        }

        private void btnZoom_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }
}
