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
    public partial class sell_cust_menu_show : Form
    {
        public sell_cust_menu_show()
        {
            InitializeComponent();
        }

        private void seller_button_Click(object sender, EventArgs e)
        {
            seller_show ms = new seller_show();
            ms.ShowDialog();
        }

        private void customer_button_Click(object sender, EventArgs e)
        {
            customer_show ms = new customer_show();
            ms.ShowDialog();
        }
    }
}
