namespace billSolution
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesap = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDownilk = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSon = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSonIndex = new System.Windows.Forms.Label();
            this.lblilkIndex = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblKullanım = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownilk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatura Tipi :";
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(320, 196);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(75, 23);
            this.btnHesap.TabIndex = 1;
            this.btnHesap.Text = "Hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDownilk
            // 
            this.numericUpDownilk.Location = new System.Drawing.Point(94, 70);
            this.numericUpDownilk.Name = "numericUpDownilk";
            this.numericUpDownilk.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownilk.TabIndex = 3;
            // 
            // numericUpDownSon
            // 
            this.numericUpDownSon.Location = new System.Drawing.Point(94, 121);
            this.numericUpDownSon.Name = "numericUpDownSon";
            this.numericUpDownSon.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "İlk İndex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Son Index:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ödenecek Tutar:";
            // 
            // lblSonIndex
            // 
            this.lblSonIndex.AutoSize = true;
            this.lblSonIndex.Location = new System.Drawing.Point(230, 128);
            this.lblSonIndex.Name = "lblSonIndex";
            this.lblSonIndex.Size = new System.Drawing.Size(13, 13);
            this.lblSonIndex.TabIndex = 0;
            this.lblSonIndex.Text = "  ";
            // 
            // lblilkIndex
            // 
            this.lblilkIndex.AutoSize = true;
            this.lblilkIndex.Location = new System.Drawing.Point(230, 77);
            this.lblilkIndex.Name = "lblilkIndex";
            this.lblilkIndex.Size = new System.Drawing.Size(0, 13);
            this.lblilkIndex.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kullanım Miktarı:";
            // 
            // lblKullanım
            // 
            this.lblKullanım.AutoSize = true;
            this.lblKullanım.Location = new System.Drawing.Point(167, 196);
            this.lblKullanım.Name = "lblKullanım";
            this.lblKullanım.Size = new System.Drawing.Size(13, 13);
            this.lblKullanım.TabIndex = 4;
            this.lblKullanım.Text = "  ";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(167, 251);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(13, 13);
            this.lblTutar.TabIndex = 4;
            this.lblTutar.Text = "  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 326);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblKullanım);
            this.Controls.Add(this.numericUpDownSon);
            this.Controls.Add(this.numericUpDownilk);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSonIndex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblilkIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownilk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownilk;
        private System.Windows.Forms.NumericUpDown numericUpDownSon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSonIndex;
        private System.Windows.Forms.Label lblilkIndex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblKullanım;
        private System.Windows.Forms.Label lblTutar;
    }
}

