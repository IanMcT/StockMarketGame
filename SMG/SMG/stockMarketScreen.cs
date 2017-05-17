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
        Bitmap bmpUp = new Bitmap("up.bmp");
        Bitmap bmpDown = new Bitmap("down.bmp");
        Graph graph;
        Stock selectedStock;

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
            Stock guugle = new Stock("Guugle", "Search swamps", new List<double>(), 10.0, 90.0);
            Stock pear = new Stock("Pear", "fruity computers", new List<double>(), 12.0, 95.0);
            Stock skybucks = new Stock("Skybucks", "java time!", new List<double>(), 50, 50);
            Program.stocks.Add(guugle);
            Program.stocks.Add(pear);
            Program.stocks.Add(skybucks);
            //adds rows
            int currentRow = 0;
            foreach (Stock s in Program.stocks)
            {
                Console.WriteLine(s.ToString());
                dgvStockList.Rows.Add();
                dgvStockList.Rows[currentRow].Cells[0].Value = s.StockName;
                dgvStockList.Rows[currentRow].Cells[1].Value = String.Format("${0:0.00}", s.StockHistory[s.StockHistory.Count - 1]);
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
            LoadPlayerStocks();
            graph = new Graph();
            selectedStock = Program.stocks[0];
            tbDays.Text = Program.user.CurrentDay.ToString();
        }

        /// <summary>
        /// Refreshes the grid of player's owned stocks
        /// </summary>
        public void LoadPlayerStocks()
        {
            //remove all of the current rows in the grid
            dgvOwnedStocks.Rows.Clear();
            /*foreach (DataGridViewRow row in dgvOwnedStocks.Rows)
            {
                try
                {
                    dgvOwnedStocks.Rows.Remove(row);
                }
                catch (InvalidOperationException)
                {
                    //pretend nothing is wrong and move on with life
                    break;
                }
            }*/
            int currentRow = 0;
            //loop through each of the player's owned stocks
            foreach (string s in Program.user.OwnedStocks.Keys)
            {
                //find the stock to display in the global array of stocks
                Stock stockToDisplay = null;
                foreach (Stock stock in Program.stocks)
                {
                    if (stock.StockName.Equals(s))
                    {
                        stockToDisplay = stock;
                        break;
                    }
                }
                //add the stock to the grid
                dgvOwnedStocks.Rows.Add();
                dgvOwnedStocks.Rows[currentRow].Cells[0].Value = stockToDisplay.StockName;
                dgvOwnedStocks.Rows[currentRow].Cells[1].Value = String.Format("${0:0.00}", stockToDisplay.StockHistory[stockToDisplay.StockHistory.Count - 1]);
                if (stockToDisplay.isStockUp())
                {
                    dgvOwnedStocks.Rows[currentRow].Cells[2].Value = bmpUp;
                }
                else
                {
                    dgvOwnedStocks.Rows[currentRow].Cells[2].Value = bmpDown;
                }
                dgvOwnedStocks.Rows[currentRow].Cells[3].Value = Program.user.OwnedStocks[stockToDisplay.StockName];

                currentRow++;
            }

            tbBalance.Text = String.Format("${0:0.00}", Program.user.Balance);
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
               /* MessageBox.Show("You clicked " +
                    dgvStockList.Rows[e.RowIndex].Cells[0].Value);*/
                //draw the graph for the selected stock
                string selectedStockName = dgvStockList.Rows[e.RowIndex].Cells[0].Value.ToString();
                foreach(Stock s in Program.stocks){
                    if(selectedStockName.Equals(s.StockName)){
                        selectedStock = s;
                        break;
                    }
                }
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
               /* MessageBox.Show("You double clicked " +
                    dgvStockList.Rows[e.RowIndex].Cells[0].Value);*/
                Stock clickedStock = null;
                foreach (Stock s in Program.stocks)
                {
                    if (dgvStockList.Rows[e.RowIndex].Cells[0].Value.Equals(s.StockName))
                    {
                        clickedStock = s;
                        break;
                    }
                }
                BuySellScreen buySellScreen = new BuySellScreen(clickedStock, true);
                buySellScreen.Show();
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        /// <summary>
        /// When a user double-clicks on a cell in the "Owned Stocks" grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvOwnedStocks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvStockList.RowCount && dgvOwnedStocks.Rows[e.RowIndex].Cells[0].Value != null)
            {
                Stock clickedStock = null;
                foreach (Stock s in Program.stocks)
                {
                    if (dgvOwnedStocks.Rows[e.RowIndex].Cells[0].Value.Equals(s.StockName))
                    {
                        clickedStock = s;
                        break;
                    }
                }
                BuySellScreen buySellScreen = new BuySellScreen(clickedStock, false);
                buySellScreen.Show();
            }
        }

        private void dgvOwnedStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelGraph_Paint(object sender, PaintEventArgs e)
        {
            graph.Render(selectedStock.StockHistory, panelGraph.Width, panelGraph.Height, e);
        }
    }
}

