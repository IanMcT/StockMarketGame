namespace SMG
{
    partial class stockMarketScreen
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
            this.panelStocks = new System.Windows.Forms.Panel();
            this.dgvStockList = new System.Windows.Forms.DataGridView();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceChange = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelOwned = new System.Windows.Forms.Panel();
            this.dgvOwnedStocks = new System.Windows.Forms.DataGridView();
            this.OwnedStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnedCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnedPriceChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.tbStockInfo = new System.Windows.Forms.TextBox();
            this.btnSellStocks = new System.Windows.Forms.Button();
            this.btnBuyStocks = new System.Windows.Forms.Button();
            this.tbStockProfit = new System.Windows.Forms.TextBox();
            this.tbSellQuantity = new System.Windows.Forms.TextBox();
            this.tbStocksValue = new System.Windows.Forms.TextBox();
            this.tbOwnedStocks = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.tbDays = new System.Windows.Forms.TextBox();
            this.panelStocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).BeginInit();
            this.panelOwned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnedStocks)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStocks
            // 
            this.panelStocks.Controls.Add(this.dgvStockList);
            this.panelStocks.Location = new System.Drawing.Point(35, 25);
            this.panelStocks.Name = "panelStocks";
            this.panelStocks.Size = new System.Drawing.Size(393, 222);
            this.panelStocks.TabIndex = 0;
            // 
            // dgvStockList
            // 
            this.dgvStockList.AllowUserToAddRows = false;
            this.dgvStockList.AllowUserToDeleteRows = false;
            this.dgvStockList.AllowUserToResizeColumns = false;
            this.dgvStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stock,
            this.Cost,
            this.priceChange});
            this.dgvStockList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStockList.Location = new System.Drawing.Point(3, 3);
            this.dgvStockList.Name = "dgvStockList";
            this.dgvStockList.Size = new System.Drawing.Size(387, 216);
            this.dgvStockList.TabIndex = 0;
            this.dgvStockList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockList_CellContentClick);
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            // 
            // priceChange
            // 
            this.priceChange.HeaderText = "Movement";
            this.priceChange.Name = "priceChange";
            // 
            // panelOwned
            // 
            this.panelOwned.Controls.Add(this.dgvOwnedStocks);
            this.panelOwned.Location = new System.Drawing.Point(35, 285);
            this.panelOwned.Name = "panelOwned";
            this.panelOwned.Size = new System.Drawing.Size(393, 236);
            this.panelOwned.TabIndex = 1;
            // 
            // dgvOwnedStocks
            // 
            this.dgvOwnedStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwnedStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OwnedStock,
            this.OwnedCost,
            this.OwnedPriceChange});
            this.dgvOwnedStocks.Location = new System.Drawing.Point(3, 3);
            this.dgvOwnedStocks.Name = "dgvOwnedStocks";
            this.dgvOwnedStocks.Size = new System.Drawing.Size(387, 230);
            this.dgvOwnedStocks.TabIndex = 0;
            // 
            // OwnedStock
            // 
            this.OwnedStock.HeaderText = "Stock";
            this.OwnedStock.Name = "OwnedStock";
            // 
            // OwnedCost
            // 
            this.OwnedCost.HeaderText = "Cost";
            this.OwnedCost.Name = "OwnedCost";
            // 
            // OwnedPriceChange
            // 
            this.OwnedPriceChange.HeaderText = "Price Change";
            this.OwnedPriceChange.Name = "OwnedPriceChange";
            // 
            // panelGraph
            // 
            this.panelGraph.BackColor = System.Drawing.Color.White;
            this.panelGraph.Location = new System.Drawing.Point(472, 26);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(432, 221);
            this.panelGraph.TabIndex = 2;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.tbStockInfo);
            this.panelInfo.Controls.Add(this.btnSellStocks);
            this.panelInfo.Controls.Add(this.btnBuyStocks);
            this.panelInfo.Controls.Add(this.tbStockProfit);
            this.panelInfo.Controls.Add(this.tbSellQuantity);
            this.panelInfo.Controls.Add(this.tbStocksValue);
            this.panelInfo.Controls.Add(this.tbOwnedStocks);
            this.panelInfo.Controls.Add(this.label8);
            this.panelInfo.Controls.Add(this.label7);
            this.panelInfo.Controls.Add(this.label6);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Location = new System.Drawing.Point(472, 285);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(432, 232);
            this.panelInfo.TabIndex = 3;
            // 
            // tbStockInfo
            // 
            this.tbStockInfo.Location = new System.Drawing.Point(58, 4);
            this.tbStockInfo.Name = "tbStockInfo";
            this.tbStockInfo.Size = new System.Drawing.Size(310, 20);
            this.tbStockInfo.TabIndex = 10;
            // 
            // btnSellStocks
            // 
            this.btnSellStocks.Location = new System.Drawing.Point(268, 192);
            this.btnSellStocks.Name = "btnSellStocks";
            this.btnSellStocks.Size = new System.Drawing.Size(100, 37);
            this.btnSellStocks.TabIndex = 9;
            this.btnSellStocks.Text = "Sell";
            this.btnSellStocks.UseVisualStyleBackColor = true;
            // 
            // btnBuyStocks
            // 
            this.btnBuyStocks.Location = new System.Drawing.Point(58, 192);
            this.btnBuyStocks.Name = "btnBuyStocks";
            this.btnBuyStocks.Size = new System.Drawing.Size(100, 37);
            this.btnBuyStocks.TabIndex = 8;
            this.btnBuyStocks.Text = "Buy";
            this.btnBuyStocks.UseVisualStyleBackColor = true;
            // 
            // tbStockProfit
            // 
            this.tbStockProfit.Location = new System.Drawing.Point(268, 155);
            this.tbStockProfit.Name = "tbStockProfit";
            this.tbStockProfit.ReadOnly = true;
            this.tbStockProfit.Size = new System.Drawing.Size(100, 20);
            this.tbStockProfit.TabIndex = 7;
            // 
            // tbSellQuantity
            // 
            this.tbSellQuantity.Location = new System.Drawing.Point(58, 155);
            this.tbSellQuantity.Name = "tbSellQuantity";
            this.tbSellQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbSellQuantity.TabIndex = 6;
            // 
            // tbStocksValue
            // 
            this.tbStocksValue.Location = new System.Drawing.Point(268, 88);
            this.tbStocksValue.Name = "tbStocksValue";
            this.tbStocksValue.ReadOnly = true;
            this.tbStocksValue.Size = new System.Drawing.Size(100, 20);
            this.tbStocksValue.TabIndex = 5;
            // 
            // tbOwnedStocks
            // 
            this.tbOwnedStocks.Location = new System.Drawing.Point(58, 88);
            this.tbOwnedStocks.Name = "tbOwnedStocks";
            this.tbOwnedStocks.ReadOnly = true;
            this.tbOwnedStocks.Size = new System.Drawing.Size(100, 20);
            this.tbOwnedStocks.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(266, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Profit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sell Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(265, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Owned:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stocks List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(640, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stock Trend";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Owned Stocks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(640, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stock Info";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(175, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "BALANCE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(751, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "DAY:";
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(275, 527);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.ReadOnly = true;
            this.tbBalance.Size = new System.Drawing.Size(100, 20);
            this.tbBalance.TabIndex = 9;
            // 
            // tbDays
            // 
            this.tbDays.Location = new System.Drawing.Point(803, 527);
            this.tbDays.Name = "tbDays";
            this.tbDays.ReadOnly = true;
            this.tbDays.Size = new System.Drawing.Size(100, 20);
            this.tbDays.TabIndex = 10;
            // 
            // stockMarketScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(937, 557);
            this.Controls.Add(this.tbDays);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.panelOwned);
            this.Controls.Add(this.panelStocks);
            this.Name = "stockMarketScreen";
            this.Text = "stockMarketScreen";
            this.Load += new System.EventHandler(this.stockMarketScreen_Load);
            this.panelStocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).EndInit();
            this.panelOwned.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnedStocks)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelStocks;
        private System.Windows.Forms.Panel panelOwned;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvStockList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewImageColumn priceChange;
        private System.Windows.Forms.DataGridView dgvOwnedStocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnedStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnedCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnedPriceChange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbStockProfit;
        private System.Windows.Forms.TextBox tbSellQuantity;
        private System.Windows.Forms.TextBox tbStocksValue;
        private System.Windows.Forms.TextBox tbOwnedStocks;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.TextBox tbDays;
        private System.Windows.Forms.Button btnSellStocks;
        private System.Windows.Forms.Button btnBuyStocks;
        private System.Windows.Forms.TextBox tbStockInfo;
    }
}
