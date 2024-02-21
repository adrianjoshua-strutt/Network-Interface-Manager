namespace NetworkInterface_Manager
{
    partial class TabPageNetworkInterface
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxInterfaceInformation = new System.Windows.Forms.GroupBox();
            this.groupBoxInterfaceConfiguration = new System.Windows.Forms.GroupBox();
            this.labelValueGateway = new System.Windows.Forms.Label();
            this.labelValueSubnetMask = new System.Windows.Forms.Label();
            this.labelValueIPAddress = new System.Windows.Forms.Label();
            this.labelGateway = new System.Windows.Forms.Label();
            this.labelSubnetMask = new System.Windows.Forms.Label();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.labelValueDHCP = new System.Windows.Forms.Label();
            this.labelValueState = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelValueMtu = new System.Windows.Forms.Label();
            this.labelValueMet = new System.Windows.Forms.Label();
            this.labelValueIDX = new System.Windows.Forms.Label();
            this.labelMtu = new System.Windows.Forms.Label();
            this.labelMet = new System.Windows.Forms.Label();
            this.labelIDX = new System.Windows.Forms.Label();
            this.labelValueName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridViewNetworkInterfacesConfigs = new System.Windows.Forms.DataGridView();
            this.contextMenuStripItemSelected = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSplitter = new System.Windows.Forms.Label();
            this.labelDNS = new System.Windows.Forms.Label();
            this.labelValueDNS = new System.Windows.Forms.Label();
            this.groupBoxInterfaceInformation.SuspendLayout();
            this.groupBoxInterfaceConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNetworkInterfacesConfigs)).BeginInit();
            this.contextMenuStripItemSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInterfaceInformation
            // 
            this.groupBoxInterfaceInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInterfaceInformation.Controls.Add(this.groupBoxInterfaceConfiguration);
            this.groupBoxInterfaceInformation.Controls.Add(this.labelValueState);
            this.groupBoxInterfaceInformation.Controls.Add(this.labelState);
            this.groupBoxInterfaceInformation.Controls.Add(this.labelValueMtu);
            this.groupBoxInterfaceInformation.Controls.Add(this.labelValueMet);
            this.groupBoxInterfaceInformation.Controls.Add(this.labelValueIDX);
            this.groupBoxInterfaceInformation.Controls.Add(this.labelMtu);
            this.groupBoxInterfaceInformation.Controls.Add(this.labelMet);
            this.groupBoxInterfaceInformation.Controls.Add(this.labelIDX);
            this.groupBoxInterfaceInformation.Controls.Add(this.labelValueName);
            this.groupBoxInterfaceInformation.Controls.Add(this.labelName);
            this.groupBoxInterfaceInformation.Location = new System.Drawing.Point(3, 32);
            this.groupBoxInterfaceInformation.Name = "groupBoxInterfaceInformation";
            this.groupBoxInterfaceInformation.Size = new System.Drawing.Size(215, 320);
            this.groupBoxInterfaceInformation.TabIndex = 0;
            this.groupBoxInterfaceInformation.TabStop = false;
            this.groupBoxInterfaceInformation.Text = "Interface Information";
            this.groupBoxInterfaceInformation.Enter += new System.EventHandler(this.groupBoxInterfaceInformation_Enter);
            // 
            // groupBoxInterfaceConfiguration
            // 
            this.groupBoxInterfaceConfiguration.Controls.Add(this.labelValueDNS);
            this.groupBoxInterfaceConfiguration.Controls.Add(this.labelDNS);
            this.groupBoxInterfaceConfiguration.Controls.Add(this.labelValueGateway);
            this.groupBoxInterfaceConfiguration.Controls.Add(this.labelValueSubnetMask);
            this.groupBoxInterfaceConfiguration.Controls.Add(this.labelValueIPAddress);
            this.groupBoxInterfaceConfiguration.Controls.Add(this.labelGateway);
            this.groupBoxInterfaceConfiguration.Controls.Add(this.labelSubnetMask);
            this.groupBoxInterfaceConfiguration.Controls.Add(this.labelIPAddress);
            this.groupBoxInterfaceConfiguration.Controls.Add(this.labelValueDHCP);
            this.groupBoxInterfaceConfiguration.Location = new System.Drawing.Point(10, 140);
            this.groupBoxInterfaceConfiguration.Name = "groupBoxInterfaceConfiguration";
            this.groupBoxInterfaceConfiguration.Size = new System.Drawing.Size(199, 126);
            this.groupBoxInterfaceConfiguration.TabIndex = 2;
            this.groupBoxInterfaceConfiguration.TabStop = false;
            this.groupBoxInterfaceConfiguration.Text = "Configuration";
            // 
            // labelValueGateway
            // 
            this.labelValueGateway.AutoSize = true;
            this.labelValueGateway.Location = new System.Drawing.Point(85, 81);
            this.labelValueGateway.Name = "labelValueGateway";
            this.labelValueGateway.Size = new System.Drawing.Size(16, 13);
            this.labelValueGateway.TabIndex = 16;
            this.labelValueGateway.Text = "...";
            // 
            // labelValueSubnetMask
            // 
            this.labelValueSubnetMask.AutoSize = true;
            this.labelValueSubnetMask.Location = new System.Drawing.Point(85, 60);
            this.labelValueSubnetMask.Name = "labelValueSubnetMask";
            this.labelValueSubnetMask.Size = new System.Drawing.Size(16, 13);
            this.labelValueSubnetMask.TabIndex = 15;
            this.labelValueSubnetMask.Text = "...";
            // 
            // labelValueIPAddress
            // 
            this.labelValueIPAddress.AutoSize = true;
            this.labelValueIPAddress.Location = new System.Drawing.Point(85, 39);
            this.labelValueIPAddress.Name = "labelValueIPAddress";
            this.labelValueIPAddress.Size = new System.Drawing.Size(16, 13);
            this.labelValueIPAddress.TabIndex = 14;
            this.labelValueIPAddress.Text = "...";
            // 
            // labelGateway
            // 
            this.labelGateway.AutoSize = true;
            this.labelGateway.Location = new System.Drawing.Point(6, 81);
            this.labelGateway.Name = "labelGateway";
            this.labelGateway.Size = new System.Drawing.Size(52, 13);
            this.labelGateway.TabIndex = 13;
            this.labelGateway.Text = "Gateway:";
            // 
            // labelSubnetMask
            // 
            this.labelSubnetMask.AutoSize = true;
            this.labelSubnetMask.Location = new System.Drawing.Point(5, 60);
            this.labelSubnetMask.Name = "labelSubnetMask";
            this.labelSubnetMask.Size = new System.Drawing.Size(73, 13);
            this.labelSubnetMask.TabIndex = 12;
            this.labelSubnetMask.Text = "Subnet Mask:";
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Location = new System.Drawing.Point(6, 39);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(61, 13);
            this.labelIPAddress.TabIndex = 11;
            this.labelIPAddress.Text = "IP-Address:";
            // 
            // labelValueDHCP
            // 
            this.labelValueDHCP.AutoSize = true;
            this.labelValueDHCP.Location = new System.Drawing.Point(6, 16);
            this.labelValueDHCP.Name = "labelValueDHCP";
            this.labelValueDHCP.Size = new System.Drawing.Size(16, 13);
            this.labelValueDHCP.TabIndex = 10;
            this.labelValueDHCP.Text = "...";
            // 
            // labelValueState
            // 
            this.labelValueState.AutoSize = true;
            this.labelValueState.Location = new System.Drawing.Point(50, 115);
            this.labelValueState.Name = "labelValueState";
            this.labelValueState.Size = new System.Drawing.Size(16, 13);
            this.labelValueState.TabIndex = 9;
            this.labelValueState.Text = "...";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(7, 115);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(35, 13);
            this.labelState.TabIndex = 8;
            this.labelState.Text = "State:";
            // 
            // labelValueMtu
            // 
            this.labelValueMtu.AutoSize = true;
            this.labelValueMtu.Location = new System.Drawing.Point(50, 93);
            this.labelValueMtu.Name = "labelValueMtu";
            this.labelValueMtu.Size = new System.Drawing.Size(16, 13);
            this.labelValueMtu.TabIndex = 7;
            this.labelValueMtu.Text = "...";
            // 
            // labelValueMet
            // 
            this.labelValueMet.AutoSize = true;
            this.labelValueMet.Location = new System.Drawing.Point(50, 71);
            this.labelValueMet.Name = "labelValueMet";
            this.labelValueMet.Size = new System.Drawing.Size(16, 13);
            this.labelValueMet.TabIndex = 6;
            this.labelValueMet.Text = "...";
            // 
            // labelValueIDX
            // 
            this.labelValueIDX.AutoSize = true;
            this.labelValueIDX.Location = new System.Drawing.Point(50, 48);
            this.labelValueIDX.Name = "labelValueIDX";
            this.labelValueIDX.Size = new System.Drawing.Size(16, 13);
            this.labelValueIDX.TabIndex = 5;
            this.labelValueIDX.Text = "...";
            // 
            // labelMtu
            // 
            this.labelMtu.AutoSize = true;
            this.labelMtu.Location = new System.Drawing.Point(7, 93);
            this.labelMtu.Name = "labelMtu";
            this.labelMtu.Size = new System.Drawing.Size(28, 13);
            this.labelMtu.TabIndex = 4;
            this.labelMtu.Text = "Mtu:";
            // 
            // labelMet
            // 
            this.labelMet.AutoSize = true;
            this.labelMet.Location = new System.Drawing.Point(7, 71);
            this.labelMet.Name = "labelMet";
            this.labelMet.Size = new System.Drawing.Size(28, 13);
            this.labelMet.TabIndex = 3;
            this.labelMet.Text = "Met:";
            // 
            // labelIDX
            // 
            this.labelIDX.AutoSize = true;
            this.labelIDX.Location = new System.Drawing.Point(7, 48);
            this.labelIDX.Name = "labelIDX";
            this.labelIDX.Size = new System.Drawing.Size(29, 13);
            this.labelIDX.TabIndex = 2;
            this.labelIDX.Text = "IDx: ";
            // 
            // labelValueName
            // 
            this.labelValueName.AutoSize = true;
            this.labelValueName.Location = new System.Drawing.Point(50, 26);
            this.labelValueName.Name = "labelValueName";
            this.labelValueName.Size = new System.Drawing.Size(16, 13);
            this.labelValueName.TabIndex = 1;
            this.labelValueName.Text = "...";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // dataGridViewNetworkInterfacesConfigs
            // 
            this.dataGridViewNetworkInterfacesConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNetworkInterfacesConfigs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNetworkInterfacesConfigs.ContextMenuStrip = this.contextMenuStripItemSelected;
            this.dataGridViewNetworkInterfacesConfigs.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewNetworkInterfacesConfigs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewNetworkInterfacesConfigs.Location = new System.Drawing.Point(224, 38);
            this.dataGridViewNetworkInterfacesConfigs.Name = "dataGridViewNetworkInterfacesConfigs";
            this.dataGridViewNetworkInterfacesConfigs.ReadOnly = true;
            this.dataGridViewNetworkInterfacesConfigs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNetworkInterfacesConfigs.Size = new System.Drawing.Size(417, 314);
            this.dataGridViewNetworkInterfacesConfigs.TabIndex = 1;
            this.dataGridViewNetworkInterfacesConfigs.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNetworkInterfacesConfigs_CellContentDoubleClick);
            this.dataGridViewNetworkInterfacesConfigs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNetworkInterfacesConfigs_CellDoubleClick);
            this.dataGridViewNetworkInterfacesConfigs.SelectionChanged += new System.EventHandler(this.dataGridViewNetworkInterfacesConfigs_SelectionChanged);
            this.dataGridViewNetworkInterfacesConfigs.DoubleClick += new System.EventHandler(this.dataGridViewNetworkInterfacesConfigs_DoubleClick);
            // 
            // contextMenuStripItemSelected
            // 
            this.contextMenuStripItemSelected.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripSeparator1,
            this.applyToolStripMenuItem});
            this.contextMenuStripItemSelected.Name = "contextMenuStripItemSelected";
            this.contextMenuStripItemSelected.Size = new System.Drawing.Size(108, 98);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::NetworkInterface_Manager.Properties.Resources.add;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add...";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::NetworkInterface_Manager.Properties.Resources.delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::NetworkInterface_Manager.Properties.Resources.edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // applyToolStripMenuItem
            // 
            this.applyToolStripMenuItem.Image = global::NetworkInterface_Manager.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
            this.applyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.applyToolStripMenuItem.Text = "Apply";
            this.applyToolStripMenuItem.Click += new System.EventHandler(this.applyToolStripMenuItem_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Image = global::NetworkInterface_Manager.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.buttonApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApply.Location = new System.Drawing.Point(3, 3);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(60, 23);
            this.buttonApply.TabIndex = 5;
            this.buttonApply.Text = "Apply";
            this.buttonApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = global::NetworkInterface_Manager.Properties.Resources.edit;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(220, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(60, 23);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edit...";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = global::NetworkInterface_Manager.Properties.Resources.delete;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(150, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(64, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::NetworkInterface_Manager.Properties.Resources.add;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(84, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(60, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add...";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelSplitter
            // 
            this.labelSplitter.AutoSize = true;
            this.labelSplitter.Location = new System.Drawing.Point(69, 8);
            this.labelSplitter.Name = "labelSplitter";
            this.labelSplitter.Size = new System.Drawing.Size(9, 13);
            this.labelSplitter.TabIndex = 6;
            this.labelSplitter.Text = "|";
            // 
            // labelDNS
            // 
            this.labelDNS.AutoSize = true;
            this.labelDNS.Location = new System.Drawing.Point(6, 103);
            this.labelDNS.Name = "labelDNS";
            this.labelDNS.Size = new System.Drawing.Size(33, 13);
            this.labelDNS.TabIndex = 17;
            this.labelDNS.Text = "DNS:";
            // 
            // labelValueDNS
            // 
            this.labelValueDNS.AutoSize = true;
            this.labelValueDNS.Location = new System.Drawing.Point(85, 103);
            this.labelValueDNS.Name = "labelValueDNS";
            this.labelValueDNS.Size = new System.Drawing.Size(16, 13);
            this.labelValueDNS.TabIndex = 18;
            this.labelValueDNS.Text = "...";
            // 
            // TabPageNetworkInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSplitter);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewNetworkInterfacesConfigs);
            this.Controls.Add(this.groupBoxInterfaceInformation);
            this.Name = "TabPageNetworkInterface";
            this.Size = new System.Drawing.Size(644, 355);
            this.Load += new System.EventHandler(this.TabPageNetworkInterface_Load);
            this.groupBoxInterfaceInformation.ResumeLayout(false);
            this.groupBoxInterfaceInformation.PerformLayout();
            this.groupBoxInterfaceConfiguration.ResumeLayout(false);
            this.groupBoxInterfaceConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNetworkInterfacesConfigs)).EndInit();
            this.contextMenuStripItemSelected.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInterfaceInformation;
        private System.Windows.Forms.Label labelValueName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelValueIDX;
        private System.Windows.Forms.Label labelMtu;
        private System.Windows.Forms.Label labelMet;
        private System.Windows.Forms.Label labelIDX;
        private System.Windows.Forms.Label labelValueMtu;
        private System.Windows.Forms.Label labelValueMet;
        private System.Windows.Forms.Label labelValueState;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.GroupBox groupBoxInterfaceConfiguration;
        private System.Windows.Forms.Label labelSubnetMask;
        private System.Windows.Forms.Label labelIPAddress;
        private System.Windows.Forms.Label labelValueDHCP;
        private System.Windows.Forms.Label labelGateway;
        private System.Windows.Forms.Label labelValueIPAddress;
        private System.Windows.Forms.Label labelValueSubnetMask;
        private System.Windows.Forms.Label labelValueGateway;
        private System.Windows.Forms.DataGridView dataGridViewNetworkInterfacesConfigs;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripItemSelected;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label labelSplitter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
        private System.Windows.Forms.Label labelValueDNS;
        private System.Windows.Forms.Label labelDNS;
    }
}
