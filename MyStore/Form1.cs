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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void loginLbl_Click(object sender, EventArgs e)
        {
            //var conn = Singleton.Instance;
            MyStoreDataDataContext db = new MyStoreDataDataContext();

            if(db.USERs.Where(p => p.username == usernameTxt.Text && p.user_password == passTxt.Text).Count() == 1)
            {
                var id = db.USERs.Where(p => p.username == usernameTxt.Text).Select(p => p.userID).First();
                Home home = new Home(id);
                this.Hide();
                db.Dispose();
                home.Show();

            }
            else
            {
                MessageBox.Show("Wrong username or password! Please try again!" );
            }
        }

        private void usernamelbl_Click(object sender, EventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {
            passTxt.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 600;
            this.Height = 400;
        }
    }
}
