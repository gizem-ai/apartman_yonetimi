
namespace _201613709028
{
    partial class daire1
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
            this.daire1no = new System.Windows.Forms.MaskedTextBox();
            this.daire1kisisoyAd = new System.Windows.Forms.TextBox();
            this.daire1kisiAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.apartmanadonenbuton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.daire1kisiSayisi = new System.Windows.Forms.TextBox();
            this.onaylaButonu = new System.Windows.Forms.Button();
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
            this.silbutonu.Click += new System.EventHandler(this.silbutonu_Click);
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
            // daire1no
            // 
            this.daire1no.Location = new System.Drawing.Point(74, 84);
            this.daire1no.Mask = "(999) 000-0000";
            this.daire1no.Name = "daire1no";
            this.daire1no.Size = new System.Drawing.Size(100, 20);
            this.daire1no.TabIndex = 4;
            // 
            // daire1kisisoyAd
            // 
            this.daire1kisisoyAd.Location = new System.Drawing.Point(74, 58);
            this.daire1kisisoyAd.Name = "daire1kisisoyAd";
            this.daire1kisisoyAd.Size = new System.Drawing.Size(100, 20);
            this.daire1kisisoyAd.TabIndex = 3;
            // 
            // daire1kisiAd
            // 
            this.daire1kisiAd.Location = new System.Drawing.Point(74, 32);
            this.daire1kisiAd.Name = "daire1kisiAd";
            this.daire1kisiAd.Size = new System.Drawing.Size(100, 20);
            this.daire1kisiAd.TabIndex = 2;
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
            this.label2.Location = new System.Drawing.Point(12, 61);
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
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 110);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(250, 95);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kişi Sayısı:";
            // 
            // daire1kisiSayisi
            // 
            this.daire1kisiSayisi.Location = new System.Drawing.Point(74, 6);
            this.daire1kisiSayisi.Name = "daire1kisiSayisi";
            this.daire1kisiSayisi.Size = new System.Drawing.Size(100, 20);
            this.daire1kisiSayisi.TabIndex = 1;
            this.daire1kisiSayisi.TextChanged += new System.EventHandler(this.daire1kisiSayisi_TextChanged);
            this.daire1kisiSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.daire1kisiSayisi_KeyPress);
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
            // daire1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 211);
            this.Controls.Add(this.onaylaButonu);
            this.Controls.Add(this.daire1kisiSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.apartmanadonenbuton);
            this.Controls.Add(this.silbutonu);
            this.Controls.Add(this.eklebutonu);
            this.Controls.Add(this.daire1no);
            this.Controls.Add(this.daire1kisisoyAd);
            this.Controls.Add(this.daire1kisiAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "daire1";
            this.Text = "daire1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.daire1_FormClosing);
            this.Load += new System.EventHandler(this.daire1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button silbutonu;
        private System.Windows.Forms.Button eklebutonu;
        private System.Windows.Forms.MaskedTextBox daire1no;
        private System.Windows.Forms.TextBox daire1kisisoyAd;
        private System.Windows.Forms.TextBox daire1kisiAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apartmanadonenbuton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox daire1kisiSayisi;
        private System.Windows.Forms.Button onaylaButonu;
    }
}