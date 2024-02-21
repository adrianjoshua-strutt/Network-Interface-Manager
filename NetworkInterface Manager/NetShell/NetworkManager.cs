using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkInterface_Manager.NetShell
{
    public class NetworkManager
    {

        public static List<NetworkInterface> GetNetworkInterfaces() {
            List<NetworkInterface> interfaces = new List<NetworkInterface>();
            String[] lines = ConsoleHelper.RunCommand("interface ipv4 show interfaces");
            foreach (String line in lines)
            {
                string[] splitted = line.Split(' ');
                string idx = splitted[0];
                string met = splitted[1];
                string mtu = splitted[2];
                string state = splitted[3];
                string name = ConsoleHelper.ReadSplittedArrayToEnd(splitted,4);
                interfaces.Add(new NetworkInterface(idx, met, mtu, state, name));
            }
            return interfaces;
        }


    }
}
