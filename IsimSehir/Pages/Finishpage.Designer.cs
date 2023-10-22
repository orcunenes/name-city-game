namespace IsimSehir.Pages
{
    partial class Finishpage
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
            this.namelbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pointlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(517, 305);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(149, 24);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "PLACEHOLDER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IsimSehir.Properties.Resources.istockphoto_1025281982_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(448, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pointlbl
            // 
            this.pointlbl.AutoSize = true;
            this.pointlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointlbl.ForeColor = System.Drawing.Color.Red;
            this.pointlbl.Location = new System.Drawing.Point(530, 342);
            this.pointlbl.Name = "pointlbl";
            this.pointlbl.Size = new System.Drawing.Size(119, 18);
            this.pointlbl.TabIndex = 2;
            this.pointlbl.Text = "PLACEHOLDER";
            // 
            // Finishpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 529);
            this.Controls.Add(this.pointlbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.namelbl);
            this.Name = "Finishpage";
            this.Text = "Finishpagecs";
            this.Load += new System.EventHandler(this.Finishpagecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pointlbl;
    }
}