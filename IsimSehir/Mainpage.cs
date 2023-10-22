using IsimSehir.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsimSehir
{
    public partial class Mainpage : Form
    {
        public string onlineuser;
        public Mainpage()
        {
            InitializeComponent();

        }
        private void Mainpage_Load(object sender, EventArgs e)
        {
            onlineusername.Text = onlineuser;
            selectedcategories.Text = string.Empty;
        }
        private void startbtn_Click(object sender, EventArgs e)
        {
            Gamepage gamepage = new Gamepage();
            if (Roundcount.Text == string.Empty)
            {
                gamepage.totalgamecount = 2;
            }
            else
            {
                gamepage.totalgamecount = Convert.ToInt32(Roundcount.Text);
            }
            gamepage.playername = onlineuser;
            gamepage.Show();
            this.Hide();
        }

        private void logintest_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // An item is checked, so add it to the label
                selectedcategories.Text += checkedListBox1.Items[e.Index].ToString() + ", ";
            }
            else
            {
                // An item is unchecked, so remove it from the label
                string itemToRemove = checkedListBox1.Items[e.Index].ToString() + ", ";
                selectedcategories.Text = selectedcategories.Text.Replace(itemToRemove, "");
            }
        }
    }
}
