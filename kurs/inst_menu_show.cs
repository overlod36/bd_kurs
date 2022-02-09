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
    public partial class inst_menu_show : Form
    {
        public inst_menu_show()
        {
            InitializeComponent();
        }

        private void guitar_button_Click(object sender, EventArgs e)
        {
            guitar_show ms = new guitar_show();
            ms.ShowDialog();
        }

        private void amplifier_button_Click(object sender, EventArgs e)
        {
            amplifier_show ms = new amplifier_show();
            ms.ShowDialog();
        }

        private void pedal_button_Click(object sender, EventArgs e)
        {
            pedal_show ms = new pedal_show();
            ms.ShowDialog();
        }
    }
}
