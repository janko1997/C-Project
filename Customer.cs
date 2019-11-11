using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace wirginmediacw2
{
    public class Customer
    {
        public int IdNumber { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public int NumberOfServices { get; set; }
        public ArrayList Services { get; set; }

        public Customer()
        {
            
        }

        public Customer( string thepostcode, string thenumofserv, string theID, string thefirstname, string thesurname, string theaddress)
        {            
            Postcode = thepostcode;
            setnumofserv(thenumofserv);
            setIdnumber(theID);
            Firstname= thefirstname;
            Surname = thesurname;
            Address = theaddress;
            Services = new ArrayList();
        }

        public string GetUserFriendlyString()
        {
            return $"Firstname:{ Firstname} LastName:{Surname}" ;
        }

        public override string ToString()
        {
            return $"Firstname:{ Firstname} LastName:{Surname} Address:{Address} Postcode:{Postcode}";
        }


        //getters:
        public string getPostcode()
        {
            return Postcode;
        }
        public int getnumofserv()
        {
            return NumberOfServices;
        }
        public ArrayList getService()
        {
            return Services;
        }
        public int getID()
        {
            return IdNumber;
        }
        public string getfirstname()
        {
            return Firstname;
        }
        public string getsurname()
        {
            return Surname;
        }
        public string getaddress()
        {
            return Address;
        }
        //setters:
        public void setpostcode(string inpostcode)
        {
            Postcode = inpostcode;
        }
        public void setnumofserv(string innumofserv)
        {
            NumberOfServices = Convert.ToInt32(innumofserv);
        }
        public void setservice(ArrayList inservice)
        {
           Services = inservice;
        }
        public void setIdnumber(string inIdnumber)
        {
            IdNumber = Convert.ToInt32(inIdnumber);
        }
        public void setFirstname(string inFirstname)
        {
            Firstname = inFirstname;
        }
        public void setSurname(string inSurname)
        {
            Surname = inSurname;
        }
        public void setAdress(string inAddress)
        {
            Address = inAddress;
        }
    }
} 
    
