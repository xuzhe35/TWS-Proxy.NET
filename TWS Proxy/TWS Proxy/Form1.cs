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
            ActionBlock<AssetUpdate> OnUpdate = new ActionBlock<AssetUpdate>((update) =>
            {
                
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
            client.a(txtAssetID.Text);
        }


    }
}
