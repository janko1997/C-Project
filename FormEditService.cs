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
    public partial class FormEditService : Form
    {
        private DataStore dataStore;

        public FormEditService(DataStore dataStore)
        {
            this.dataStore = dataStore;
            InitializeComponent();

            listServices.DataSource = dataStore.Services;
        }

        private void listServices_DoubleClick(object sender, EventArgs e)
        {
            FormAddNewService editService = new FormAddNewService(dataStore, listServices.SelectedValue as Service);
            editService.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Service newService = listServices.SelectedValue as Service;

            foreach (Service item in dataStore.Services)
            {
                if (newService.IdNumber == item.IdNumber)
                {
                    dataStore.Services.Remove(item);

                    listServices.DataSource = null;
                    listServices.DataSource = dataStore.Services;
                    return;
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormMain.frmkeepmain.Show();
            this.Close();
        }

        private void FormEditService_Load(object sender, EventArgs e)
        {

        }
    }
}
