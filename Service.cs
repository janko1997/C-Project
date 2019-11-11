using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wirginmediacw2
{
    public class Service
    {
        public int IdNumber { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastContacted { get; set; }
        public string Notes { get; set; }

        public Service()
        {

        }

        public Service(int theidnumber,string thedescription)
        {
            Description = thedescription;
            IdNumber = theidnumber;
        }

        public override string ToString()
        {
            return Description;
        }

        public string ToStringWithDateTime()
        {
           return String.Format("{0} - {1} - {2}", Description, StartDate.ToShortDateString(), LastContacted.ToShortDateString());
        }

        //getters

        public int getidnumber()
        {
            return IdNumber;
        }

        public string getdiscription()
        {
            return Description;
        }

        public DateTime getstartdate()
        {
            return StartDate;
        }

        public DateTime getlastcontacted()
        {
            return LastContacted;
        }
        public string getnotes()
        {
            return Notes;
        }

        //setters:

        public void setidnumber(int inidnumber)
        {
            IdNumber = inidnumber;
        }
        public void setdescription(string indescription)
        {
            Description = indescription;
        }
        public void setstartdate(DateTime instartdate)
        {
            StartDate = instartdate;
        }
        public void setlastcontacted(DateTime inlastcontacted)
        {
            LastContacted = inlastcontacted;
        }
        public void setnotes(string innotes)
        {
            Notes = innotes; 
        }
    }
}
