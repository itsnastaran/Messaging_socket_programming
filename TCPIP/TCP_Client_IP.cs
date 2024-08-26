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

namespace TCPIP
{
    public partial class TCP_Client_IP : Form
    {
        SimpleTcpClient client;
        public TCP_Client_IP()
        {
            InitializeComponent();
        }

        private void TCP_Client_IP_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient(txtserver.Text);
            client.Events.Connected += Events_Connected;
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
            btnsend.Enabled = false;
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtinfo.Text += $"Server Connected.{Environment.NewLine}";
            }
            );
        }

        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtinfo.Text += $"Server Disconneted.{Environment.NewLine}";
            });
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtinfo.Text += $"Server {Encoding.UTF8.GetString((e.Data).ToArray())}{Environment.NewLine}";
            });
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(txtmessage.Text))
                {
                    client.Send(txtmessage.Text);
                    txtinfo.Text += $"{txtname.Text}: {txtmessage.Text}{Environment.NewLine}";
                    txtmessage.Text = string.Empty;
                }
            }
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                btnsend.Enabled = true;
                btnconnect.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "پیام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
