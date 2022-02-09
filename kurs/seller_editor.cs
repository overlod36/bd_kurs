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
    public partial class seller_editor : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

        public seller_editor()
        {
            InitializeComponent();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(this.str_connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand check = new SqlCommand("select * from Sellers where seller_id = @code", con);
                check.Parameters.AddWithValue("@code", seller_id.Text);
                SqlDataReader rd = check.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        first_seller_name.Text = rd.GetString(1);
                        second_name_seller.Text = rd.GetString(2);
                        position_seller.Text = rd.GetString(3);
                    }
                    first_seller_name.Enabled = true;
                    second_name_seller.Enabled = true;
                    position_seller.Enabled = true;
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
                    SqlCommand cm1 = new SqlCommand("update Sellers set first_seller_name = @t, last_seller_name = @sm, seller_position = @ch where seller_id = @code", con);
                    cm1.Parameters.AddWithValue("@t", first_seller_name.Text);
                    cm1.Parameters.AddWithValue("@sm", second_name_seller.Text);
                    cm1.Parameters.AddWithValue("@ch", position_seller.Text);
                    cm1.Parameters.AddWithValue("@code", seller_id.Text);
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
