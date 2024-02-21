using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using NetworkInterface_Manager.NetShell;
using NetworkInterface_Manager.NetShellSettings;

namespace NetworkInterface_Manager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           NetworkInterfaceSettingsManager.LoadList();
           foreach (NetworkInterface networkInterface in NetworkManager.GetNetworkInterfaces()){
                if (networkInterface.Name.ToLower().Contains("loopback") || networkInterface.Name.ToLower().Contains("* "))
                {
                    continue;
                }
                bool found = false;
                foreach (NetworkInterfaceSettings setting in NetworkInterfaceSettingsManager.networkInterfaceConfigs) {
                    if (setting.NetworkInterface.Equals(networkInterface)) {
                        found = true;
                    }
                }
                if (!found) {
                    NetworkInterfaceSettingsManager.networkInterfaceConfigs.Add(new NetworkInterfaceSettings(networkInterface));
                }
                foreach (NetworkInterfaceSettings setting in NetworkInterfaceSettingsManager.networkInterfaceConfigs)
                {
                    if (setting.NetworkInterface.Equals(networkInterface))
                    {
                        NetworkInterfaceConfiguration config = networkInterface.GetNetworkInterfaceConfiguration();
                        if (!setting.Configurations.Contains(config,config.GetDataEqualityComparer()))
                        {
                            setting.Configurations.Add(config);
                        }
                    }
                }
                TabPage tabPage = new TabPage(networkInterface.Name);
                tabControlNetworkInterfaces.TabPages.Add(tabPage);
                TabPageNetworkInterface tabPageNetworkInterface = new TabPageNetworkInterface(networkInterface);
                tabPageNetworkInterface.Dock = DockStyle.Fill;
                tabPage.Controls.Add(tabPageNetworkInterface);
                foreach (NetworkInterfaceSettings setting in NetworkInterfaceSettingsManager.networkInterfaceConfigs)
                {
                    setting.Configurations.ListChanged += SaveListOnItemChange;
                }
            }
            NetworkInterfaceSettingsManager.SaveList(); 
        }

        private void SaveListOnItemChange(object sender, ListChangedEventArgs e) {
            //NetworkInterfaceSettingsManager.SaveList();
        }

    }
}