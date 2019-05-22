namespace UI.WinForm
{
    partial class StokHareketForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMarkaStok = new System.Windows.Forms.ComboBox();
            this.cbAyakabiStok = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nupNumaraStok = new System.Windows.Forms.NumericUpDown();
            this.nupAdetStok = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rbGirisStok = new System.Windows.Forms.RadioButton();
            this.rbCıkısStok = new System.Windows.Forms.RadioButton();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumaraStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAdetStok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ayakkabi:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbMarkaStok
            // 
            this.cbMarkaStok.FormattingEnabled = true;
            this.cbMarkaStok.Location = new System.Drawing.Point(217, 43);
            this.cbMarkaStok.Margin = new System.Windows.Forms.Padding(5);
            this.cbMarkaStok.Name = "cbMarkaStok";
            this.cbMarkaStok.Size = new System.Drawing.Size(199, 28);
            this.cbMarkaStok.TabIndex = 1;
            this.cbMarkaStok.SelectedIndexChanged += new System.EventHandler(this.cbMarkaStok_SelectedIndexChanged);
            // 
            // cbAyakabiStok
            // 
            this.cbAyakabiStok.FormattingEnabled = true;
            this.cbAyakabiStok.Location = new System.Drawing.Point(217, 103);
            this.cbAyakabiStok.Margin = new System.Windows.Forms.Padding(5);
            this.cbAyakabiStok.Name = "cbAyakabiStok";
            this.cbAyakabiStok.Size = new System.Drawing.Size(199, 28);
            this.cbAyakabiStok.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numara:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adet:";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // nupNumaraStok
            // 
            this.nupNumaraStok.Location = new System.Drawing.Point(217, 171);
            this.nupNumaraStok.Margin = new System.Windows.Forms.Padding(5);
            this.nupNumaraStok.Name = "nupNumaraStok";
            this.nupNumaraStok.Size = new System.Drawing.Size(200, 26);
            this.nupNumaraStok.TabIndex = 2;
            // 
            // nupAdetStok
            // 
            this.nupAdetStok.Location = new System.Drawing.Point(217, 219);
            this.nupAdetStok.Margin = new System.Windows.Forms.Padding(5);
            this.nupAdetStok.Name = "nupAdetStok";
            this.nupAdetStok.Size = new System.Drawing.Size(200, 26);
            this.nupAdetStok.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "İslemYönü:";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbGirisStok
            // 
            this.rbGirisStok.AutoSize = true;
            this.rbGirisStok.Location = new System.Drawing.Point(227, 290);
            this.rbGirisStok.Margin = new System.Windows.Forms.Padding(5);
            this.rbGirisStok.Name = "rbGirisStok";
            this.rbGirisStok.Size = new System.Drawing.Size(64, 24);
            this.rbGirisStok.TabIndex = 3;
            this.rbGirisStok.TabStop = true;
            this.rbGirisStok.Text = "Giris";
            this.rbGirisStok.UseVisualStyleBackColor = true;
            // 
            // rbCıkısStok
            // 
            this.rbCıkısStok.AutoSize = true;
            this.rbCıkısStok.Location = new System.Drawing.Point(339, 290);
            this.rbCıkısStok.Margin = new System.Windows.Forms.Padding(5);
            this.rbCıkısStok.Name = "rbCıkısStok";
            this.rbCıkısStok.Size = new System.Drawing.Size(65, 24);
            this.rbCıkısStok.TabIndex = 3;
            this.rbCıkısStok.TabStop = true;
            this.rbCıkısStok.Text = "Cıkıs";
            this.rbCıkısStok.UseVisualStyleBackColor = true;
            this.rbCıkısStok.CheckedChanged += new System.EventHandler(this.rbCıkısStok_CheckedChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(342, 355);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(89, 50);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // StokHareketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 430);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rbCıkısStok);
            this.Controls.Add(this.rbGirisStok);
            this.Controls.Add(this.nupAdetStok);
            this.Controls.Add(this.nupNumaraStok);
            this.Controls.Add(this.cbAyakabiStok);
            this.Controls.Add(this.cbMarkaStok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StokHareketForm";
            this.Text = "StokHareketForm";
            this.Load += new System.EventHandler(this.StokHareketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupNumaraStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAdetStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMarkaStok;
        private System.Windows.Forms.ComboBox cbAyakabiStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupNumaraStok;
        private System.Windows.Forms.NumericUpDown nupAdetStok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbGirisStok;
        private System.Windows.Forms.RadioButton rbCıkısStok;
        private System.Windows.Forms.Button btnKaydet;
    }
}