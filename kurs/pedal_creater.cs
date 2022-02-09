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
    public partial class pedal_creater : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private SqlDataReader SQL_datareader = null;
        public pedal_creater()
        {
            InitializeComponent();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            pedal_effect_box.Text = "";
            pedal_model_box.Text = "";
            pedal_type.Text = "";
            pictureBox1.Image = null;
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
                    SqlCommand cm1 = new SqlCommand("insert into Pedals(pedal_model,pedal_type,pedal_effect)values(@pedal_model,@pedal_type,@pedal_effect)", con);
                    cm1.Parameters.AddWithValue("@pedal_model", pedal_model_box.Text);
                    cm1.Parameters.AddWithValue("@pedal_type", pedal_type.Text);
                    cm1.Parameters.AddWithValue("@pedal_effect", pedal_effect_box.Text);
                    cm1.Parameters.AddWithValue("@pedal_picture", ImgConv);
                    cm1.ExecuteNonQuery();
                }
                catch
                {

                }
                
                con.Close();
            }
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
    }
}
