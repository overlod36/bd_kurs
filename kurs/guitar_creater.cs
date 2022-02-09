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
    public partial class guitar_creater : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private SqlDataReader SQL_datareader = null;

        public guitar_creater()
        {
            InitializeComponent();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            guitar_model_box.Text = "";
            guitar_neck_material_box.Text = "";
            guitar_body_material_box.Text = "";
            guitar_body_color_box.Text = "";
            number_of_guitar_frets_box.Text = "";
            number_of_guitar_string_box.Text = "";
            guitar_orientation.Text = "";
            guitar_scale_length_box.Text = "";
            pictureBox1.Image = null;
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

        private void add_button_Click(object sender, EventArgs e)
        {
            this.SQL_connection.Open();
            Image photo = pictureBox1.Image;
            ImageConverter Conv = new ImageConverter();
            var ImgConv = Conv.ConvertTo(photo, typeof(byte[]));

            using (SqlConnection con = new SqlConnection(this.str_connection))
            {
                con.Open();
                try
                {
                    SqlCommand cm1 = new SqlCommand("insert into Guitars(guitar_model,guitar_pickup_type,guitar_neck_material,guitar_body_material,guitar_body_color,number_of_guitar_frets,guitar_orientation,guitar_scale_length,number_of_guitar_strings,guitar_picture)values(@guitar_model,@guitar_pickup_type,@guitar_neck_material,@guitar_body_material,@guitar_body_color,@number_of_guitar_frets,@guitar_orientation,@guitar_scale_length,@number_of_guitar_strings,@guitar_picture)", con);
                    cm1.Parameters.AddWithValue("@guitar_model", guitar_model_box.Text);
                    cm1.Parameters.AddWithValue("@guitar_pickup_type", "smth");
                    cm1.Parameters.AddWithValue("@guitar_neck_material", guitar_neck_material_box.Text);
                    cm1.Parameters.AddWithValue("@guitar_body_material", guitar_body_material_box.Text);
                    cm1.Parameters.AddWithValue("@guitar_body_color", guitar_body_color_box.Text);
                    cm1.Parameters.AddWithValue("@number_of_guitar_frets", Convert.ToInt32(number_of_guitar_frets_box.Text));
                    cm1.Parameters.AddWithValue("@guitar_orientation", guitar_orientation.Text);
                    cm1.Parameters.AddWithValue("@guitar_scale_length", Convert.ToDouble(guitar_scale_length_box.Text));
                    cm1.Parameters.AddWithValue("@number_of_guitar_strings", Convert.ToInt32(number_of_guitar_string_box.Text));
                    cm1.Parameters.AddWithValue("@guitar_picture", ImgConv);
                    cm1.ExecuteNonQuery();
                }
                catch { }
                con.Close();
            }
        }
    }
}
