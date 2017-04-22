namespace SMG
{
    partial class endGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoneyMade = new System.Windows.Forms.Label();
            this.lblDaysPlayed = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MoneyMade
            // 
            this.MoneyMade.AutoSize = true;
            this.MoneyMade.ForeColor = System.Drawing.Color.White;
            this.MoneyMade.Location = new System.Drawing.Point(164, 115);
            this.MoneyMade.Name = "MoneyMade";
            this.MoneyMade.Size = new System.Drawing.Size(44, 13);
            this.MoneyMade.TabIndex = 15;
            this.MoneyMade.Text = "Number";
            // 
            // lblDaysPlayed
            // 
            this.lblDaysPlayed.AutoSize = true;
            this.lblDaysPlayed.ForeColor = System.Drawing.Color.White;
            this.lblDaysPlayed.Location = new System.Drawing.Point(164, 85);
            this.lblDaysPlayed.Name = "lblDaysPlayed";
            this.lblDaysPlayed.Size = new System.Drawing.Size(42, 13);
            this.lblDaysPlayed.TabIndex = 14;
            this.lblDaysPlayed.Text = "number";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.ForeColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(79, 115);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(86, 13);
            this.lblMoney.TabIndex = 13;
            this.lblMoney.Text = "MONEY MADE: ";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.ForeColor = System.Drawing.Color.White;
            this.lblDays.Location = new System.Drawing.Point(78, 85);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(87, 13);
            this.lblDays.TabIndex = 12;
            this.lblDays.Text = "DAYS PLAYED: ";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.ForeColor = System.Drawing.Color.White;
            this.lblGameOver.Location = new System.Drawing.Point(103, 58);
            this.lblGameOver.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(87, 13);
            this.lblGameOver.TabIndex = 11;
            this.lblGameOver.Text = "♥GAME OVER♥";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(164, 182);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(46, 182);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // endGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.MoneyMade);
            this.Controls.Add(this.lblDaysPlayed);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRestart);
            this.Name = "endGame";
            this.Text = "endGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MoneyMade;
        private System.Windows.Forms.Label lblDaysPlayed;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnRestart;
    }
}