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
    public partial class FormSearchServices : Form
    {
        private DataStore dataStore;

        public FormSearchServices(DataStore dataStore)
        {
            this.dataStore = dataStore;
            InitializeComponent();
        }

        private void FormSearchServices_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            List<Service> foundCustomers = new List<Service>();
            foreach (Service current in dataStore.Services)
            {
                if ((!string.IsNullOrWhiteSpace(txtid.Text) && current.IdNumber == Convert.ToInt32(txtid.Text)) ||
                    (!string.IsNullOrWhiteSpace(txtdisc.Text) && current.Description.Contains(txtdisc.Text)))
                {
                    foundCustomers.Add(current);
                }
            }
            dataGridView2.DataSource = foundCustomers;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtdisc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtdisc.Text = "";
            txtid.Text = "";
            dataGridView2.DataSource = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormMain.frmkeepmain.Show();
            this.Close();
        }
    }
}
