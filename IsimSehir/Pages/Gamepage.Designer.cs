namespace IsimSehir.Pages
{
    partial class Gamepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.finishbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.citytxt = new System.Windows.Forms.TextBox();
            this.animaltxt = new System.Windows.Forms.TextBox();
            this.Letterlabel = new System.Windows.Forms.Label();
            this.gamecount = new System.Windows.Forms.Label();
            this.scorelbl = new System.Windows.Forms.Label();
            this.playernametxtbox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // finishbtn
            // 
            this.finishbtn.Location = new System.Drawing.Point(522, 309);
            this.finishbtn.Name = "finishbtn";
            this.finishbtn.Size = new System.Drawing.Size(289, 88);
            this.finishbtn.TabIndex = 1;
            this.finishbtn.Text = "DURDUR";
            this.finishbtn.UseVisualStyleBackColor = true;
            this.finishbtn.Click += new System.EventHandler(this.finishbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "İSİM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ŞEHİR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "HAYVAN";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(576, 172);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(185, 20);
            this.nametxt.TabIndex = 5;
            this.nametxt.TextChanged += new System.EventHandler(this.checkfirstchar);
            this.nametxt.Enter += new System.EventHandler(this.textboxenter);
            this.nametxt.Leave += new System.EventHandler(this.textboxleave);
            // 
            // citytxt
            // 
            this.citytxt.Location = new System.Drawing.Point(576, 207);
            this.citytxt.Name = "citytxt";
            this.citytxt.Size = new System.Drawing.Size(185, 20);
            this.citytxt.TabIndex = 6;
            this.citytxt.TextChanged += new System.EventHandler(this.checkfirstchar);
            this.citytxt.Enter += new System.EventHandler(this.textboxenter);
            this.citytxt.Leave += new System.EventHandler(this.textboxleave);
            // 
            // animaltxt
            // 
            this.animaltxt.Location = new System.Drawing.Point(576, 246);
            this.animaltxt.Name = "animaltxt";
            this.animaltxt.Size = new System.Drawing.Size(185, 20);
            this.animaltxt.TabIndex = 7;
            this.animaltxt.TextChanged += new System.EventHandler(this.checkfirstchar);
            this.animaltxt.Enter += new System.EventHandler(this.textboxenter);
            this.animaltxt.Leave += new System.EventHandler(this.textboxleave);
            // 
            // Letterlabel
            // 
            this.Letterlabel.AutoSize = true;
            this.Letterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letterlabel.Location = new System.Drawing.Point(572, 77);
            this.Letterlabel.Name = "Letterlabel";
            this.Letterlabel.Size = new System.Drawing.Size(149, 24);
            this.Letterlabel.TabIndex = 8;
            this.Letterlabel.Text = "PLACEHOLDER";
            // 
            // gamecount
            // 
            this.gamecount.AutoSize = true;
            this.gamecount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamecount.Location = new System.Drawing.Point(1232, 13);
            this.gamecount.Name = "gamecount";
            this.gamecount.Size = new System.Drawing.Size(91, 20);
            this.gamecount.TabIndex = 9;
            this.gamecount.Text = "placeholder";
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.Location = new System.Drawing.Point(12, 9);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(81, 24);
            this.scorelbl.TabIndex = 10;
            this.scorelbl.Text = "SCORE:";
            // 
            // playernametxtbox
            // 
            this.playernametxtbox.AutoSize = true;
            this.playernametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playernametxtbox.Location = new System.Drawing.Point(12, 48);
            this.playernametxtbox.Name = "playernametxtbox";
            this.playernametxtbox.Size = new System.Drawing.Size(71, 24);
            this.playernametxtbox.TabIndex = 11;
            this.playernametxtbox.Text = "NAME:";
            // 
            // Gamepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1335, 628);
            this.Controls.Add(this.playernametxtbox);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.gamecount);
            this.Controls.Add(this.Letterlabel);
            this.Controls.Add(this.animaltxt);
            this.Controls.Add(this.citytxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finishbtn);
            this.Name = "Gamepage";
            this.Text = "Gamepage";
            this.Load += new System.EventHandler(this.Gamepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finishbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox citytxt;
        private System.Windows.Forms.TextBox animaltxt;
        private System.Windows.Forms.Label Letterlabel;
        private System.Windows.Forms.Label gamecount;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label playernametxtbox;
    }
}