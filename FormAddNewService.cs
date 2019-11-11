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
    public partial class FormAddNewService : Form
    {
        private DataStore dataStore;
        private Service service;

        public FormAddNewService(DataStore dataStore)
        {
            this.dataStore = dataStore;
            InitializeComponent();
        }

        public FormAddNewService(DataStore dataStore, Service serviceForEdit)
        {
            this.service = serviceForEdit;
            this.dataStore = dataStore;
            InitializeComponent();
            txtdisc.Text = service.Description;
            txtid.Text = service.IdNumber.ToString();
            txtid.ReadOnly = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(service != null)
            {
                foreach (Service item in dataStore.Services)
                {
                    if(item.IdNumber == service.IdNumber)
                    {
                        dataStore.Services.Remove(item);
                        break;
                    }
                }
            }

            int idnumber =Convert.ToInt32( txtid.Text);
            string description = txtdisc.Text;

            Service temp = new Service(idnumber, description);

            dataStore.Services.Add(temp);
            
            MessageBox.Show("Success: " + idnumber + "service added!");
            if(service != null)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdisc.Text = "";
            txtid.Text = "";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormMain.frmkeepmain.Show();
            this.Close();
        }

        private void FormAddNewService_Load(object sender, EventArgs e)
        {

        }
    }
}
