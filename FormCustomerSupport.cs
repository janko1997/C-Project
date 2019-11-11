using System;
using System.Collections;
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
    public partial class FormCustomerSupport : Form
    {
        private DataStore dataStore;

        public FormCustomerSupport(DataStore dataStore)
        {
            this.dataStore = dataStore;
            InitializeComponent();
            RefreshAll();
        }

        private void RefreshAll()
        {
            ArrayList customersForUpgrade = new ArrayList();
            foreach (Customer item in dataStore.Customers)
            {
                foreach (Service serviceOfCustomer in item.Services)
                {
                    if (DateTime.Now.Subtract(serviceOfCustomer.StartDate).TotalDays > 180)
                    {
                        if (DateTime.Now.Subtract(serviceOfCustomer.LastContacted).TotalDays > 30)
                        {
                            customersForUpgrade.Add(item);
                            break;
                        }
                    }
                }
            }
            listCustomersForUpgrade.DataSource = null;
            listCustomersForUpgrade.DataSource = customersForUpgrade;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            Customer customerForUpgrade = (listCustomersForUpgrade.SelectedValue as Customer);
            txtaddress.Text = customerForUpgrade.Address;
            txtID.Text = customerForUpgrade.IdNumber.ToString();
            txtfn.Text = customerForUpgrade.Firstname;
            txtsur.Text = customerForUpgrade.Surname;
            txtpostcode.Text = customerForUpgrade.Postcode;

            UpdateCustomerServices(customerForUpgrade);
        }

        private void UpdateCustomerServices(Customer customerForUpgrade)
        {
            ArrayList newPackageOffer = new ArrayList();
            foreach (Service item in customerForUpgrade.Services)
            {
                if (DateTime.Now.Subtract(item.StartDate).TotalDays > 180)
                {
                    if (DateTime.Now.Subtract(item.LastContacted).TotalDays > 30)
                    {
                        newPackageOffer.Add(item);
                    }
                }
            }
            listCustomerServices.DataSource = null;
            listCustomerServices.DataSource = newPackageOffer;
            RefreshServiceData(listCustomerServices.SelectedValue as Service);
        }

        private void listCustomerServices_Click(object sender, EventArgs e)
        {
            Service serviceForUpgrade = (listCustomerServices.SelectedValue as Service);
            RefreshServiceData(serviceForUpgrade);
        }

        private void RefreshServiceData(Service serviceForUpgrade)
        {
            if(serviceForUpgrade == null)
            {
                RefreshAll();
                return;
            }
            textServiceDateStart.Text = serviceForUpgrade.StartDate.ToShortDateString();
            textServiceLastContact.Text = serviceForUpgrade.LastContacted.ToShortDateString();
            textServiceDesc.Text = serviceForUpgrade.Description.ToString();
            textServiceId.Text = serviceForUpgrade.IdNumber.ToString();
            textServiceNotes.Text = serviceForUpgrade.Notes;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Service serviceForUpgrade = (listCustomerServices.SelectedValue as Service);
            serviceForUpgrade.Notes = textServiceNotes.Text;
            serviceForUpgrade.LastContacted = DateTime.Now;
            UpdateCustomerServices((listCustomersForUpgrade.SelectedValue as Customer));
        }

        private void FormCustomerSupport_Load(object sender, EventArgs e)
        {

        }

        private void listCustomersForUpgrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listCustomerServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormMain.frmkeepmain.Show();
            this.Close();
        }
    }
}
