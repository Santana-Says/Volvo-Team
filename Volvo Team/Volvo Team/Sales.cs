using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volvo_Team
{
    public partial class Sales: Form
    {
        // variables to be use
        public int CurrentCar = 1;

        public Sales()
        {
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
            tabControlSales.SelectedTab = tabInventory;
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
            variables.package = 3250.0;
            radioBtnB1.Checked = true;
            radioBtnB2.Checked = true;
            radioBtnB3.Checked = true;
            radioBtnB4.Checked = true;
            radioBtnB5.Checked = true;

            groupBoxA.Enabled = false;

            variables.packlbl = "Package B";
            
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

            
            //calculate total car cost
            stotal = variables.msrp + variables.package + variables.finish;

            //deduct trade in value
            stotal1 = stotal - variables.trade;

            //calculate interest over remaining balance
            intCalculate = stotal1 * variables.intrate;
            variables.inter = intCalculate;

            //calculate total price of the car
            finalprice = stotal1 - variables.promo  + variables.inter;
            Stotal.Text = stotal.ToString("C");
            lblQuoteEstNum.Text = finalprice.ToString("C");
            lblStotal1.Text = stotal1.ToString("C");
            lblInterValue.Text = variables.inter.ToString("C");
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

            if (int.Parse(txtBoxMilage.Text) >= 35000.0)
                milageVal = 10000;
            else if (int.Parse(txtBoxMilage.Text) >= 15000.0)
                milageVal = 5000.0;
            else
                milageVal = 2000.0;

            yearVal = 1000.0 * (2016 - int.Parse(comboBoxYear.Text));

            variables.trade = 30000.0 - yearVal - milageVal;
        }

        //private int quoteEst()

        //Quote to MyAccount
        private void button1_Click(object sender, EventArgs e)
        {
            tradeInVal();
            if (cash.Checked == true)
            {
                variables.promo = 750.0;
                variables.intrate = 0.0;
            }
            if (finance.Checked == true)
            {
                variables.promo = 0.0;
                variables.intrate = 0.07;
            }
            tabControlSales.SelectedTab = tabAccount;
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


    }
}
