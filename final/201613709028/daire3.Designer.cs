
namespace _201613709028
{
    partial class daire3
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
            this.silbutonu = new System.Windows.Forms.Button();
            this.eklebutonu = new System.Windows.Forms.Button();
            this.daire3no = new System.Windows.Forms.MaskedTextBox();
            this.daire3kisisoyAd = new System.Windows.Forms.TextBox();
            this.daire3kisiAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.apartmanadonenbuton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.daire3kisiSayisi = new System.Windows.Forms.TextBox();
            this.onaylaButonu = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // silbutonu
            // 
            this.silbutonu.Location = new System.Drawing.Point(187, 56);
            this.silbutonu.Name = "silbutonu";
            this.silbutonu.Size = new System.Drawing.Size(75, 23);
            this.silbutonu.TabIndex = 7;
            this.silbutonu.Text = "Sil";
            this.silbutonu.UseVisualStyleBackColor = true;
            // 
            // eklebutonu
            // 
            this.eklebutonu.Location = new System.Drawing.Point(187, 4);
            this.eklebutonu.Name = "eklebutonu";
            this.eklebutonu.Size = new System.Drawing.Size(75, 23);
            this.eklebutonu.TabIndex = 5;
            this.eklebutonu.Text = "Ekle";
            this.eklebutonu.UseVisualStyleBackColor = true;
            this.eklebutonu.Click += new System.EventHandler(this.eklebutonu_Click);
            // 
            // daire3no
            // 
            this.daire3no.Location = new System.Drawing.Point(74, 84);
            this.daire3no.Mask = "(999) 000-0000";
            this.daire3no.Name = "daire3no";
            this.daire3no.Size = new System.Drawing.Size(100, 20);
            this.daire3no.TabIndex = 4;
            // 
            // daire3kisisoyAd
            // 
            this.daire3kisisoyAd.Location = new System.Drawing.Point(74, 58);
            this.daire3kisisoyAd.Name = "daire3kisisoyAd";
            this.daire3kisisoyAd.Size = new System.Drawing.Size(100, 20);
            this.daire3kisisoyAd.TabIndex = 3;
            // 
            // daire3kisiAd
            // 
            this.daire3kisiAd.Location = new System.Drawing.Point(74, 32);
            this.daire3kisiAd.Name = "daire3kisiAd";
            this.daire3kisiAd.Size = new System.Drawing.Size(100, 20);
            this.daire3kisiAd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad: ";
            // 
            // apartmanadonenbuton
            // 
            this.apartmanadonenbuton.Location = new System.Drawing.Point(187, 82);
            this.apartmanadonenbuton.Name = "apartmanadonenbuton";
            this.apartmanadonenbuton.Size = new System.Drawing.Size(75, 23);
            this.apartmanadonenbuton.TabIndex = 8;
            this.apartmanadonenbuton.Text = "Geri";
            this.apartmanadonenbuton.UseVisualStyleBackColor = true;
            this.apartmanadonenbuton.Click += new System.EventHandler(this.apartmanadonenbuton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kişi Sayısı:";
            // 
            // daire3kisiSayisi
            // 
            this.daire3kisiSayisi.Location = new System.Drawing.Point(74, 6);
            this.daire3kisiSayisi.Name = "daire3kisiSayisi";
            this.daire3kisiSayisi.Size = new System.Drawing.Size(100, 20);
            this.daire3kisiSayisi.TabIndex = 1;
            this.daire3kisiSayisi.TextChanged += new System.EventHandler(this.daire3kisiSayisi_TextChanged);
            this.daire3kisiSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.daire3kisiSayisi_KeyPress);
            // 
            // onaylaButonu
            // 
            this.onaylaButonu.Location = new System.Drawing.Point(187, 31);
            this.onaylaButonu.Name = "onaylaButonu";
            this.onaylaButonu.Size = new System.Drawing.Size(75, 23);
            this.onaylaButonu.TabIndex = 6;
            this.onaylaButonu.Text = "Onayla";
            this.onaylaButonu.UseVisualStyleBackColor = true;
            this.onaylaButonu.Click += new System.EventHandler(this.onaylaButonu_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 110);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(250, 95);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // daire3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 211);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.onaylaButonu);
            this.Controls.Add(this.daire3kisiSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apartmanadonenbuton);
            this.Controls.Add(this.silbutonu);
            this.Controls.Add(this.eklebutonu);
            this.Controls.Add(this.daire3no);
            this.Controls.Add(this.daire3kisisoyAd);
            this.Controls.Add(this.daire3kisiAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "daire3";
            this.Text = "daire3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.daire3_FormClosing);
            this.Load += new System.EventHandler(this.daire3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button silbutonu;
        private System.Windows.Forms.Button eklebutonu;
        private System.Windows.Forms.MaskedTextBox daire3no;
        private System.Windows.Forms.TextBox daire3kisisoyAd;
        private System.Windows.Forms.TextBox daire3kisiAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apartmanadonenbuton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox daire3kisiSayisi;
        private System.Windows.Forms.Button onaylaButonu;
        private System.Windows.Forms.ListView listView1;
    }
}