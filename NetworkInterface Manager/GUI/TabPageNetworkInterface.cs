using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkInterface_Manager.NetShell;
using NetworkInterface_Manager.NetShellSettings;
using NetworkInterface_Manager.GUI;

namespace NetworkInterface_Manager
{
    public partial class TabPageNetworkInterface : UserControl
    {

        public NetworkInterface Interface { get; private set; }

        public NetworkInterfaceSettings InterfaceSettings { get; private set; }

        public TabPageNetworkInterface(NetworkInterface networkInterface)
        {
            this.Interface = networkInterface;
            InitializeComponent();
        }

        private void TabPageNetworkInterface_Load(object sender, EventArgs e)
        {
            this.dataGridViewNetworkInterfacesConfigs.AllowUserToAddRows = false;
            foreach (NetworkInterfaceSettings setting in NetworkInterfaceSettingsManager.networkInterfaceConfigs)
            {
                if (setting.NetworkInterface.Equals(Interface))
                {
                    this.dataGridViewNetworkInterfacesConfigs.DataSource = setting.Configurations;
                    this.InterfaceSettings = setting;
                }
            }
            UpdateDisplay();
        }


        private void UpdateDisplay() {
            this.labelValueName.Text = Interface.Name;
            this.labelValueIDX.Text = Interface.Idx;
            this.labelValueMtu.Text = Interface.Mtu;
            this.labelValueMet.Text = Interface.Met;
            this.labelValueState.Text = Interface.State;
            NetworkInterfaceConfiguration config = Interface.GetNetworkInterfaceConfiguration();
            this.labelValueDHCP.Text = config.DHCP ? "DHCP" : "Static";
            this.labelValueIPAddress.Text = config.IPAddress;
            this.labelValueSubnetMask.Text = config.SubnetMask;
            this.labelValueGateway.Text = config.Gateway;
            this.labelValueDNS.Text = config.DNS;
        }

        private void groupBoxInterfaceInformation_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewNetworkInterfacesConfigs_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewNetworkInterfacesConfigs.SelectedRows.Count > 0)
            {
                buttonEdit.Enabled = true;
            }
            else {
                buttonEdit.Enabled = false;
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem();
        }

        private void DeleteSelectedItem() {
            if (dataGridViewNetworkInterfacesConfigs.SelectedRows.Count > 0) {
                foreach (DataGridViewRow row in dataGridViewNetworkInterfacesConfigs.SelectedRows) {
                    InterfaceSettings.Configurations.Remove((NetworkInterfaceConfiguration)row.DataBoundItem);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditSelected();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add() {
            FormEditNetworkConfiguration formEdit = new FormEditNetworkConfiguration(InterfaceSettings.Configurations);
            formEdit.ShowDialog(this);
        }

        private void EditSelected() {
            if (dataGridViewNetworkInterfacesConfigs.SelectedRows.Count > 0)
            {
                FormEditNetworkConfiguration formEdit = new FormEditNetworkConfiguration((NetworkInterfaceConfiguration)dataGridViewNetworkInterfacesConfigs.SelectedRows[0].DataBoundItem);
                formEdit.ShowDialog(this);
            }
        }

        private void dataGridViewNetworkInterfacesConfigs_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //EditSelected();
        }

        private void dataGridViewNetworkInterfacesConfigs_DoubleClick(object sender, EventArgs e)
        {
       
        }

        private void dataGridViewNetworkInterfacesConfigs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditSelected();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSelected();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            ApplySelected();
        }

        private void ApplySelected() {
            if (dataGridViewNetworkInterfacesConfigs.SelectedRows.Count > 0)
            {
                String output = Interface.SetNetworkInterfaceConfiguration((NetworkInterfaceConfiguration)(dataGridViewNetworkInterfacesConfigs.SelectedRows[0].DataBoundItem));
                if (output.Trim() != "")
                {
                    MessageBox.Show(output, "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else {
                    MessageBox.Show("Succesfuly applied the configuration", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                UpdateDisplay();
            }
        }

        private void applyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplySelected();
        }
    }
}
