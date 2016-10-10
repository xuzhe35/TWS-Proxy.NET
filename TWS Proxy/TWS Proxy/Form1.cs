using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using TWSHelper;

namespace TWS_Proxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            ActionBlock<AssetUpdate> OnUpdate = new ActionBlock<AssetUpdate>((update) =>
            {
                string news = string.Format("{0}:{1}({2}),{3}({4})",update.strAssetID,
                    update.Ask.ToString(),update.AskSize.ToString(),
                    update.Bid.ToString(),update.BidSize.ToString());


                listLogs.Items.Add(news);
            });

            client.UpdateBoradCast.LinkTo(OnUpdate);
        }

        IB_Client client = new IB_Client();

        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool ret = client.ConnectToTWS(txtIP.Text, int.Parse(txtPort.Text));

            if (ret)
                MessageBox.Show("Connect to TWS success", "TWS Proxy");
            else
                MessageBox.Show("Something wrong", "TWS Proxy", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            client.add(txtAssetID.Text);
        }

        private void btnSubWithExchange_Click(object sender, EventArgs e)
        {
            client.add(txtAssetID.Text, txtExchange.Text);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            client.DefaultAccout = txtAccount.Text;

            client.Buy(txtTradeAssetID.Text, int.Parse(txtQuanity.Text));
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            client.DefaultAccout = txtAccount.Text;

            client.Sell(txtTradeAssetID.Text, int.Parse(txtQuanity.Text));
        }

        private void btnBuyLMT_Click(object sender, EventArgs e)
        {
            client.DefaultAccout = txtAccount.Text;
            int order_id = client.BuyLMT(txtTradeAssetID.Text, int.Parse(txtQuanity.Text), double.Parse(txtPriceLMT.Text));

            listOrderIDs.Items.Add(order_id);
        }

        private void btnSellLMT_Click(object sender, EventArgs e)
        {
            client.DefaultAccout = txtAccount.Text;
            int order_id = client.SellLMT(txtTradeAssetID.Text, int.Parse(txtQuanity.Text), double.Parse(txtPriceLMT.Text));

            listOrderIDs.Items.Add(order_id);
        }

        private void btnCancelAllOrders_Click(object sender, EventArgs e)
        {
            client.CancelAllOrders();

            listOrderIDs.Items.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int i = listOrderIDs.SelectedIndex;
            int order_id = Convert.ToInt32(listOrderIDs.Items[i]);

            client.CancelOrder(order_id);
        }
    }
}
