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
    public partial class seller_creater : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private SqlDataReader SQL_datareader = null;
        public seller_creater()
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
                    SqlCommand cm1 = new SqlCommand("insert into Sellers(seller_id,first_seller_name,last_seller_name,seller_position)values(@seller_id,@first_seller_name,@last_seller_name,@seller_position)", con);
                    cm1.Parameters.AddWithValue("@seller_id", seller_id.Text);
                    cm1.Parameters.AddWithValue("@first_seller_name", first_seller_name.Text);
                    cm1.Parameters.AddWithValue("@last_seller_name", second_name_seller.Text);
                    cm1.Parameters.AddWithValue("@seller_position", position_seller.SelectedItem);
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
