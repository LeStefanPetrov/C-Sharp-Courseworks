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
    public partial class Queries : UserControl
    {
        public Queries()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=KursovProekt;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != ""&&textBox1.Text != "0"&& textBox2.Text != "0")
            {
                using (SqlConnection con2 = new SqlConnection(conString))
                {
                    con2.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT CustomerTable.FirstName,CustomerTable.LastName,CustomerTable.Phone,CustomerTable.Address" +
                        ",FirstTable.MovieTitle,FirstTable.NumberOfCopies,FirstTable.Price FROM PurchaseTable INNER JOIN FirstTable ON PurchaseTable.MovieID=FirstTable.id " +
                        "INNER JOIN CustomerTable ON PurchaseTable.CustomerID=CustomerTable.id WHERE CustomerTable.FirstName='" + textBox1.Text.ToString() + "'AND  CustomerTable.LastName='" +
                        textBox2.Text.ToString()+"'", con2);
                    
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dataGridView5.DataSource = dtbl;

                }
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else MessageBox.Show("Error!");

        }
    }
}
