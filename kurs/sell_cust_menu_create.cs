using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public partial class sell_cust_menu_create : Form
    {
        public sell_cust_menu_create()
        {
            InitializeComponent();
        }

        private void guitar_button_Click(object sender, EventArgs e)
        {
            seller_creater ms = new seller_creater();
            ms.ShowDialog();
        }

        private void amplifier_button_Click(object sender, EventArgs e)
        {
            customers_creater ms = new customers_creater();
            ms.ShowDialog();
        }
    }
}
