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
    public partial class inst_menu_creater : Form
    {
        public inst_menu_creater()
        {
            InitializeComponent();
        }

        private void guitar_button_Click(object sender, EventArgs e)
        {
            guitar_creater gm = new guitar_creater();
            gm.ShowDialog();
        }

        private void amplifier_button_Click(object sender, EventArgs e)
        {
            amplifier_creater am = new amplifier_creater();
            am.ShowDialog();

        }

        private void pedal_button_Click(object sender, EventArgs e)
        {
            pedal_creater pm = new pedal_creater();
            pm.ShowDialog();
        }
    }
}
