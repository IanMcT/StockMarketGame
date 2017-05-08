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
            //adds a row
            dgvStockList.Rows.Add();
            dgvStockList.Rows[dgvStockList.RowCount - 1].Cells[0].Value = "Google";
            dgvStockList.Rows[dgvStockList.RowCount - 1].Cells[1].Value = 99.98;
            dgvStockList.Rows[dgvStockList.RowCount - 1].Cells[2].Value = bmpUp;
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
