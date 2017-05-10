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
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.lblTutorialText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.tbDays = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            this.panelInfo.Controls.Add(this.richTextBox1);
            this.panelInfo.Controls.Add(this.btnEndTurn);
            this.panelInfo.Controls.Add(this.lblTutorialText);
            this.panelInfo.Location = new System.Drawing.Point(472, 285);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(432, 232);
            this.panelInfo.TabIndex = 3;
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(58, 183);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(319, 37);
            this.btnEndTurn.TabIndex = 8;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            // 
            // lblTutorialText
            // 
            this.lblTutorialText.AutoSize = true;
            this.lblTutorialText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorialText.Location = new System.Drawing.Point(19, 12);
            this.lblTutorialText.Name = "lblTutorialText";
            this.lblTutorialText.Size = new System.Drawing.Size(0, 16);
            this.lblTutorialText.TabIndex = 0;
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
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DimGray;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(22, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(394, 102);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "To look at a stock graph, click on a stock once to change the graph, to buy/sell " +
    "stocks, double click on a stock to bring up the buy/sell menu.";
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
        private System.Windows.Forms.Label lblTutorialText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.TextBox tbDays;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
