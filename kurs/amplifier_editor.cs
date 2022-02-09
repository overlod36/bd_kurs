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
    public partial class amplifier_editor : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        public amplifier_editor()
        {
            InitializeComponent();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(this.str_connection))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand check = new SqlCommand("select * from Amplifiers where amplifier_model = @code", con);
                check.Parameters.AddWithValue("@code", amplifier_model.Text);
                SqlDataReader rd = check.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        amplifier_type.Text = rd.GetString(1);
                        amplifier_speaker_model_box.Text = rd.GetString(2);
                        number_of_amplifier_channels_box.Text = rd.GetInt32(3).ToString();
                        amplifier_power_box.Text = Convert.ToString(rd.GetInt32(4));
                                                
                    }
                    amplifier_type.Enabled = true;
                    amplifier_speaker_model_box.Enabled = true;
                    number_of_amplifier_channels_box.Enabled = true;
                    amplifier_power_box.Enabled = true;
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
                    SqlCommand cm1 = new SqlCommand("update Amplifiers set amplifier_type = @t, amplifier_speakers_model = @sm, amplifier_number_of_channels = @ch, amplifier_power = @p  where amplifier_model = @code", con);
                    cm1.Parameters.AddWithValue("@t", amplifier_type.Text);
                    cm1.Parameters.AddWithValue("@sm", amplifier_speaker_model_box.Text);
                    cm1.Parameters.AddWithValue("@ch", number_of_amplifier_channels_box.Text);
                    cm1.Parameters.AddWithValue("@p", amplifier_power_box.Text);
                    cm1.Parameters.AddWithValue("@code", amplifier_model.Text);
                    cm1.ExecuteNonQuery();
                }
                catch(Exception exc) { }
                
                con.Close();
            }
        }
    }
}
