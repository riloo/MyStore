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
    public partial class AccountBalance : Form
    {
        private int id;
        MyStoreDataDataContext db = new MyStoreDataDataContext();

        public AccountBalance(int id)
        {
            this.id = id;
            InitializeComponent();
            
            var user = from u in db.USERs
                       where id == u.userID
                       select u.user_balance;

            fillBalance.Text = user.First().ToString();
        }

        private void balanceTxt_TextChanged(object sender, EventArgs e)
        {
                     
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            double pay = 0.0;
            if (payAmt.Text != "")
            {
                pay = Convert.ToDouble(payAmt.Text);
            }
            else MessageBox.Show("Invalid Amount!");
            String sql = "UPDATE USERS SET USER_BALANCE = USER_BALANCE + " + pay + " WHERE USERID = " + id;
            db.ExecuteCommand(sql);
            var user = from u in db.USERs
                       where id == u.userID
                       select u.user_balance;

            fillBalance.Text = user.First().ToString();
        }

        private void payAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccountBalance_Load(object sender, EventArgs e)
        {

        }

        private void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profile profile = new Profile(id);
            this.Close();
            profile.Show();
        }
    }
}
