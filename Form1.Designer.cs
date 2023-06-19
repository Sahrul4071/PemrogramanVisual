namespace UASVISUAL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KadoPanti = new System.Windows.Forms.Label();
            this.Masuk = new System.Windows.Forms.Button();
            this.TentangKami = new System.Windows.Forms.Button();
            this.TRANSPARASI = new System.Windows.Forms.Button();
            this.FAQ = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(-1, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(87, 54);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(1);
            this.panel3.Size = new System.Drawing.Size(683, 384);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.Masuk);
            this.panel1.Controls.Add(this.KadoPanti);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(88, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 56);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Controls.Add(this.FAQ);
            this.panel4.Controls.Add(this.TRANSPARASI);
            this.panel4.Controls.Add(this.TentangKami);
            this.panel4.Location = new System.Drawing.Point(1, 328);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(682, 56);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // KadoPanti
            // 
            this.KadoPanti.AutoSize = true;
            this.KadoPanti.Font = new System.Drawing.Font("Muthiara -Demo Version-", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KadoPanti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KadoPanti.Location = new System.Drawing.Point(63, 17);
            this.KadoPanti.Name = "KadoPanti";
            this.KadoPanti.Size = new System.Drawing.Size(248, 39);
            this.KadoPanti.TabIndex = 3;
            this.KadoPanti.Text = "KADO PANTI JBI";
            this.KadoPanti.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Masuk
            // 
            this.Masuk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Masuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Masuk.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masuk.ForeColor = System.Drawing.Color.Transparent;
            this.Masuk.Location = new System.Drawing.Point(557, 11);
            this.Masuk.Name = "Masuk";
            this.Masuk.Size = new System.Drawing.Size(108, 37);
            this.Masuk.TabIndex = 4;
            this.Masuk.Text = "MASUK";
            this.Masuk.UseVisualStyleBackColor = false;
            this.Masuk.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TentangKami
            // 
            this.TentangKami.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TentangKami.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TentangKami.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TentangKami.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TentangKami.Location = new System.Drawing.Point(3, 3);
            this.TentangKami.Name = "TentangKami";
            this.TentangKami.Size = new System.Drawing.Size(222, 50);
            this.TentangKami.TabIndex = 5;
            this.TentangKami.Text = "TENTANG KAMI";
            this.TentangKami.UseVisualStyleBackColor = false;
            // 
            // TRANSPARASI
            // 
            this.TRANSPARASI.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TRANSPARASI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TRANSPARASI.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRANSPARASI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TRANSPARASI.Location = new System.Drawing.Point(230, 3);
            this.TRANSPARASI.Name = "TRANSPARASI";
            this.TRANSPARASI.Size = new System.Drawing.Size(222, 50);
            this.TRANSPARASI.TabIndex = 6;
            this.TRANSPARASI.Text = "TRANSPARASI";
            this.TRANSPARASI.UseVisualStyleBackColor = false;
            // 
            // FAQ
            // 
            this.FAQ.BackColor = System.Drawing.Color.CornflowerBlue;
            this.FAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FAQ.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FAQ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FAQ.Location = new System.Drawing.Point(456, 3);
            this.FAQ.Name = "FAQ";
            this.FAQ.Size = new System.Drawing.Size(222, 50);
            this.FAQ.TabIndex = 7;
            this.FAQ.Text = "FAQ";
            this.FAQ.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(683, 380);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label KadoPanti;
        private System.Windows.Forms.Button Masuk;
        private System.Windows.Forms.Button TentangKami;
        private System.Windows.Forms.Button FAQ;
        private System.Windows.Forms.Button TRANSPARASI;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

