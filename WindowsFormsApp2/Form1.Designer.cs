namespace WindowsFormsApp2
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Yukseklik1 = new System.Windows.Forms.TextBox();
            this.Genislik1 = new System.Windows.Forms.TextBox();
            this.MerkezY1 = new System.Windows.Forms.TextBox();
            this.MerkezX1 = new System.Windows.Forms.TextBox();
            this.Yaricap1 = new System.Windows.Forms.TextBox();
            this.Derinlik1 = new System.Windows.Forms.TextBox();
            this.MerkezZ1 = new System.Windows.Forms.TextBox();
            this.MerkezZ2 = new System.Windows.Forms.TextBox();
            this.Derinlik2 = new System.Windows.Forms.TextBox();
            this.Yaricap2 = new System.Windows.Forms.TextBox();
            this.MerkezY2 = new System.Windows.Forms.TextBox();
            this.Genislik2 = new System.Windows.Forms.TextBox();
            this.Yukseklik2 = new System.Windows.Forms.TextBox();
            this.MerkezX2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DenetimL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nokta, Dörtgen çarpişma denetimi",
            "Nokta, çember çarpişma denetimi",
            "Dikdörtgen, dikdörtgen çarpişma denetimi",
            "Dikdörtgen, çember çarpişma denetimi",
            "Çember, çember çarpişma denetimi",
            "Nokta, Küre çarpişma denetimi",
            "Nokta, dikdörtgen prizma çarpişma denetimi",
            "Nokta, Silindir çarpişma denetimi",
            "Silindir, silindir çarpişma denetimi",
            "Küre, küre çarpişma denetimi",
            "Küre silindir çarpişma denetimi",
            "Yüzey, küre çarpişma denetimi",
            "Yüzey, dikdörtgen prizma çarpişma denetimi",
            "Yüzey silindir çarpişma denetimi",
            "Küre, dikdörtgen prizma çarpişma denetimi",
            "Dikdörtgen prizma, dikdörtgen prizma çarpişma denetimi"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(288, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 457);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Yukseklik1
            // 
            this.Yukseklik1.Location = new System.Drawing.Point(12, 125);
            this.Yukseklik1.Name = "Yukseklik1";
            this.Yukseklik1.Size = new System.Drawing.Size(115, 20);
            this.Yukseklik1.TabIndex = 3;
            // 
            // Genislik1
            // 
            this.Genislik1.Location = new System.Drawing.Point(12, 168);
            this.Genislik1.Name = "Genislik1";
            this.Genislik1.Size = new System.Drawing.Size(115, 20);
            this.Genislik1.TabIndex = 4;
            // 
            // MerkezY1
            // 
            this.MerkezY1.Location = new System.Drawing.Point(12, 359);
            this.MerkezY1.Name = "MerkezY1";
            this.MerkezY1.Size = new System.Drawing.Size(115, 20);
            this.MerkezY1.TabIndex = 5;
            // 
            // MerkezX1
            // 
            this.MerkezX1.Location = new System.Drawing.Point(12, 311);
            this.MerkezX1.Name = "MerkezX1";
            this.MerkezX1.Size = new System.Drawing.Size(115, 20);
            this.MerkezX1.TabIndex = 6;
            // 
            // Yaricap1
            // 
            this.Yaricap1.Location = new System.Drawing.Point(12, 261);
            this.Yaricap1.Name = "Yaricap1";
            this.Yaricap1.Size = new System.Drawing.Size(115, 20);
            this.Yaricap1.TabIndex = 7;
            // 
            // Derinlik1
            // 
            this.Derinlik1.Location = new System.Drawing.Point(12, 214);
            this.Derinlik1.Name = "Derinlik1";
            this.Derinlik1.Size = new System.Drawing.Size(115, 20);
            this.Derinlik1.TabIndex = 8;
            // 
            // MerkezZ1
            // 
            this.MerkezZ1.Location = new System.Drawing.Point(12, 403);
            this.MerkezZ1.Name = "MerkezZ1";
            this.MerkezZ1.Size = new System.Drawing.Size(115, 20);
            this.MerkezZ1.TabIndex = 9;
            // 
            // MerkezZ2
            // 
            this.MerkezZ2.Location = new System.Drawing.Point(146, 403);
            this.MerkezZ2.Name = "MerkezZ2";
            this.MerkezZ2.Size = new System.Drawing.Size(115, 20);
            this.MerkezZ2.TabIndex = 16;
            // 
            // Derinlik2
            // 
            this.Derinlik2.Location = new System.Drawing.Point(146, 214);
            this.Derinlik2.Name = "Derinlik2";
            this.Derinlik2.Size = new System.Drawing.Size(115, 20);
            this.Derinlik2.TabIndex = 15;
            // 
            // Yaricap2
            // 
            this.Yaricap2.Location = new System.Drawing.Point(146, 261);
            this.Yaricap2.Name = "Yaricap2";
            this.Yaricap2.Size = new System.Drawing.Size(115, 20);
            this.Yaricap2.TabIndex = 14;
            // 
            // MerkezY2
            // 
            this.MerkezY2.Location = new System.Drawing.Point(146, 359);
            this.MerkezY2.Name = "MerkezY2";
            this.MerkezY2.Size = new System.Drawing.Size(115, 20);
            this.MerkezY2.TabIndex = 12;
            // 
            // Genislik2
            // 
            this.Genislik2.Location = new System.Drawing.Point(146, 168);
            this.Genislik2.Name = "Genislik2";
            this.Genislik2.Size = new System.Drawing.Size(115, 20);
            this.Genislik2.TabIndex = 11;
            // 
            // Yukseklik2
            // 
            this.Yukseklik2.Location = new System.Drawing.Point(146, 125);
            this.Yukseklik2.Name = "Yukseklik2";
            this.Yukseklik2.Size = new System.Drawing.Size(115, 20);
            this.Yukseklik2.TabIndex = 10;
            // 
            // MerkezX2
            // 
            this.MerkezX2.Location = new System.Drawing.Point(146, 311);
            this.MerkezX2.Name = "MerkezX2";
            this.MerkezX2.Size = new System.Drawing.Size(115, 20);
            this.MerkezX2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Yükseklik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Yükseklik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Genişlik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Genişlik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Derinlik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Derinlik";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Yarıçap";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(145, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Yarıçap";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Y Koordinatı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Z Koordinatı";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 295);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "X Koordinatı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(145, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "X Koordinatı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(145, 387);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Z Koordinatı";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(145, 343);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Y Koordinatı";
            // 
            // DenetimL
            // 
            this.DenetimL.AutoSize = true;
            this.DenetimL.Font = new System.Drawing.Font("Microsoft Sans Serif", 31F);
            this.DenetimL.Location = new System.Drawing.Point(12, 426);
            this.DenetimL.Name = "DenetimL";
            this.DenetimL.Size = new System.Drawing.Size(211, 48);
            this.DenetimL.TabIndex = 36;
            this.DenetimL.Text = "Çarptı mı?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.DenetimL);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MerkezZ2);
            this.Controls.Add(this.Derinlik2);
            this.Controls.Add(this.Yaricap2);
            this.Controls.Add(this.MerkezX2);
            this.Controls.Add(this.MerkezY2);
            this.Controls.Add(this.Genislik2);
            this.Controls.Add(this.Yukseklik2);
            this.Controls.Add(this.MerkezZ1);
            this.Controls.Add(this.Derinlik1);
            this.Controls.Add(this.Yaricap1);
            this.Controls.Add(this.MerkezX1);
            this.Controls.Add(this.MerkezY1);
            this.Controls.Add(this.Genislik1);
            this.Controls.Add(this.Yukseklik1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Yukseklik1;
        private System.Windows.Forms.TextBox Genislik1;
        private System.Windows.Forms.TextBox MerkezY1;
        private System.Windows.Forms.TextBox MerkezX1;
        private System.Windows.Forms.TextBox Yaricap1;
        private System.Windows.Forms.TextBox Derinlik1;
        private System.Windows.Forms.TextBox MerkezZ1;
        private System.Windows.Forms.TextBox MerkezZ2;
        private System.Windows.Forms.TextBox Derinlik2;
        private System.Windows.Forms.TextBox Yaricap2;
        private System.Windows.Forms.TextBox MerkezY2;
        private System.Windows.Forms.TextBox Genislik2;
        private System.Windows.Forms.TextBox Yukseklik2;
        private System.Windows.Forms.TextBox MerkezX2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label DenetimL;
    }
}

