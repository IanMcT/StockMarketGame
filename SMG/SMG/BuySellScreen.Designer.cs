namespace SMG
{
    partial class BuySellScreen
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
            this.tabBuySell = new System.Windows.Forms.TabControl();
            this.tabPageBuy = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.numBuyQuantity = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPageSell = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.numSellQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblProfit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBuyPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblOwnedStock = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStockValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStockDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStockName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBuySell.SuspendLayout();
            this.tabPageBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyQuantity)).BeginInit();
            this.tabPageSell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSellQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBuySell
            // 
            this.tabBuySell.Controls.Add(this.tabPageBuy);
            this.tabBuySell.Controls.Add(this.tabPageSell);
            this.tabBuySell.Location = new System.Drawing.Point(12, 12);
            this.tabBuySell.Name = "tabBuySell";
            this.tabBuySell.SelectedIndex = 0;
            this.tabBuySell.Size = new System.Drawing.Size(737, 389);
            this.tabBuySell.TabIndex = 0;
            // 
            // tabPageBuy
            // 
            this.tabPageBuy.BackColor = System.Drawing.Color.DimGray;
            this.tabPageBuy.Controls.Add(this.label13);
            this.tabPageBuy.Controls.Add(this.numBuyQuantity);
            this.tabPageBuy.Controls.Add(this.panel1);
            this.tabPageBuy.Controls.Add(this.btnBuy);
            this.tabPageBuy.Controls.Add(this.label7);
            this.tabPageBuy.Controls.Add(this.label8);
            this.tabPageBuy.Controls.Add(this.label9);
            this.tabPageBuy.Controls.Add(this.label10);
            this.tabPageBuy.Controls.Add(this.label11);
            this.tabPageBuy.Controls.Add(this.label12);
            this.tabPageBuy.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuy.Name = "tabPageBuy";
            this.tabPageBuy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuy.Size = new System.Drawing.Size(729, 363);
            this.tabPageBuy.TabIndex = 0;
            this.tabPageBuy.Text = "Buy";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Quantity:";
            // 
            // numBuyQuantity
            // 
            this.numBuyQuantity.Location = new System.Drawing.Point(33, 290);
            this.numBuyQuantity.Name = "numBuyQuantity";
            this.numBuyQuantity.Size = new System.Drawing.Size(394, 20);
            this.numBuyQuantity.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(291, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 221);
            this.panel1.TabIndex = 9;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(291, 251);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(136, 23);
            this.btnBuy.TabIndex = 13;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "label4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Stock Value:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "label3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Stock Description:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(200, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "label2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Stock Name:";
            // 
            // tabPageSell
            // 
            this.tabPageSell.BackColor = System.Drawing.Color.DimGray;
            this.tabPageSell.Controls.Add(this.label14);
            this.tabPageSell.Controls.Add(this.numSellQuantity);
            this.tabPageSell.Controls.Add(this.lblProfit);
            this.tabPageSell.Controls.Add(this.label6);
            this.tabPageSell.Controls.Add(this.lblBuyPrice);
            this.tabPageSell.Controls.Add(this.label5);
            this.tabPageSell.Controls.Add(this.panelGraph);
            this.tabPageSell.Controls.Add(this.btnSell);
            this.tabPageSell.Controls.Add(this.lblOwnedStock);
            this.tabPageSell.Controls.Add(this.label4);
            this.tabPageSell.Controls.Add(this.lblStockValue);
            this.tabPageSell.Controls.Add(this.label3);
            this.tabPageSell.Controls.Add(this.lblStockDescription);
            this.tabPageSell.Controls.Add(this.label2);
            this.tabPageSell.Controls.Add(this.lblStockName);
            this.tabPageSell.Controls.Add(this.label1);
            this.tabPageSell.Location = new System.Drawing.Point(4, 22);
            this.tabPageSell.Name = "tabPageSell";
            this.tabPageSell.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSell.Size = new System.Drawing.Size(729, 363);
            this.tabPageSell.TabIndex = 1;
            this.tabPageSell.Text = "Sell";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Quantity:";
            // 
            // numSellQuantity
            // 
            this.numSellQuantity.Location = new System.Drawing.Point(33, 293);
            this.numSellQuantity.Name = "numSellQuantity";
            this.numSellQuantity.Size = new System.Drawing.Size(394, 20);
            this.numSellQuantity.TabIndex = 15;
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(580, 295);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(35, 13);
            this.lblProfit.TabIndex = 14;
            this.lblProfit.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Profit:";
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.AutoSize = true;
            this.lblBuyPrice.Location = new System.Drawing.Point(580, 248);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(35, 13);
            this.lblBuyPrice.TabIndex = 12;
            this.lblBuyPrice.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bought For:";
            // 
            // panelGraph
            // 
            this.panelGraph.BackColor = System.Drawing.Color.White;
            this.panelGraph.Location = new System.Drawing.Point(291, 6);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(432, 221);
            this.panelGraph.TabIndex = 10;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(291, 248);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(136, 23);
            this.btnSell.TabIndex = 9;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lblOwnedStock
            // 
            this.lblOwnedStock.AutoSize = true;
            this.lblOwnedStock.Location = new System.Drawing.Point(199, 253);
            this.lblOwnedStock.Name = "lblOwnedStock";
            this.lblOwnedStock.Size = new System.Drawing.Size(35, 13);
            this.lblOwnedStock.TabIndex = 7;
            this.lblOwnedStock.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "# of Owned stocks:";
            // 
            // lblStockValue
            // 
            this.lblStockValue.AutoSize = true;
            this.lblStockValue.Location = new System.Drawing.Point(199, 149);
            this.lblStockValue.Name = "lblStockValue";
            this.lblStockValue.Size = new System.Drawing.Size(35, 13);
            this.lblStockValue.TabIndex = 5;
            this.lblStockValue.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stock Value:";
            // 
            // lblStockDescription
            // 
            this.lblStockDescription.AutoSize = true;
            this.lblStockDescription.Location = new System.Drawing.Point(199, 100);
            this.lblStockDescription.Name = "lblStockDescription";
            this.lblStockDescription.Size = new System.Drawing.Size(35, 13);
            this.lblStockDescription.TabIndex = 3;
            this.lblStockDescription.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock Description:";
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Location = new System.Drawing.Point(199, 58);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(35, 13);
            this.lblStockName.TabIndex = 1;
            this.lblStockName.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Name:";
            // 
            // BuySellScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(764, 414);
            this.Controls.Add(this.tabBuySell);
            this.Name = "BuySellScreen";
            this.Text = "BuySellScreen";
            this.Load += new System.EventHandler(this.BuySellScreen_Load);
            this.tabBuySell.ResumeLayout(false);
            this.tabPageBuy.ResumeLayout(false);
            this.tabPageBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyQuantity)).EndInit();
            this.tabPageSell.ResumeLayout(false);
            this.tabPageSell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSellQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBuySell;
        private System.Windows.Forms.TabPage tabPageBuy;
        private System.Windows.Forms.TabPage tabPageSell;
        private System.Windows.Forms.Label lblOwnedStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStockValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStockDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBuyPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numBuyQuantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numSellQuantity;
    }
}