using System;
using System.Threading;

namespace NetworkInterface_Manager.NetShell
{
    public class NetworkInterface
    {

        public String Idx { get; set;}
        public String Met { get;set; }
        public String Mtu { get; set; }
        public String State { get; set; }
        public String Name { get; set; }

        public NetworkInterfaceConfiguration GetNetworkInterfaceConfiguration() {
            String[] lines = ConsoleHelper.RunCommand("interface ipv4 show address name=\"" + Idx + "\"", false, 2);
            bool dhcp = lines[0].Split(' ')[2] != "Nein";
            string ip = "";
            string subnetMask = "";
            string gateway = "";
            if (!dhcp) {
                ip = ConsoleHelper.ReadSplittedArrayToEnd(lines[1].Split(' '), 1);
                subnetMask = lines[2].Split(' ')[1];
                gateway = ConsoleHelper.ReadSplittedArrayToEnd(lines[3].Split(' '), 1);
            }
            string dns = "";
            if (!dhcp) { 
                dns = ConsoleHelper.RunCommand("interface ipv4 show dnsservers name=\"" + Idx + "\"", false, 2)[0].Split(' ')[3];
            }
            return new NetworkInterfaceConfiguration(dhcp, ip,subnetMask,gateway,dns);
        }

        public String SetNetworkInterfaceConfiguration(NetworkInterfaceConfiguration config)
        {
            String first = "";
            String second = "";
            if (config.DHCP)
            {
                first = ConsoleHelper.RunCommand("interface ipv4 set address \"" + Idx + "\"  dhcp", true)[0];
                second = ConsoleHelper.RunCommand("interface ipv4 set dnsservers \"" + Idx + "\" dhcp", true)[0];
            }
            else {
                first = ConsoleHelper.RunCommand("interface ipv4 set address \"" + Idx + "\" static " + config.IPAddress + " " + config.SubnetMask + " " + config.Gateway, true)[0];
                second = ConsoleHelper.RunCommand("interface ipv4 set dns \"" + Idx + "\" static " + config.DNS + "", true)[0];
                Thread.Sleep(3000);
            }
            first = first.Trim();
            second = second.Trim();
            if (first == "" && second == "") {
                return "";
            }
            else if (first == "")
            {
                return "DNS Error: " + second;
            }
            else if (second == "")
            {
                return "IP Error: " + first;
            }
            else
            {
                return "IP Error: " + first + "\n" + "DNS Error: " + second; 
            }
        }

        public NetworkInterface()
        {
        }

        public NetworkInterface(String idx, String met, String mtu, string state, String name) {
            Idx = idx;
            Met = met;
            Mtu = mtu;
            State = state;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as NetworkInterface);
        }

        public virtual bool Equals(NetworkInterface obj)
        {
            return obj != null && this.Idx == obj.Idx && this.Met == obj.Met && this.Mtu == obj.Mtu && this.State == obj.State && this.Name == obj.Name;
        }

        public override int GetHashCode()
        {
            return 0;
        }

    }
}
