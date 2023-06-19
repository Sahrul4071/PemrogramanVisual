namespace UASVISUAL
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.panel1 = new System.Windows.Forms.Panel();
            this.KadoPanti = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.email = new System.Windows.Forms.Button();
            this.Google = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.KadoPanti);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(60, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 56);
            this.panel1.TabIndex = 5;
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
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.email);
            this.panel3.Controls.Add(this.Google);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(59, 33);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(1);
            this.panel3.Size = new System.Drawing.Size(683, 384);
            this.panel3.TabIndex = 6;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.CornflowerBlue;
            this.email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.email.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email.Location = new System.Drawing.Point(211, 193);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(247, 32);
            this.email.TabIndex = 8;
            this.email.Text = "Masuk Menggunakan Email";
            this.email.UseVisualStyleBackColor = false;
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // Google
            // 
            this.Google.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Google.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Google.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Google.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Google.Location = new System.Drawing.Point(211, 140);
            this.Google.Name = "Google";
            this.Google.Size = new System.Drawing.Size(247, 32);
            this.Google.TabIndex = 7;
            this.Google.Text = "Masuk Menggunakan Google";
            this.Google.UseVisualStyleBackColor = false;
            this.Google.Click += new System.EventHandler(this.DonasiSekarang_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
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
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form7";
            this.Text = "Formmasuk";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label KadoPanti;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Google;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button email;
    }
}