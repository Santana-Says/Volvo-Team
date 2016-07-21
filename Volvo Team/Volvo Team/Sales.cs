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
        public int CurrentCar = 1, paint = 0, package = 0, tradeIn = 0, promo = 0, estimate = 0;

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
            radioBtnA1.Checked = true;
            radioBtnA2.Checked = true;
            radioBtnA3.Checked = true;

            groupBoxB.Enabled = false;

            lblQuotePackage.Text = "Package A";
            lblQuotePackageNum.Text = package.ToString("C");
        }
        private void groupBoxB_Enter(object sender, EventArgs e)
        {
            radioBtnB1.Checked = true;
            radioBtnB2.Checked = true;
            radioBtnB3.Checked = true;
            radioBtnB4.Checked = true;
            radioBtnB5.Checked = true;

            groupBoxA.Enabled = false;

            package = 2200;
            lblQuotePackage.Text = "Package B";
            lblQuotePackageNum.Text = package.ToString("C");
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
                lblQuoteFinish.Text = "Standard Finish";
                lblQuoteFinishNum.Text = paint.ToString("C");
            }
            else
            {
                paint = 600;
                lblQuoteFinish.Text = "Metallic Finish";
                lblQuoteFinishNum.Text = paint.ToString("C");
            }
        }

        private void tradeInVal()
        {
            int milageVal = 0, yearVal = 0;

            if (int.Parse(txtBoxMilage.Text) >= 35000)
                milageVal = 10000;
            else if (int.Parse(txtBoxMilage.Text) >= 15000)
                milageVal = 5000;
            else
                milageVal = 2000;

            yearVal = 1000 * (2016 - int.Parse(comboBoxYear.Text));

            tradeIn = 30000 - yearVal - milageVal;
        }

        //private int quoteEst()

        //Quote to MyAccount
        private void button1_Click(object sender, EventArgs e)
        {
            tradeInVal();

            tabControlSales.SelectedTab = tabAccount;
            lblWelcomeName.Text = txtName.Text;
            //lblAccountNum.Text = 
            lblQuoteMSRPNum.Text = lblMSRPInfo.Text;
            lblQuoteTradeNum.Text = tradeIn.ToString("C");
            //lblQuotePromoPromo.Text = 
            //lblQuoteEstNum.Text = 
        }
    }
}
