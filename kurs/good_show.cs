using System;
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
    public partial class good_show : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private SqlDataAdapter adapter = null;
        private DataTable table = null;
        public good_show()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Goods", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            sqlConnection.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Goods ORDER BY good_price DESC", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            sqlConnection.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Goods ORDER BY good_price ASC", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            sqlConnection.Close();
        }
    }
}
