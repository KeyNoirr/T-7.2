using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICMP
{
    public partial class FrmICMP : Form
    {
        private static int pingstart, pingstop, elapsedtime;
        private static TextBox hostbox, databox;
        private static ListBox results;
        private static Thread pinger;
        private Socket sock;
        public FrmICMP()
        {
            InitializeComponent();
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Icmp);
            sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 3000);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            sock.Close();
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pinger = new Thread(new ThreadStart(sendPing));
            pinger.IsBackground = true;
            pinger.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            pinger.Abort();
            this.Invoke((MethodInvoker)(() => listBox.Items.Add("Ping stopped")));
        }

        void sendPing()
        {
            IPHostEntry iphe = Dns.Resolve(txtHost.Text);
            IPEndPoint iep = new IPEndPoint(iphe.AddressList[0], 0);
            EndPoint ep = (EndPoint)iep;
            ICMP packet = new ICMP();
            int recv, i = 1;
            packet.Type = 0x08;
            packet.Code = 0x00;
            Buffer.BlockCopy(BitConverter.GetBytes(1), 0, packet.Message, 0, 2);
            byte[] data = Encoding.ASCII.GetBytes(txtPacketData.Text);
            Buffer.BlockCopy(data, 0, packet.Message, 4, data.Length);
            packet.MessageSize = data.Length + 4;
            int packetsize = packet.MessageSize + 4;
            this.Invoke((MethodInvoker)(() => listBox.Items.Add("Pinging " + txtHost.Text)));
            while (true)
            {
                packet.Checksum = 0;
                Buffer.BlockCopy(BitConverter.GetBytes(i), 0, packet.Message, 2, 2);
                UInt16 chcksum = packet.getChecksum();
                packet.Checksum = chcksum;
                pingstart = Environment.TickCount;
                sock.SendTo(packet.getBytes(), packetsize, SocketFlags.None, iep);
                try
                {
                    data = new byte[1024];
                    recv = sock.ReceiveFrom(data, ref ep);
                    pingstop = Environment.TickCount;
                    elapsedtime = pingstop - pingstart;
                    this.Invoke((MethodInvoker)(() => listBox.Items.Add("reply from: " + ep.ToString() + ", seq: " + i + ", time = " + elapsedtime + "ms")));
                }
                catch (SocketException)
                {
                    this.Invoke((MethodInvoker)(() => listBox.Items.Add("no reply from host")));
                }
                i++;
                Thread.Sleep(3000);
            }
        }
    }
}
