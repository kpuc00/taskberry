using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenant_Application
{
    class WebSocket
    {
        // Declaring a Net Socket object
        public Socket sck;
        // Declaring 2 Endpoints objects for 2 pcs
        public EndPoint epLocal, epRemote/*, epRemote2*/;

        // An array to holds the message 
        byte[] buffer;
        //byte[] buffer2;

        // this list stores all the messages 
        public List<string> messages;

        //constructore
        public WebSocket()
        {
            //setup socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            messages = new List<string>();
        }

        //methods
        public void connect(string LocalIP, string LocalPort, string User1IP, string User1Port/*, string U2IP, string U2Port*/)
        {
            //binding Socket
            epLocal = new IPEndPoint(IPAddress.Parse(LocalIP), Convert.ToInt32(LocalPort));
            sck.Bind(epLocal);

            epRemote = new IPEndPoint(IPAddress.Parse(User1IP), Convert.ToInt32(User1Port));
            sck.Connect(epRemote);
            //start the connection 
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            /*epRemote2 = new IPEndPoint(IPAddress.Parse(U2IP), Convert.ToInt32(U2Port));
            sck.Connect(epRemote2);
            //start the connection 
            buffer2 = new byte[1500];
            sck.BeginReceiveFrom(buffer2, 0, buffer2.Length, SocketFlags.None, ref epRemote2, new AsyncCallback(MessageCallBack), buffer2);*/
        }

        // A method to get your IP address from DNS server
        public string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";

        }
        public void sendMsg(string msg)
        {
            // convert string msg to byte[]
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(msg);
            messages.Add(msg);
            // send the msg
            try
            {
                sck.Send(sendingMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The message was not delivered. You are not connected with at least one user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString(), "Error description", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                //converting byte[] to string

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);


                //add to list 
                messages.Add(receivedMessage);
                //messages.Add("Friend " + receivedMessage);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
