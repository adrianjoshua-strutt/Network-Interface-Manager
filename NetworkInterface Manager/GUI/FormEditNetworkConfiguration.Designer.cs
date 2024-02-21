namespace NetworkInterface_Manager.GUI
{
    partial class FormEditNetworkConfiguration
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditNetworkConfiguration));
            this.panelObjectEditor = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelObjectEditor
            // 
            this.panelObjectEditor.Location = new System.Drawing.Point(12, 12);
            this.panelObjectEditor.Name = "panelObjectEditor";
            this.panelObjectEditor.Size = new System.Drawing.Size(321, 159);
            this.panelObjectEditor.TabIndex = 0;
            this.panelObjectEditor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelObjectEditor_Paint);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = global::NetworkInterface_Manager.Properties.Resources.edit;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(214, 177);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(53, 23);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Image = global::NetworkInterface_Manager.Properties.Resources.delete;
            this.buttonAbort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbort.Location = new System.Drawing.Point(273, 177);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(60, 23);
            this.buttonAbort.TabIndex = 3;
            this.buttonAbort.Text = "Abort";
            this.buttonAbort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::NetworkInterface_Manager.Properties.Resources.add;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(214, 177);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(53, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormEditNetworkConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 207);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelObjectEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditNetworkConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Configuration";
            this.Load += new System.EventHandler(this.FormEditNetworkConfiguration_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelObjectEditor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Button buttonEdit;
    }
}