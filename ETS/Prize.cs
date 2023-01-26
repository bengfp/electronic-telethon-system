using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSClassLibrary
{
    class Prize
    {
        string prizeID;
        string description;
        double val;
        double donationLimit;
        int originalAvailable;
        int currentAvailable;
        string sponsorID;

        public Prize(string pID, string desc, double val, double dLimit, 
                        int origlAvail, int curAvail, string sID)
        {
            this.prizeID = pID;
            this.description = desc;
            this.val = val;
            this.donationLimit = dLimit;
            this.originalAvailable = origlAvail;
            this.currentAvailable = curAvail;
            this.sponsorID = sID;
        }

        public Prize(string pID, string desc, double v, double dLimit, int origAvail, string sID)
        {
            this.prizeID = pID;
            this.description = desc;
            this.val = v;
            this.donationLimit = dLimit;
            this.originalAvailable = origAvail;
            this.sponsorID = sID;
        }

        public string PrizeID { 
            get { return prizeID; }
            set { prizeID = value; }
        }
        public string Description { 
            get { return description; }
            set { description = value; }
        }
        public double Val {
            get { return val; }
            set { val = value; } 
        }
        public double DonationLimit
        {
            get { return donationLimit; }
            set { donationLimit = value; }
        }
        public int OriginalAvailable {
            get { return originalAvailable; }
            set { originalAvailable = value; } 
        }
        public int CurrentAvailable {
            get { return currentAvailable; }
            set { currentAvailable = value; }
        }
        public string SponsorID
        {
            get { return sponsorID; }
            set { sponsorID = value; }
        }

        public string toString()
        {
            return "PrizeID: " + this.prizeID + "\nDescription: " + this.description + "\nValue: " + this.val + 
                "\nDonation Limit: " + this.donationLimit + "\nOriginal available: " + this.originalAvailable + 
                "\nCurrent available: " + this.currentAvailable + "\nSponsor ID: " + this.sponsorID;
        }

        public string getPrizeID()
        {
            return PrizeID;
        }

        public double decrease(int noOfPrize)
        {
           return this.currentAvailable = this.originalAvailable - noOfPrize;
        }

        public void onChangePrize(EventArgs eve)
        {
            this.CurrentAvailable--;
        }

        public void clearPrize()
        {
            this.prizeID = "";
            this.description = "";
            this.val = 0.0;
            this.donationLimit = 0.0;
            this.originalAvailable = 0;
            this.currentAvailable = 0;
            this.sponsorID = "";

        }
    }
}
