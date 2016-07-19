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
        CarClass s60 = new CarClass("S60", "2.0 Liter Turbocharge Direct - Injection", 34150, 17.8, 12, 38, 26, 5, 240, 4);
        CarClass s80 = new CarClass("S80", "2.0 Liter Turbocharge Direct - Injection", 43450, 18.5, 14.9, 37, 25, 5, 240, 4);
        CarClass s90 = new CarClass("S90", "In-Line Turbocharge", 46950, 14.5, 13.5, 0, 0, 5, 250, 4);
        CarClass V60 = new CarClass("V60", "2.5 Turbocharged", 41200, 17.8, 43.8, 28, 20, 5, 250, 5);


        //function to display car inforamtion
        public void DisplayCar(int car)
        {
            if (car == 1)
            {
                lblModelName.Text = s60.Model;
                lblMSRPInfo.Text = Convert.ToString(s60.MSRP);
                lblEngineInfo.Text = s60.Engine;
            }
            if (car == 2)
            {
                lblModelName.Text = s80.Model;
                lblMSRPInfo.Text = Convert.ToString(s60.MSRP);
                lblEngineInfo.Text = s60.Engine;
            }
            if (car == 3)
            {
                lblModelName.Text = s90.Model;
                lblMSRPInfo.Text = Convert.ToString(s60.MSRP);
                lblEngineInfo.Text = s60.Engine;
            }
            if (car == 4)
            {
                lblModelName.Text = V60.Model;
                lblMSRPInfo.Text = Convert.ToString(s60.MSRP);
                lblEngineInfo.Text = s60.Engine;
            }

        }

        //show firs car in inventory
        
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

        //select all radio buttons per groupBox
        private void groupBoxA_Enter(object sender, EventArgs e)
        {
            radioBtnA1.Checked = true;
            radioBtnA2.Checked = true;
            radioBtnA3.Checked = true;

            groupBoxB.Enabled = false;
        }
        private void groupBoxB_Enter(object sender, EventArgs e)
        {
            radioBtnB1.Checked = true;
            radioBtnB2.Checked = true;
            radioBtnB3.Checked = true;
            radioBtnB4.Checked = true;
            radioBtnB5.Checked = true;

            groupBoxA.Enabled = false;
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
    }
}
