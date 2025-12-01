/*************************************************************************************************************************************************************************************************************
**************************************************************************************************************************************************************************************************************


                                                                            SAKARYA ÜNİVERSİTESİ
                                                                   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
                                                                      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
                                                                         NESNEYE DAYALI PROGRAMLAMA

                                                                         Ödev Numarası......:2.Ödev
                                                                         Öğrenci Adı........:Ömer Faruk TÜRKDOĞDU
                                                                         Öğrenci Numarası...:G231210002


**************************************************************************************************************************************************************************************************************
*************************************************************************************************************************************************************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Nesne n;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            n = new Nesne();
            Visibility();
            label1.Font = new Font(label1.Font, FontStyle.Bold);
            label2.Font = new Font(label2.Font, FontStyle.Bold);
            pictureBox1.BackColor = Color.White;

        }

        public void Visibility()
        {
            //Nesne bilgileri girilirken gerekli olmayan textboxlar gizleniyor.
            if (comboBox1.SelectedIndex == 0)
            {
                Yukseklik1.Visible = false;
                Genislik1.Visible = false;
                Derinlik1.Visible = false;
                Yaricap1.Visible = false;
                Derinlik2.Visible = false;
                Yaricap2.Visible = false;
                label1.Text = "Nokta";
                label2.Text = "Dörtgen";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Yukseklik1.Visible = false;
                Genislik1.Visible = false;
                Derinlik1.Visible = false;
                Yaricap1.Visible = false;
                Yukseklik2.Visible = false;
                Genislik2.Visible = false;
                Derinlik2.Visible = false;
                label1.Text = "Nokta";
                label2.Text = "Çember";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Derinlik1.Visible = false;
                Yaricap1.Visible = false;
                Derinlik2.Visible = false;
                Yaricap2.Visible = false;
                label1.Text = "Diktörtgen";
                label2.Text = "Diktörtgen";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Derinlik1.Visible = false;
                Yaricap1.Visible = false;
                Yukseklik2.Visible = false;
                Genislik2.Visible = false;
                Derinlik2.Visible = false;
                label1.Text = "Diktörtgen";
                label2.Text = "Çember";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                Yukseklik1.Visible = false;
                Genislik1.Visible = false;
                Derinlik1.Visible = false;
                Yukseklik2.Visible = false;
                Genislik2.Visible = false;
                Derinlik2.Visible = false;
                label1.Text = "Çember";
                label2.Text = "Çember";
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                Yukseklik1.Visible = false;
                Genislik1.Visible = false;
                Derinlik1.Visible = false;
                Yaricap1.Visible = false;
                Yukseklik2.Visible = false;
                Genislik2.Visible = false;
                Derinlik2.Visible = false;
                label1.Text = "Nokta";
                label2.Text = "Küre";
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                Yukseklik1.Visible = false;
                Genislik1.Visible = false;
                Derinlik1.Visible = false;
                Yaricap1.Visible = false;               
                Yaricap2.Visible = false;
                label1.Text = "Nokta";
                label2.Text = "Dikdörtgen Prizma";
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                Yukseklik1.Visible = false;
                Genislik1.Visible = false;
                Derinlik1.Visible = false;
                Yaricap1.Visible = false;
                Genislik2.Visible = false;
                Derinlik2.Visible= false;
                label1.Text = "Nokta";
                label2.Text = "Silindir";
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                Genislik1.Visible = false;
                Derinlik1.Visible = false;
                Genislik2.Visible = false;
                Derinlik2.Visible = false;
                label1.Text = "Silindir";
                label2.Text = "Silindir";
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                Yukseklik1.Visible = false;
                Genislik1.Visible = false;
                Derinlik1.Visible = false;
                Yukseklik2.Visible = false;
                Genislik2.Visible = false;
                Derinlik2.Visible = false;
                label1.Text = "Küre";
                label2.Text = "Küre";
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                Yukseklik1.Visible = false;
                Genislik1.Visible = false;
                Derinlik1.Visible = false;
                Genislik2.Visible = false;
                Derinlik2.Visible = false;
                label1.Text = "Küre";
                label2.Text = "Silindir";
            }
            else if (comboBox1.SelectedIndex == 11)
            {
                Genislik1.Visible = false;
                Derinlik1.Visible = false;
                Yaricap1.Visible = false;
                MerkezX1.Visible = false;
                MerkezY1.Visible = false;
                MerkezZ1.Visible = false;
                Yukseklik2.Visible = false;
                Genislik2.Visible = false;
                Derinlik2.Visible = false;
                label1.Text = "Yüzey";
                label2.Text = "Küre";
            }
            else if (comboBox1.SelectedIndex == 12)
            {
                Genislik1.Visible = false;
                Derinlik1.Visible = false;
                Yaricap1.Visible = false;
                MerkezX1.Visible = false;
                MerkezY1.Visible = false;
                MerkezZ1.Visible = false;
                Derinlik2.Visible = false;
                Yaricap2.Visible = false;
                label1.Text = "Yüzey";
                label2.Text = "Dikdörtgen";
            }
            else if (comboBox1.SelectedIndex == 13)
            {
                Genislik1.Visible = false;
                Derinlik1.Visible = false;
                Yaricap1.Visible = false;
                MerkezX1.Visible = false;
                MerkezY1.Visible = false;
                MerkezZ1.Visible = false;
                Genislik2.Visible = false;
                Derinlik2.Visible = false;
                label1.Text = "Yüzey";
                label2.Text = "Silindir";
            }
            else if (comboBox1.SelectedIndex == 14)
            {
                Yukseklik1.Visible = false;
                Genislik1.Visible = false;
                Derinlik1.Visible = false;
                Yaricap2.Visible = false;
                label1.Text = "Küre";                
                label2.Text = "Dikdörtgen Prizma";
            }
            else if (comboBox1.SelectedIndex == 15)
            {
                Yaricap1.Visible = false;
                Yaricap2.Visible = false;
                label1.Text = "Dikdörtgen Prizma";
                label2.Text = "Dikdörtgen Prizma";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            pictureBox1.Refresh();
            Graphics g = pictureBox1.CreateGraphics();     
            int sonuc;

          { 
            //Eğer textbox boş bırakıldıysa değer 0'a atanıyor.
            if (Yukseklik1.Text == string.Empty)
            {
                Yukseklik1.Text = "0";
            }

            if (Genislik1.Text == string.Empty)
            {
                Genislik1.Text = "0";
            }

            if (Derinlik1.Text == string.Empty)
            {
                Derinlik1.Text = "0";
            }

            if (Yaricap1.Text == string.Empty)
            {
                Yaricap1.Text = "0";
            }

            if (MerkezX1.Text == string.Empty)
            {
                MerkezX1.Text = "0";
            }

            if (MerkezY1.Text == string.Empty)
            {
                MerkezY1.Text = "0";
            }

            if (MerkezZ1.Text == string.Empty)
            {
                MerkezZ1.Text = "0";
            }

            if (Yukseklik2.Text == string.Empty)
            {
                Yukseklik2.Text = "0";
            }

            if (Genislik2.Text == string.Empty)
            {
                Genislik2.Text = "0";
            }

            if (Derinlik2.Text == string.Empty)
            {
                Derinlik2.Text = "0";
            }

            if (Yaricap2.Text == string.Empty)
            {
                Yaricap2.Text = "0";
            }

            if (MerkezX2.Text == string.Empty)
            {
                MerkezX2.Text = "0";
            }

            if (MerkezY2.Text == string.Empty)
            {
                MerkezY2.Text = "0";
            }

            if (MerkezZ2.Text == string.Empty)
            {
                MerkezZ2.Text = "0";
            }
          }

            if (comboBox1.SelectedIndex == 0) 
            { 
                //Nesneler çiziliyor
                n.noktaCiz(g, float.Parse(MerkezX1.Text), float.Parse(MerkezY1.Text));
                n.dortgenCiz(g, float.Parse(MerkezX2.Text), float.Parse(MerkezY2.Text), float.Parse(Yukseklik2.Text), float.Parse(Genislik2.Text));

                //Çarpışıp çarpışmama durumu int deperinden alınıyor.
                sonuc = Denetim.NoktaDortgen(double.Parse(MerkezX1.Text), double.Parse(MerkezY1.Text), double.Parse(MerkezZ1.Text), double.Parse(Yukseklik2.Text), double.Parse(Genislik2.Text), double.Parse(MerkezX2.Text), double.Parse(MerkezY2.Text), double.Parse(MerkezZ2.Text));

                //Alınan sonuca göre label(DenetimL) değişiyor.
                switch (sonuc) 
                {
                    case 0:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 1:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 2:
                        DenetimL.Text = "İÇİNDE";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Orange;
                        break;
                    case 3:
                        DenetimL.Text = "DIŞARIDA";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Red;
                        break;
                }
            }

            else if (comboBox1.SelectedIndex == 1) 
            {             
                //Nesneler çiziliyor.
                n.noktaCiz(g, float.Parse(MerkezX1.Text), float.Parse(MerkezY1.Text));
                n.cemberCiz(g, float.Parse(MerkezX2.Text), float.Parse(MerkezY2.Text), float.Parse(Yaricap2.Text));

                //Çarpışıp çarpışmama durumu int deperinden alınıyor.
                sonuc = Denetim.NoktaCember(double.Parse(MerkezX1.Text), double.Parse(MerkezY1.Text), double.Parse(MerkezZ1.Text), double.Parse(Yaricap2.Text), double.Parse(MerkezX2.Text), double.Parse(MerkezY2.Text), double.Parse(MerkezZ2.Text));

                //Alınan sonuca göre label(DenetimL) değişiyor.
                switch (sonuc)
                {
                    case 0:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 1:
                        DenetimL.Text = "İÇİNDE";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Orange;
                        break;
                    case 2:
                        DenetimL.Text = "DIŞARIDA";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Red;
                        break;
                }
            }

            else if(comboBox1.SelectedIndex == 2) 
            {
                //Nesneler çiziliyor.
                n.dikdortgenCiz(g, float.Parse(MerkezX1.Text), float.Parse(MerkezY1.Text), float.Parse(Yukseklik1.Text), float.Parse(Genislik1.Text));
                n.dikdortgenCiz(g, float.Parse(MerkezX2.Text), float.Parse(MerkezY2.Text), float.Parse(Yukseklik2.Text), float.Parse(Genislik2.Text));

                //Çarpışıp çarpışmama durumu int deperinden alınıyor.
                sonuc = Denetim.DikdortgenDikdortgen(double.Parse(Yukseklik1.Text), double.Parse(Genislik1.Text), double.Parse(MerkezX1.Text), double.Parse(MerkezY1.Text), double.Parse(MerkezZ1.Text), double.Parse(Yukseklik2.Text), double.Parse(Genislik2.Text), double.Parse(MerkezX2.Text), double.Parse(MerkezY2.Text), double.Parse(MerkezZ2.Text));
                
                //Alınan sonuca göre label(DenetimL) değişiyor.
                switch (sonuc)
                {
                    case 0:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 1:
                        DenetimL.Text = "ÇARPIŞMADI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Red;
                        break;
                }
            }

            else if (comboBox1.SelectedIndex == 3)
            {
                //Nesneler çiziliyor.
                n.dikdortgenCiz(g, float.Parse(MerkezX1.Text), float.Parse(MerkezY1.Text), float.Parse(Yukseklik1.Text), float.Parse(Genislik1.Text));
                n.cemberCiz(g, float.Parse(MerkezX2.Text), float.Parse(MerkezY2.Text), float.Parse(Yaricap2.Text));

                //Çarpışıp çarpışmama durumu int deperinden alınıyor.
                sonuc = Denetim.DikdortgenCember(double.Parse(Yukseklik1.Text), double.Parse(Genislik1.Text), double.Parse(MerkezX1.Text), double.Parse(MerkezY1.Text), double.Parse(MerkezZ1.Text), double.Parse(Yaricap2.Text), double.Parse(MerkezX2.Text), double.Parse(MerkezY2.Text), double.Parse(MerkezZ2.Text));
                
                //Alınan sonuca göre label(DenetimL) değişiyor.
                switch (sonuc) 
                {
                    case 0:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 1:
                        DenetimL.Text = "ÇARPIŞMADI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Red;
                        break;
                }
            }

            else if (comboBox1.SelectedIndex == 4) 
            {
                //Nesneler çiziliyor.
                n.cemberCiz(g, float.Parse(MerkezX1.Text), float.Parse(MerkezY1.Text), float.Parse(Yaricap1.Text));
                n.cemberCiz(g, float.Parse(MerkezX2.Text), float.Parse(MerkezY2.Text), float.Parse(Yaricap2.Text));

                //Çarpışıp çarpışmama durumu int deperinden alınıyor.
                sonuc = Denetim.CemberCember(double.Parse(Yaricap1.Text), double.Parse(MerkezX1.Text), double.Parse(MerkezY1.Text), double.Parse(MerkezZ1.Text), double.Parse(Yaricap2.Text), double.Parse(MerkezX2.Text), double.Parse(MerkezY2.Text), double.Parse(MerkezZ2.Text));
                
                //Alınan sonuca göre label(DenetimL) değişiyor.
                switch(sonuc) 
                { 
                    case 0:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 1:
                        DenetimL.Text = "ÇARPIŞMADI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Red;
                        break;
                }
            }

            else if (comboBox1.SelectedIndex == 5) 
            {      
                //Nesneler çiziliyor.
                n.noktaCiz(g, float.Parse(MerkezX1.Text), float.Parse(MerkezY1.Text));
                n.kureCiz(g, float.Parse(MerkezX2.Text), float.Parse(MerkezY2.Text), float.Parse(Yaricap2.Text));

                //Çarpışıp çarpışmama durumu int deperinden alınıyor.
                sonuc = Denetim.NoktaKure(double.Parse(MerkezX1.Text), double.Parse(MerkezY1.Text), double.Parse(MerkezZ1.Text), double.Parse(Yaricap2.Text), double.Parse(MerkezX2.Text), double.Parse(MerkezY2.Text), double.Parse(MerkezZ2.Text));
                
                //Alınan sonuca göre label(DenetimL) değişiyor.
                switch(sonuc) 
                {
                    case 0:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 1:
                        DenetimL.Text = "İÇİNDE";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Orange;
                        break;
                    case 2:
                        DenetimL.Text = "DIŞARIDA";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Red;
                        break;
                }
            }

            else if (comboBox1.SelectedIndex == 6) 
            {       
                //Nesneler çiziliyor.
                n.noktaCiz(g, float.Parse(MerkezX1.Text), float.Parse(MerkezY1.Text));
                n.dikdortgenPrizmaCiz(g, float.Parse(MerkezX2.Text), float.Parse(MerkezY2.Text), float.Parse(Yukseklik2.Text), float.Parse(Genislik2.Text));

                //Çarpışıp çarpışmama durumu int deperinden alınıyor.
                sonuc = Denetim.NoktaDikdortgenPrizma(double.Parse(MerkezX1.Text), double.Parse(MerkezY1.Text), double.Parse(MerkezZ1.Text), double.Parse(Yukseklik2.Text), double.Parse(Genislik2.Text), double.Parse(Derinlik2.Text), double.Parse(MerkezX2.Text), double.Parse(MerkezY2.Text), double.Parse(MerkezZ2.Text));
                
                //Alınan sonuca göre label(DenetimL) değişiyor.
                switch (sonuc)
                {
                    case 0:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 1:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 2:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 3:
                        DenetimL.Text = "İÇİNDE";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Orange;
                        break;
                    case 4:
                        DenetimL.Text = "DIŞARIDA";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Red;
                        break;
                }
            }

            else if (comboBox1.SelectedIndex == 7) 
            {
                //Nesneler çiziliyor.
                n.noktaCiz(g, float.Parse(MerkezX1.Text), float.Parse(MerkezY1.Text));
                n.silindirCiz(g, float.Parse(MerkezX2.Text), float.Parse(MerkezY2.Text), float.Parse(Yaricap2.Text), float.Parse(Yukseklik2.Text));

                //Çarpışıp çarpışmama durumu int deperinden alınıyor.
                sonuc = Denetim.NoktaSilindir(double.Parse(MerkezX1.Text), double.Parse(MerkezY1.Text), double.Parse(MerkezZ1.Text), double.Parse(Yukseklik2.Text), double.Parse(Yaricap2.Text), double.Parse(MerkezX2.Text), double.Parse(MerkezY2.Text), double.Parse(MerkezZ2.Text));
                
                //Alınan sonuca göre label(DenetimL) değişiyor.
                switch (sonuc)
                {
                    case 0:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 1:
                        DenetimL.Text = "ÇARPIŞMADI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Red;
                        break;
                }
            }

            else if (comboBox1.SelectedIndex == 8) 
            {
                //Nesneler çiziliyor.
                n.silindirCiz(g, float.Parse(MerkezX1.Text), float.Parse(MerkezY1.Text), float.Parse(Yaricap1.Text), float.Parse(Yukseklik1.Text));
                n.silindirCiz(g, float.Parse(MerkezX2.Text), float.Parse(MerkezY2.Text), float.Parse(Yaricap2.Text), float.Parse(Yukseklik2.Text));

                //Çarpışıp çarpışmama durumu int deperinden alınıyor.
                sonuc = Denetim.SilindirSilindir(double.Parse(Yukseklik1.Text), double.Parse(Yaricap1.Text), double.Parse(MerkezX1.Text), double.Parse(MerkezY1.Text), double.Parse(MerkezZ1.Text), double.Parse(Yukseklik2.Text), double.Parse(Yaricap2.Text), double.Parse(MerkezX2.Text), double.Parse(MerkezY2.Text), double.Parse(MerkezZ2.Text));

                //Alınan sonuca göre label(DenetimL) değişiyor.
                switch (sonuc)
                {
                    case 0:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 1:
                        DenetimL.Text = "ÇARPIŞMADI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Red;
                        break;
                }
            }

            else if (comboBox1.SelectedIndex == 9) 
            {
                //Nesneler çiziliyor.
                n.kureCiz(g, float.Parse(MerkezX1.Text), float.Parse(MerkezY1.Text), float.Parse(Yaricap1.Text));
                n.kureCiz(g, float.Parse(MerkezX2.Text), float.Parse(MerkezY2.Text), float.Parse(Yaricap2.Text));

                //Çarpışıp çarpışmama durumu int deperinden alınıyor.
                sonuc = Denetim.KureKure(double.Parse(Yaricap1.Text), double.Parse(MerkezX1.Text), double.Parse(MerkezY1.Text), double.Parse(MerkezZ1.Text), double.Parse(Yaricap2.Text), double.Parse(MerkezX2.Text), double.Parse(MerkezY2.Text), double.Parse(MerkezZ2.Text));

                //Alınan sonuca göre label(DenetimL) değişiyor.
                switch (sonuc)
                {
                    case 0:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;

                    case 1:
                        DenetimL.Text = "ÇARPIŞMADI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Red;
                        break;
                }
            }

            else if (comboBox1.SelectedIndex == 10) 
            {
                //Nesneler çiziliyor.
                n.kureCiz(g, float.Parse(MerkezX1.Text), float.Parse(MerkezY1.Text), float.Parse(Yaricap1.Text));
                n.silindirCiz(g, float.Parse(MerkezX2.Text), float.Parse(MerkezY2.Text), float.Parse(Yaricap2.Text), float.Parse(Yukseklik2.Text));

                //Çarpışıp çarpışmama durumu int deperinden alınıyor.
                sonuc = Denetim.KureSilindir(double.Parse(Yaricap1.Text), double.Parse(MerkezX1.Text), double.Parse(MerkezY1.Text), double.Parse(MerkezZ1.Text), double.Parse(Yukseklik2.Text), double.Parse(Yaricap2.Text), double.Parse(MerkezX2.Text), double.Parse(MerkezY2.Text), double.Parse(MerkezZ2.Text));

                //Alınan sonuca göre label(DenetimL) değişiyor.
                switch (sonuc)
                {
                    case 0:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 1:
                        DenetimL.Text = "ÇARPIŞMADI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Red;
                        break;
                }
            }

            else if (comboBox1.SelectedIndex == 11) 
            {
                //Nesneler çiziliyor.
                n.yuzeyCiz(g, int.Parse(Yukseklik1.Text));
                n.kureCiz(g, float.Parse(MerkezX2.Text), float.Parse(MerkezY2.Text), float.Parse(Yaricap2.Text));

                //Çarpışıp çarpışmama durumu int deperinden alınıyor.
                sonuc = Denetim.YuzeyKure(double.Parse(Yukseklik1.Text), double.Parse(Yaricap2.Text), double.Parse(MerkezY2.Text));

                //Alınan sonuca göre label(DenetimL) değişiyor.
                switch (sonuc)
                {
                    case 0:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 1:
                        DenetimL.Text = "ÇARPIŞMADI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Red;
                        break;
                }
            }

            else if (comboBox1.SelectedIndex == 12) 
            {
                //Nesneler çiziliyor.
                n.yuzeyCiz(g, int.Parse(Yukseklik1.Text));
                n.dikdortgenPrizmaCiz(g, float.Parse(MerkezX2.Text), float.Parse(MerkezY2.Text), float.Parse(Yukseklik2.Text), float.Parse(Genislik2.Text));

                //Çarpışıp çarpışmama durumu int deperinden alınıyor.
                sonuc = Denetim.YuzeyDikdortgenPrizma(double.Parse(Yukseklik1.Text), double.Parse(Yukseklik2.Text), double.Parse(MerkezY2.Text));

                //Alınan sonuca göre label(DenetimL) değişiyor.
                switch (sonuc)
                {
                    case 0:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 1:
                        DenetimL.Text = "ÇARPIŞMADI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Red;
                        break;
                }
            }

            else if (comboBox1.SelectedIndex == 13) 
            {
                //Nesneler çiziliyor.
                n.yuzeyCiz(g, int.Parse(Yukseklik1.Text));
                n.silindirCiz(g, float.Parse(MerkezX2.Text), float.Parse(MerkezY2.Text), float.Parse(Yaricap2.Text), float.Parse(Yukseklik2.Text));

                //Çarpışıp çarpışmama durumu int deperinden alınıyor.
                sonuc = Denetim.YuzeySilindir(double.Parse(Yukseklik1.Text), double.Parse(Yukseklik2.Text), double.Parse(MerkezY2.Text));

                //Alınan sonuca göre label(DenetimL) değişiyor.
                switch (sonuc)
                {
                    case 0:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 1:
                        DenetimL.Text = "ÇARPIŞMADI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Red;
                        break;
                }
            }

            else if (comboBox1.SelectedIndex == 14) 
            {
                //Nesneler çiziliyor.
                n.kureCiz(g, float.Parse(MerkezX1.Text), float.Parse(MerkezY1.Text), float.Parse(Yaricap1.Text));
                n.dikdortgenPrizmaCiz(g, float.Parse(MerkezX2.Text), float.Parse(MerkezY2.Text), float.Parse(Yukseklik2.Text), float.Parse(Genislik2.Text));

                //Çarpışıp çarpışmama durumu int deperinden alınıyor.
                sonuc = Denetim.KureDikdortgenPrizma(double.Parse(Yaricap1.Text), double.Parse(MerkezX1.Text), double.Parse(MerkezY1.Text), double.Parse(MerkezZ1.Text), double.Parse(Yukseklik2.Text), double.Parse(Genislik2.Text), double.Parse(Derinlik2.Text), double.Parse(MerkezX2.Text), double.Parse(MerkezY2.Text), double.Parse(MerkezZ2.Text));
                
                //Alınan sonuca göre label(DenetimL) değişiyor.
                switch (sonuc)
                {
                    case 0:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 1:
                        DenetimL.Text = "ÇARPIŞMADI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Red;
                        break;
                }
            }

            else if (comboBox1.SelectedIndex == 15) 
            {
                //Nesneler çiziliyor.
                n.dikdortgenPrizmaCiz(g, float.Parse(MerkezX1.Text), float.Parse(MerkezY1.Text), float.Parse(Yukseklik1.Text), float.Parse(Genislik1.Text));
                n.dikdortgenPrizmaCiz(g, float.Parse(MerkezX2.Text), float.Parse(MerkezY2.Text), float.Parse(Yukseklik2.Text), float.Parse(Genislik2.Text));

                //Çarpışıp çarpışmama durumu int deperinden alınıyor.
                sonuc = Denetim.DikdortgenPrizmaDikdortgenPrizma(double.Parse(Yukseklik1.Text), double.Parse(Genislik1.Text), double.Parse(Derinlik1.Text), double.Parse(MerkezX1.Text), double.Parse(MerkezY1.Text), double.Parse(MerkezZ1.Text), double.Parse(Yukseklik2.Text), double.Parse(Genislik2.Text), double.Parse(Derinlik2.Text), double.Parse(MerkezX2.Text), double.Parse(MerkezY2.Text), double.Parse(MerkezZ2.Text));
                
                //Alınan sonuca göre label(DenetimL) değişiyor.
                switch (sonuc)
                {
                    case 0:
                        DenetimL.Text = "ÇARPIŞTI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Green;
                        break;
                    case 1:
                        DenetimL.Text = "ÇARPIŞMADI";
                        DenetimL.Font = new Font(DenetimL.Font, FontStyle.Bold);
                        DenetimL.ForeColor = Color.Red;
                        break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobox her değiştiğinde tüm textboxlar görünür hale gelip sonrasında gereksiz textboxların kapanması için Visibility() metodu çalışıyor.
            Yukseklik1.Visible = true;
            Genislik1.Visible = true;
            Derinlik1.Visible = true;
            Yaricap1.Visible = true;
            MerkezX1.Visible = true;
            MerkezY1.Visible = true;
            MerkezZ1.Visible = true;
            Yukseklik2.Visible = true;
            Genislik2.Visible = true;
            Derinlik2.Visible = true;
            Yaricap2.Visible = true;
            MerkezX2.Visible = true;
            MerkezY2.Visible = true;
            MerkezZ2.Visible = true;            

            Visibility();
        }
    }

    public static class Denetim
    {
        //Nokta - Dörtgen Çarpışma Denetimi.
        public static int NoktaDortgen(double X1, double Y1, double Z1, double H, double W, double X2, double Y2, double Z2)
        {
            if ((X1 == X2 || X1 == X2 + W) && (Y1 >= Y2 && Y1 <= Y2 + H) && Z1==Z2)
            {
                return 0;
            }

            else if ((X1 > X2 && X1 < X2 + W) && (Y1 == Y2 || Y1 == Y2 + H) && Z1==Z2)
            {
                return 1;
            }

            if ((X1 > X2 && X1 < X2 + W) && (Y1 > Y2 && Y1 < Y2 + H) && Z1 == Z2)
            {
                return 2;
            }

            return 3;
        }

        //Nokta - Çember Çarpışma Denetimi.
        public static int NoktaCember(double X1, double Y1, double Z1, double R, double X2, double Y2, double Z2)
        {
            if ((Z1 == Z2) && (((X2 + R - X1) * (X2 + R - X1)) + ((Y2 + R - Y1) * (Y2 + R - Y1))) == (R * R))
            {
                return 0;
            }

            else if ((Z1 == Z2) && (((X2 + R - X1) * (X2 + R - X1)) + ((Y2 + R - Y1) * (Y2 + R - Y1))) < (R * R))
            {
                return 1;
            }

            return 2;
        }

        //Dikdörtgen - Dikdörtgen Çarpışma Denetimi.
        public static int DikdortgenDikdortgen(double H1, double W1, double X1, double Y1, double Z1, double H2, double W2, double X2, double Y2, double Z2)
        {
            double MutlakX;
            double MutlakY;

            //X ve Y koordinatında merkezler arası fark.
            MutlakX = Math.Abs((X1 + (W1 / 2)) - (X2 + (W2 / 2)));
            MutlakY = Math.Abs((Y1 + (H1 / 2)) - (Y2 + (H2 / 2)));

            if ((MutlakX <= (W1 / 2 + W2 / 2)) && (MutlakY <= (H1 / 2 + H2 / 2)) && (Z1 == Z2))
            {
                return 0;
            }

            return 1;
        }

        //Dikdörtgen - Çember Çarpışma Denetimi.
        public static int DikdortgenCember(double H, double W, double X1, double Y1, double Z1, double R, double X2, double Y2, double Z2)
        {
            double MutlakX;
            double MutlakY;
            double Kosegen;

            //X ve Y koordinatında merkezler arası fark.
            MutlakX = Math.Abs((X1 + (W / 2)) - (X2 + R));
            MutlakY = Math.Abs((Y1 + (H / 2)) - (Y2 + R));
            Kosegen = Math.Sqrt((W / 2) * (W / 2) + (H / 2) * (H / 2));

            if ((Z1 == Z2) && (((MutlakX * MutlakX) + (MutlakY * MutlakY)) <= (Kosegen + R) * (Kosegen + R)))
            {
                return 0;
            }

            return 1;
        }

        //Çember - Çember Çarpışma Denetimi.
        public static int CemberCember(double R1, double X1, double Y1, double Z1, double R2, double X2, double Y2, double Z2)
        {
            double MutlakX;
            double MutlakY;
            double Sinir;

            //X ve Y koordinatında merkezler arası fark.
            MutlakX = Math.Abs((X1+R1)-(X2+R2));
            MutlakY = Math.Abs((Y1 + R1) - (Y2 + R2));
            Sinir = Math.Sqrt((MutlakX*MutlakX)+(MutlakY*MutlakY));

            if ((Sinir <= (R1 + R2)) && (Z1 == Z2))
            {
                return 0;
            }

            return 1;
        }

        //Nokta - Küre Çarpışma Denetimi.
        public static int NoktaKure(double X1, double Y1, double Z1, double R, double X2, double Y2, double Z2)
        {
            if ((((X2 + R - X1) * (X2 + R - X1)) + ((Y2 + R - Y1) * (Y2 + R - Y1))) == (R * R))
            {
                return 0;
            }

            else if ((((X2 + R - X1) * (X2 + R - X1)) + ((Y2 + R - Y1) * (Y2 + R - Y1))) < (R * R))
            {
                return 1;
            }

            return 2;
        }

        //Nokta - Dikdörtgen Prizma Çarpışma Denetimi.
        public static int NoktaDikdortgenPrizma(double X1, double Y1, double Z1, double H, double W, double D, double X2, double Y2, double Z2)
        {
            if ((X1 == X2 || X1 == X2 + W) && (Y1 >= Y2 && Y1 <= Y2 + H) && ((Z1 >= Z2)&&(Z1<=(Z2+D))))
            {
                return 0;
            }

            else if ((X1 > X2 && X1 < X2 + W) && (Y1 == Y2 || Y1 == Y2 + H) && ((Z1 >= Z2) && (Z1 <= (Z2 + D))))
            {
                return 1;
            }

            else if ((X1 > X2 && X1 < X2 + W) && (Y1 > Y2 && Y1 < Y2 + H) && ((Z1 == Z2) || (Z1 == (Z2 + D))))
            {
                return 2;
            }

            if ((X1 > X2 && X1 < X2 + W) && (Y1 > Y2 && Y1 < Y2 + H) && ((Z1 > Z2) && (Z1 < (Z2 + D))))
            {
                return 3;
            }
        
            return 4;
        }

        //Nokta - Silindir Çarpışma Denetimi.
        public static int NoktaSilindir(double X1, double Y1, double Z1, double H, double R, double X2, double Y2, double Z2)
        {
            double MutlakX;
            double MutlakY;
            double MutlakZ;

            //X ve Y koordinatında merkezler arası fark.
            MutlakX = Math.Abs(X1 - (X2 + R));
            MutlakY = Math.Abs(Y1 - (Y2 + (H/2)));
            MutlakZ = Math.Abs(Z1 - (Z2 + R));

            if ((MutlakX <= R) && (MutlakZ <= R) && (MutlakY <= (H / 2)))
            {
                return 0;
            }

            return 1;
        }

        //Silindir - Silindir Çarpışma Denetimi.
        public static int SilindirSilindir(double H1, double R1, double X1, double Y1, double Z1, double H2, double R2, double X2, double Y2, double Z2)
        {
            double MutlakX;
            double MutlakY;
            double MutlakZ;

            //X ve Y koordinatında merkezler arası fark.
            MutlakX = Math.Abs((X1 + R1) - (X2 + R2));
            MutlakY = Math.Abs((Y1 + R1) - (Y2 + R2));
            MutlakZ = Math.Abs((Z1 + R1) - (Z2 + R2));


            if ((MutlakX <= (R1 + R2)) && (MutlakZ <= (R1 + R2)) && (MutlakY <= ((H1 + H2) / 2)))
            {
                return 0;
            }

            return 1;
        }

        //Küre - Küre Çarpışma Denetimi.
        public static int KureKure(double R1, double X1, double Y1, double Z1, double R2, double X2, double Y2, double Z2)
        {
            double MutlakX;
            double MutlakY;
            double MutlakZ;
            double Uzunluk;

            //X,Y ve Z koordinatında merkezler arası fark.
            MutlakX = Math.Abs(((X1 + R1) - (X2 + R2)) * ((X1 + R1) - (X2 + R2)));
            MutlakY = Math.Abs(((Y1 + R1) - (Y2 + R2)) * ((Y1 + R1) - (Y2 + R2)));
            MutlakZ = Math.Abs(((Z1 + R1) - (Z2 + R2)) * ((Z1 + R1) - (Z2 + R2)));
            Uzunluk = Math.Sqrt(MutlakX + MutlakY + MutlakZ);

            if (Uzunluk <= (R1 + R2))
            {
                return 0;
            }

            return 1;
        }

        //Küre - Silindir Çarpışma Denetimi.
        public static int KureSilindir(double R1, double X1, double Y1, double Z1, double H, double R2, double X2, double Y2, double Z2)
        {
            double MutlakX;
            double MutlakY;
            double MutlakZ;

            //X,Y ve Z koordinatında merkezler arası fark.
            MutlakX = Math.Abs(((X1 + R1) - (X2 + R2 / 2)));
            MutlakY = Math.Abs(((Y1 + R1) - (Y2 + H / 2)));
            MutlakZ = Math.Abs(((Z1 + R1) - (Z2 + R2 / 2)));

            if (MutlakX <= R1 + R2 / 2 && MutlakY <= R1 + H / 2 && MutlakZ <= R1 + R2 / 2)
            {
                return 0;
            }
            
            return 1;
        }

        //Yüzey - Küre Çarpışma Denetimi.
        public static int YuzeyKure(double H, double R, double Y)
        {
            if (H <= (Y + (2 * R)))
            {
                return 0;
            }
            return 1;
        }

        //Yüzey - Dikdörtgen Prizması Çarpışma Denetimi.
        public static int YuzeyDikdortgenPrizma(double H1, double H2,  double Y)
        {
            if (H1<=Y+H2)
            {
                return 0;
            }

            return 1;
        }

        //Yüzey - Silindir Çarpışma Denetimi.
        public static int YuzeySilindir(double H1, double H2, double Y)
        {
            if (H1<=H2+Y)
            {
                return 0;
            }

            return 1;
        }

        //Küre - Dikdörtgen Prizma Çarpışma Denetimi.
        public static int KureDikdortgenPrizma(double R, double X1, double Y1, double Z1, double H, double W, double D, double X2, double Y2, double Z2)
        {
            double MutlakX;
            double MutlakY;
            double MutlakZ;

            //X,Y ve Z koordinatında merkezler arası fark.
            MutlakX = Math.Abs(((X1 + R) - (X2 + W/2)));
            MutlakY = Math.Abs(((Y1 + R) - (Y2 + H/2)));
            MutlakZ = Math.Abs(((Z1 + R) - (Z2 + D / 2)));     

            if (MutlakX <= R + W / 2 && MutlakY <= R + H / 2 && MutlakZ <= R + D / 2)
            {
                return 0;
            }

            return 1;
        }

        //Dikdörtgen Prizma - Dikdörtgen Prizma Çarpışma Denetimi. 
        public static int DikdortgenPrizmaDikdortgenPrizma(double H1, double W1, double D1, double X1, double Y1, double Z1, double H2, double W2, double D2, double X2, double Y2, double Z2)
        {
            double MutlakX;
            double MutlakY;
            double MutlakZ;
            double Uzunluk;
            double Sinir;

            //X,Y ve Z koordinatında merkezler arası fark.
            MutlakX = Math.Abs(((X1 + (W1 / 2)) - (X2 + (W2 / 2))) * ((X1 + (W1 / 2)) - (X2 + (W2 / 2))));
            MutlakY = Math.Abs(((Y1 + (H1 / 2)) - (Y2 + (H2 / 2))) * ((Y1 + (H1 / 2)) - (Y2 + (H2 / 2))));
            MutlakZ = Math.Abs(((Z1 + (D1 / 2)) - (Z2 + (D2 / 2))) * ((Z1 + (D1 / 2)) - (Z2 + (D2 / 2))));
            Uzunluk = Math.Sqrt(MutlakX + MutlakY + MutlakZ);
            Sinir = Math.Sqrt((((W1/2)+(W2/2))* ((W1 / 2) + (W2 / 2)))+ (((H1 / 2) + (H2 / 2)) * ((H1 / 2) + (H2 / 2)))+ (((D1 / 2) + (D2 / 2)) * ((D1 / 2) + (D2 / 2))));

            if (Uzunluk <=Sinir)
            {
                return 0;
            }
            return 1;
        }
    }

    public class Nesne
    {
        public float yukseklik;
        public float genişlik;
        public float derinlik;
        public float yaricap;
        public float merkezX;
        public float merkezY;
        public float merkezZ;

        //Nokta çiziyor.
        public virtual void noktaCiz(Graphics g, float X, float Y) 
        {
            g.FillEllipse(Brushes.Black, X, Y, 3, 3);
        }

        //Dörtgen çiziyor.
        public virtual void dortgenCiz(Graphics g, float X, float Y, float Z, float T) 
        {           
            g.DrawRectangle(Pens.Black,X,Y,T,Z);
        }

        //Çember çiziyor.
        public virtual void cemberCiz(Graphics g, float X, float Y, float Z) 
        {
            g.DrawEllipse(Pens.Black,X,Y,Z*2,Z*2);
        }

        //Küre çiziyor.
        public virtual void kureCiz(Graphics g, float X, float Y, float Z) 
        {
            g.DrawEllipse(Pens.Black, X, Y, Z * 2, Z * 2);
        }

        //Silindir çiziyor.
        public virtual void silindirCiz(Graphics g, float X, float Y, float Z, float T) 
        {
            g.DrawEllipse(Pens.Black, X, Y, Z, Z / 2);
            g.DrawRectangle(Pens.Black, X, Y + (Z / 4), 1, T - Z/2);
            g.DrawRectangle(Pens.Black, X + Z, (Z / 4) + Y, 1, T - Z/2);
            g.DrawEllipse(Pens.Black, X, Y + T - Z/2, Z, Z / 2);
        }

        //Yüzey çiziyor.
        public virtual void yuzeyCiz(Graphics g, int X) 
        {
            g.DrawRectangle(Pens.Black, 0, X, 500, 1);
        }

        //Dikdörtgen Prizma çiziyor.
        public virtual void dikdortgenPrizmaCiz(Graphics g, float X, float Y, float Z, float T) 
        {
            g.DrawRectangle(Pens.Black, X, Y, T, Z);
        }

        //Dikdörtgen çiziyor.
        public virtual void dikdortgenCiz(Graphics g, float X, float Y, float Z, float T) 
        {
            g.DrawRectangle(Pens.Black, X, Y, T, Z);
        }
    }
}
