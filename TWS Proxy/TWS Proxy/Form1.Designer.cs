namespace TWS_Proxy
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIP = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAssetID = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listLogs = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExchange = new System.Windows.Forms.TextBox();
            this.btnSubWithExchange = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTradeAssetID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.txtQuanity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPriceLMT = new System.Windows.Forms.TextBox();
            this.btnSellLMT = new System.Windows.Forms.Button();
            this.btnBuyLMT = new System.Windows.Forms.Button();
            this.listOrderIDs = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancelAllOrders = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(94, 19);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(128, 21);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "127.0.0.1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 225);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.txtPort);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtIP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(958, 199);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connect";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSubWithExchange);
            this.tabPage2.Controls.Add(this.txtExchange);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnSubscribe);
            this.tabPage2.Controls.Add(this.txtAssetID);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(958, 199);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MarketData";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(94, 49);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(128, 21);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "7497";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(94, 89);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "AssetID:";
            // 
            // txtAssetID
            // 
            this.txtAssetID.Location = new System.Drawing.Point(76, 14);
            this.txtAssetID.Name = "txtAssetID";
            this.txtAssetID.Size = new System.Drawing.Size(144, 21);
            this.txtAssetID.TabIndex = 1;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(226, 12);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnSubscribe.TabIndex = 2;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listLogs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 338);
            this.panel1.TabIndex = 3;
            // 
            // listLogs
            // 
            this.listLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLogs.FormattingEnabled = true;
            this.listLogs.ItemHeight = 12;
            this.listLogs.Location = new System.Drawing.Point(0, 0);
            this.listLogs.Name = "listLogs";
            this.listLogs.Size = new System.Drawing.Size(966, 338);
            this.listLogs.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exchange:";
            // 
            // txtExchange
            // 
            this.txtExchange.Location = new System.Drawing.Point(76, 65);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.Size = new System.Drawing.Size(144, 21);
            this.txtExchange.TabIndex = 4;
            // 
            // btnSubWithExchange
            // 
            this.btnSubWithExchange.Location = new System.Drawing.Point(226, 63);
            this.btnSubWithExchange.Name = "btnSubWithExchange";
            this.btnSubWithExchange.Size = new System.Drawing.Size(75, 23);
            this.btnSubWithExchange.TabIndex = 5;
            this.btnSubWithExchange.Text = "Subscribe";
            this.btnSubWithExchange.UseVisualStyleBackColor = true;
            this.btnSubWithExchange.Click += new System.EventHandler(this.btnSubWithExchange_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCancelAllOrders);
            this.tabPage3.Controls.Add(this.btnCancel);
            this.tabPage3.Controls.Add(this.listOrderIDs);
            this.tabPage3.Controls.Add(this.btnSellLMT);
            this.tabPage3.Controls.Add(this.btnBuyLMT);
            this.tabPage3.Controls.Add(this.txtPriceLMT);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtAccount);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtQuanity);
            this.tabPage3.Controls.Add(this.btnSell);
            this.tabPage3.Controls.Add(this.btnBuy);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtTradeAssetID);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(958, 199);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Trade";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "AssetID:";
            // 
            // txtTradeAssetID
            // 
            this.txtTradeAssetID.Location = new System.Drawing.Point(79, 12);
            this.txtTradeAssetID.Name = "txtTradeAssetID";
            this.txtTradeAssetID.Size = new System.Drawing.Size(196, 21);
            this.txtTradeAssetID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "Quantity:";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(79, 119);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(78, 31);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(163, 119);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(78, 31);
            this.btnSell.TabIndex = 4;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // txtQuanity
            // 
            this.txtQuanity.Location = new System.Drawing.Point(79, 48);
            this.txtQuanity.Name = "txtQuanity";
            this.txtQuanity.Size = new System.Drawing.Size(196, 21);
            this.txtQuanity.TabIndex = 5;
            this.txtQuanity.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Account:";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(79, 82);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(196, 21);
            this.txtAccount.TabIndex = 7;
            this.txtAccount.Text = "DU269607";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "LMT Price:";
            // 
            // txtPriceLMT
            // 
            this.txtPriceLMT.Location = new System.Drawing.Point(409, 12);
            this.txtPriceLMT.Name = "txtPriceLMT";
            this.txtPriceLMT.Size = new System.Drawing.Size(115, 21);
            this.txtPriceLMT.TabIndex = 9;
            // 
            // btnSellLMT
            // 
            this.btnSellLMT.Location = new System.Drawing.Point(446, 119);
            this.btnSellLMT.Name = "btnSellLMT";
            this.btnSellLMT.Size = new System.Drawing.Size(78, 31);
            this.btnSellLMT.TabIndex = 11;
            this.btnSellLMT.Text = "Sell LMT";
            this.btnSellLMT.UseVisualStyleBackColor = true;
            this.btnSellLMT.Click += new System.EventHandler(this.btnSellLMT_Click);
            // 
            // btnBuyLMT
            // 
            this.btnBuyLMT.Location = new System.Drawing.Point(362, 119);
            this.btnBuyLMT.Name = "btnBuyLMT";
            this.btnBuyLMT.Size = new System.Drawing.Size(78, 31);
            this.btnBuyLMT.TabIndex = 10;
            this.btnBuyLMT.Text = "Buy LMT";
            this.btnBuyLMT.UseVisualStyleBackColor = true;
            this.btnBuyLMT.Click += new System.EventHandler(this.btnBuyLMT_Click);
            // 
            // listOrderIDs
            // 
            this.listOrderIDs.FormattingEnabled = true;
            this.listOrderIDs.ItemHeight = 12;
            this.listOrderIDs.Location = new System.Drawing.Point(569, 15);
            this.listOrderIDs.Name = "listOrderIDs";
            this.listOrderIDs.Size = new System.Drawing.Size(197, 76);
            this.listOrderIDs.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(569, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 31);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCancelAllOrders
            // 
            this.btnCancelAllOrders.Location = new System.Drawing.Point(653, 119);
            this.btnCancelAllOrders.Name = "btnCancelAllOrders";
            this.btnCancelAllOrders.Size = new System.Drawing.Size(113, 31);
            this.btnCancelAllOrders.TabIndex = 14;
            this.btnCancelAllOrders.Text = "Cancel all";
            this.btnCancelAllOrders.UseVisualStyleBackColor = true;
            this.btnCancelAllOrders.Click += new System.EventHandler(this.btnCancelAllOrders_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TWS Porxy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.TextBox txtAssetID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listLogs;
        private System.Windows.Forms.Button btnSubWithExchange;
        private System.Windows.Forms.TextBox txtExchange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTradeAssetID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuanity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listOrderIDs;
        private System.Windows.Forms.Button btnSellLMT;
        private System.Windows.Forms.Button btnBuyLMT;
        private System.Windows.Forms.TextBox txtPriceLMT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelAllOrders;
    }
}

