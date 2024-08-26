using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperSimpleTcp;

namespace TCPServer
{
    public partial class TCP_Server_IP : Form
    {
        SimpleTcpServer server;
        public TCP_Server_IP()
        {
            InitializeComponent();
        }

        private void TCP_Server_IP_Load(object sender, EventArgs e)
        {
            btnsend.Enabled = false;
            server = new SimpleTcpServer(txtserver.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }
        private void Events_DataReceived(object sender,DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtinfo.Text += $"{e.IpPort}:{Encoding.UTF8.GetString((e.Data).ToArray())}{Environment.NewLine}";
            });
        }
        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtinfo.Text += $"{e.IpPort} Connect.{Environment.NewLine}";
                lstip.Items.Add(e.IpPort);
            });
        }
        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtinfo.Text += $"{e.IpPort} Disconnect.{Environment.NewLine}";
                lstip.Items.Remove(e.IpPort);
            });
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            server.Start();
            txtinfo.Text += $"Starting...{Environment.NewLine}";
            btnsend.Enabled = true;
            btnstart.Enabled = false;
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            if(server.IsListening)
            {
                if(!string.IsNullOrEmpty(txtmessage.Text) && lstip.SelectedItem!=null)
                {
                    server.Send(lstip.SelectedItem.ToString(), txtmessage.Text);
                    txtinfo.Text += $"Server: {txtmessage.Text}{Environment.NewLine}{txtmessage.Text = string.Empty}";
                }
            }
        }
    }
}
