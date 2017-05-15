using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMG
{
    static class Program
    {
        public static User user;
        public static double difficulty = 1000.00;
        public static List<Stock> stocks = new List<Stock>();

        public static Form1 mainScreen;
        public static startScreen startScreen;
        public static stockMarketScreen smScreen;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainScreen = new Form1();
            mainScreen.Show();
            Application.Run();
        }
    }
}
