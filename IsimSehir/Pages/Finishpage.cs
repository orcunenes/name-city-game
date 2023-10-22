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
    public partial class Finishpage : Form
    {
        public Finishpage()
        {
            InitializeComponent();
        }
        public int finalscore;
        public string playername;
        private void Finishpagecs_Load(object sender, EventArgs e)
        {
            pointlbl.Text = finalscore.ToString();
            namelbl.Text = playername;
        }
    }
}
