using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMG
{
    class User
    {
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

        public static User CreateNewUser(string UserName, int TotalDays)
        {
            return new User(UserName, 0.0, 0, TotalDays, "");
        }

        public static User LoadUserFromFile()
        {
            User result = new User("", 0.0, 0, 0, "");
            OpenFileDialog fileDialog = new OpenFileDialog();
            System.IO.StreamReader file = null;

            int counter = 0;
            string line = "";

            int ownedStockNumber = 0;
            string[] ownedStockNames = new string[0];
            int[] ownedStockAmounts = new int[0];

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = new System.IO.StreamReader(fileDialog.FileName);
            }

            while ((line = file.ReadLine()) != null)
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
                //stocks.Add(new stock using data about name and number);
            }
            //result.OwnedStocks = stocks;

            file.Close();
            return result;
        }
    }
}