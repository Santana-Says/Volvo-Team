using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Volvo_Team
{
    public partial class SalesRecords: Form
    {
        //declare an instance of a customer
        customer CurrentCust = new customer();

        //declare a list of cds
        List<customer> CustomerList = new List<customer>();
        int count = 0;

        public SalesRecords()
        {
            InitializeComponent();
            loadRecords();
        }

        public void loadRecords()
        {
            try
            {
                count = 0;

                //declare a file stream for input
                FileStream infile = new FileStream("customers.txt", FileMode.Open, FileAccess.Read);

                //declare a file reader
                StreamReader reader = new StreamReader(infile);

                //declare an array to be used for possible delimiters
                char[] sep = new char[1]; //the only delimiter in this file is a ,

                sep[0] = '/'; //assign comma as delimiter

                //array of fields once the data is split
                string[] fields = new string[30]; //size 3 for the three fields

                //declare a string to store the data for a single record
                string line1;

                //read in one line at a time
                //priming read
                line1 = reader.ReadLine();

                while (line1 != null)
                {
                    //declare a temporary CD
                    customer tempCust = new customer();

                    //split data and store the split data into fields array
                    fields = line1.Split(sep);
                    // convert string to bool
                    bool b1 = false;
                    if(fields[6] == "true")
                    {
                        b1 = true;
                    }

                    bool b2 = false;
                    if (fields[7] == "true")
                    {
                        b2 = true;
                    }

                    bool b3 = false;
                    if (fields[8] == "true")
                    {
                        b3 = true;
                    }

                    bool b4 = false;
                    if (fields[9] == "true")
                    {
                        b4 = true;
                    }
                    //store each element in tempCD
                    tempCust.Name = fields[0];
                    tempCust.Address = fields[1];
                    tempCust.City = fields[2];
                    tempCust.State = fields[3];
                    tempCust.Zip = fields[4];
                    tempCust.Phone = fields[5];
                    tempCust.pay = b1;
                    tempCust.add1 = b2;
                    tempCust.add2 = b3;
                    tempCust.finish = b4;
                    tempCust.taxes = Convert.ToDouble(fields[10]);
                    tempCust.tag = Convert.ToDouble(fields[11]);
                    tempCust.tradein = Convert.ToDouble(fields[12]);
                    tempCust.promo = Convert.ToDouble(fields[13]);
                    tempCust.price = Convert.ToDouble(fields[14]);
                    tempCust.added = Convert.ToDouble(fields[15]);
                    tempCust.fin = Convert.ToDouble(fields[16]);
                    tempCust.inter = Convert.ToDouble(fields[17]);
                    tempCust.cCar = Convert.ToInt32(fields[18]);
                    tempCust.account = Convert.ToInt32(fields[19]);
                    tempCust.car.Model = fields[20];
                    tempCust.car.Engine = fields[21];
                    tempCust.car.MSRP = Convert.ToDouble(fields[22]);
                    tempCust.car.FCapacity = Convert.ToDouble(fields[23]);
                    tempCust.car.CCapacity = Convert.ToDouble(fields[24]);
                    tempCust.car.High = Convert.ToInt32(fields[25]);
                    tempCust.car.City = Convert.ToInt32(fields[26]);
                    tempCust.car.Seat = Convert.ToInt32(fields[27]);
                    tempCust.car.Horse = Convert.ToInt32(fields[28]);
                    tempCust.car.cylinders = Convert.ToInt32(fields[29]);
                    

                    //add tempCD to back end CDList
                    CustomerList.Add(tempCust);



                    //add to counter
                    count++;


                    //read in next line
                    line1 = reader.ReadLine();



                } //end of while loop
                  //testing
                MessageBox.Show(count.ToString() + " Customers were read in");
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("File Not Found");
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HomePage homeForm = new HomePage();
            Sales.ActiveForm.Hide();
            homeForm.Show();
        }

        private void SalesRecords_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLoadCust_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < CustomerList.Count; i++)
            {
                listBoxCustomers.Items.Add(CustomerList[i].Name);
            }
        }
    }
}
