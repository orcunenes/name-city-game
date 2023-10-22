using IsimSehir.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IsimSehir.Utils;
using System.Runtime.Remoting.Contexts;

namespace IsimSehir
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void login_Load(object sender, EventArgs e)
        {
            registerpanel.Visible = false;

        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            connect.connection.Open();

            string sql = "select * from users where username='"+usernametxt.Text+"'";
            SQLiteCommand cmd = new SQLiteCommand(sql, connect.connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == usernametxt.Text)
                {
                    if (reader[1].ToString() == passwordtxt.Text)
                    {
                        Mainpage mainpage = new Mainpage();
                        mainpage.onlineuser = usernametxt.Text;
                        this.Hide();
                        mainpage.Show();
                    }
                }
            }
            connect.connection.Close();
            
        }

        private void registerlbl_Click(object sender, EventArgs e)
        {
            registerpanel.Visible = true;
            loginpanel.Visible = false;

        }

        private void gobackloginlbl_Click(object sender, EventArgs e)
        {
            loginpanel.Visible = true;
            registerpanel.Visible = false;

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            connect.connection.Open();

            string sql = "Insert into users(username,password,onlinestatus) Values('" +registerusername.Text + "','" +registerpass.Text+"','"+"1'"+ ")"; ;

            SQLiteCommand cmd = new SQLiteCommand(sql, connect.connection);
            cmd.ExecuteReader();
            connect.connection.Close();
            this.Hide();
            

        }
    }
}
