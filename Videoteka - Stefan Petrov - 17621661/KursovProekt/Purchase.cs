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
    public partial class Purchase : UserControl
    {
        public Purchase()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=KursovProekt;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox1.Text != "0" && textBox2.Text != "0" && textBox3.Text != "0" && textBox4.Text != "0")
            {
                int counter = 0;
                string queryString = " Select FirstTable.NumberOfCopies From FirstTable Where id="+ textBox1.Text.ToString();
                using (SqlConnection connection = new SqlConnection(conString))
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            counter = reader.GetInt32(0);
                            reader.Close();
                        }
                    }
                }
                int intMovieId = int.Parse(textBox3.Text);
                Console.WriteLine(counter);
                Console.WriteLine(intMovieId);
                if (counter < intMovieId)
                {
                    MessageBox.Show("We can't complete your order!Too many movies!");
                }
                else
                {
                    string q = "insert into PurchaseTable (MovieID,CustomerID,NumberOfCopies,DateOfPurchase) values('" + textBox1.Text.ToString() + "','"
                        + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    string a = "Select CustomerTable.FirstName From PurchaseTable INNER JOIN CustomerTable ON PurchaseTable.CustomerID=CustomerTable.id Where CustomerID=" + textBox2.Text.ToString();
                    string b = "Select FirstTable.MovieTitle From PurchaseTable INNER JOIN FirstTable ON PurchaseTable.MovieID=FirstTable.id Where MovieID=" + textBox1.Text.ToString();

                    SqlCommand cmd2 = new SqlCommand(a, con);
                    SqlCommand cmd3 = new SqlCommand(b, con);
                    string customerName = (string)cmd2.ExecuteScalar();
                    string movieName = (string)cmd3.ExecuteScalar();
                    MessageBox.Show("You've created a new purchase!\n'" + "The Customer " + customerName + " bought the movie " + movieName + " !");

                    //--------------------------------Subtract NumberOfCopies From the Database

                    string qq = "UPDATE FirstTable SET FirstTable.NumberOfCopies=FirstTable.NumberOfCopies-'" + textBox3.Text.ToString() +
                        "' From FirstTable Inner Join PurchaseTable ON FirstTable.id=PurchaseTable.MovieID WHERE PurchaseTable.MovieID= '" + textBox1.Text.ToString() + "';";
                    SqlCommand cmd4 = new SqlCommand(qq, con);
                    Console.WriteLine(qq);
                    cmd4.ExecuteNonQuery();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
            }
            else MessageBox.Show("Error!");
            con.Close();

            using (SqlConnection con2 = new SqlConnection(conString))
            {
                con2.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select CustomerTable.FirstName,CustomerTable.LastName,FirstTable.MovieTitle,FirstTable.Price,CustomerTable.Phone,PurchaseTable.NumberOfCopies,PurchaseTable.DateOfPurchase From PurchaseTable" +
                    " INNER JOIN FirstTable ON PurchaseTable.MovieID=FirstTable.id  INNER JOIN CustomerTable ON PurchaseTable.CustomerID=CustomerTable.id", con2);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView3.DataSource = dtbl;
            }
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '/';

        }
    }
}
