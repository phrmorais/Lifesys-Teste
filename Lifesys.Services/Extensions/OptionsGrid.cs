using System.ComponentModel;
using System.Windows.Forms;

namespace Lifesys.Services.Extensions
{
    public static class OptionsGrid
    {
        public static string Ordena(this DataGridView dataGrid, int columnIndex)
        {
            DataGridViewColumn newColumn = dataGrid.Columns[columnIndex];
            DataGridViewColumn oldColumn = dataGrid.SortedColumn;
            ListSortDirection direction;

            if (oldColumn != null)
            {
                if (oldColumn == newColumn &&
                    dataGrid.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }
            try
            {

                dataGrid.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                        SortOrder.Ascending : SortOrder.Descending;
            }
            catch
            {
            }

            return $"Pesquisa por {newColumn.HeaderText}:";
        }
        public static void Pesquisa(this DataGridView dataGrid, string textoPesquisa, CurrencyManager cm)
        {
            bool seleciona = true;
            DataGridViewColumn oldColumn = dataGrid.SortedColumn;
            cm.EndCurrentEdit();
            cm.ResumeBinding();
            cm.SuspendBinding();
            dataGrid.ClearSelection();
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[oldColumn.Index].Value == null) continue;
                if (row.Cells[oldColumn.Index].Value.ToString().ToLower().Contains(textoPesquisa.ToLower()))
                {
                    row.Visible = true;
                    row.Selected = seleciona;
                    seleciona = false;
                    continue;
                }
                row.Visible = false;
            }
        }
    }
}