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
    public partial class order_creater : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private SqlDataReader SQL_datareader = null;
        public order_creater()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            this.SQL_connection.Open();
            using (SqlConnection con = new SqlConnection(this.str_connection))
            {
                con.Open();
                try
                {
                    SqlCommand cm1 = new SqlCommand("insert into Orders(seller_id, customer_id, status)values(@si, @ci, @st)", con);
                    cm1.Parameters.AddWithValue("@si", ID_seller.Text);
                    cm1.Parameters.AddWithValue("@ci", ID_customer.Text);
                    cm1.Parameters.AddWithValue("@st", order_status.Text);
                    cm1.ExecuteNonQuery();
                }
                catch (Exception exc)
                {

                }
                
                con.Close();
            }
        }
    }
}
