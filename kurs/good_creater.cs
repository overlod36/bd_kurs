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
    public partial class good_creater : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private SqlDataReader SQL_datareader = null;
        public good_creater()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(this.str_connection))
            {
                con.Open();
                if (good_type.Text == "Гитара")
                {
                    this.SQL_connection.Open();
                    
                    SqlCommand check = new SqlCommand("select * from Guitars where guitar_model = @code", con);
                    check.Parameters.AddWithValue("@code", good_model.Text);
                    SqlDataReader rd = check.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Close();
                        try 
                        {
                            SqlCommand cm1 = new SqlCommand("insert into Goods(good_id, good_price, good_brand, good_model, good_type)values(@gi,@gp,@gb,@gm,@gt)", con);
                            cm1.Parameters.AddWithValue("@gi", good_id.Text);
                            cm1.Parameters.AddWithValue("@gp", good_price.Text);
                            cm1.Parameters.AddWithValue("@gb", good_brand.Text);
                            cm1.Parameters.AddWithValue("@gm", good_model.Text);
                            cm1.Parameters.AddWithValue("@gt", good_type.Text);
                            cm1.ExecuteNonQuery();
                        }
                        catch(Exception exc) { }
                        con.Close();
                    }
                }
                else if(good_type.Text == "Усилитель")
                {
                    this.SQL_connection.Open();
                    SqlCommand check = new SqlCommand("select * from Amplifiers where amplifier_model = @code",con);
                    check.Parameters.AddWithValue("@code", good_model.Text);
                    SqlDataReader rd = check.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Close();
                        try
                        {
                            SqlCommand cm1 = new SqlCommand("insert into Goods(good_id, good_price, good_brand, good_model, good_type)values(@gi,@gp,@gb,@gm,@gt)", con);
                            cm1.Parameters.AddWithValue("@gi", good_id.Text);
                            cm1.Parameters.AddWithValue("@gp", good_price.Text);
                            cm1.Parameters.AddWithValue("@gb", good_brand.Text);
                            cm1.Parameters.AddWithValue("@gm", good_model.Text);
                            cm1.Parameters.AddWithValue("@gt", good_type.Text);
                            cm1.ExecuteNonQuery();
                        }
                        catch(Exception exc) { }
                        con.Close();
                    }
                }
                else if (good_type.Text == "Педаль")
                {
                    this.SQL_connection.Open();
                    SqlCommand check = new SqlCommand("select * from Pedals where pedal_model = @code",con);
                    check.Parameters.AddWithValue("@code", good_model.Text);
                    SqlDataReader rd = check.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Close();
                        try
                        {
                            SqlCommand cm1 = new SqlCommand("insert into Goods(good_id, good_price, good_brand, good_model, good_type)values(@gi,@gp,@gb,@gm,@gt)", con);
                            cm1.Parameters.AddWithValue("@gi", good_id.Text);
                            cm1.Parameters.AddWithValue("@gp", good_price.Text);
                            cm1.Parameters.AddWithValue("@gb", good_brand.Text);
                            cm1.Parameters.AddWithValue("@gm", good_model.Text);
                            cm1.Parameters.AddWithValue("@gt", good_type.Text);
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
