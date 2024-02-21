using NetworkInterface_Manager.NetShell;
using System.ComponentModel;

namespace NetworkInterface_Manager.NetShellSettings
{
    public class NetworkInterfaceSettings
    {
        public NetworkInterface NetworkInterface { get; set; }
        public BindingList<NetworkInterfaceConfiguration> Configurations { get; set; }
        public NetworkInterfaceSettings()
        {
            Configurations = new BindingList<NetworkInterfaceConfiguration>();
        }
        public NetworkInterfaceSettings(NetworkInterface networkInterface)
        {
            NetworkInterface = networkInterface;
            Configurations = new BindingList<NetworkInterfaceConfiguration>();
        }
    }
}
