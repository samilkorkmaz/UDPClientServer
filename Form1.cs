using System;
using System.Windows.Forms;

namespace UDPClientServer
{
    public partial class Form1 : Form
    {
        private UDPSocket server;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            UDPSocket c = new UDPSocket();
            int sendPort = int.Parse(tbSendPort.Text);
            c.Client(tbSendIP.Text, sendPort);
            c.Send(tbSendMessage.Text);
            tbLog.AppendText(Environment.NewLine + "Sent \"" + tbSendMessage.Text + "\" to " + tbSendIP.Text + ":" + sendPort);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            server = new UDPSocket();
            //String receiveIP = "127.0.0.1";
            //String receiveIP = "192.168.61.32";
            String receiveIP = tbReceiveIP.Text;            
            int receivePort = int.Parse(tbReceivePort.Text);
            server.Server(receiveIP, receivePort);
            tbLog.AppendText(Environment.NewLine + "Listening on " + receiveIP + ":" + receivePort + "...");
        }
    }
}
