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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            main_menu menu1 = new main_menu();
            menu1.ShowDialog();
        }
    }
}
