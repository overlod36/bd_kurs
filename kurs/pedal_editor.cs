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
    public partial class pedal_editor : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        public pedal_editor()
        {
            InitializeComponent();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(this.str_connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand check = new SqlCommand("select * from Pedals where pedal_model = @code", con);
                check.Parameters.AddWithValue("@code", pedal_model.Text);
                SqlDataReader rd = check.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        pedal_type.Text = rd.GetString(1);
                        pedal_effect_box.Text = rd.GetString(2);
                    }
                    pedal_type.Enabled = true;
                    pedal_effect_box.Enabled = true;
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(this.str_connection))
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("update Pedals set pedal_type = @t, pedal_effect = @p where pedal_model = @code", con);
                cm1.Parameters.AddWithValue("@t", pedal_type.Text);
                cm1.Parameters.AddWithValue("@p", pedal_effect_box.Text);
                cm1.Parameters.AddWithValue("@code", pedal_model.Text);
                cm1.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
