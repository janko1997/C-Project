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
    public partial class FormNewCustomer : Form
    {
        private DataStore dataStore;
        private Customer customerForEdit;
        private ArrayList services;

        // This is constructor we use from FormMain when we want to create new Customers, since we DO NOT pass
        // any Customer, we are adding the new ones, and customerForEdit variable stays null
        public FormNewCustomer(DataStore dataStore)
        {
            this.dataStore = dataStore;
            InitializeComponent();
            listAllServices.DataSource = dataStore.Services;
            services = new ArrayList();
            RefreshCustomerServices();
        }

        // This is constructor we use for Editing of the customers, and we use it from formsearchcustomer form.
        // In this constructor we pass the customerPassedForEditing value, and we use the data from this customer to fill
        // text boxes in the form, and we also set private variable customerForEdit to the passed value.
        public FormNewCustomer(DataStore dataStore, Customer customerPassedForEditing)
        {
            this.customerForEdit = customerPassedForEditing;
            this.dataStore = dataStore;
            InitializeComponent();
            listAllServices.DataSource = dataStore.Services;
            txtID.Text = customerForEdit.IdNumber.ToString();
            txtID.ReadOnly = true;
            txtfn.Text = customerForEdit.Firstname.ToString();
            txtsur.Text = customerForEdit.Surname.ToString();
            txtaddress.Text = customerForEdit.Address.ToString();
            txtpostcode.Text = customerForEdit.Postcode.ToString();
            txtnumserv.Text = customerForEdit.NumberOfServices.ToString();
            services = customerForEdit.Services;
            RefreshCustomerServices();
        }       

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            // delete previous object with the same ID
            if (customerForEdit != null)
            {
                
                foreach (Customer item in dataStore.Customers)
                {
                    // comparing IDs
                    if (item.IdNumber == customerForEdit.IdNumber)
                    {
                        // If the ID match, we remove the customer from the list of customers
                        dataStore.Customers.Remove(item);
                        // To prevent failure during enumeration in Customers, we break from foreach loop
                        break;
                    }
                }
            }
            //get inputs
            string IDnumber = txtID.Text;
            string FirstName = txtfn.Text;
            string Surname = txtsur.Text;
            string address = txtaddress.Text;
            string postcode = txtpostcode.Text;
            string NumberOfServices = txtnumserv.Text;

            //create book
            Customer temp = new Customer(postcode, services.Count.ToString(), IDnumber, FirstName, Surname, address);

            temp.Services = new ArrayList(services);

            //add to array
            dataStore.Customers.Add(temp);


            // Cleanup after adding one user
            services = new ArrayList();
            RefreshCustomerServices();

            //finish 
            MessageBox.Show("Success: " + FirstName + " added!");

            //close the form when we update the customer data.
          
            if (customerForEdit!=null)
            {
                Close();
            }
            
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtaddress.Text = "";
            txtfn.Text = "";
            txtID.Text = "";
            txtnumserv.Text = "";
            txtpostcode.Text = "";
            txtsur.Text = "";
            listCustomerServices.Items.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormMain.frmkeepmain.Show();
            this.Close();
        }

        private void btnAddToCustomer_Click(object sender, EventArgs e)
        {
            Service serviceTemplate = listAllServices.SelectedValue as Service;
            foreach (Service item in services)
            {
                if(serviceTemplate.Description == item.Description)
                {
                    return;
                }
            }
            Service newService = new Service();
            newService.Description = serviceTemplate.Description;
            newService.IdNumber = serviceTemplate.IdNumber;
            newService.LastContacted = DateTime.Now;
            newService.StartDate = DateTime.Now;
            services.Add(newService);
            RefreshCustomerServices();
        }

        private void btnRemoveFromCustomer_Click(object sender, EventArgs e)
        {
            Service newService = listCustomerServices.SelectedValue as Service;
            foreach (Service item in services)
            {
                if (newService.Description == item.Description)
                {
                    services.Remove(item);
                    RefreshCustomerServices();
                    return;
                }
            }
        }

        private void RefreshCustomerServices()
        {
            ArrayList custServices = new ArrayList();
            foreach (Service item in services)
            {
                custServices.Add(item.ToStringWithDateTime());
            }
            listCustomerServices.DataSource = null;
            listCustomerServices.DataSource = custServices;
            txtnumserv.Text = services.Count.ToString();
        }

        private void FormNewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void listCustomerServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
