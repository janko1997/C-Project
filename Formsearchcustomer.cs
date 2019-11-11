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
    public partial class Formsearchcustomer : Form
    {
        private DataStore dataStore;

        public Formsearchcustomer(DataStore dataStore)
        {
            this.dataStore = dataStore;
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            List<Customer> foundCustomers = new List<Customer>();
            foreach (Customer current in dataStore.Customers)
            {
                if ((!string.IsNullOrWhiteSpace(txtfirstname.Text) && current.Firstname.Contains(txtfirstname.Text)) ||
                    (!string.IsNullOrWhiteSpace(txtlastname.Text) && current.Surname.Contains(txtlastname.Text)))
                {
                    foundCustomers.Add(current);
                }
                else if ((!string.IsNullOrWhiteSpace(txtpostcode.Text) && current.Postcode.Contains(txtpostcode.Text)) ||
    (!string.IsNullOrWhiteSpace(txtaddress.Text) && current.Address.Contains(txtaddress.Text)))
                {
                    foundCustomers.Add(current);
                }

            }
            dataGridView1.DataSource = foundCustomers;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            resetForm();

        }

        private void resetForm()
        {
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtaddress.Text = "";
            txtpostcode.Text = "";
            dataGridView1.DataSource = "";

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormMain.frmkeepmain.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Formsearchcustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
