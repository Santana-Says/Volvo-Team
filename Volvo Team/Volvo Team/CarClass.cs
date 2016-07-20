using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volvo_Team
{
    public class CarClass
    {
        protected internal string model, engine, package, paint;
        protected internal double msrp, fuelCapacity, cargoCapacity;
        protected internal int FuelHigh, fuelCity, seatingCapacity, horsePower, cylinder;

        //default constructor
        public CarClass()
        {
            model = "VOLVO";
            engine = "";
            msrp = 0.0;
            fuelCapacity = 0.0;
            cargoCapacity = 0.0;
            FuelHigh = 0;
            fuelCity = 0;
            seatingCapacity = 0;
            horsePower = 0;
            cylinder = 0;
        }
        //parameter constructor
        public CarClass(string st1, string st2, double do1, double do2, double do3, int in1, int in2, int in3, int in4, int in5)
        {
            model = st1;
            engine = st2;
            msrp = do1;
            fuelCapacity = do2;
            cargoCapacity = do3;
            FuelHigh = in1;
            fuelCity = in2;
            seatingCapacity = in3;
            horsePower = in4;
            cylinder = in5;
        }
        // set / get model
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        // set / get engine
        public string Engine
        {
            get
            {
                return engine;
            }
            set
            {
                engine = value;
            }
        }

        // set / get msrp
        public double MSRP
        {
            get
            {
                return msrp;
            }
            set
            {
                msrp = value;
            }
        }

        // set / get fuel capacity
        public double FCapacity
        {
            get
            {
                return fuelCapacity;
            }
            set
            {
                fuelCapacity = value;
            }
        }

        // set / get cargo capacity
        public double CCapacity
        {
            get
            {
                return cargoCapacity;
            }
            set
            {
                cargoCapacity = value;
            }
        }

        // set / get fuel highway
        public int High
        {
            get
            {
                return FuelHigh;
            }
            set
            {
                FuelHigh = value;
            }
        }

        // set / get fuel city
        public int City
        {
            get
            {
                return fuelCity;
            }
            set
            {
                fuelCity = value;
            }
        }

        // set / get Seatting
        public int Seat
        {
            get
            {
                return seatingCapacity;
            }
            set
            {
                seatingCapacity = value;
            }
        }

        // set / get horsepower
        public int Horse
        {
            get
            {
                return horsePower;
            }
            set
            {
                horsePower = value;
            }
        }

        // set / get cylinder
        public int cylinders
        {
            get
            {
                return cylinder;
            }
            set
            {
                cylinder = value;
            }
        }
    }


}