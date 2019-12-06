using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace connection
{
    public class DeviceConnection
    {
        private string stringToReceive;
        private string stringToSend;
        private void serverThread()
        {
            UdpClient udpClient = new UdpClient(8888);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returndata = Encoding.ASCII.GetString(receiveBytes);
                stringToReceive = returndata;
            }
        }
        private void sendData()
        {
            string ip = "";
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(ip, 8888);
            Byte[] sendData = Encoding.ASCII.GetBytes(stringToSend);
            udpClient.Send(sendData, sendData.Length);
        }
        public string ReceiveData()
        {
            return this.stringToReceive;
        }
        public string SendData()
        {
            return this.stringToSend;
        }

        //orderNum = returndata.Split('#').First();
        //returndata = returndata.Replace(orderNum + "#", "");

        //pizzaNum = returndata.Split('%').First();
        //returndata = returndata.Replace(pizzaNum + "%", "");
        //message = returndata.Split('&').First();

        //lbxOrders.Items.Add($"{orderNum} \t {pizzaNum} \t {message}");
        //data.Add($"{orderNum}#{pizzaNum}%{message}&*");
    }
}
