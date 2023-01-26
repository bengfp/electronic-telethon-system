using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSClassLibrary
{
    class Donor : Person
    {
        string donorID;
        string address;
        string phone;
        char cardType;
        string cardNum;
        string cardExpiry;

        public Donor(string donorID, string firstName, string lastName, string address, string phone, char cardType, string cardNum, string cardExpiry): base(firstName, lastName)
        {
            this.donorID = donorID;
            this.address = address;
            this.phone = phone;
            this.cardType = cardType;
            this.cardNum = cardNum;
            this.cardExpiry = cardExpiry;
        }

        public string DonorID
        {
            get { return donorID; }
            set { donorID = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public char CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }
        public string CardNum
        {
            get { return cardNum; }
            set { cardNum = value; }
        }
        public string CardExpiry
        {
            get { return cardExpiry; }
            set { cardExpiry = value; }
        }

        public string getID()
        {
            return DonorID;
        }

        public override string toString()
        {
            return "Donor ID: " + this.donorID + "\n" + base.toString() + "\nAddress: " + this.address + "\nPhone: " 
                + this.phone + "\nCard Type: " + cardType + "\nCard Number: " + this.cardNum + "\nCard Expiry: " + this.cardExpiry;
        }
    }
}
