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
            DisplayCar(CurrentCar);

        }

        // declare 4 instance of CarClass
        CarClass s60 = new CarClass("S60", "2.0 Liter", 34150, 17.8, 12, 38, 26, 5, 240, 4);
        CarClass s80 = new CarClass("S80", "2.0 Liter", 43450, 18.5, 14.9, 37, 25, 5, 240, 4);
        CarClass s90 = new CarClass("S90", "In-Line ", 46950, 14.5, 13.5, 39, 26, 5, 250, 4);
        CarClass v60 = new CarClass("V60", "2.5 Liter", 41200, 17.8, 43.8, 28, 20, 5, 250, 5);


        //function to display car inforamtion
        public void DisplayCar(int car)
        {
            if (car == 1)
            {
                lblModelName.Text = s60.Model;
                lblMSRPInfo.Text = s60.msrp.ToString("C");
                lblEngineInfo.Text = s60.Engine;
                lblCylinderInfo.Text = Convert.ToString(s60.cylinder);
                lblHPInfo.Text = Convert.ToString(s60.horsePower);
                lblFuelInfo.Text = Convert.ToString(s60.fuelCapacity);
                lblCargoInfo.Text = Convert.ToString(s60.cargoCapacity);
                lblSeatInfo.Text = Convert.ToString(s60.seatingCapacity);
                lblMpgCityInfo.Text = Convert.ToString(s60.fuelCity);
                lblMpgHwInfo.Text = Convert.ToString(s60.FuelHigh);
            }
            if (car == 2)
            {
                lblModelName.Text = s80.Model;
                lblMSRPInfo.Text = s80.msrp.ToString("C");
                lblEngineInfo.Text = s80.Engine;
                lblCylinderInfo.Text = Convert.ToString(s80.cylinder);
                lblHPInfo.Text = Convert.ToString(s80.horsePower);
                lblFuelInfo.Text = Convert.ToString(s80.fuelCapacity);
                lblCargoInfo.Text = Convert.ToString(s80.cargoCapacity);
                lblSeatInfo.Text = Convert.ToString(s80.seatingCapacity);
                lblMpgCityInfo.Text = Convert.ToString(s80.fuelCity);
                lblMpgHwInfo.Text = Convert.ToString(s80.FuelHigh);
            }
            if (car == 3)
            {
                lblModelName.Text = s90.Model;
                lblMSRPInfo.Text = s90.msrp.ToString("C");
                lblEngineInfo.Text = s90.Engine;
                lblCylinderInfo.Text = Convert.ToString(s90.cylinder);
                lblHPInfo.Text = Convert.ToString(s90.horsePower);
                lblFuelInfo.Text = Convert.ToString(s90.fuelCapacity);
                lblCargoInfo.Text = Convert.ToString(s90.cargoCapacity);
                lblSeatInfo.Text = Convert.ToString(s90.seatingCapacity);
                lblMpgCityInfo.Text = Convert.ToString(s90.fuelCity);
                lblMpgHwInfo.Text = Convert.ToString(s90.FuelHigh);
            }
            if (car == 4)
            {
                lblModelName.Text = v60.Model;
                lblMSRPInfo.Text = v60.msrp.ToString("C");
                lblEngineInfo.Text = v60.Engine;
                lblCylinderInfo.Text = Convert.ToString(v60.cylinder);
                lblHPInfo.Text = Convert.ToString(v60.horsePower);
                lblFuelInfo.Text = Convert.ToString(v60.fuelCapacity);
                lblCargoInfo.Text = Convert.ToString(v60.cargoCapacity);
                lblSeatInfo.Text = Convert.ToString(v60.seatingCapacity);
                lblMpgCityInfo.Text = Convert.ToString(v60.fuelCity);
                lblMpgHwInfo.Text = Convert.ToString(v60.FuelHigh);
            }

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
            comboBox2.Enabled = true;
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
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

            s60.package = "Package A";
            s80.package = "Package A";
            s90.package = "Package A";
            v60.package = "Package A";
        }
        private void groupBoxB_Enter(object sender, EventArgs e)
        {
            radioBtnB1.Checked = true;
            radioBtnB2.Checked = true;
            radioBtnB3.Checked = true;
            radioBtnB4.Checked = true;
            radioBtnB5.Checked = true;

            groupBoxA.Enabled = false;

            s60.package = "Package B";
            s80.package = "Package B";
            s90.package = "Package B";
            v60.package = "Package B";
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
                s60.paint = "Standard Finish";
                s80.paint = "Standard Finish";
                s90.paint = "Standard Finish";
                v60.paint = "Standard Finish";
            }
            else
            {
                s60.paint = "Metallic Finish";
                s80.paint = "Metallic Finish";
                s90.paint = "Metallic Finish";
                v60.paint = "Metallic Finish";
            }
        }

        //Quote to MyAccount
        private void button1_Click(object sender, EventArgs e)
        {
            tabControlSales.SelectedTab = tabAccount;
            lblWelcomeName.Text = txtName.Text;
            //lblAccountNum.Text = 
            lblQuoteMSRPNum.Text = lblMSRPInfo.Text;
            //lblQuotePackageNum.Text = 
            //lblQuoteFinishNum.Text = 
            //lblQuoteTradeNum.Text = 
            //lblQuotePromoPromo.Text = 
            //lblQuoteEstNum.Text = 
        }
    }
}
