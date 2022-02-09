using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace kurs
{
    public partial class guitar_tab_form : Form
    {
        public void iniz()
        {
            
        }
        public guitar_tab_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Guitars". При необходимости она может быть перемещена или удалена.
            this.guitarsTableAdapter.Fill(this.baseDataSet.Guitars);

        }
    }
}

