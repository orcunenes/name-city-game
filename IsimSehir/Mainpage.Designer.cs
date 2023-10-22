namespace IsimSehir
{
    partial class Mainpage
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
            this.startbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectedcategories = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Roundcount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.logintest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(345, 416);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(695, 132);
            this.startbtn.TabIndex = 0;
            this.startbtn.Text = "OYUNA BAŞLA";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.selectedcategories);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Location = new System.Drawing.Point(345, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 202);
            this.panel1.TabIndex = 1;
            // 
            // selectedcategories
            // 
            this.selectedcategories.AutoSize = true;
            this.selectedcategories.Location = new System.Drawing.Point(311, 26);
            this.selectedcategories.Name = "selectedcategories";
            this.selectedcategories.Size = new System.Drawing.Size(86, 13);
            this.selectedcategories.TabIndex = 1;
            this.selectedcategories.Text = "PLACEHOLDER";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "isim",
            "şehir",
            "hayvan",
            "bitki",
            "eşya",
            "ünlü"});
            this.checkedListBox1.Location = new System.Drawing.Point(39, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(149, 169);
            this.checkedListBox1.TabIndex = 0;
            // 
            // Roundcount
            // 
            this.Roundcount.Location = new System.Drawing.Point(901, 390);
            this.Roundcount.Name = "Roundcount";
            this.Roundcount.Size = new System.Drawing.Size(139, 20);
            this.Roundcount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(805, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ROUND SAYISI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "NAME :";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(384, 387);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(139, 20);
            this.nametxt.TabIndex = 4;
            // 
            // logintest
            // 
            this.logintest.Location = new System.Drawing.Point(382, 37);
            this.logintest.Name = "logintest";
            this.logintest.Size = new System.Drawing.Size(108, 23);
            this.logintest.TabIndex = 6;
            this.logintest.Text = "LOGINTEST";
            this.logintest.UseVisualStyleBackColor = true;
            this.logintest.Click += new System.EventHandler(this.logintest_Click);
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1403, 643);
            this.Controls.Add(this.logintest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Roundcount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startbtn);
            this.Name = "Mainpage";
            this.Text = "İsim Şehir ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label selectedcategories;
        private System.Windows.Forms.TextBox Roundcount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Button logintest;
    }
}

