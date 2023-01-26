using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ETSClassLibrary
{
    public class ETSManager
    {
        public ETSManager() { }

        Donors myDonors = new Donors();
        Sponsors mySponsors = new Sponsors();
        Donations myDonations = new Donations();
        Prizes myPrizes = new Prizes();

        public bool validatePrizeID(string dID)
        {
            bool flag = false;

            foreach (Prize pr in myPrizes)
            {
                if (pr.getPrizeID() == dID)
                {
                    flag = true;
                }
            }
            return flag;
        }
        public string addPrize(string prID, string desc, double valPerPrize, int qty, double minDonationLimit, string spID)
        {
            string msg = "";
            if(prID.Length != 4)
            {
                msg = "Error! ID must have 4 characters.";
            }
            else
            {
                if(validatePrizeID(prID) == true)
                {
                    msg = "Error! ID already exist.";
                }
                else
                {
                    if (desc.Length > 15)
                    {
                        msg = "Error! Description must only have 15 characters.";
                    }
                    else
                    {
                        if( valPerPrize > 299.99)
                        {
                            msg = "Error! Prize value should be less than $299.99";
                        }
                        else
                        {
        
                            
                            if(validateSponsorID(spID) == false)
                            {
                                msg = "ERROR! Sponsor ID doesn't exist.";
                            }
                            else
                            {
                                int currentAvail = qty;
                                Prize pr = new Prize(prID, desc, valPerPrize, minDonationLimit, qty, currentAvail, spID);
                                for (int i = 0; i < mySponsors.Count; i++)
                                {
                                    if (mySponsors[i].SponsorID == spID)
                                    {
                                        mySponsors[i].addValue(valPerPrize * qty);
                                    }
                                }
                                myPrizes.add(pr); 
                                msg = "Success! Prize has been successfully added.";
                            }
                           
                        }
                    }
                }
            }

            return msg;
        }

        public string listPrizes()
        {
            string displayInfo = "";
            if (myPrizes.Count == 0)
            {
                displayInfo = "No prizes found.";
            }
            else
            {
                foreach (Prize pr in myPrizes)
                {
                    displayInfo += pr.toString();
                    displayInfo += Environment.NewLine + "***";
                    displayInfo += Environment.NewLine;
                }
            }

            return displayInfo;
        }

        public string listQualifiedPrizes(double donAmount)
        {
            string displayInfo = "";
            bool flag = false;
                
            for (int i = 0; i < myPrizes.Count; i++)
            {  
                if (donAmount >= myPrizes[i].DonationLimit)     
                {    
                    displayInfo += myPrizes[i].toString();
                    displayInfo += Environment.NewLine + "***";    
                    displayInfo += Environment.NewLine;
                    flag = true; 
                }
            }

            if (flag == false)
            {
                displayInfo = "No qualified donations found.";
            }

            return displayInfo;
        }

        public bool validateSponsorID(string sID)
        {
            bool flag = false;

            foreach (Sponsor spons in mySponsors)
            {
                if (spons.getID() == sID)
                {
                    flag = true;
                }
            }
            return flag;
        }
        public string addSponsor(string spID, string FN, string LN, double totalPrizeVal)
        {
            string msg = "";
            if (spID.Length != 4) {

                msg = "Error! ID must have 4 characters";
            }
            else { 
                if ( validateSponsorID(spID) == true )
                {
                    msg = "Error! ID already exist.";
                }
                else
                {
                    if (FN.Length + LN.Length > 30)
                    {
                        msg = "Error! First name and Last Name cannot have more than 30 characters.";
                    }
                    else
                    {
                        Sponsor sp = new Sponsor(spID, totalPrizeVal, FN, LN);
                        mySponsors.add(sp);
                        msg = "Success! Sponsos has been successfully added.";
                    }
                }
            }

            return msg;
        }

        public string listSponsors()
        {
            string displayInfo = "";
            if(mySponsors.Count == 0)
            {
               displayInfo = "No sponsors found.";
            }
            else { 
                foreach(Sponsor sponsor in mySponsors)
                {
                    displayInfo += sponsor.toString();
                    displayInfo += Environment.NewLine + "***";
                    displayInfo += Environment.NewLine;
                }
            }

            return displayInfo;
        }

        public string findSponsor(string spID)
        {
            bool flag = false;
            string displayInfo = "";
            if (mySponsors.Count == 0)
            {
                flag = false;
            }
            else
            {
                foreach(Sponsor sp in mySponsors)
                {
                    if(sp.getID() == spID) { 
                        displayInfo += sp.toString();
                        displayInfo += Environment.NewLine;
                        flag = true;
                    }
                }
            }

            if(flag == false)
            {
                displayInfo = "No sponsors found.";
            }

            return displayInfo;
        }

        public bool validateDonorID(string dID)
        {
            bool flag = false;

            foreach(Donor don in myDonors)
            {
                if(don.getID() == dID)
                {
                    flag = true;
                }
            }
            return flag;
        }
        public string addDonor(string dID, string fn, string ln, string addr, string phone, char ct, string cNum, string cExpiry)
        {
            string msg = "";
            if (dID.Length != 4)
            {
                msg = "ERROR! ID must have 4 characters.";
            }
            else
            {
                if (validateDonorID(dID) == true )
                {
                    msg = "ERROR! ID already exist.";
                }
                else
                {
                    if(fn.Length > 15)
                    {
                        msg = "ERROR! First name must not exceed 15 characters.";
                    }
                    else
                    {
                        if(ln.Length > 15)
                        {
                            msg = "ERROR! Last name must not exceed 15 characters.";
                        }
                        else
                        {
                            if (addr.Length > 40)
                            {
                                msg = "ERROR! Address must not have more than 40 characters.";
                            }
                            else
                            {
                                Regex reg = new Regex("^((\\+0?1\\s)?)\\(?\\d{3}\\)?[\\s.\\s]\\d{3}[\\s.-]\\d{4}$");
                                if (!(reg.IsMatch(phone)))
                                {
                                    msg = "ERROR! Phone number invalid. (Ex. 999 999-9999)";
                                }
                                else
                                {
                                    if(cNum.Length != 16)
                                    {
                                        msg = "ERROR! Credit card number must be 16 characters.";
                                    }
                                    else
                                    {
                                        Regex regex = new Regex("^(0[1-9]|1[0-2])\\/?([0-9]{2})$");
                                        if (regex.IsMatch(cExpiry))
                                        {
                                            Donor donor = new Donor(dID, fn, ln, addr, phone, ct, cNum, cExpiry);
                                            myDonors.add(donor);
                                            msg = "SUCCESS! Donor has been added";
                                        }
                                        else
                                        {
                                            msg = "ERROR! Invalid expiry date. (ex. mm/yy)";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return msg;
        }

        public string listDonors()
        {
            string displayInfo = "";
            if (myDonors.Count == 0)
            {
                displayInfo = "No donors found.";
            }
            else
            {
                foreach (Donor donor in myDonors)
                {
                    displayInfo += donor.toString();
                    displayInfo += Environment.NewLine + "***";
                    displayInfo += Environment.NewLine;
                }
            }

            return displayInfo;
        }

        public string findDonor(string dID)
        {
            bool flag = false;
            string displayInfo = "";
            if (myDonors.Count == 0)
            {
                flag = false;
            }
            else
            {
                foreach (Donor don in myDonors)
                {
                    if (don.getID() == dID)
                    {
                        displayInfo += don.toString();
                        displayInfo += Environment.NewLine;
                        flag = true;
                    }
                }
            }

            if (flag == false)
            {
                displayInfo = "No donors found.";
            }

            return displayInfo;
        }

        public string deleteDonor(string dID)
        {
            string msg = "";
            if(validateDonorID(dID) == true)
            {
                for(int i = 0; i < myDonors.Count; i++)
                {
                    if(myDonors[i].getID() == dID)
                    {
                        myDonors.RemoveAt(i);
                        msg = "Success! Donor has been successfully deleted.";
                    }
                }
            }

            return msg;
        }

        public bool writeDonors()
        {
            //string[] array;
            try
            {
                using (StreamWriter SW = new StreamWriter(@"C:\Users\joann\Desktop\firstProject\txtFile\Donor.txt"))
                {
                    foreach (Donor don in myDonors)
                    { 
                        SW.WriteLine(don.toString().Replace('\n', ','));
                        SW.WriteLine("***");
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
        }

        public bool readDonors()
        {
            bool flag = false;
 
                using (StreamReader sr = new StreamReader(@"C:\Users\joann\Desktop\firstProject\txtFile\Donor.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        string str = sr.ReadLine();
                        string[] strarray;
                        str.Replace('*', ' ');
                        str = sr.ReadLine();

                        strarray = (str.Split(',') as string[]);
                        Donor donor = new Donor(strarray[0], strarray[1], strarray[2], strarray[3], strarray[4], Convert.ToChar(strarray[5]), strarray[6], strarray[7]);
                        myDonors.add(donor);
                    }
                    flag = true;
                }

            return flag;
        }

        public bool validateDonationID(string donID)
        {
            bool flag = false;

            foreach (Donation don in myDonations)
            {
                if (don.getID() == donID)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public string addDonation(string donID, string dDate, string dID, double donAmount, string prizeID, int noOfPrize)
        {
            string msg = "";
            bool flag = false;

            if (donID.Length != 4)
            {
                msg = "ERROR! ID must not exceed 4 characters.";
            }
            else
            {
                if (validateDonationID(donID) == true)
                {
                    msg = "ERROR! ID already exist.";
                }
                else
                {
                    if (validateDonorID(dID) == false)
                    {
                        msg = "ERROR! Donor ID, doesn't exist";
                    }
                    else
                    {
                        if (donAmount < 5 && donAmount > 999999.99)
                        {
                            msg = "ERROR! Amount must be between $5 and $999,999.99";
                        }
                        else
                        {
                            if (validatePrizeID(prizeID) == false)
                            {
                                msg = "ERROR! Prize ID not found";
                            }
                            else
                            {
                                Donation donation = new Donation(donID, dDate, dID, donAmount, prizeID);

                                for (int i = 0; i < myPrizes.Count; i++)
                                {
                                    if (donation.PrizeID == myPrizes[i].PrizeID)
                                    {
                                        if (donAmount < myPrizes[i].DonationLimit)
                                        {
                                            msg = "Donor cannot get prize. Minimum donation limit not acquired.";
                                            msg += "SUCCESS! Donation has been successfully done";
                                            flag = true;
                                        }
                                        else
                                        {
                                            if (noOfPrize > myPrizes[i].CurrentAvailable)
                                            {
                                                msg = "Error! Insufficient amount of Prize " + myPrizes[i].CurrentAvailable + " left. ";
                                                flag = false;
                                            }
                                            else
                                            {
                                                myPrizes[i].decrease(noOfPrize);
                                                msg = "SUCCESS! Prize has been issued.";
                                                flag = true;
                                            }
                                        }
                                    }
                                }
                                if (flag == false)
                                {
                                    msg += "Error! Donation has not been successfully added.";
                                }
                                else
                                {
                                    myDonations.add(donation);
                                }
                                //msg = "SUCCESS! Donation has been successfully done";
                            }
                        }
                    }
                }
            }

            return msg;
        }

        public string listDonations()
        {
            string displayInfo = "";
            if (myDonations.Count == 0)
            {
                displayInfo = "No donations found.";
            }
            else
            {
                foreach (Donation donation in myDonations)
                {
                    displayInfo += donation.toString();
                    displayInfo += Environment.NewLine + "***";
                    displayInfo += Environment.NewLine;
                }
            }

            return displayInfo;
        }
    }
}
