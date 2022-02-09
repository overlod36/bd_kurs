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
    public partial class gd_det_menu_show : Form
    {
        public gd_det_menu_show()
        {
            InitializeComponent();
        }

        private void det_button_Click(object sender, EventArgs e)
        {
            det_menu_show ms = new det_menu_show();
            ms.ShowDialog();
        }

        private void goods_button_Click(object sender, EventArgs e)
        {
            good_show ms = new good_show();
            ms.ShowDialog();
        }
    }
}
