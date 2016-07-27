using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volvo_Team
{
    public class Quote
    {
        protected internal int account,zipCode = 0;
        protected internal string name, sAddress, city, state, phone = "";

        public Quote(int acct, int zip, string nme, string address, string cty, string st, string ph)
        {
            account = acct;
            zipCode = zip;
            name = nme;
            sAddress = address;
            city = cty;
            state = st;
            phone = ph;
        }
        
        //set/get
        public int ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                zipCode = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string SAddress
        {
            get
            {
                return sAddress;
            }
            set
            {
                sAddress = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        //Random number generator
        public void GenerateRandom()
        {
            //create a random number
            Random myRandom = new Random();

            //generate a random number between 1 and 10000
            account = myRandom.Next(1, 10000);

            //display in lblOrderNumber
            lblAccountRand.Text = account.ToString();
        }
    }
}
