using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMG
{

    public partial class stockMarketScreen : Form
    {
        //Global Variables
        List<Stock> stocks = new List<Stock>();
        Bitmap bmpUp = new Bitmap("up.bmp");
        Bitmap bmpDown = new Bitmap("down.bmp");
        public stockMarketScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Runs when screen loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockMarketScreen_Load(object sender, EventArgs e)
        {
            //load stocks
            stocks.Add(new Stock("Guugle"));
            stocks.Add(new Stock("Pear"));
            stocks.Add(new Stock("Skybucks"));
            //adds rows
            int currentRow = 0;
            foreach (Stock s in stocks)
            {
                dgvStockList.Rows.Add();
                dgvStockList.Rows[currentRow].Cells[0].Value = s.StockName;
                dgvStockList.Rows[currentRow].Cells[1].Value = s.StockReturn;
                dgvStockList.Rows[currentRow].Cells[2].Value = bmpUp;
                currentRow++;
            }
        }

        /// <summary>
        /// Runs when stock list clicked.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStockList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //is a row clicked?
            if (e.RowIndex >= 0 && e.RowIndex < dgvStockList.RowCount)
            {
                MessageBox.Show("You clicked " +
                    dgvStockList.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}
