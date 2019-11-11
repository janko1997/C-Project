using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wirginmediacw2
{
    public partial class FormMain : Form
    {
        public static FormMain frmkeepmain = null;

        private DataStore dataStore = new DataStore();
        public FormMain()
        {
            InitializeComponent();
            frmkeepmain = this;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataStore.ImportData(@"WirginData.txt");
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewCustomer newCustomer = new FormNewCustomer(dataStore);
            newCustomer.ShowDialog();

        }

        private void searchCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formsearchcustomer newCustomer = new Formsearchcustomer(dataStore);
            newCustomer.ShowDialog();
        }

        private void addServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddNewService newCustomer = new FormAddNewService(dataStore);
            newCustomer.ShowDialog();
        }

        private void searchServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchServices newCustomer = new FormSearchServices(dataStore);
            newCustomer.ShowDialog();
        }

        private void showCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditCustomer newCustomer = new FormEditCustomer(dataStore);
            newCustomer.ShowDialog();
        }

        private void editServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditService newService = new FormEditService(dataStore);
            newService.ShowDialog();
        }

        private void upgradePackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomerSupport customerSupport = new FormCustomerSupport(dataStore);
            customerSupport.ShowDialog();
        }

        private void upgradePackageListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}