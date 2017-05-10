using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SMG
{
    public class Stock
    {
        static Random r = new Random();
        /// <summary>
        /// Name of the Stock
        /// </summary>
        public string StockName;
        /// <summary>
        /// Description of the Stock
        /// </summary>
        public string StockDescription;
        /// <summary>
        /// The last four or so points for the Stock
        /// </summary>
        public List<double> StockHistory;
        /// <summary>
        /// scale of one to ten determining if its going to be low risk or high risk
        /// </summary>
        public double StockRisk;
        /// <summary>
        /// what percent payout the stock is going to have
        /// </summary>
        public double StockReturn;

        public bool isStockUp() 
        {
            if (StockHistory.Count >1 && this.StockHistory[StockHistory.Count - 1] > this.StockHistory[StockHistory.Count - 2]) 
            {
                return true;
            }else{
                return false;
            }
        }

        public override string ToString()
        {
            string temp = this.StockName + " - " +
                this.StockDescription;
            foreach (double d in this.StockHistory) 
            {
                temp += ", " + d.ToString("$0.00");
            }
            temp += " Return: " + this.StockReturn +
                " Risk: " + this.StockRisk;
            return temp;
        }

        /// <summary>
        /// Creates the stock
        /// </summary>
        /// <param name="sn">name</param>
        /// <param name="sd">description</param>
        /// <param name="sh">History</param>
        /// <param name="sri">Risk</param>
        /// <param name="sre">Return</param>
        public Stock(string sn, string sd, List<double> sh, double sri, double sre)
        {
            this.StockName = sn;
            this.StockDescription = sd;
            this.StockHistory = sh;
            this.StockRisk = sri;
            this.StockReturn = sre;

            if (StockHistory.Count < 1) 
            {
                for (int i = 0; i < 10; i++) 
                {
                    StockHistory.Add(r.NextDouble() * 1000);
                }
            }
        }
    }
}
