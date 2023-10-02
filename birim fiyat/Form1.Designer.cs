namespace birim_fiyat
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
            this.lblBirimfiyat = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.txtBirimfiyat = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBirimfiyat
            // 
            this.lblBirimfiyat.AutoSize = true;
            this.lblBirimfiyat.Location = new System.Drawing.Point(113, 42);
            this.lblBirimfiyat.Name = "lblBirimfiyat";
            this.lblBirimfiyat.Size = new System.Drawing.Size(50, 13);
            this.lblBirimfiyat.TabIndex = 0;
            this.lblBirimfiyat.Text = "birim fiyat";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(113, 178);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(28, 13);
            this.lblSonuc.TabIndex = 1;
            this.lblSonuc.Text = "tutar";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(113, 105);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(35, 13);
            this.lblMiktar.TabIndex = 2;
            this.lblMiktar.Text = "miktar";
            // 
            // txtBirimfiyat
            // 
            this.txtBirimfiyat.Location = new System.Drawing.Point(236, 34);
            this.txtBirimfiyat.Name = "txtBirimfiyat";
            this.txtBirimfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtBirimfiyat.TabIndex = 3;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(236, 102);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtMiktar.TabIndex = 4;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(82, 230);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(188, 58);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 306);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtBirimfiyat);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblBirimfiyat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBirimfiyat;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.TextBox txtBirimfiyat;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnHesapla;
    }
}

