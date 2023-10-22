﻿using IsimSehir.Pages;
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
        public Mainpage()
        {
            InitializeComponent();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            Gamepage gamepage = new Gamepage();
            gamepage.totalgamecount = Convert.ToInt32(Roundcount.Text);
            gamepage.playername=nametxt.Text;
            gamepage.Show();
            this.Hide();
        }

        private void logintest_Click(object sender, EventArgs e)
        {
            login login=new login();
            login.Show();
        }
    }
}
