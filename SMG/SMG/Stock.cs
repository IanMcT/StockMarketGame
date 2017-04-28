using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMG
{
    class Stock
    { 
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
        public decimal StockHistory;  
        /// <summary>
        /// scale of one to ten determining if its going to be low risk or high risk
        /// </summary>
        public decimal StockRisk;
        /// <summary>
        /// what percent payout the stock is going to have
        /// </summary>
        public decimal StockReturn;

    }
}
