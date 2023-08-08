using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dealing_With_DataGridView
{
    public class DataGridViewPrintDocument
    {
        private DataGridView dataGridView;
        private int rowIndex;
        private float currentY;

        public DataGridViewPrintDocument(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
            this.rowIndex = 0;
            this.currentY = 0;
        }

        public void DrawDataGridView(Graphics g)
        {
            float leftMargin = 50; // Set the left margin of the printed page
            float topMargin = 50; // Set the top margin of the printed page

            // Loop through the rows of the DataGridView and print each row
            while (rowIndex < dataGridView.Rows.Count)
            {
                DataGridViewRow row = dataGridView.Rows[rowIndex];

                // Calculate the total height of the row
                float totalHeight = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    totalHeight = Math.Max(totalHeight, cell.Size.Height);
                }

                // Set the current position to start printing the row
                currentY = topMargin + rowIndex * totalHeight;

                // Loop through the cells of the row and print each cell
                for (int columnIndex = 0; columnIndex < row.Cells.Count; columnIndex++)
                {
                    DataGridViewCell cell = row.Cells[columnIndex];
                    float cellWidth = dataGridView.Columns[columnIndex].Width;

                    // Draw the cell content on the printed page
                    g.DrawString(cell.FormattedValue.ToString(), dataGridView.Font, Brushes.Black, leftMargin, currentY);

                    // Move to the next cell position
                    leftMargin += cellWidth;
                }

                // Move to the next row position
                rowIndex++;
                leftMargin = 50;
            }
        }
    }
}
