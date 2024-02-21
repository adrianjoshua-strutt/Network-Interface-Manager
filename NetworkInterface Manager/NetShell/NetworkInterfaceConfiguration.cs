using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NetworkInterface_Manager.NetShell
{
    [Serializable]
    public class NetworkInterfaceConfiguration  : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public NetworkInterfaceConfiguration()
        {
        }

        public NetworkInterfaceConfiguration(Boolean dhcp, String ipAddress, String subnetMask, String gateway, String dns) {
            DHCP = dhcp;
            IPAddress = ipAddress;
            SubnetMask = subnetMask;
            Gateway = gateway;
            Name = DateTime.Now + "";
            DNS = dns;
        }
        public NetworkInterfaceConfiguration(Boolean dhcp, String ipAddress, String subnetMask, String gateway, String dns, String name)
        {
            DHCP = dhcp;
            IPAddress = ipAddress;
            SubnetMask = subnetMask;
            Gateway = gateway;
            Name = name;
            DNS = dns;
        }

        private String name = "";
        private Boolean dhcp = false;
        private String ipAddress = "";
        private String subnetMask = "";
        private String gateway = "";
        private String dns = "";

        public String           Name                { get { return name; } set { name = value;  NotifyPropertyChanged("Name"); } }
        public Boolean          DHCP                { get { return dhcp; } set { dhcp = value;  NotifyPropertyChanged("DHCP"); } }
        public String           IPAddress           { get { return ipAddress; } set { ipAddress = value;  NotifyPropertyChanged("IPAddress"); } }
        public String           SubnetMask          { get { return subnetMask; } set { subnetMask = value;  NotifyPropertyChanged("SubnetMask"); } }
        public String           Gateway             { get { return gateway; } set { gateway = value;  NotifyPropertyChanged("Gateway"); } } 
        public String           DNS                 { get { return dns; } set { dns = value;  NotifyPropertyChanged("DNS"); } } 

        public override bool Equals(object obj)
        {
            return Equals(obj as NetworkInterfaceConfiguration);
        }

        public virtual bool EqualsData(NetworkInterfaceConfiguration obj)
        {
            return obj != null && this.DHCP == obj.DHCP && this.IPAddress == obj.IPAddress && this.SubnetMask == obj.SubnetMask && this.Gateway == obj.Gateway && this.DNS == obj.DNS;
        }

        public virtual bool Equals(NetworkInterfaceConfiguration obj)
        {
            return obj != null && EqualsData(obj) && this.Name == obj.Name;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public NetworkInterfaceConfiguration ShallowCopy()
        {
            return (NetworkInterfaceConfiguration)this.MemberwiseClone();
        }

        public void Override(NetworkInterfaceConfiguration config) {
            Name = config.Name;
            DHCP = config.DHCP;
            IPAddress = config.IPAddress;
            SubnetMask = config.SubnetMask;
            Gateway = config.Gateway;
            DNS = config.DNS;
        }

        public IEqualityComparer<NetworkInterfaceConfiguration> GetDataEqualityComparer() {
            return new NetworkInterfaceConfigurationEqualityDataComparator();
        }

        public class NetworkInterfaceConfigurationEqualityDataComparator : IEqualityComparer<NetworkInterfaceConfiguration> {
            public virtual bool Equals(NetworkInterfaceConfiguration obj1, NetworkInterfaceConfiguration obj2)
            {
                return obj1.EqualsData(obj2);
            }
            public virtual int GetHashCode(NetworkInterfaceConfiguration n)
                {
                     return n.GetHashCode();
                }
        }

    }


}

