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
using System.IO;

namespace kurs
{
    public partial class guitar_editor : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        public guitar_editor()
        {
            InitializeComponent();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(this.str_connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand check = new SqlCommand("select * from Guitars where guitar_model = @code", con);
                check.Parameters.AddWithValue("@code", guitar_model_box.Text);
                SqlDataReader rd = check.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        guitar_neck_material_box.Text = rd.GetString(2);
                        guitar_body_material_box.Text = rd.GetString(3);
                        guitar_body_color_box.Text = rd.GetString(4);
                        number_of_guitar_frets_box.Text = Convert.ToString(rd.GetInt32(5));
                        guitar_orientation.Text = rd.GetString(6);
                        guitar_scale_length_box.Text = rd.GetDouble(7).ToString();
                        number_of_guitar_string_box.Text = Convert.ToString(rd.GetInt32(8));
                        /*
                        var data = rd[9].ToString();
                        MemoryStream image_stream = new MemoryStream(Encoding.Default.GetBytes(data));
                        pictureBox1.Image = Image.FromStream(image_stream);
                        pictureBox1.Refresh();*/
                    }
                    guitar_neck_material_box.Enabled = true;
                    guitar_body_material_box.Enabled = true;
                    guitar_body_color_box.Enabled = true;
                    number_of_guitar_frets_box.Enabled = true;
                    guitar_orientation.Enabled = true;
                    guitar_scale_length_box.Enabled = true;
                    number_of_guitar_string_box.Enabled = true;
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
                    SqlCommand cm1 = new SqlCommand("update Guitars set guitar_model = @g_m, guitar_neck_material = @g_n_m, guitar_body_material = @g_b_m, guitar_body_color = @g_b_c, number_of_guitar_frets = @n_of_g_f, guitar_orientation = @g_o, guitar_scale_length = @g_s_l, number_of_guitar_strings = @n_of_g_s where guitar_model = @code", con);
                    cm1.Parameters.AddWithValue("@g_m", guitar_model_box.Text);
                    cm1.Parameters.AddWithValue("@g_n_m", guitar_neck_material_box.Text);
                    cm1.Parameters.AddWithValue("@g_b_m", guitar_body_material_box.Text);
                    cm1.Parameters.AddWithValue("@g_b_c", guitar_body_color_box.Text);
                    cm1.Parameters.AddWithValue("@n_of_g_f", Convert.ToInt32(number_of_guitar_frets_box.Text));
                    cm1.Parameters.AddWithValue("@g_o", guitar_orientation.Text);
                    cm1.Parameters.AddWithValue("@g_s_l", Convert.ToDouble(guitar_scale_length_box.Text));
                    cm1.Parameters.AddWithValue("@n_of_g_s", Convert.ToInt32(number_of_guitar_string_box.Text));
                    cm1.Parameters.AddWithValue("@code", guitar_model_box.Text);
                    cm1.ExecuteNonQuery();
                }
                catch(Exception exc) { }
                
                con.Close();
            }
        }
    }
}
