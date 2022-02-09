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
    public partial class det_one_show : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private SqlDataAdapter adapter = null;
        private DataTable table = null;
        public det_one_show()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string sql_c = String.Format("SELECT * FROM Detailings WHERE order_id = {0}", order_key.Text);
            adapter = new SqlDataAdapter(sql_c, sqlConnection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            sqlConnection.Close();
        }
    }
}
