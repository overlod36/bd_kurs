﻿using System;
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
    public partial class customer_delete : Form
    {
        private string str_connection = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private SqlConnection SQL_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        public customer_delete()
        {
            InitializeComponent();
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            if (id_customer.Text != "")
            {
                
                this.SQL_connection.Open();
                SqlCommand check = new SqlCommand("select * from Orders where customer_id = @code", SQL_connection);
                check.Parameters.AddWithValue("@code", id_customer.Text);
                SqlDataReader rd = check.ExecuteReader();
                if (!rd.HasRows)
                {
                    rd.Close();
                    using (SQL_connection)
                    {
                        SqlCommand cm1 = new SqlCommand("delete from Customers where customer_id = @code", SQL_connection);
                        cm1.Parameters.AddWithValue("@code", Convert.ToInt32(id_customer.Text));
                        cm1.ExecuteNonQuery();
                        SQL_connection.Close();
                    }
                    return;
                }
                rd.Close();
                // вывод окна
            }
        }
    }
}
