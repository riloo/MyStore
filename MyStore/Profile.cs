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
    public partial class Profile : Form
    {
        private int id;        

        public Profile(int id)
        {
            this.id = id;
            InitializeComponent();

            using (MyStoreDataDataContext db = new MyStoreDataDataContext())
            {

                var user = from u in db.USERs
                           where id == u.userID
                           select u;

                fillName.Text = user.First().username;
                fillAddress.Text = user.First().user_address;
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            this.Width = 375;
            this.Height = 400;
        }

        private void specPurchTxt_Click(object sender, EventArgs e)
        {
            SpecificPurchase spec = new SpecificPurchase(id);
            this.Hide();
            spec.Show();
        }

        private void balanceTxt_Click(object sender, EventArgs e)
        {
            AccountBalance balance = new AccountBalance(id);
            this.Hide();
            balance.Show();
        }

        private void homeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home = new Home(id);
            this.Hide();
            home.Show();
        }

        private void logoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

        private void allPurchTxt_Click(object sender, EventArgs e)
        {
            AllPurchases all = new AllPurchases(id);
            this.Hide();
            all.Show();
        }

    }
}
