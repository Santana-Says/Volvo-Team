using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volvo_Team
{
    class customer
    {
        protected internal string name, address, city, state, zip, phone;

        //default constructor
        plublic customer()
        {
            name = "name";
            address = "address";
            city = "city";
            state = "Florida";
            zip = "33324";
            phone = "555 555-5555";
        }

        //parameter constructor
        public customer(string str1, string str2, string str3, string str4, string str5, string str6)
        {
            name = str1;
            address = str2;
            city = str3;
            state = str4;
            zip = str5;
            phone = str6;
        }

        // set / get name
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

        // set / get address
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        // set / get city
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

        // set / get state
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        // set / get zip
        public string Zip
        {
            get
            {
                return zip;
            }
            set
            {
                zip = value;
            }
        }

        // set / get phone
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
    }
}
