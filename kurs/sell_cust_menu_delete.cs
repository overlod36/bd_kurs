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
    public partial class sell_cust_menu_delete : Form
    {
        public sell_cust_menu_delete()
        {
            InitializeComponent();
        }

        private void seller_button_Click(object sender, EventArgs e)
        {
            seller_delete ms = new seller_delete();
            ms.ShowDialog();
        }

        private void customer_button_Click(object sender, EventArgs e)
        {
            customer_delete ms = new customer_delete();
            ms.ShowDialog();
        }
    }
}
