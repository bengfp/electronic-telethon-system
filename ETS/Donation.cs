using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSClassLibrary
{
    class Donation
    {
        string donationID;
        string donationDate;
        string donorID;
        double donationAmount;
        string prizeID;

        public Donation(string donID, string donDate, string dID, double donAmount, string prID)
        {
            this.donationID = donID;
            this.donationDate = donDate;
            this.donorID = dID;
            this.donationAmount = donAmount;
            this.prizeID = prID;
        }

        public string DonationID
        {
            get { return donationID; }
            set { donationID = value; }
        }

        public string DonationDate
        {
            get { return donationDate; }
            set { donationDate = value; }
        }

        public string DonorID
        {
            get { return donorID; }
            set { donorID = value; }
        }

        public double DonationAmount
        {
            get { return donationAmount; }
            set { donationAmount = value; }
        }

        public string PrizeID
        {
            get { return prizeID; }
            set { prizeID = value; }
        }

        public string getID()
        {
            return DonationID;
        }
        public string toString()
        {
            return "Donation ID: " + this.donationID + "\nDonation Date: " + this.donationDate + "\nDonation Amount: "
                + this.donationAmount + "\nDonor ID: " + this.donorID + "\nPrize ID: " + this.prizeID;
        }
    }
}
