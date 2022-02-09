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
    public partial class inst_delete : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        
        public inst_delete()
        {
            InitializeComponent();
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            if (table_box.Text != "" && key_box.Text != "")
            {
                this.SQL_connection.Open();
                
                if (table_box.Text == "Гитары")
                {
                    
                    SqlCommand check = new SqlCommand("select * from Goods where good_model = @code", SQL_connection);
                    check.Parameters.AddWithValue("@code", key_box.Text);
                    SqlDataReader rd = check.ExecuteReader();
                    if (!rd.HasRows)
                    {
                        rd.Close();
                        using (SQL_connection)
                        {
                            SqlCommand cm1 = new SqlCommand("delete from Guitars where guitar_model = @code", SQL_connection);
                            cm1.Parameters.AddWithValue("@code", key_box.Text);
                            cm1.ExecuteNonQuery();
                            SQL_connection.Close();
                        }
                        return;
                    }
                    rd.Close();
                    
                }
                else if (table_box.Text == "Педали")
                {
                    SqlCommand check = new SqlCommand("select * from Goods where good_model = @code", SQL_connection);
                    check.Parameters.AddWithValue("@code", key_box.Text);
                    SqlDataReader rd = check.ExecuteReader();
                    if (!rd.HasRows)
                    {
                        rd.Close();
                        using (SQL_connection)
                        {
                            SqlCommand cm1 = new SqlCommand("delete from Pedals where pedal_model = @code", SQL_connection);
                            cm1.Parameters.AddWithValue("@code", key_box.Text);
                            cm1.ExecuteNonQuery();
                            SQL_connection.Close();
                        }
                        return;
                    }
                    rd.Close();
                    
                }
                else if (table_box.Text == "Усилители")
                {
                    SqlCommand check = new SqlCommand("select * from Goods where good_model = @code", SQL_connection);
                    check.Parameters.AddWithValue("@code", key_box.Text);
                    SqlDataReader rd = check.ExecuteReader();
                    if (!rd.HasRows)
                    {
                        rd.Close();
                        using (SQL_connection)
                        {
                            SqlCommand cm1 = new SqlCommand("delete from Amplifiers where amplifier_model = @code", SQL_connection);
                            cm1.Parameters.AddWithValue("@code", key_box.Text);
                            cm1.ExecuteNonQuery();
                            SQL_connection.Close();
                        }
                        return;
                    }
                    rd.Close();
                    
                }
                
            }

        }
    }
}
