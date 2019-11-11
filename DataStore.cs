using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wirginmediacw2
{
    public class DataStore
    {
        public ArrayList Customers{ get; set; }
        public ArrayList Services { get; set; }

        public DataStore()
        {
            Services = new ArrayList();
            Customers = new ArrayList();
        }

        public void ImportData(string filename)
        {
            String[] dataLines =File.ReadAllLines(filename);
            List<Customer> initialCustomerList = GetCustomersFromStringArray(dataLines);
            Customers.AddRange(initialCustomerList);            
        }

        public List<Customer> GetCustomersFromStringArray(string[] dataLines)
        {
            List<Customer> customers = new List<Customer>();
            int currentLine = 0;
            try
            {
                if (dataLines.Count() > 0)
                {
                    while (currentLine < dataLines.Count())
                    {
                        Customer newCustomer = CreateNewCustomer(currentLine, dataLines);
                        currentLine = currentLine + GetNumberOfLines(newCustomer);
                        customers.Add(newCustomer);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return customers;
        }

        private int GetNumberOfLines(Customer newCustomer)
        {
            return 6 + (newCustomer.NumberOfServices * 5);
        }

        private Customer CreateNewCustomer(int currentLine, string[] dataLines)
        {
            int customerId = Convert.ToInt32(dataLines[currentLine + 0]);
            string firstname = dataLines[currentLine + 1];
            string surname = dataLines[currentLine + 2];
            string address = dataLines[currentLine + 3];
            string postcode = dataLines[currentLine + 4];
            int noservices = Convert.ToInt32(dataLines[currentLine + 5]);
            Customer newCustomer = new Customer();
            newCustomer.IdNumber = customerId;
            newCustomer.Firstname = firstname;
            newCustomer.Surname = surname;
            newCustomer.Address = address;
            newCustomer.Postcode = postcode;
            newCustomer.NumberOfServices = noservices;
            newCustomer.Services = new ArrayList(noservices);
            for (int i = 0; i < noservices; i++)
            {
                int serviceId = Convert.ToInt32(dataLines[currentLine + 6 + i * 5 + 0]);
                string serviceDescription = dataLines[currentLine + 6 + i * 5 + 1];
                DateTime serviceStart = GetDateTimeFromImportLine(dataLines[currentLine + 6 + i * 5 + 2]);
                DateTime serviceLastUpgraded = GetDateTimeFromImportLine(dataLines[currentLine + 6 + i * 5 + 3]);
                string serviceNotes = dataLines[currentLine + 6 + i * 5 + 4];
                Service newService = new Service();
                newService.IdNumber = serviceId;
                newService.Description = serviceDescription;
                newService.StartDate = serviceStart;
                newService.LastContacted = serviceLastUpgraded;
                newService.Notes = serviceNotes;
                newCustomer.Services.Add(newService);
                customerservice(newService);
            }
            return newCustomer;
        }

        private void customerservice(Service newService)
        {
            foreach (Service item in Services)
            {
               if (newService.Description==item.Description)
                {
                    return;
                }
               
            }
            Services.Add(newService);
        }

        private DateTime GetDateTimeFromImportLine(string v)
        {
            string[] dayMonthYear = v.Split(new char[] { '/' });
            return new DateTime(Convert.ToInt32(dayMonthYear[2]), Convert.ToInt32(dayMonthYear[1]), Convert.ToInt32(dayMonthYear[0]));
        }
        
    }
}
