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
    public partial class AllPurchases : Form
    {
        int id;
        public AllPurchases(int id)
        {
            this.id = id;
            InitializeComponent();
            using (MyStoreDataDataContext db = new MyStoreDataDataContext())
            {

                var orders = from order in db.ORDER_DETAILs
                             where id == order.custID
                             select order;


                foreach (var o in orders)
                {
                    String desc = db.ITEMs.Where(p => p.item_upc == o.item_upc).Select(p => p.item_description).First();
                    string[] row = {o.order_num.ToString(),
                                o.order_date.ToString(),
                                desc,
                                o.order_quantity.ToString(),
                                "$ " + o.order_price.ToString()};
                    var listViewItem = new ListViewItem(row);
                    purchaseList.Items.Add(listViewItem);

                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profile profile = new Profile(id);
            this.Hide();
            profile.Show();
        }
    }
}
