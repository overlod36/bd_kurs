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
    public partial class amplifier_creater : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private SqlDataReader SQL_datareader = null;
        public amplifier_creater()
        {
            InitializeComponent();
        }

        private void choose_image_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Выбор файла";
            of.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(of.FileName);
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            amplifier_model_box.Text = "";
            amplifier_power_box.Text = "";
            amplifier_type.Text = "";
            amplifier_speaker_model_box.Text = "";
            number_of_amplifier_channels_box.Text = "";
        }

        private void add_button_Click(object sender, EventArgs e)
        {

            Image photo = pictureBox1.Image;
            ImageConverter Conv = new ImageConverter();
            var ImgConv = Conv.ConvertTo(photo, typeof(byte[]));

            using (SqlConnection con = new SqlConnection(this.str_connection))
            {
                con.Open();
                try
                {
                    SqlCommand cm1 = new SqlCommand("insert into Amplifiers(amplifier_model,amplifier_type,amplifier_speakers_model,amplifier_number_of_channels,amplifier_power,amplifier_picture)values(@amplifier_model,@amplifier_type,@amplifier_speakers_model,@amplifier_number_of_channels,@amplifier_power,@amplifier_picture)", con);

                    cm1.Parameters.AddWithValue("@amplifier_model", amplifier_model_box.Text);
                    cm1.Parameters.AddWithValue("@amplifier_type", amplifier_type.Text);
                    cm1.Parameters.AddWithValue("@amplifier_speakers_model", amplifier_speaker_model_box.Text);
                    cm1.Parameters.AddWithValue("@amplifier_power", amplifier_power_box.Text);
                    cm1.Parameters.AddWithValue("@amplifier_number_of_channels", number_of_amplifier_channels_box.Text);
                    cm1.Parameters.AddWithValue("@amplifier_picture", ImgConv);
                    cm1.ExecuteNonQuery();
                }
                catch(Exception exc) { }
                
                con.Close();
            }

        }
    }
}
