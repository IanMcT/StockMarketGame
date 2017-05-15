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
    public partial class BuySellScreen : Form
    {
        public Stock stockToShow;
        public Boolean buyingStocks = true;

        public BuySellScreen()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="s">Stock to buy or sell</param>
        /// <param name="bs">true if buying, false if selling</param>
        public BuySellScreen(Stock s, Boolean bs) 
        {
            stockToShow = s;
            buyingStocks = bs;
            InitializeComponent();
        }

        /// <summary>
        /// What happens when the player clicks the "Buy" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuy_Click(object sender, EventArgs e)
        {
            //get number of stocks to buy from box
            int quantity = (int)(numBuyQuantity.Value);
            
            //if the player already owns the stock, add to it's number. if not, add a new stock
            if (!Program.user.OwnedStocks.ContainsKey(stockToShow.StockName))
            {
                Program.user.OwnedStocks.Add(stockToShow.StockName, quantity);
            }
            else
            {
                Program.user.OwnedStocks[stockToShow.StockName] += quantity;
            }
            
            //update player balance
            Program.user.Balance -= stockToShow.StockHistory[stockToShow.StockHistory.Count - 1] * quantity;
            //refresh list of owned stocks on stockMarketScreen and close window
            Program.smScreen.LoadPlayerStocks();
            this.Close();
        }

        /// <summary>
        /// What happens when the player clicks the "Sell" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSell_Click(object sender, EventArgs e)
        {
            //get number of stocks to sell from box
            int quantity = (int)(numSellQuantity.Value);

            //subtract number of stocks from player's list
            Program.user.OwnedStocks[stockToShow.StockName] -= quantity;
            //update player's balance
            Program.user.Balance += stockToShow.StockHistory[stockToShow.StockHistory.Count - 1] * quantity;
            //if the player owns 0 of the stock they just sold, remove it from their list
            if (Program.user.OwnedStocks[stockToShow.StockName] <= 0)
            {
                Program.user.OwnedStocks.Remove(stockToShow.StockName);
            }
            //refresh list of ownedstocks on stockMarketScreen and close window
            Program.smScreen.LoadPlayerStocks();
            this.Close();
        }

        /// <summary>
        /// Set up the screen's visuals depending on whether or not we're buying or selling stocks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuySellScreen_Load(object sender, EventArgs e)
        {
            //load different fields based on buyingStocks
            if (buyingStocks)
            {
                //only execute if User has enough money to buy one
                if (Program.user.Balance >= stockToShow.StockHistory[stockToShow.StockHistory.Count - 1])
                {
                    //disable sell tab
                    tabBuySell.TabPages.Remove(tabPageSell);
                    //setup
                    numBuyQuantity.Maximum = (int)(Program.user.Balance / stockToShow.StockHistory[stockToShow.StockHistory.Count - 1]);
                    numBuyQuantity.Minimum = 1;
                    label11.Text = stockToShow.StockName;
                    label9.Text = stockToShow.StockDescription;
                    label7.Text = String.Format("${0:0.00}", stockToShow.StockHistory[stockToShow.StockHistory.Count - 1]);
                }
                else
                {
                    MessageBox.Show("You can't buy any " + stockToShow.StockName + " stocks because you don't have enough money!");
                    this.Close();
                }
            }
            else
            {
                //only execute if User owns the stock they're trying to sell
                if(Program.user.OwnsStock(stockToShow.StockName))
                {
                    //disable buy tab
                    tabBuySell.TabPages.Remove(tabPageBuy);
                    //setup
                    numSellQuantity.Maximum = Program.user.OwnedStocks[stockToShow.StockName];
                    numSellQuantity.Minimum = 1;
                    lblStockName.Text = stockToShow.StockName;
                    lblStockDescription.Text = stockToShow.StockDescription;
                    lblStockValue.Text = String.Format("${0:0.00}", stockToShow.StockHistory[stockToShow.StockHistory.Count - 1]);
                    lblOwnedStock.Text = "" + Program.user.OwnedStocks[stockToShow.StockName];
                }else{
                    MessageBox.Show("You cannot sell any " + stockToShow.StockName + " stocks because you don't own any!");
                    this.Close();
                }
            }
        }

        private void tabPageBuy_Click(object sender, EventArgs e)
        {

        }

        private void numBuyQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblStockName_Click(object sender, EventArgs e)
        {

        }

        private void lblOwnedStock_Click(object sender, EventArgs e)
        {

        }
    }
}
