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
    public partial class det_menu_show : Form
    {
        public det_menu_show()
        {
            InitializeComponent();
        }

        private void det_button_Click(object sender, EventArgs e)
        {
            det_show ms = new det_show();
            ms.ShowDialog();
        }

        private void goods_button_Click(object sender, EventArgs e)
        {
            det_one_show ms = new det_one_show();
            ms.ShowDialog();
        }
    }
}
