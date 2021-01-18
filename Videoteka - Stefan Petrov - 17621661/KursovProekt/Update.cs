using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KursovProekt
{
    public partial class Update : UserControl
    {
        public Update()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=KursovProekt;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string selectQuery = "SELECT * FROM FirstTable WHERE MovieTitle='" + textBox7.Text + "';";
            SqlCommand command = new SqlCommand(selectQuery, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = (reader["MovieTitle"].ToString());
                textBox2.Text = (reader["Year"].ToString());
                textBox3.Text = (reader["Director"].ToString());
                textBox4.Text = (reader["Country"].ToString());
                textBox5.Text = (reader["NumberOfCopies"].ToString());
                textBox6.Text = (reader["Price"].ToString());
            }
            reader.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != ""&&
                textBox1.Text != "0" && textBox2.Text != "0" && textBox3.Text != "0" && textBox4.Text != "0" && textBox5.Text != "0" && textBox6.Text != "0")
            {

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string UpdateQuery = "UPDATE FirstTable SET MovieTitle='" + textBox1.Text + "',Year='" + textBox2.Text + "',Director='" + textBox3.Text +
                    "',Country='" + textBox4.Text + "',NumberOfCopies='" + textBox5.Text + "',Price='" + textBox6.Text + "'WHERE [MovieTitle]='" + textBox7.Text + "';";

                    SqlCommand cmd = new SqlCommand(UpdateQuery, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You've updated the movie '" + textBox1.Text + "' to the database!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                }
            }
            else MessageBox.Show("Error!");
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }
    }
}
