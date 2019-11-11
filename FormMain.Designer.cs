namespace wirginmediacw2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upgradePackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Harlow Solid Italic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDataToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.servicesToolStripMenuItem,
            this.showCustomersToolStripMenuItem,
            this.showServicesToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(636, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(12, 28);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.searchCustomersToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(100, 28);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.addCustomerToolStripMenuItem.Text = "Add customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // searchCustomersToolStripMenuItem
            // 
            this.searchCustomersToolStripMenuItem.Name = "searchCustomersToolStripMenuItem";
            this.searchCustomersToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.searchCustomersToolStripMenuItem.Text = "Search customers";
            this.searchCustomersToolStripMenuItem.Click += new System.EventHandler(this.searchCustomersToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addServiceToolStripMenuItem,
            this.searchServicesToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // addServiceToolStripMenuItem
            // 
            this.addServiceToolStripMenuItem.Name = "addServiceToolStripMenuItem";
            this.addServiceToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.addServiceToolStripMenuItem.Text = "Add service";
            this.addServiceToolStripMenuItem.Click += new System.EventHandler(this.addServiceToolStripMenuItem_Click);
            // 
            // searchServicesToolStripMenuItem
            // 
            this.searchServicesToolStripMenuItem.Name = "searchServicesToolStripMenuItem";
            this.searchServicesToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.searchServicesToolStripMenuItem.Text = "Search services";
            this.searchServicesToolStripMenuItem.Click += new System.EventHandler(this.searchServicesToolStripMenuItem_Click);
            // 
            // showCustomersToolStripMenuItem
            // 
            this.showCustomersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCustomerToolStripMenuItem,
            this.upgradePackageToolStripMenuItem});
            this.showCustomersToolStripMenuItem.Name = "showCustomersToolStripMenuItem";
            this.showCustomersToolStripMenuItem.Size = new System.Drawing.Size(142, 28);
            this.showCustomersToolStripMenuItem.Text = "Show customers";
            this.showCustomersToolStripMenuItem.Click += new System.EventHandler(this.showCustomersToolStripMenuItem_Click);
            // 
            // editCustomerToolStripMenuItem
            // 
            this.editCustomerToolStripMenuItem.Name = "editCustomerToolStripMenuItem";
            this.editCustomerToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.editCustomerToolStripMenuItem.Text = "Edit Customer";
            this.editCustomerToolStripMenuItem.Click += new System.EventHandler(this.editCustomerToolStripMenuItem_Click);
            // 
            // upgradePackageToolStripMenuItem
            // 
            this.upgradePackageToolStripMenuItem.Name = "upgradePackageToolStripMenuItem";
            this.upgradePackageToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.upgradePackageToolStripMenuItem.Text = "Upgrade package";
            this.upgradePackageToolStripMenuItem.Click += new System.EventHandler(this.upgradePackageToolStripMenuItem_Click);
            // 
            // showServicesToolStripMenuItem
            // 
            this.showServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editServicesToolStripMenuItem});
            this.showServicesToolStripMenuItem.Name = "showServicesToolStripMenuItem";
            this.showServicesToolStripMenuItem.Size = new System.Drawing.Size(124, 28);
            this.showServicesToolStripMenuItem.Text = "Show services";
            // 
            // editServicesToolStripMenuItem
            // 
            this.editServicesToolStripMenuItem.Name = "editServicesToolStripMenuItem";
            this.editServicesToolStripMenuItem.Size = new System.Drawing.Size(176, 28);
            this.editServicesToolStripMenuItem.Text = "Edit services";
            this.editServicesToolStripMenuItem.Click += new System.EventHandler(this.editServicesToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 362);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "WirginiMedia";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upgradePackageToolStripMenuItem;
    }
}

