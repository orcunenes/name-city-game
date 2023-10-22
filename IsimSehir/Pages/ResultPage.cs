using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsimSehir.Pages
{
    public partial class ResultPage : Form
    {
        public ResultPage()
        {
            InitializeComponent();
        }
        public string name;
        public string city;
        public string animal;
        public int currentscore=0;
        private void ResultPage_Load(object sender, EventArgs e)
        {
            nameresult.Text = name;
            cityresult.Text = city;
            animalresult.Text = animal;
        }

        private void finishbtn_Click(object sender, EventArgs e)
        {
            if (namecb.Checked)
            {
                currentscore += 10;
            }
            if(citycb.Checked)
            {
                currentscore += 10;

            }
            if (animalcb.Checked) 
            {
                currentscore += 10;

            }
            this.Close();

        }
    }
}
