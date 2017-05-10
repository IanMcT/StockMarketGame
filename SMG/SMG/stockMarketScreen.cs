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
            stocks.Add(new Stock("Guugle","Search swamps", new List<double>(),10.0,90.0));
            stocks.Add(new Stock("Pear","fruity computers", new List<double>(), 12.0,95.0));
            stocks.Add(new Stock("Skybucks","java time!", new List<double>(), 50,50));
            //adds rows
            int currentRow = 0;
            foreach (Stock s in stocks)
            {
                Console.WriteLine(s.ToString());
                dgvStockList.Rows.Add();
                dgvStockList.Rows[currentRow].Cells[0].Value = s.StockName;
                dgvStockList.Rows[currentRow].Cells[1].Value = s.StockReturn;
                if (s.isStockUp())
                {
                    dgvStockList.Rows[currentRow].Cells[2].Value = bmpUp;
                }
                else 
                {
                    dgvStockList.Rows[currentRow].Cells[2].Value = bmpDown;
                }
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

        /// <summary>
        /// Handle cell clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStockList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Don't change
            dgvStockList_CellContentClick(sender, e);
        }

        /// <summary>
        /// Runs when you double click the stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStockList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //is a row double-clicked?
            if (e.RowIndex >= 0 && e.RowIndex < dgvStockList.RowCount)
            {
                MessageBox.Show("You double clicked " +
                    dgvStockList.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        /// <summary>
        /// Owned stocks click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvOwnedStocks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// End turn button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEndTurn_Click(object sender, EventArgs e)
        {

        }
    }
}

