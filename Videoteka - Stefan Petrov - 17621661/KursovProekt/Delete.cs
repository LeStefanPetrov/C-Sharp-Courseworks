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
    public partial class Delete : UserControl
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }
        public string conString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=KursovProekt;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string DeleteQuery = "Delete From FirstTable Where MovieTitle='" + textBox3.Text + "';";
                SqlCommand cmd = new SqlCommand(DeleteQuery, con);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("There is no such movie in this database!");
                }
                else MessageBox.Show("The movie '" + textBox3.Text+"' is no longer part of the database!");
            }
            textBox3.Text = "";
            con.Close();
        }
    }
}
