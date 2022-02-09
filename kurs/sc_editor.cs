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
    public partial class sc_editor : Form
    {
        public sc_editor()
        {
            InitializeComponent();
        }

        private void seller_button_Click(object sender, EventArgs e)
        {
            seller_editor ms = new seller_editor();
            ms.ShowDialog();
        }

        private void customer_button_Click(object sender, EventArgs e)
        {
            customer_editor ms = new customer_editor();
            ms.ShowDialog();
        }
    }
}
