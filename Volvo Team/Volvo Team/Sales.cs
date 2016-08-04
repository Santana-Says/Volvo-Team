using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Volvo_Team
{
    public partial class Sales: Form
    {
        //declare an instance of a customer
        customer CurrentCust = new customer();

        //declare a list of cds
        List<customer> CustomerList = new List<customer>();

        // variables to be use
        public int CurrentCar = 1;

        public Sales()
        {
            GenerateRandom();
            InitializeComponent();
            newCars();
            DisplayCar(CurrentCar);

        }

        // declare 4 instance of CarClass
        CarClass[] carList = new CarClass[4];
        private void newCars()
        {
            carList[0] = new CarClass("S60", "2.0 Liter", 34150, 17.8, 12, 38, 26, 5, 240, 4);
            carList[1] = new CarClass("S80", "2.0 Liter", 43450, 18.5, 14.9, 37, 25, 5, 240, 4);
            carList[2] = new CarClass("S90", "In-Line ", 46950, 14.5, 13.5, 39, 26, 5, 250, 4);
            carList[3] = new CarClass("V60", "2.5 Liter", 41200, 17.8, 43.8, 28, 20, 5, 250, 5);
        }

        //function to display car inforamtion
        public void DisplayCar(int car)
        {            
            lblModelName.Text = carList[car-1].Model;
            lblMSRPInfo.Text = carList[car-1].msrp.ToString("C");
            lblEngineInfo.Text = carList[car-1].Engine;
            lblCylinderInfo.Text = Convert.ToString(carList[car-1].cylinder);
            lblHPInfo.Text = Convert.ToString(carList[car-1].horsePower);
            lblFuelInfo.Text = Convert.ToString(carList[car-1].fuelCapacity);
            lblCargoInfo.Text = Convert.ToString(carList[car-1].cargoCapacity);
            lblSeatInfo.Text = Convert.ToString(carList[car-1].seatingCapacity);
            lblMpgCityInfo.Text = Convert.ToString(carList[car-1].fuelCity);
            lblMpgHwInfo.Text = Convert.ToString(carList[car-1].FuelHigh);
            picFrontView.Image = Image.FromFile("../../Resources/" + car + "-front.jpg");
            picSideView.Image = Image.FromFile("../../Resources/" + car + "-side.jpg");
            variables.selectedCar = car;
            variables.msrp = carList[car - 1].msrp;
            variables.model = carList[car - 1].Model;
        }

        //random number
        public void GenerateRandom()
        {
            //create a random number
            Random myRandom = new Random();

            //generate a random number between 1 and 10000
            variables.account = myRandom.Next(1000000,9999999);
        }        

        //show first car in inventory

        //inventory to add-on
        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            tabControlSales.SelectedTab = tabAddOn;
        }

        //inventory to trade 
        private void btnTrade_Click(object sender, EventArgs e)
        {
            tabControlSales.SelectedTab = tabTrade;
        }

        //trade to inventory
        private void btnContinue_Click(object sender, EventArgs e)
        {
            int tempMile = Convert.ToInt32(txtBoxMilage.Text);
            if ((comboBoxMake.SelectedItem != null || comboBoxYear.SelectedItem != null) && tempMile<1 )
            {
                MessageBox.Show("Please enter a mileage greater than zero for your trade in.");
            }
            else
            {
                tabControlSales.SelectedTab = tabInventory;
            }                      
        }

        //add-on to quote
        private void btnQoute_Click(object sender, EventArgs e)
        {
            if(groupBoxA.Enabled == false || groupBoxB.Enabled == false)
                tabControlSales.SelectedTab = tabQuote;
        }

        //trade in section
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxMake.Enabled = true;
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            txtBoxMilage.Enabled = true;
        }

        //for homepage to pick which tab to enter
        public void changeTabs(int tab)
        {
            tabControlSales.SelectedIndex = tab;
        }

        //return to homePage form and start over
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HomePage homeForm = new HomePage();
            Sales.ActiveForm.Hide();
            homeForm.Show();

        }

        private void Sales_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //select all radio buttons per groupBox and disable the other package
        private void groupBoxA_Enter(object sender, EventArgs e)
        {

            variables.package = 2200.0;
            radioBtnA1.Checked = true;
            radioBtnA2.Checked = true;
            radioBtnA3.Checked = true;

            groupBoxB.Enabled = false;

            variables.packlbl = "Package A";
        }
        private void groupBoxB_Enter(object sender, EventArgs e)
        {
            if(variables.selectedCar == 1 || variables.selectedCar == 4)
            {
                groupBoxB.Enabled = false;
            }
            if (variables.selectedCar == 2 || variables.selectedCar == 3)
            {
                variables.package = 3250.0;
                radioBtnB1.Checked = true;
                radioBtnB2.Checked = true;
                radioBtnB3.Checked = true;
                radioBtnB4.Checked = true;
                radioBtnB5.Checked = true;

                groupBoxA.Enabled = false;

                variables.packlbl = "Package B";
            }
            
        }

        private void tabControlSales_Selecting(object sender, TabControlCancelEventArgs e)
        {
            int car1 = variables.selectedCar;
            double stotal = 0.0, stotal1 = 0.0, intCalculate = 0.0, finalprice = 0.0;
            
            picBoxMyAcc.Image = Image.FromFile("../../Resources/" + car1 + "-angle.jpg");
            lblCarModel.Text = ("2016 " + variables.model);
            lblWelcomeName.Text = variables.name;
            lblQuoteMSRPNum.Text = variables.msrp.ToString("C");
            lblQuotePackageNum.Text = variables.package.ToString("C");
            lblQuoteFinishNum.Text = variables.finish.ToString("C");
            lblQuoteTradeNum.Text = variables.trade.ToString("C");
            lblQuotePromoNum.Text = variables.promo.ToString("C");
            lblInterValue.Text = variables.inter.ToString("C");
            lblQuotePackage.Text = variables.packlbl;
            lblQuoteFinish.Text = variables.finishlbl;
            lblAccountNum.Text = variables.account.ToString();


            //calculate total car cost
            stotal = variables.msrp + variables.package + variables.finish;

            //deduct trade in value
            stotal1 = stotal - variables.trade;

            //calculate interest over remaining balance
            intCalculate = stotal1 * variables.intrate;
            variables.inter = intCalculate;

            // calculate taxes
            variables.taxTotal = stotal1 * variables.taxRate;
            //calculate total price of the car
            finalprice = stotal1 - variables.promo  + variables.inter + variables.tag + variables.taxTotal;
            Stotal.Text = stotal.ToString("C");
            lblQuoteEstNum.Text = finalprice.ToString("C");
            lblStotal1.Text = stotal1.ToString("C");
            lblInterValue.Text = variables.inter.ToString("C");
            lblTaxValue.Text = variables.taxTotal.ToString("C");
            lblTag.Text = variables.tag.ToString("C");
            lblTaxText.Text = ("Tax " + variables.taxRate * 100 + "%");

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if(CurrentCar < 5)
            {
                CurrentCar++;
            }
            if(CurrentCar == 5)
            {
                CurrentCar = 1;
            }

            DisplayCar(CurrentCar);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (CurrentCar > 0)
            {
                CurrentCar--;
            }
            if (CurrentCar == 0)
            {
                CurrentCar = 4;
            }

            DisplayCar(CurrentCar);
        }

        private void groupBoxPaint_Enter(object sender, EventArgs e)
        {
            if (radioBtnP1.Checked)
            {
                variables.finish = 0.0;
                variables.finishlbl = "Standard Finish";
            }
            else
            {
                variables.finish = 600.0;
                variables.finishlbl = "Metallic Finish";   
            }
        }

        private void tradeInVal()
        {
            double milageVal = 0.0, yearVal = 0.0;
            
            if(comboBoxYear.Text == "")
            {
                variables.trade = 0.0;
            }

            if (comboBoxYear.Text != "")
            {
                if (int.Parse(txtBoxMilage.Text) >= 35000.0)
                    milageVal = 10000;
                else if (int.Parse(txtBoxMilage.Text) >= 15000.0)
                    milageVal = 5000.0;
                else
                    milageVal = 2000.0;

                yearVal = 1000.0 * (2016 - int.Parse(comboBoxYear.Text));

                variables.trade = 30000.0 - yearVal - milageVal;
            }
        }

        //private int quoteEst()

        //Quote to MyAccount
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Zip validation
        public bool IsValidZip(string zip)
        {
            int len = 0;

            len = zip.Length;

            //check the length
            if (len != 5 && len != 10)
                return false;

            //check 5 digit zip
            if (len == 5)
            {
                //check if all characters are digits
                for (int i = 0; i < 5; i++)
                {
                    if (!char.IsDigit(zip[i]))
                        return false;
                }
            }

            //check 9 digit zip
            if (len == 10)
            {
                if (zip[5] != '-')
                    return false;

                for (int i = 0; i < 5; i++)
                {
                    if (!char.IsDigit(zip[i]))
                        return false;
                }

                for (int i = 6; i < 10; i++)
                {
                    if (!char.IsDigit(zip[i]))
                        return false;
                }
            }
            return true;
        }

        private void txtZip_Leave(object sender, EventArgs e)
        {
            if (!IsValidZip(txtZip.Text))
            {
                MessageBox.Show("Invalid.  Must be XXXXX-XXXX or XXXXX");
                //reset focus to the text box
                txtZip.Focus();
                //select all to highlight text and type over
                txtZip.SelectAll();
            }
        }

        //mileage validation
        private void txtBoxMilage_Validating(object sender, CancelEventArgs e)
        {
            int tempMiles = Convert.ToInt32(txtBoxMilage.Text);
            if(tempMiles<1)
            {
                MessageBox.Show("Invalid. Must be a mileage greater than zero.");
                txtBoxMilage.Focus();
                txtBoxMilage.SelectAll();
            }
        }

        //phone number validation
        public bool IsValidPhone(string phone)
        {
            string tempPhone;

            tempPhone = @"^(\()?\d{3}(\))?\s\d{3}\-\d{4}$"; //@^start of the string, $ end of the string, 
                                                            //\is for an escape sequence, d{n} is n digits, ()? is optional-
                                                            //surround optional part with ()
            Regex myreg = new Regex(tempPhone);

            return myreg.IsMatch(phone);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Invalid Phone Number.  Must be (XXX) XXX-XXXX or XXX XXX-XXXX");
                txtPhone.Focus();
                txtPhone.SelectAll();
            }
        }

        //name validation
        public bool isValidName(string name)
        {
            string tempName;
            tempName = @"^[A-Z]{1,30}$";
            Regex myregn = new Regex(tempName, RegexOptions.IgnoreCase);
            return myregn.IsMatch(name);
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (!isValidName(txtName.Text))
            {
                MessageBox.Show("Invalid name. Must be a name 1-30 characters in length(a-z only).");
                txtName.Focus();
                txtName.SelectAll();
            }
        }

        //city validation
        public bool isValidCity(string city)
        {
            string tempCity;
            tempCity = @"^[A-Za-z\s\-]";
            Regex myregc = new Regex(tempCity, RegexOptions.IgnoreCase);
            return myregc.IsMatch(city);
        }

        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            if(!isValidCity(txtCity.Text))
            {
                MessageBox.Show("Please enter a city.");
                txtCity.Focus();
                txtCity.SelectAll();
            }
        }


    }

    class variables
    {
        public static int selectedCar = 0;
        public static string name = "";
        public static double trade = 0.0;
        public static double promo = 0.0;
        public static double msrp = 0.0;
        public static double package = 0.0;
        public static double finish = 0.0;
        public static string model = "";
        public static double inter = 0.0;
        public static string packlbl = "";
        public static string finishlbl = "";
        public static double intrate = 0.0;
        public static int account = 0;
        public static double taxRate = 0.06;
        public static double taxTotal = 0.0;
        public static double tag = 325.0;
    }
}
