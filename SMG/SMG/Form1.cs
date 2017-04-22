using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**********************************
 * Stock Market Game
 * ICS3C/4C
 * McTavish class
 * *******************************/

namespace SMG
{
    /// <summary>
    /// Form1 - opens when program starts
    /// Allows you to pick options and start game
    /// </summary>
    public partial class Form1 : Form
    {
        /****************************
         * Global Variables
         * *************************/

        public Form1()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Form1_Load - runs when form loads
        /// Sets default variables,
        /// reads data from text files to set options.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
