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

namespace KursovProekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Default defaultt = new Default();
        Insert insert = new Insert();
        Update update = new Update();
        Delete delete = new Delete();
        Customer customer = new Customer();
        Purchase purchase = new Purchase();
        Queries queries = new Queries();
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
        public string conString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=KursovProekt;Integrated Security=True";

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            buttonInfo.BackColor = Color.FromArgb(192, 192, 0);
            buttonInsert.BackColor = Color.FromArgb(41, 44, 51);
            buttonUpdate.BackColor = Color.FromArgb(41, 44, 51);
            buttonDelete.BackColor = Color.FromArgb(41, 44, 51);
            buttonCustomer.BackColor = Color.FromArgb(41, 44, 51);
            buttonPurchase.BackColor = Color.FromArgb(41, 44, 51);
            buttonQueries.BackColor = Color.FromArgb(41, 44, 51);
            defaultt.Show();
            insert.Hide();
            update.Hide();
            delete.Hide();
            customer.Hide();
            purchase.Hide();
            queries.Hide();
            insert.Dock = DockStyle.Fill;
            this.Controls.Add(defaultt);

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * From FirstTable", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                defaultt.dataGridView1.DataSource = dtbl;
            }
            

        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            buttonInfo.BackColor = Color.FromArgb(41,44,51);
            buttonInsert.BackColor = Color.FromArgb(192, 192, 0);
            buttonUpdate.BackColor = Color.FromArgb(41, 44, 51);
            buttonDelete.BackColor = Color.FromArgb(41, 44, 51);
            buttonCustomer.BackColor = Color.FromArgb(41, 44, 51);
            buttonPurchase.BackColor = Color.FromArgb(41, 44, 51);
            buttonQueries.BackColor = Color.FromArgb(41, 44, 51);
            defaultt.Hide();
            insert.Show();
            update.Hide();
            delete.Hide();
            customer.Hide();
            purchase.Hide();
            queries.Hide();
            insert.Dock = DockStyle.Fill;
            this.Controls.Add(insert);

            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            buttonInfo.BackColor = Color.FromArgb(41,44,51);
            buttonInsert.BackColor = Color.FromArgb(41, 44, 51);
            buttonUpdate.BackColor = Color.FromArgb(192,192,0);
            buttonDelete.BackColor = Color.FromArgb(41, 44, 51);
            buttonCustomer.BackColor = Color.FromArgb(41, 44, 51);
            buttonPurchase.BackColor = Color.FromArgb(41, 44, 51);
            buttonQueries.BackColor = Color.FromArgb(41, 44, 51);
            defaultt.Hide();
            insert.Hide();
            update.Show();
            delete.Hide();
            customer.Hide();
            purchase.Hide();
            queries.Hide();
            update.Dock = DockStyle.Fill;
            this.Controls.Add(update);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            buttonInfo.BackColor = Color.FromArgb(41, 44, 51);
            buttonInsert.BackColor = Color.FromArgb(41, 44, 51);
            buttonUpdate.BackColor = Color.FromArgb(41, 44, 51);
            buttonDelete.BackColor = Color.FromArgb(192, 192, 0);
            buttonCustomer.BackColor = Color.FromArgb(41, 44, 51);
            buttonPurchase.BackColor = Color.FromArgb(41, 44, 51);
            buttonQueries.BackColor = Color.FromArgb(41, 44, 51);
            defaultt.Hide();
            insert.Hide();
            update.Hide();
            delete.Show();
            customer.Hide();
            purchase.Hide();
            queries.Hide();
            delete.Dock = DockStyle.Fill;
            this.Controls.Add(delete);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        int TogMove;
        int MValX;
        int MValY;
        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if(TogMove==1)
            {
                this.SetDesktopLocation(MousePosition.X-MValX,MousePosition.Y-MValY);
            }
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            buttonInfo.BackColor = Color.FromArgb(41, 44, 51);
            buttonInsert.BackColor = Color.FromArgb(41, 44, 51);
            buttonUpdate.BackColor = Color.FromArgb(41, 44, 51);
            buttonDelete.BackColor = Color.FromArgb(41, 44, 51);
            buttonCustomer.BackColor = Color.FromArgb(192, 192, 0);
            buttonPurchase.BackColor = Color.FromArgb(41, 44, 51);
            buttonQueries.BackColor = Color.FromArgb(41, 44, 51);
            defaultt.Hide();
            insert.Hide();
            update.Hide();
            delete.Hide();
            customer.Show();
            purchase.Hide();
            queries.Hide();
            customer.Dock = DockStyle.Fill;
            this.Controls.Add(customer);

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * From CustomerTable", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                customer.dataGridView2.DataSource = dtbl;
                con.Close();
            }

        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            buttonInfo.BackColor = Color.FromArgb(41, 44, 51);
            buttonInsert.BackColor = Color.FromArgb(41, 44, 51);
            buttonUpdate.BackColor = Color.FromArgb(41, 44, 51);
            buttonDelete.BackColor = Color.FromArgb(41, 44, 51);
            buttonCustomer.BackColor = Color.FromArgb(41, 44, 51);
            buttonPurchase.BackColor = Color.FromArgb(192, 192, 0);
            buttonQueries.BackColor = Color.FromArgb(41, 44, 51);
            defaultt.Hide();
            insert.Hide();
            update.Hide();
            delete.Hide();
            customer.Hide();
            purchase.Show();
            queries.Hide();
            purchase.Dock = DockStyle.Fill;
            this.Controls.Add(purchase);

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select CustomerTable.FirstName,CustomerTable.LastName,FirstTable.MovieTitle,FirstTable.Price,CustomerTable.Phone,PurchaseTable.NumberOfCopies,PurchaseTable.DateOfPurchase From PurchaseTable" +
                    " INNER JOIN FirstTable ON PurchaseTable.MovieID=FirstTable.id  INNER JOIN CustomerTable ON PurchaseTable.CustomerID=CustomerTable.id", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                purchase.dataGridView3.DataSource = dtbl;
            }
        }

        private void buttonQueries_Click(object sender, EventArgs e)
        {
            buttonInfo.BackColor = Color.FromArgb(41, 44, 51);
            buttonInsert.BackColor = Color.FromArgb(41, 44, 51);
            buttonUpdate.BackColor = Color.FromArgb(41, 44, 51);
            buttonDelete.BackColor = Color.FromArgb(41, 44, 51);
            buttonCustomer.BackColor = Color.FromArgb(41, 44, 51);
            buttonPurchase.BackColor = Color.FromArgb(41, 44, 51);
            buttonQueries.BackColor = Color.FromArgb(192, 192, 0);
            defaultt.Hide();
            insert.Hide();
            update.Hide();
            delete.Hide();
            customer.Hide();
            purchase.Hide();
            queries.Show();
            purchase.Dock = DockStyle.Fill;
            this.Controls.Add(queries);
        }
    }
}
