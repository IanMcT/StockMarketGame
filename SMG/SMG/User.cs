using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SMG
{
    class User
    {
        //variables specific to one user
        public string UserName;
        public double Balance;
        public int CurrentDay;
        public int TotalDays;
        public string StockFilePath;
        //public List<Stock> OwnedStocks;

        private User(string UserName, double Balance, int CurrentDay, int TotalDays, string StockFilePath)
        {
            this.UserName = UserName;
            this.Balance = Balance;
            this.CurrentDay = CurrentDay;
            this.TotalDays = TotalDays;
            this.StockFilePath = StockFilePath;
            //this.OwnedStocks = new List<Stock>();
        }

        /// <summary>
        /// Creates a new instance of User from scratch.
        /// </summary>
        /// <param name="UserName">The username of the user.</param>
        /// <param name="TotalDays">The total days of the user.</param>
        /// <returns>The instance of User</returns>
        public static User CreateNewUser(string UserName, int TotalDays)
        {
            return new User(UserName, 0.0, 0, TotalDays, "");
        }

        /// <summary>
        /// Creates a new instance of User from a user info file.
        /// </summary>
        /// <returns>The instance of User</returns>
        public static User LoadUserFromFile()
        {
            User result = new User("", 0.0, 0, 0, "");
            OpenFileDialog fileDialog = new OpenFileDialog();
            StreamReader file = null;

            int counter = 0;
            string line = "";

            int ownedStockNumber = 0;
            string[] ownedStockNames = new string[0];
            int[] ownedStockAmounts = new int[0];

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                file = new StreamReader(fileDialog.FileName);
            }
			//reads throught the file
            while ((line = file.ReadLine()) != null)
            {
				//first 5 lines are user information
                if (counter <= 5)
                {
                    switch (counter)
                    {
                        case 0:
                            result.UserName = line;
                            break;
                        case 1:
                            result.Balance = double.Parse(line);
                            break;
                        case 2:
                            result.CurrentDay = int.Parse(line);
                            break;
                        case 3:
                            result.TotalDays = int.Parse(line);
                            break;
                        case 4:
                            result.StockFilePath = line;
                            break;
                        case 5:
                            ownedStockNumber = int.Parse(line);
                            ownedStockNames = new string[ownedStockNumber];
                            ownedStockAmounts = new int[ownedStockNumber];
                            break;
                        default:
                            break;
                    }
                }
				
				//after 5 lines user stock information
                if (counter > 5 && counter < 5 + ownedStockNumber + 1)
                {
                    ownedStockNames[counter - 6] = line;
                }
                if (counter > 5 + ownedStockNumber && counter < 5 + (ownedStockNumber * 2) + 1)
                {
                    ownedStockAmounts[counter - 6 - ownedStockNumber] = int.Parse(line);
                }

                counter++;
            }

            //List<Stock> stocks = new List<Stock>();
            for (int i = 0; i < ownedStockNumber; i++)
            {
                //stocks.Add(new stock based on ownedStockNames[i] and ownedStockAmounts[i]);
            }
            //result.OwnedStocks = stocks;

            file.Close();
            return result;
        }
    }
}
