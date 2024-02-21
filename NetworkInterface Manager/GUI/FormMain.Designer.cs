namespace NetworkInterface_Manager
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlNetworkInterfaces = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tabControlNetworkInterfaces
            // 
            this.tabControlNetworkInterfaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlNetworkInterfaces.Location = new System.Drawing.Point(0, 0);
            this.tabControlNetworkInterfaces.Name = "tabControlNetworkInterfaces";
            this.tabControlNetworkInterfaces.SelectedIndex = 0;
            this.tabControlNetworkInterfaces.Size = new System.Drawing.Size(851, 426);
            this.tabControlNetworkInterfaces.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 426);
            this.Controls.Add(this.tabControlNetworkInterfaces);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Interface Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlNetworkInterfaces;
    }
}

