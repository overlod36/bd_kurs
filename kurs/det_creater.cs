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
    public partial class det_creater : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private SqlDataReader SQL_datareader = null;
        public det_creater()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(this.str_connection))
            {
                con.Open();

                SqlCommand check1 = new SqlCommand("select * from Orders where order_id = @code", con);
                check1.Parameters.AddWithValue("@code", id_order.Text);
                SqlDataReader rd1 = check1.ExecuteReader();
                if (rd1.HasRows)
                {
                    rd1.Close();
                    SqlCommand check2 = new SqlCommand("select * from Goods where good_id = @gd", con);
                    check2.Parameters.AddWithValue("@gd", id_good.Text);
                    SqlDataReader rd2 = check2.ExecuteReader();
                    if (rd2.HasRows)
                    {
                        rd2.Close();
                        try 
                        {
                            SqlCommand cm1 = new SqlCommand("insert into Detailings(order_id, good_id)values(@oi,@gi)", con);
                            cm1.Parameters.AddWithValue("@oi", Convert.ToInt32(id_order.Text));
                            cm1.Parameters.AddWithValue("@gi", Convert.ToInt32(id_good.Text));
                            cm1.ExecuteNonQuery();
                        }
                        catch(Exception exc) { }
                        
                        con.Close();
                    }
                    
                }
            }
        }
    }
}
