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
    public partial class gd_det_menu_create : Form
    {
        public gd_det_menu_create()
        {
            InitializeComponent();
        }

        private void goods_button_Click(object sender, EventArgs e)
        {
            good_creater ms = new good_creater();
            ms.ShowDialog();
        }

        private void det_button_Click(object sender, EventArgs e)
        {
            det_creater ms = new det_creater();
            ms.ShowDialog();
        }
    }
}
