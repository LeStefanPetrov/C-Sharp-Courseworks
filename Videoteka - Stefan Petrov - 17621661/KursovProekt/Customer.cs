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
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=KursovProekt;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            textBox3.MaxLength = 10;
            textBox5.MaxLength = 10;

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != ""  &&
                textBox1.Text != "0" && textBox2.Text != "0" && textBox3.Text != "0" && textBox4.Text != "0" && textBox5.Text != "0" )
            {
                if (con.State == System.Data.ConnectionState.Open)
                {

                    string q = "insert into CustomerTable (FirstName,LastName,EGN,Address,Phone) values('" + textBox1.Text.ToString() + "','"
                        + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You've added the person '" + textBox1.Text +" "+textBox2.Text+ "' to the database!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            }
            else MessageBox.Show("Error!");
            con.Close();
                                                                                                      
            using (SqlConnection con2 = new SqlConnection(conString))
            {
                con2.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * From CustomerTable", con2);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView2.DataSource = dtbl;

            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
