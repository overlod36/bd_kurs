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
    public partial class good_editor : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

        public good_editor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(this.str_connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand check = new SqlCommand("select * from Goods where good_id = @code", con);
                check.Parameters.AddWithValue("@code", good_id.Text);
                SqlDataReader rd = check.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        try
                        {
                            good_price.Text = rd.GetInt32(1).ToString();
                            good_brand.Text = rd.GetString(2);
                            good_model.Text = rd.GetString(3);
                            good_type.Text = rd.GetString(4);
                        }
                        catch(Exception exc) { }
                    }
                    good_price.Enabled = true;
                    good_brand.Enabled = true;
                    good_type.Enabled = true;
                    good_model.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(this.str_connection))
            {
                con.Open();
                try
                {
                    SqlCommand cm1 = new SqlCommand("update Goods set good_price = @g_m, good_brand = @g_n_m, good_model = @g_b_m, good_type = @gt where good_id = @code", con);
                    cm1.Parameters.AddWithValue("@g_m", good_price.Text);
                    cm1.Parameters.AddWithValue("@g_n_m", good_brand.Text);
                    cm1.Parameters.AddWithValue("@g_b_m", good_model.Text);
                    cm1.Parameters.AddWithValue("@gt", good_type.Text);
                    cm1.Parameters.AddWithValue("@code", good_id.Text);
                    cm1.ExecuteNonQuery();
                }
                catch(Exception exc) { }
                
                con.Close();
            }
        }
    }
}
