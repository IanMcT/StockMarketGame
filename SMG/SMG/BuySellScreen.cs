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

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }

        private void btnSell_Click(object sender, EventArgs e)
        {

        }

        private void BuySellScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
