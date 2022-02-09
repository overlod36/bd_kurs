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
    public partial class order_delete : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        public order_delete()
        {
            InitializeComponent();
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            if (id_order.Text != "")
            {
                this.SQL_connection.Open();
                using (SQL_connection)
                {
                    SqlCommand cm1 = new SqlCommand("delete from Orders where order_id = @code", SQL_connection);
                    cm1.Parameters.AddWithValue("@code", Convert.ToInt32(id_order.Text));
                    cm1.ExecuteNonQuery();
                    SQL_connection.Close();
                }

            }
        }
    }
}
