using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace wirginmediacw2
{
    public partial class FormEditCustomer : Form
    {
        private DataStore dataStore;

        public FormEditCustomer(DataStore dataStore)
        {
            this.dataStore = dataStore;
            InitializeComponent();
        }

        private void FormEditCustomer_Load(object sender, EventArgs e)
        {
            // Uses ToString overriden method of the Customer class
            lstcustomers.DataSource = dataStore.Customers;
        }

        private void lstcustomers_Click(object sender, EventArgs e)
        {
            // We take currently selected value of the list, and cast it as a Customer
            // After casting it to Customer type, we get it's user friendly string by using method : GetUserFriendlyString()
            FormNewCustomer newCustomer = new FormNewCustomer(dataStore, (lstcustomers.SelectedValue as Customer));
            newCustomer.ShowDialog();
            lstcustomers.DataSource = null;
            lstcustomers.DataSource = dataStore.Customers;
        }

        private void lstcustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormMain.frmkeepmain.Show();
            this.Close();
        }
    }
}