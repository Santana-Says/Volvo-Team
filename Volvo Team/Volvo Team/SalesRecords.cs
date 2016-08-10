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

        //declare a list of customers
        List<customer> CustomerList = new List<customer>();
        int count = 0;

        public SalesRecords()
        {
            InitializeComponent();
            loadRecords();
            CustomerInfo();
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
                char[] sep = new char[1]; //the only delimiter in this file is a '/'

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
                    //declare a temporary customer
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
                    //store each element in tempCust
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
                    tempCust.aTotal = Convert.ToDouble(fields[10]);
                    tempCust.taxes = Convert.ToDouble(fields[11]);
                    tempCust.tag = Convert.ToDouble(fields[12]);
                    tempCust.tradein = Convert.ToDouble(fields[13]);
                    tempCust.aPromo = Convert.ToDouble(fields[14]);
                    tempCust.aMsrp = Convert.ToDouble(fields[15]);
                    tempCust.aPackage = Convert.ToDouble(fields[16]);
                    tempCust.aFinish = Convert.ToDouble(fields[17]);
                    tempCust.aInterest = Convert.ToDouble(fields[18]);
                    tempCust.cCar = Convert.ToInt32(fields[19]);
                    tempCust.cAccountNum = Convert.ToInt32(fields[20]);
                    tempCust.car.Model = fields[21];
                    tempCust.car.Engine = fields[22];
                    tempCust.car.MSRP = Convert.ToDouble(fields[23]);
                    tempCust.car.FCapacity = Convert.ToDouble(fields[24]);
                    tempCust.car.CCapacity = Convert.ToDouble(fields[25]);
                    tempCust.car.High = Convert.ToInt32(fields[26]);
                    tempCust.car.City = Convert.ToInt32(fields[27]);
                    tempCust.car.Seat = Convert.ToInt32(fields[28]);
                    tempCust.car.Horse = Convert.ToInt32(fields[29]);
                    tempCust.car.cylinders = Convert.ToInt32(fields[30]);
                    

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

        private void picBoxBanner_Click(object sender, EventArgs e)
        {
            HomePage homeForm = new HomePage();
            Sales.ActiveForm.Hide();
            homeForm.Show();
        }

        private void SalesRecords_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void buttonLoadCust_Click(object sender, EventArgs e)
        {
            if (CustomerList.Count > 0)
            {
                lblNameTxt.Text = CustomerList[listBoxCustomers.SelectedIndex].Name;
                lblSAddressTxt.Text = CustomerList[listBoxCustomers.SelectedIndex].Address;
                lblCityTxt.Text = CustomerList[listBoxCustomers.SelectedIndex].City;
                lblStateTxt.Text = CustomerList[listBoxCustomers.SelectedIndex].State;
                lblZipNum.Text = CustomerList[listBoxCustomers.SelectedIndex].Zip;
                lblPhoneNum.Text = CustomerList[listBoxCustomers.SelectedIndex].Phone;

                lblQuoteMSRPNum.Text = CustomerList[listBoxCustomers.SelectedIndex].car.MSRP.ToString("C");
                lblQuotePackageNum.Text = CustomerList[listBoxCustomers.SelectedIndex].aPackage.ToString("C");
                lblQuoteFinishNum.Text = CustomerList[listBoxCustomers.SelectedIndex].aFinish.ToString("C");
                lblQuoteTradeNum.Text = CustomerList[listBoxCustomers.SelectedIndex].tradein.ToString("C");
                lblQuotePromoNum.Text = CustomerList[listBoxCustomers.SelectedIndex].aPromo.ToString("C");
                lblInterValue.Text = CustomerList[listBoxCustomers.SelectedIndex].aInterest.ToString("C");
                lblTagNum.Text = CustomerList[listBoxCustomers.SelectedIndex].tag.ToString("C");
                lblTaxNum.Text = CustomerList[listBoxCustomers.SelectedIndex].aTax.ToString("C");
                lblQuoteEstNum.Text = CustomerList[listBoxCustomers.SelectedIndex].aTotal.ToString("C");

                for (int i = 1; i < 5; i++)
                {
                    if (CustomerList[listBoxCustomers.SelectedIndex].cCar == i)
                        picBoxCar.Image = Image.FromFile("../../Resources/" + CustomerList[listBoxCustomers.SelectedIndex].cCar + "-angle.jpg");
                }
            }
        }

        private void CustomerInfo()
        {
            for (int i = 0; i < CustomerList.Count; i++)
            {
                listBoxCustomers.Items.Add(CustomerList[i].Name);
            }

            listBoxCustomers.SelectedIndex = 0;

            
        }

    }
}
