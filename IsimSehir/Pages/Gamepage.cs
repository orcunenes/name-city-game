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
    public partial class Gamepage : Form
    {
        public Gamepage()
        {
            InitializeComponent();
        }
        List<string> charlist = new List<string>() { "a", "b", "c", "ç", "d", "e", "f", "g", "h", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z", "j" };
        string selectedchar;
        public int score=0;
        int currentgamecount = 0;
        public int totalgamecount;
        public string playername;
        private void Gamepage_Load(object sender, EventArgs e)
        {
            gamecount.Text = currentgamecount+"/"+totalgamecount;
            playernametxtbox.Text= playername;
            nextchar();
            scorelbl.Text = "SCORE:" + score;
        }
        public void nextchar()
        {
            if (currentgamecount >= totalgamecount)
            {
                Finishpage finishpage = new Finishpage();
                finishpage.finalscore = score;
                finishpage.playername = playername;

                finishpage.Show();
                this.Close();
            }
            Random random = new Random();
            int generatedrandom = random.Next(0, charlist.Count - 1);
            Letterlabel.Text = charlist[generatedrandom].ToUpper();
            selectedchar = charlist[generatedrandom].ToUpper();
            charlist.RemoveAt(generatedrandom);
            nametxt.Text = selectedchar+"...";
            nametxt.ForeColor = Color.LightGray;
            citytxt.Text = selectedchar+"...";
            citytxt.ForeColor = Color.LightGray;
            animaltxt.Text = selectedchar+"...";
            animaltxt.ForeColor = Color.LightGray;
            currentgamecount++;
            gamecount.Text = currentgamecount + "/" + totalgamecount;

        }

        private void finishbtn_Click(object sender, EventArgs e)
        {
            ResultPage resultPage   = new ResultPage();
            resultPage.animal = animaltxt.Text;
            resultPage.city = citytxt.Text;
            resultPage.name=nametxt.Text;
            resultPage.ShowDialog();
            score += resultPage.currentscore;
            nextchar();
            scorelbl.Text = "SCORE:" + score;

        }

        private void checkfirstchar(object sender, EventArgs e)
        {
            TextBox textbox=sender as TextBox;
            if (textbox.Text.FirstOrDefault().ToString().ToUpper() != selectedchar.ToUpper())
            {
                textbox.Text = string.Empty;
            }
        }

        private void textboxenter(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if(textbox.Text==selectedchar+"...") { textbox.Text = string.Empty;textbox.ForeColor = Color.Black; }

        }

        private void textboxleave(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == string.Empty) { textbox.Text = selectedchar+"..."; textbox.ForeColor = Color.LightGray; }

        }
    }
}
