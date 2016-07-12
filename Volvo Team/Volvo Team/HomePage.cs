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

        private void picBoxTrade_Click(object sender, EventArgs e)
        {
            Sales salesForm = new Sales();
            
            HomePage.ActiveForm.Hide();
            salesForm.Show();
        }

        private void picBoxInventory_Click(object sender, EventArgs e)
        {
            Sales salesForm = new Sales();
            HomePage.ActiveForm.Hide();
            salesForm.Show();
        }
    }
}
