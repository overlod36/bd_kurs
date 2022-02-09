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
    public partial class customers_creater : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private SqlDataReader SQL_datareader = null;
        public customers_creater()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(this.str_connection))
            {
                con.Open();
                try
                {
                    SqlCommand cm1 = new SqlCommand("insert into Customers(customer_id,customer_mail,customer_card_code)values(@customer_id,@customer_mail,@customer_card_code)", con);
                    cm1.Parameters.AddWithValue("@customer_id", id_customer.Text);
                    cm1.Parameters.AddWithValue("@customer_mail", mail_customer.Text);
                    cm1.Parameters.AddWithValue("@customer_card_code", card_customer.Text);
                    cm1.ExecuteNonQuery();
                }
                catch(Exception exc)
                {

                }
                
                con.Close();
            }
        }
    }
}
