using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volvo_Team
{
    class customer
    {
        public CarClass car;
        protected internal string name, address, city, state, zip, phone;
        protected internal bool payment, addon1, addon2, paint;
        protected internal int qCar, cAccount;
        protected internal double aTax, aTag, aTrade, aPromo, aMsrp, aPackage, aFinish, aInter;

        //default constructor
        public customer()
        {
            car = new CarClass();
            name = "name";
            address = "address";
            city = "city";
            state = "Florida";
            zip = "33324";
            phone = "555 555-5555";
            payment = false;
            addon1 = false;
            addon2 = false;
            paint = false;
            aTax = aTag = aTrade = aPromo = aMsrp = aPackage = aFinish=aInter = 0.0;
            qCar = 0;
            cAccount = 0;
        }

        //parameter constructor
        public customer(string str1, string str2, string str3, string str4, string str5, string str6,bool b1, bool b2, bool b3, bool b4, double a1, double a2, double a3, double a4, double a5, double a6, double a7, double a8, int in1, int in2, string st1, string st2, double d1, double d2, double d3, int in3, int in4, int in5, int in6, int in7)
        {
            name = str1;
            address = str2;
            city = str3;
            state = str4;
            zip = str5;
            phone = str6;
            payment = b1;
            addon1 = b2;
            addon2 = b3;
            paint = b4;
            aTax = a1;
            aTag = a2;
            aTrade = a3;
            aPromo = a4;
            aMsrp = a5;
            aPackage = a6;
            aFinish = a7;
            aInter = a8;
            qCar = in1;
            cAccount = in2;
            car.Model = st1;
            car.Engine = st2;
            car.MSRP = d1;
            car.FCapacity = d2;
            car.CCapacity = d3;
            car.High = in3;
            car.City = in4;
            car.Seat = in5;
            car.Horse = in6;
            car.cylinders = in7;
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
        public bool pay
        {
            get { return payment; }
            set { payment = value; }
        }
        public bool add1
        {
            get { return addon1; }
            set { addon1 = value; }
        }
        public bool add2
        {
            get { return addon2; }
            set { addon2 = value; }
        }
        public bool finish
        {
            get { return paint; }
            set { paint = value; }
        }
        public double tag
        {
            get { return aTag; }
            set { aTag = value; }
        }
        public double taxes
        {
            get { return aTax; }
            set { aTax = value; }
        }
        public double tradein
        {
            get { return aTrade; }
            set { aTrade = value; }
        }
        public double promo
        {
            get { return aPromo; }
            set { aPromo = value; }
        }
        public double price
        {
            get { return aMsrp; }
            set { aMsrp = value; }
        }
        public double added
        {
            get { return aPackage; }
            set { aPackage = value; }
        }
        public double fin
        {
            get { return aFinish; }
            set { aFinish = value; }
        }
        public double inter
        {
            get { return aInter; }
            set { aInter = value; }
        }
        public int cCar
        {
            get { return qCar; }
            set { qCar = value; }
        }
        public int account
        {
            get { return cAccount; }
            set { cAccount = value; }
        }

    }
}
