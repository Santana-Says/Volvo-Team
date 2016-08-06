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
    public partial class HomePage: Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void splashScreen()
        {

        }

        private void picBoxTrade_Click(object sender, EventArgs e)
        {
            Sales salesForm = new Sales();
            HomePage.ActiveForm.Hide();
            salesForm.changeTabs(1);
            salesForm.Show();
        }

        private void picBoxInventory_Click(object sender, EventArgs e)
        {
            Sales salesForm = new Sales();
            HomePage.ActiveForm.Hide();
            salesForm.Show();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picBoxSplash.BringToFront();
            picBoxSplash.Hide();
            timer1.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SalesRecords recordsForm = new SalesRecords();
            HomePage.ActiveForm.Hide();
            recordsForm.Show();
        }
    }
}
