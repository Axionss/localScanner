using Microsoft.SqlServer.Server;
using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace localScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hostList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void startScan_Click(object sender, EventArgs e)
        {
            // Clear the hostListView in case it has been run previously

            hostListView.Items.Clear();

            // Declare listOfHosts to be used later

            string[] listOfHostAddr = new string[] {};
            Ping ipaddr = new Ping();
            // Get start host and end host values
            
            string startHost = startHostBox.Text;
            string endHost = endHostBox.Text;

            // Format the start host value to remove the last octect
            
            string[] split = startHost.Split('.');
            Array.Resize(ref split, split.Length - 1);
            string firstPart = string.Join(".", split);
            firstPart += ".";

            // Get the balue of the last octect of the start host, finally create new variable and cast to int

            string[] firstOctect = startHost.Split('.');
            string firstOctetValue = firstOctect.Last();
            int firstOctectValueInt = Int32.Parse(firstOctetValue);
            

            // Get the value of the last octect of the end host, finally create new variable and cast to int
            
            string[] lastOctet = endHost.Split('.');
            string lastOctetValue = lastOctet.Last();
            int lastOctectValueInt = Int32.Parse(lastOctetValue);

            // Create a loop to generate the list of hosts to test
            /*
            for(int i = firstOctectValueInt; i < lastOctectValueInt + 1; i++)
            {
                string str = Convert.ToString(i);
                Ping p = new Ping();
                PingReply r;
                string s;
                s = firstPart + str;
                r = p.Send(s);
                hostListView.Items.Add(new ListViewItem(new[] { firstPart + str, r.Status.ToString()}));
            }
            */
            Parallel.For(firstOctectValueInt,lastOctectValueInt+1, index => { 
                string str = Convert.ToString(index);
                Ping p = new Ping();
                PingReply r;
                string s;
                s = firstPart + str;
                r = p.Send(s);
                hostListView.Items.BeginInvoke(() => hostListView.Items.Add(new ListViewItem(new[] { firstPart + str, r.Status.ToString() }));
            });
            
        }

        private void endHostBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startHostBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void hostListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            hostListView.View = View.Details;

            hostListView.Columns.Add("Host", 100, HorizontalAlignment.Left);
            hostListView.Columns.Add("Response", 100, HorizontalAlignment.Center);
            hostListView.Columns.Add("Hostname",100, HorizontalAlignment.Right);

            hostListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
    }
}
