namespace IsimSehir.Pages
{
    partial class ResultPage
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
            this.animalresult = new System.Windows.Forms.TextBox();
            this.cityresult = new System.Windows.Forms.TextBox();
            this.nameresult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.finishbtn = new System.Windows.Forms.Button();
            this.namecb = new System.Windows.Forms.CheckBox();
            this.citycb = new System.Windows.Forms.CheckBox();
            this.animalcb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // animalresult
            // 
            this.animalresult.Location = new System.Drawing.Point(394, 195);
            this.animalresult.Name = "animalresult";
            this.animalresult.Size = new System.Drawing.Size(185, 20);
            this.animalresult.TabIndex = 14;
            // 
            // cityresult
            // 
            this.cityresult.Location = new System.Drawing.Point(394, 156);
            this.cityresult.Name = "cityresult";
            this.cityresult.Size = new System.Drawing.Size(185, 20);
            this.cityresult.TabIndex = 13;
            // 
            // nameresult
            // 
            this.nameresult.Location = new System.Drawing.Point(394, 121);
            this.nameresult.Name = "nameresult";
            this.nameresult.Size = new System.Drawing.Size(185, 20);
            this.nameresult.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "HAYVAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ŞEHİR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "İSİM";
            // 
            // finishbtn
            // 
            this.finishbtn.Location = new System.Drawing.Point(362, 267);
            this.finishbtn.Name = "finishbtn";
            this.finishbtn.Size = new System.Drawing.Size(289, 88);
            this.finishbtn.TabIndex = 8;
            this.finishbtn.Text = "BİTİR";
            this.finishbtn.UseVisualStyleBackColor = true;
            this.finishbtn.Click += new System.EventHandler(this.finishbtn_Click);
            // 
            // namecb
            // 
            this.namecb.AutoSize = true;
            this.namecb.Checked = true;
            this.namecb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.namecb.Location = new System.Drawing.Point(595, 124);
            this.namecb.Name = "namecb";
            this.namecb.Size = new System.Drawing.Size(38, 17);
            this.namecb.TabIndex = 15;
            this.namecb.Text = "✅";
            this.namecb.UseVisualStyleBackColor = true;
            // 
            // citycb
            // 
            this.citycb.AutoSize = true;
            this.citycb.Checked = true;
            this.citycb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.citycb.Location = new System.Drawing.Point(595, 159);
            this.citycb.Name = "citycb";
            this.citycb.Size = new System.Drawing.Size(38, 17);
            this.citycb.TabIndex = 16;
            this.citycb.Text = "✅";
            this.citycb.UseVisualStyleBackColor = true;
            // 
            // animalcb
            // 
            this.animalcb.AutoSize = true;
            this.animalcb.Checked = true;
            this.animalcb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.animalcb.Location = new System.Drawing.Point(595, 194);
            this.animalcb.Name = "animalcb";
            this.animalcb.Size = new System.Drawing.Size(38, 17);
            this.animalcb.TabIndex = 17;
            this.animalcb.Text = "✅";
            this.animalcb.UseVisualStyleBackColor = true;
            // 
            // ResultPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1053, 556);
            this.Controls.Add(this.animalcb);
            this.Controls.Add(this.citycb);
            this.Controls.Add(this.namecb);
            this.Controls.Add(this.animalresult);
            this.Controls.Add(this.cityresult);
            this.Controls.Add(this.nameresult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finishbtn);
            this.Name = "ResultPage";
            this.Text = "ResultPage";
            this.Load += new System.EventHandler(this.ResultPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox animalresult;
        private System.Windows.Forms.TextBox cityresult;
        private System.Windows.Forms.TextBox nameresult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button finishbtn;
        private System.Windows.Forms.CheckBox namecb;
        private System.Windows.Forms.CheckBox citycb;
        private System.Windows.Forms.CheckBox animalcb;
    }
}