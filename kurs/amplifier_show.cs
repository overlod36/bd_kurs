﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace kurs
{
    public partial class amplifier_show : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private SqlDataAdapter adapter = null;
        private DataTable table = null;
        public amplifier_show()
        {
            InitializeComponent();
        }

        private void amplifier_show_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Amplifiers", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
