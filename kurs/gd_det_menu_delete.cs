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
    public partial class gd_det_menu_delete : Form
    {
        public gd_det_menu_delete()
        {
            InitializeComponent();
        }

        private void goods_button_Click(object sender, EventArgs e)
        {
            good_delete ms = new good_delete();
            ms.ShowDialog();
        }

        private void det_button_Click(object sender, EventArgs e)
        {
            det_delete ms = new det_delete();
            ms.ShowDialog();
        }
    }
}
