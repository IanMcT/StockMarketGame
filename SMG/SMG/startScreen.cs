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
    public partial class startScreen : Form
    {
        int numberOfDays = 0;
        double difficulty = 0;

        public startScreen()
        {
            InitializeComponent();
        }

        private void Start_Game_Click(object sender, EventArgs e)
        {
            Program.user = User.CreateNewUser("blank username", numberOfDays);
            //MessageBox.Show(Program.user.Balance.ToString() + "\n" + Program.user.ToString());

        }

        private void Length_Seven_Click(object sender, EventArgs e)
        {
            numberOfDays = 7;
        }

        private void Length_Fourteen_Click(object sender, EventArgs e)
        {
            numberOfDays = 14;
        }

        private void Length_Twentyone_Click(object sender, EventArgs e)
        {
            numberOfDays = 21;
        }

        private void Length_Endless_Click(object sender, EventArgs e)
        {
            numberOfDays = -1;
        }

        private void Difficulty_Easy_Click(object sender, EventArgs e)
        {
            difficulty = 1000.00;
        }

        private void Difficulty_Medium_Click(object sender, EventArgs e)
        {
            difficulty = 750.00;
        }

        private void Difficulty_Hard_Click(object sender, EventArgs e)
        {
            difficulty = 500.00;
        }

        private void Difficulty_VeryHard_Click(object sender, EventArgs e)
        {
            difficulty = 250.00;
        }

        private void Cancel_Game_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Cancel_Game = new Form1();
            Cancel_Game.Show();
        }

        private void startScreen_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

    }
}
