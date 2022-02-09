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
    public partial class inst_editor : Form
    {
        public inst_editor()
        {
            InitializeComponent();
        }

        private void guitar_button_Click(object sender, EventArgs e)
        {
            guitar_editor ms = new guitar_editor();
            ms.ShowDialog();
        }

        private void amplifier_button_Click(object sender, EventArgs e)
        {
            amplifier_editor ms = new amplifier_editor();
            ms.ShowDialog();
        }

        private void pedal_button_Click(object sender, EventArgs e)
        {
            pedal_editor ms = new pedal_editor();
            ms.ShowDialog();
        }
    }
}
