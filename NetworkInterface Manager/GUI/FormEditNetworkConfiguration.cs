using NetworkInterface_Manager.GUI;
using NetworkInterface_Manager.NetShell;
using NetworkInterface_Manager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkInterface_Manager.GUI
{
    public partial class FormEditNetworkConfiguration : Form
    {


        private NetworkInterfaceConfiguration networkInterfaceConfigurationToEdit;
        private NetworkInterfaceConfiguration networkInterfaceConfiguration;

        private BindingList <NetworkInterfaceConfiguration> ToAddTo;

        private ObjectEditor<NetworkInterfaceConfiguration> Editor;

        private void init() {
            InitializeComponent();
            ObjectEditor<NetworkInterfaceConfiguration> editor = new ObjectEditor<NetworkInterfaceConfiguration>(networkInterfaceConfiguration);
            editor.Dock = DockStyle.Fill;
            editor.Bounds = panelObjectEditor.Bounds;
            Editor = editor;
            this.Controls.Add(editor);
            this.Controls.Remove(panelObjectEditor);
        }

        public FormEditNetworkConfiguration(BindingList<NetworkInterfaceConfiguration> toAddTo)
        {
            this.networkInterfaceConfiguration = new NetworkInterfaceConfiguration();
            ToAddTo = toAddTo;
            init();
            this.Text = "Add Configuration";
            this.Icon = Resources.addIcon;
            this.buttonAdd.Visible = true;
            this.buttonEdit.Visible = false;
        }

        public FormEditNetworkConfiguration(NetworkInterfaceConfiguration networkInterfaceConfiguration)
        {
            this.networkInterfaceConfigurationToEdit = networkInterfaceConfiguration;
            this.networkInterfaceConfiguration = networkInterfaceConfiguration.ShallowCopy();
            init();
            this.Text = "Edit Configuration";
            this.Icon = Resources.editIcon;
            this.buttonAdd.Visible = false;
            this.buttonEdit.Visible = true;
        }

        private void FormEditNetworkConfiguration_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            this.networkInterfaceConfigurationToEdit.Override(networkInterfaceConfiguration);
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ToAddTo.Add(networkInterfaceConfiguration);
            this.Close();
        }

    }
}
