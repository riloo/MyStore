using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore
{
    public partial class DisplayItems : Form
    {
        int id;
        public DisplayItems(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void DisplayItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTOREDataSet2.ITEMS' table. You can move, or remove it, as needed.
            this.iTEMSTableAdapter1.Fill(this.sTOREDataSet2.ITEMS);
            // TODO: This line of code loads data into the 'sTOREDataSet1.ITEMS' table. You can move, or remove it, as needed.
            this.iTEMSTableAdapter.Fill(this.sTOREDataSet1.ITEMS);
            this.Width = 800;
            this.Height = 500;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Width = 800;
            this.Height = 300;

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                String item = (String)dataGridView1[e.ColumnIndex - 3, e.RowIndex].Value;
                decimal price = Convert.ToDecimal(dataGridView1[e.ColumnIndex - 2, e.RowIndex].Value);
                int upc = (int)dataGridView1[e.ColumnIndex - 4, e.RowIndex].Value;

                int quantity = 0;
                if (dataGridView1[e.ColumnIndex - 1, e.RowIndex].Value != null)
                {
                    quantity = Convert.ToInt32(dataGridView1[e.ColumnIndex - 1, e.RowIndex].Value);

                    using (MyStoreDataDataContext db = new MyStoreDataDataContext())
                    {
                        int creditLimit = 10000;
                        var userBalance = db.USERs.Where(p => p.userID == id).Select(p => p.user_balance).First();
                        if (quantity * price > creditLimit - userBalance)
                        {
                            MessageBox.Show("That amount is over your credit limit!");
                        }
                        else
                        {
                            var date = Convert.ToDateTime(DateTime.Now.Date.ToString("MM/dd/yyyy"));

                            ORDER_DETAIL o = new ORDER_DETAIL();
                            o.order_date = date;
                            o.custID = id;
                            o.item_upc = upc;
                            o.order_quantity = quantity;
                            o.order_price = price * quantity;
                            //MessageBox.Show(date + " " + id + " " + upc + " " + quantity + " " + price * quantity);

                            db.ORDER_DETAILs.InsertOnSubmit(o);
                            db.SubmitChanges();

                            MessageBox.Show("You just bought " + quantity + " " + item + " for $" + price * quantity);
                        }
                    }
                }
                else MessageBox.Show("Please choose an amount greater than 0");
                
                
            }
        }

        private void homeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home = new Home(id);
            this.Hide();
            home.Show();
        }
    }
}
