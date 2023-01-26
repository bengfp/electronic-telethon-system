using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSClassLibrary
{
    class Sponsor : Person
    {
        string sponsorID;
        double totalPrizeValue;

        public Sponsor(string SID, double tpv, string firstName, string lastName) : base(firstName, lastName)
        {
            this.sponsorID = SID;
            this.totalPrizeValue = tpv;
        }

        public string SponsorID
        {
            get { return sponsorID; }
            set { sponsorID = value; }
        }
        public double TotalPrizeValue {
            get { return totalPrizeValue; }
            set { totalPrizeValue = value; }
        }

        public override string toString()
        {
            return "Sponsor ID: " + this.sponsorID +"\n" + base.toString() + "\nTotal Prize Value: " 
                        + this.totalPrizeValue;
        }

        public string getID()
        {
            return SponsorID;
        }

        public double addValue(double val)
        {
            return this.totalPrizeValue += val;
        }

        public double calcTotalPrizeValue(double val, int qty)
        {
            return this.totalPrizeValue = val * qty;
        }
    }
}
