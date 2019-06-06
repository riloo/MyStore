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
    public partial class Home : Form
    {
        int id;
        public Home(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayItems display = new DisplayItems(id);
            this.Hide();
            display.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Width = 600;
            this.Height = 400;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(id);
            this.Hide();
            profile.ShowDialog();
        }

        private void logoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }
    }
}
