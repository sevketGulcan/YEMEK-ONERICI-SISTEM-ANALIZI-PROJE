namespace YemekOnerici
{
    partial class sonucEkrani
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
            this.sayi = new System.Windows.Forms.Label();
            this.isim_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.isim = new System.Windows.Forms.Label();
            this.malzeme_label = new System.Windows.Forms.Label();
            this.yapilis_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sayi
            // 
            this.sayi.AutoSize = true;
            this.sayi.BackColor = System.Drawing.Color.Transparent;
            this.sayi.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sayi.Location = new System.Drawing.Point(19, 20);
            this.sayi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sayi.Name = "sayi";
            this.sayi.Size = new System.Drawing.Size(156, 24);
            this.sayi.TabIndex = 1;
            this.sayi.Text = "0 Sonuç Bulundu.";
            // 
            // isim_label
            // 
            this.isim_label.AutoSize = true;
            this.isim_label.BackColor = System.Drawing.Color.Transparent;
            this.isim_label.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.isim_label.Location = new System.Drawing.Point(20, 59);
            this.isim_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isim_label.Name = "isim_label";
            this.isim_label.Size = new System.Drawing.Size(51, 24);
            this.isim_label.TabIndex = 10;
            this.isim_label.Text = "İsim:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(202, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.BackColor = System.Drawing.Color.Transparent;
            this.isim.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.isim.Location = new System.Drawing.Point(68, 59);
            this.isim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(65, 24);
            this.isim.TabIndex = 8;
            this.isim.Text = "label1";
            // 
            // malzeme_label
            // 
            this.malzeme_label.AutoSize = true;
            this.malzeme_label.BackColor = System.Drawing.Color.Transparent;
            this.malzeme_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.malzeme_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.malzeme_label.Location = new System.Drawing.Point(278, 106);
            this.malzeme_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.malzeme_label.Name = "malzeme_label";
            this.malzeme_label.Size = new System.Drawing.Size(102, 22);
            this.malzeme_label.TabIndex = 11;
            this.malzeme_label.Text = "Malzemeler:";
            // 
            // yapilis_lbl
            // 
            this.yapilis_lbl.AutoSize = true;
            this.yapilis_lbl.BackColor = System.Drawing.Color.Transparent;
            this.yapilis_lbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yapilis_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.yapilis_lbl.Location = new System.Drawing.Point(435, 106);
            this.yapilis_lbl.Name = "yapilis_lbl";
            this.yapilis_lbl.Size = new System.Drawing.Size(69, 22);
            this.yapilis_lbl.TabIndex = 12;
            this.yapilis_lbl.Text = "Yapılışı:";
            // 
            // sonucEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YemekOnerici.Properties.Resources.Notluk_Take_A_Note;
            this.ClientSize = new System.Drawing.Size(630, 526);
            this.Controls.Add(this.yapilis_lbl);
            this.Controls.Add(this.malzeme_label);
            this.Controls.Add(this.isim_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.sayi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "sonucEkrani";
            this.Text = "sonucEkrani";
            this.Load += new System.EventHandler(this.sonucEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label sayi;
        private System.Windows.Forms.Label isim_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.Label malzeme_label;
        private System.Windows.Forms.Label yapilis_lbl;
    }
}