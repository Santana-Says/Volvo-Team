using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volvo_Team
{
    public class CarClass
    {
        protected internal string model, engine;
        protected internal double msrp, fuelCapasity, cargoCapasity;
        protected internal int FuelHigh, fuelCity, seatingCapacity, horsePower, cilynder;

        //default constructor
        public CarClass()
        {
            model = "VOLVO";
            engine = "";
            msrp = 0.0;
            fuelCapasity = 0.0;
            cargoCapasity = 0.0;
            FuelHigh = 0;
            fuelCity = 0;
            seatingCapacity = 0;
            horsePower = 0;
            cilynder = 0;
        }
        //parameter constructor
        public CarClass(string st1, string st2, double do1, double do2, double do3, int in1, int in2, int in3, int in4, int in5)
        {
            model = st1;
            engine = st2;
            msrp = do1;
            fuelCapasity = do2;
            cargoCapasity = do3;
            FuelHigh = in1;
            fuelCity = in2;
            seatingCapacity = in3;
            horsePower = in4;
            cilynder = in5;
        }
    }
}

/*

    model  - string
    msrp   - double
    enngine - string
    fuel capacity - double
    cargo capacity - double
    fuel economy highway - int
    fuel economy city - int
    seat capacity - int
    horse power - int
    cilynder - int

*/
{
    public class CarClass
    {
        protected internal string model, engine;
        protected internal double msrp, fuelCapasity, cargoCapasity;
        protected internal int FuelHigh, fuelCity, seatingCapacity, horsePower, cilynder;

        //default constructor
        public CarClass()
        {
            model = "VOLVO";
            engine = "";
            msrp = 0.0;
            fuelCapasity = 0.0;
            cargoCapasity = 0.0;
            FuelHigh = 0;
            fuelCity = 0;
            seatingCapacity = 0;
            horsePower = 0;
            cilynder = 0;
        }
        //parameter constructor
        public CarClass(string st1, string st2, double do1, double do2, double do3, int in1, int in2, int in3, int in4, int in5)
        {
            model = st1;
            engine = st2;
            msrp = do1;
            fuelCapasity = do2;
            cargoCapasity = do3;
            FuelHigh = in1;
            fuelCity = in2;
            seatingCapacity = in3;
            horsePower = in4;
            cilynder = in5;
        }
    }
}

/*

    model  - string
    msrp   - double
    enngine - string
    fuel capacity - double
    cargo capacity - double
    fuel economy highway - int
    fuel economy city - int
    seat capacity - int
    horse power - int
    cilynder - int

*/
