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
        public static User difficulty;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var MainForm = new Form1();
            MainForm.Show();
            Application.Run();
        }
    }
}
