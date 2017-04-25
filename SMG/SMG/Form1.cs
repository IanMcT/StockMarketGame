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
            btn_audio.Visible = false;
            btn_music.Visible = false;
            btn_musicStyle.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
        }

        /// <summary>
        /// btn_options_Click - runs when options button is clicked
        /// </summary>
        /// <author>Oliver</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_options_Click(object sender, EventArgs e)
        {
            btn_music.Visible = false;
            btn_musicStyle.Visible = false;
            button8.Visible = false;
            button9.Visible = false;

            if (btn_audio.Visible)
            {
                btn_audio.Visible = false;
                button7.Visible = false;
            }
            else
            {
                btn_audio.Visible = true;
                button7.Visible = true;
                button7.Location = new Point(53, 140);
            }   
        }

        /// <summary>
        /// btn_audio_Click - runs when audio button is clicked
        /// </summary>
        /// <author>Oliver</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_audio_Click(object sender, EventArgs e)
        {

            if (btn_music.Visible)
            {
                btn_music.Visible = false;
                btn_musicStyle.Visible = false;
                button7.Location = new Point(53, 140);
                if (button8.Visible)
                {
                    button8.Location = new Point(103, 170);
                    button9.Location = new Point(103, 200);
                }
            }
            else
            {
                btn_music.Visible = true;
                btn_music.Location = new Point(103, 140);
                btn_musicStyle.Visible = true;
                btn_musicStyle.Location = new Point(103, 170);

                button7.Location = new Point(53, 200);
                if (button8.Visible)
                {
                    button8.Location = new Point(103, 230);
                    button9.Location = new Point(103, 260);
                }
            }
        }

        private void btn_music_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Music was selected");
        }

        private void btn_musicStyle_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Music style was selected");
        }

        /// <summary>
        /// button7_Click - runs when language button is clicked
        /// </summary>
        /// <author>Oliver</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            if (button8.Visible)
            {
                button8.Visible = false;
                button9.Visible = false;
            }
            else
            {
                if (btn_music.Visible)
                {
                    button7.Location = new Point(53, 200);
                    button8.Visible = true;
                    button8.Location = new Point(103, 230);
                    button9.Visible = true;
                    button9.Location = new Point(103, 260);
                }
                else
                {
                    button7.Location = new Point(53, 140);
                    button8.Visible = true;
                    button8.Location = new Point(103, 170);
                    button9.Visible = true;
                    button9.Location = new Point(103, 200);
                }
                
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Console.WriteLine("English was selected");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Japanese was selected");
        }
    }
}
