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
    public partial class customer_editor : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

        public customer_editor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(this.str_connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand check = new SqlCommand("select * from Customers where customer_id = @code", con);
                check.Parameters.AddWithValue("@code", id_customer.Text);
                SqlDataReader rd = check.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        mail_customer.Text = rd.GetString(1);
                        card_customer.Text = rd.GetInt32(2).ToString();
                    }
                    mail_customer.Enabled = true;
                    card_customer.Enabled = true;
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(this.str_connection))
            {
                con.Open();
                try
                {
                    SqlCommand cm1 = new SqlCommand("update Customers set customer_mail = @t, customer_card_code = @sm where customer_id = @code", con);
                    cm1.Parameters.AddWithValue("@t", mail_customer.Text);
                    cm1.Parameters.AddWithValue("@sm", card_customer.Text);
                    cm1.Parameters.AddWithValue("@code", id_customer.Text);
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
