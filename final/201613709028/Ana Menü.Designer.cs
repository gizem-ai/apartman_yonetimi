
namespace _201613709028
{
    partial class Ana_Menu
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
            this.kasayagidenbuton = new System.Windows.Forms.Button();
            this.aparmanagidenbuton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kasayagidenbuton
            // 
            this.kasayagidenbuton.Location = new System.Drawing.Point(78, 92);
            this.kasayagidenbuton.Name = "kasayagidenbuton";
            this.kasayagidenbuton.Size = new System.Drawing.Size(75, 23);
            this.kasayagidenbuton.TabIndex = 3;
            this.kasayagidenbuton.Text = "Kasa";
            this.kasayagidenbuton.UseVisualStyleBackColor = true;
            this.kasayagidenbuton.Click += new System.EventHandler(this.kasayagidenbuton_Click);
            // 
            // aparmanagidenbuton
            // 
            this.aparmanagidenbuton.Location = new System.Drawing.Point(78, 49);
            this.aparmanagidenbuton.Name = "aparmanagidenbuton";
            this.aparmanagidenbuton.Size = new System.Drawing.Size(75, 23);
            this.aparmanagidenbuton.TabIndex = 2;
            this.aparmanagidenbuton.Text = "Apartman";
            this.aparmanagidenbuton.UseVisualStyleBackColor = true;
            this.aparmanagidenbuton.Click += new System.EventHandler(this.aparmanagidenbuton_Click);
            // 
            // Ana_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 171);
            this.Controls.Add(this.kasayagidenbuton);
            this.Controls.Add(this.aparmanagidenbuton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ana_Menu";
            this.Text = "Ana_Menü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ana_Menu_FormClosing);
            this.Load += new System.EventHandler(this.Ana_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kasayagidenbuton;
        private System.Windows.Forms.Button aparmanagidenbuton;
    }
}