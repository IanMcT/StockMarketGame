namespace SMG
{
    partial class Form1
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_options = new System.Windows.Forms.Button();
            this.btn_audio = new System.Windows.Forms.Button();
            this.btn_music = new System.Windows.Forms.Button();
            this.btn_musicStyle = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.ForeColor = System.Drawing.Color.Black;
            this.btnNewGame.Location = new System.Drawing.Point(13, 25);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "Start";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btn_load
            // 
            this.btn_load.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_load.Location = new System.Drawing.Point(12, 54);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load Game";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_options
            // 
            this.btn_options.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_options.Location = new System.Drawing.Point(13, 83);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(75, 23);
            this.btn_options.TabIndex = 2;
            this.btn_options.Text = "Options";
            this.btn_options.UseVisualStyleBackColor = true;
            this.btn_options.Click += new System.EventHandler(this.btn_options_Click);
            // 
            // btn_audio
            // 
            this.btn_audio.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_audio.Location = new System.Drawing.Point(53, 112);
            this.btn_audio.Name = "btn_audio";
            this.btn_audio.Size = new System.Drawing.Size(75, 23);
            this.btn_audio.TabIndex = 3;
            this.btn_audio.Text = "Audio";
            this.btn_audio.UseVisualStyleBackColor = true;
            this.btn_audio.Click += new System.EventHandler(this.btn_audio_Click);
            // 
            // btn_music
            // 
            this.btn_music.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_music.Location = new System.Drawing.Point(95, 141);
            this.btn_music.Name = "btn_music";
            this.btn_music.Size = new System.Drawing.Size(75, 23);
            this.btn_music.TabIndex = 4;
            this.btn_music.Text = "Music On/Off";
            this.btn_music.UseVisualStyleBackColor = true;
            this.btn_music.Click += new System.EventHandler(this.btn_music_Click);
            // 
            // btn_musicStyle
            // 
            this.btn_musicStyle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_musicStyle.Location = new System.Drawing.Point(95, 170);
            this.btn_musicStyle.Name = "btn_musicStyle";
            this.btn_musicStyle.Size = new System.Drawing.Size(75, 23);
            this.btn_musicStyle.TabIndex = 5;
            this.btn_musicStyle.Text = "Music Style";
            this.btn_musicStyle.UseVisualStyleBackColor = true;
            this.btn_musicStyle.Click += new System.EventHandler(this.btn_musicStyle_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button7.Location = new System.Drawing.Point(53, 199);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Language";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button8.Location = new System.Drawing.Point(95, 228);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "English";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button9.Location = new System.Drawing.Point(95, 257);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "Japanese";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button10.Location = new System.Drawing.Point(13, 309);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 9;
            this.button10.Text = "Leaderboards";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btn_Quit
            // 
            this.btn_Quit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Quit.Location = new System.Drawing.Point(246, 309);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(75, 23);
            this.btn_Quit.TabIndex = 10;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(256, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(327, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn_musicStyle);
            this.Controls.Add(this.btn_music);
            this.Controls.Add(this.btn_audio);
            this.Controls.Add(this.btn_options);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btnNewGame);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_options;
        private System.Windows.Forms.Button btn_audio;
        private System.Windows.Forms.Button btn_music;
        private System.Windows.Forms.Button btn_musicStyle;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Label label1;
    }
}

