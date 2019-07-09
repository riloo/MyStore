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
    public partial class SpecificPurchase : Form
    {
        int id;
        public SpecificPurchase(int id)
        {
            this.id = id;
            InitializeComponent();
            priceFromTxt.Enabled = false;
            priceFromLbl.Enabled = false;
            priceToTxt.Enabled = false;
            priceToLbl.Enabled = false;
            dateFromLbl.Enabled = false;
            dateFromPicker.Enabled = false;
            dateToLbl.Enabled = false;
            dateToPicker.Enabled = false;
        }

        private void purchaseList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SpecificPurchase_Load(object sender, EventArgs e)
        {

        }

        private void dateRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(dateRadio.Checked)
            {
                priceFromTxt.Enabled = false;
                priceFromLbl.Enabled = false;
                priceToTxt.Enabled = false;
                priceToLbl.Enabled = false;

                dateFromLbl.Enabled = true;
                dateFromPicker.Enabled = true;
                dateToLbl.Enabled = true;
                dateToPicker.Enabled = true;
            }            
        }

        private void priceRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(priceRadio.Checked)
            {
                dateFromLbl.Enabled = false;
                dateFromPicker.Enabled = false;
                dateToLbl.Enabled = false;
                dateToPicker.Enabled = false;

                priceFromTxt.Enabled = true;
                priceFromLbl.Enabled = true;
                priceToTxt.Enabled = true;
                priceToLbl.Enabled = true;
            }
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            using (MyStoreDataDataContext db = new MyStoreDataDataContext())
            {
                purchaseList.Items.Clear();

                if (dateRadio.Checked)
                {
                    DateTime dFrom = dateFromPicker.Value.Date;
                    DateTime dTo = dateToPicker.Value.Date;

                    var orders = from order in db.ORDER_DETAILs
                                 where id == order.custID
                                        && order.order_date >= dFrom
                                        && order.order_date <= dTo
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
                else if (priceRadio.Checked)
                {

                    decimal pFrom = Convert.ToDecimal(priceFromTxt.Text);
                    decimal pTo = Convert.ToDecimal(priceToTxt.Text);

                    var orders = from order in db.ORDER_DETAILs
                                 where id == order.custID
                                 where order.order_price >= pFrom
                                 where order.order_price <= pTo
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
        }

        private void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profile profile = new Profile(id);
            this.Hide();
            profile.Show();
        }
    }
}
