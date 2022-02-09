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
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }

        private void instrument_add_menu_button_Click(object sender, EventArgs e)
        {
            inst_menu_creater mc = new inst_menu_creater();
            mc.ShowDialog();
        }

        private void instrument_delete_menu_button_Click(object sender, EventArgs e)
        {
            inst_delete md = new inst_delete();
            md.ShowDialog();
        }

        private void instrument_show_menu_button_Click(object sender, EventArgs e)
        {
            inst_menu_show ms = new inst_menu_show();
            ms.ShowDialog();
        }

        private void good_add_menu_button_Click(object sender, EventArgs e)
        {
            gd_det_menu_create ms = new gd_det_menu_create();
            ms.ShowDialog();
        }

        private void good_delete_menu_button_Click(object sender, EventArgs e)
        {
            gd_det_menu_delete ms = new gd_det_menu_delete();
            ms.ShowDialog();
        }

        private void good_show_menu_button_Click(object sender, EventArgs e)
        {
            gd_det_menu_show ms = new gd_det_menu_show();
            ms.ShowDialog();
        }

        private void person_add_menu_button_Click(object sender, EventArgs e)
        {
            sell_cust_menu_create ms = new sell_cust_menu_create();
            ms.ShowDialog();
        }

        private void person_delete_menu_button_Click(object sender, EventArgs e)
        {
            sell_cust_menu_delete ms = new sell_cust_menu_delete();
            ms.ShowDialog();
        }

        private void person_show_menu_button_Click(object sender, EventArgs e)
        {
            sell_cust_menu_show ms = new sell_cust_menu_show();
            ms.ShowDialog();
        }

        private void order_add_menu_button_Click(object sender, EventArgs e)
        {
            order_creater ms = new order_creater();
            ms.ShowDialog();
        }

        private void order_show_menu_button_Click(object sender, EventArgs e)
        {
            order_show ms = new order_show();
            ms.ShowDialog();
        }

        private void order_delete_menu_button_Click(object sender, EventArgs e)
        {
            order_delete ms = new order_delete();
            ms.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inst_editor ms = new inst_editor();
            ms.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sc_editor ms = new sc_editor();
            ms.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            good_editor ms = new good_editor();
            ms.ShowDialog();
        }
    }
}
