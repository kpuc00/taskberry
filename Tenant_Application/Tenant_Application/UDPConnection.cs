using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Tenant_Application
{
    public class UDPConnection
    {
        private string UDP;
        public bool isReceived = false;
        public void ReceiveUDP()
        {
            UdpClient udpClient = new UdpClient(8888);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returndata = Encoding.ASCII.GetString(receiveBytes);
                this.UDP = returndata;
                isReceived = true;
            }
        }
        public string ReturnUDP()
        {
            return this.UDP;
        }
        public void SendUDP(string stringToSend)
        {
            //enter remote ip adress here
            string ip = "";
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(ip, 8888);
            Byte[] sendData = Encoding.ASCII.GetBytes(stringToSend);
            udpClient.Send(sendData, sendData.Length);
        }

        //$"{var1} \t {var2} \t {var3}";
        //$"{var1}#{var2}%{var3}&*";

        //var1 = returndata.Split('#').First();
        //returndata = returndata.Replace(var1 + "#", "");

        //var2 = returndata.Split('%').First();
        //returndata = returndata.Replace(var2 + "%", "");

        //var3 = returndata.Split('&').First();
    }
}
