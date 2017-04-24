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
/// Brandon McCutcheon
/// hides unused buttons for clarity
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_audio.Visible = false;
            btn_music.Visible = false;
            btn_musicStyle.Visible = false;
            btn_language.Visible = false;
            btn_english.Visible = false;
            btn_japanese.Visible = false;
        }

        /// <summary>
        /// Brandon McCutcheon
        /// closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
