using System.Drawing;
using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WinFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            // Textboxlarý form'a ekle ve visible özelliðini false olarak ayarla

            textBox1.Visible = false; textBox2.Visible = false; textBox3.Visible = false; textBox4.Visible = false;
            textBox5.Visible = false; textBox6.Visible = false; textBox7.Visible = false; textBox8.Visible = false;
            textBox9.Visible = false; textBox10.Visible = false; textBox11.Visible = false; textBox12.Visible = false;



            label1.Visible = false; label2.Visible = false; label3.Visible = false; label4.Visible = false;
            label5.Visible = false; label6.Visible = false; label7.Visible = false; label8.Visible = false;
            label9.Visible = false; label10.Visible = false; label11.Visible = false; label12.Visible = false;
            label13.Visible = false; label14.Visible = false; label15.Visible = false; label16.Visible = false;
            label17.Visible = false; label18.Visible = false; label19.Visible = false; label20.Visible = false;
            label21.Visible = false; label22.Visible = false; label23.Visible = false; label24.Visible = false;
            label25.Visible = false; label26.Visible = false; label27.Visible = false; label32.Visible = false;
            label28.Visible = false; label29.Visible = false; label30.Visible = false; label31.Visible = false;
            label33.Visible = false; label34.Visible = false; label35.Visible = false; label36.Visible = false;
            label37.Visible = false; label38.Visible = false; label39.Visible = false; label40.Visible = false; label41.Visible = false;
            label42.Visible = false; label43.Visible = false; label44.Visible = false; label45.Visible = false;
            label46.Visible = false; label47.Visible = false; label48.Visible = false; label49.Visible = false; label50.Visible = false;



        }

        private void comboBoxSeçim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSeçim.SelectedIndex == 0) // Eðer "Nokta, Dikdörtgen
            {

                textBox3.Visible = true; textBox4.Visible = true; textBox5.Visible = true; label3.Visible = true;
                textBox1.Visible = true; textBox2.Visible = true; textBox6.Visible = true; label1.Visible = true;
                label4.Visible = true; label2.Visible = true; label5.Visible = true; label6.Visible = true; labelSonuç.Visible = true;


            }

            if (comboBoxSeçim.SelectedIndex == 1) //nokta çember
            {
                label7.Visible = true; label8.Visible = true; label9.Visible = true; label5.Visible = true;
                label6.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox4.Visible = true;
                textBox5.Visible = true; textBox6.Visible = true; labelSonuç.Visible = true;


            }

            if (comboBoxSeçim.SelectedIndex == 2) //dikdörtgen dikdörtgen
            {
                label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox4.Visible = true;

                label10.Visible = true; label11.Visible = true; label12.Visible = true; label13.Visible = true;
                textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true; textBox10.Visible = true; labelSonuç.Visible = true;



            }

            if (comboBoxSeçim.SelectedIndex == 3) // dikdörtgen çember
            {
                label7.Visible = true; label8.Visible = true; label9.Visible = true; label10.Visible = true;
                label11.Visible = true; label12.Visible = true; label13.Visible = true;
                textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true; textBox10.Visible = true;
                textBox2.Visible = true; textBox3.Visible = true; textBox4.Visible = true; labelSonuç.Visible = true;

            }

            if (comboBoxSeçim.SelectedIndex == 4) // çember çember
            {
                label7.Visible = true; label8.Visible = true; label9.Visible = true; label12.Visible = true;
                label13.Visible = true; label14.Visible = true; textBox2.Visible = true; textBox3.Visible = true;
                textBox4.Visible = true; textBox8.Visible = true; textBox9.Visible = true; textBox10.Visible = true; labelSonuç.Visible = true;
            }

            if (comboBoxSeçim.SelectedIndex == 5) //nokta küre
            {
                label5.Visible = true; label6.Visible = true; textBox4.Visible = true; textBox5.Visible = true;
                label17.Visible = true; textBox6.Visible = true; label18.Visible = true; label19.Visible = true;
                label20.Visible = true; label21.Visible = true; textBox7.Visible = true;
                textBox8.Visible = true; textBox9.Visible = true; textBox10.Visible = true; labelSonuç.Visible = true;

            }

            if (comboBoxSeçim.SelectedIndex == 6) // nokta prizma
            {
                label5.Visible = true; label6.Visible = true; textBox6.Visible = true;
                textBox5.Visible = true; textBox4.Visible = true; label17.Visible = true; label22.Visible = true;
                label23.Visible = true; label24.Visible = true; label25.Visible = true; label26.Visible = true;
                label27.Visible = true; textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true;
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; labelSonuç.Visible = true;



            }


            if (comboBoxSeçim.SelectedIndex == 7) //silindir nokta
            {

                label5.Visible = true; label6.Visible = true; textBox6.Visible = true; textBox5.Visible = true; textBox4.Visible = true;
                label17.Visible = true; label28.Visible = true; label29.Visible = true; labelSonuç.Visible = true;
                label30.Visible = true; label31.Visible = true; label32.Visible = true;
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true;
                textBox7.Visible = true; textBox8.Visible = true;


            }

            if (comboBoxSeçim.SelectedIndex == 8) //silindir silindir

            {
                label28.Visible = true; label29.Visible = true; label30.Visible = true; textBox8.Visible = true; labelSonuç.Visible = true;
                label31.Visible = true; label32.Visible = true; textBox2.Visible = true; label37.Visible = true;
                label33.Visible = true; label34.Visible = true; label36.Visible = true; label35.Visible = true;
                textBox1.Visible = true; textBox3.Visible = true; textBox7.Visible = true; textBox9.Visible = true;
                textBox4.Visible = true; textBox5.Visible = true; textBox6.Visible = true; textBox10.Visible = true;
            }


            if (comboBoxSeçim.SelectedIndex == 9) //silindir küre
            {
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox7.Visible = true; textBox8.Visible = true;
                label28.Visible = true; label29.Visible = true; label30.Visible = true; label31.Visible = true; label32.Visible = true;
                label20.Visible = true; label21.Visible = true; textBox9.Visible = true; textBox10.Visible = true; labelSonuç.Visible = true;
                label38.Visible = true; label39.Visible = true; textBox4.Visible = true; textBox5.Visible = true;


            }

            if (comboBoxSeçim.SelectedIndex == 10)//küre küre
            {
                textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true; textBox10.Visible = true; labelSonuç.Visible = true;
                label18.Visible = true; label19.Visible = true; label20.Visible = true; label21.Visible = true;
                textBox3.Visible = true; textBox4.Visible = true; textBox5.Visible = true; textBox6.Visible = true;
                label38.Visible = true; label39.Visible = true; label40.Visible = true; label41.Visible = true;
            }

            if (comboBoxSeçim.SelectedIndex == 11)//dikdörtgen prizmasý küre
            {
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; labelSonuç.Visible = true;
                textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true;
                label22.Visible = true; label23.Visible = true; label24.Visible = true; label25.Visible = true;
                label26.Visible = true; label27.Visible = true;
                textBox4.Visible = true; textBox5.Visible = true; textBox6.Visible = true; textBox10.Visible = true;
                label38.Visible = true; label39.Visible = true; label42.Visible = true; label41.Visible = true;

            }


            if (comboBoxSeçim.SelectedIndex == 12) //prizma prizma çarpýþmasý
            {
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; labelSonuç.Visible = true;
                textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true;
                label22.Visible = true; label23.Visible = true; label24.Visible = true; label25.Visible = true;
                label26.Visible = true; label27.Visible = true;
                textBox4.Visible = true; textBox5.Visible = true; textBox6.Visible = true;
                textBox10.Visible = true; textBox11.Visible = true; textBox12.Visible = true;
                label43.Visible = true; label44.Visible = true; label45.Visible = true; label46.Visible = true;
                label47.Visible = true; label48.Visible = true;

            }
            if (comboBoxSeçim.SelectedIndex == 13) //silindir yüzey
            {
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox7.Visible = true; textBox8.Visible = true;
                label28.Visible = true; label29.Visible = true; label30.Visible = true; label31.Visible = true; label32.Visible = true;
                label49.Visible = true; label50.Visible = true; textBox4.Visible = true; textBox5.Visible = true; labelSonuç.Visible = true;

            }


            if (comboBoxSeçim.SelectedIndex == 14)//küre yüzey
            {
                textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true; textBox10.Visible = true; labelSonuç.Visible = true;
                label49.Visible = true; label50.Visible = true; textBox4.Visible = true; textBox5.Visible = true;
                label18.Visible = true; label19.Visible = true; label20.Visible = true; label21.Visible = true;
            }

            if (comboBoxSeçim.SelectedIndex == 15)  //prizma yüzey
            {
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; labelSonuç.Visible = true;
                textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true;
                label22.Visible = true; label23.Visible = true; label24.Visible = true; label25.Visible = true;
                label26.Visible = true; label27.Visible = true; label49.Visible = true; label50.Visible = true;
                textBox4.Visible = true; textBox5.Visible = true;


            }

        }

        private void buttonKontrol_Click(object sender, EventArgs e)
        {
            switch (comboBoxSeçim.SelectedIndex)
            {
                case 0:

                    // Textbox'lardaki deðerleri al
                    int x1 = int.Parse(textBox1.Text);
                    int y1 = int.Parse(textBox2.Text);
                    int x2 = int.Parse(textBox3.Text);
                    int y2 = int.Parse(textBox4.Text);
                    int x3 = int.Parse(textBox5.Text);
                    int y3 = int.Parse(textBox6.Text);

                    dikdörtgen d1 = new dikdörtgen
                    {
                        SolUstKose = new Nokta { X = x1, Y = y1 },
                        SagAltKose = new Nokta { X = x2, Y = y2 }
                    };

                    Nokta nokta = new Nokta { X = x3, Y = y3 };

                    bool carpismaVarMi = d1.dikdörtgennoktaçarpýþma(nokta);

                    if (carpismaVarMi)
                    {
                        labelSonuç.Text = "Çarpþýyorlar"; // çarpýþma varsa "Evet" yazdýr
                        
                        
                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'ýn boyutunu belirle

                            // Noktayý çizmek için bir fýrça oluþturun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = x3 + pictureBox1.Width / 2;
                            int pointY = -y3 + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                            // dikdörtgenin içini çizmek için bir kalem oluþturun
                            Pen pen = new Pen(Color.Black);
                            int width = Math.Abs(x2 - x1);
                            int height = Math.Abs(y2 - y1);
                            int topLeftX = x1 + pictureBox1.Width / 2;
                            int topLeftY = y1 + pictureBox1.Height / 2;
                            g.DrawRectangle(pen, topLeftX, topLeftY, width, height);
                            pen.Dispose();



                        }
                    }
                    else
                    {
                        labelSonuç.Text = "Çarpýþmýyorlar"; // çarpýþma yoksa "Hayýr" yazdýr
                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'ýn boyutunu belirle

                            // Noktayý çizmek için bir fýrça oluþturun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = x3 + pictureBox1.Width / 2;
                            int pointY = -y3 + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                            // dikdörtgenin içini çizmek için bir kalem oluþturun
                            Pen pen = new Pen(Color.Black);


                            // dikdörtgenin içini çizmek için bir kalem oluþturun
                            int width = Math.Abs(x2 - x1);
                            int height = Math.Abs(y2 - y1);
                            int topLeftX = x1 + pictureBox1.Width / 2;
                            int topLeftY = y1 + pictureBox1.Height / 2;
                            g.DrawRectangle(pen, topLeftX, topLeftY, width, height);
                            pen.Dispose();

                            // Kullanýlan nesneleri temizleyin
                            pen.Dispose();



                        }


                    }

                    break;


                case 1:

                    int nokta1x = int.Parse(textBox5.Text);
                    int nokta1y = int.Parse(textBox6.Text);
                    int çember1x = int.Parse(textBox2.Text);
                    int çember1y = int.Parse(textBox3.Text);
                    int çemberyarýçap1 = int.Parse(textBox4.Text);

                    Nokta nokta1 = new Nokta { X = nokta1x, Y = nokta1y };
                    Cember cember = new Cember { Merkez = new Nokta { X = çember1x, Y = çember1y }, YariCap = çemberyarýçap1 };

                    bool Carp = cember.çarpýþtýlarmý(nokta1);

                    if (Carp)
                    {
                        labelSonuç.Text = "Çarpþýyorlar"; // çarpýþma varsa "Evet" yazdýr

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'ýn boyutunu belirle

                            // Noktayý çizmek için bir fýrça oluþturun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = nokta1x + pictureBox1.Width / 2;
                            int pointY = -nokta1y + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                        }
                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Çemberin içini çizmek için bir kalem oluþturun
                            Pen pen = new Pen(Color.Black);

                            // Çemberi çizin
                            int diameter = çemberyarýçap1 * 2;
                            int centerX = çember1x - çemberyarýçap1 + pictureBox1.Width / 2;
                            int centerY = çember1y - çemberyarýçap1 + pictureBox1.Height / 2;
                            g.DrawEllipse(pen, centerX, centerY, diameter, diameter);

                            // Kullanýlan nesneleri temizleyin
                            pen.Dispose();
                        }


                    }
                    else
                    {
                        labelSonuç.Text = "Çarpýþmýyorlar"; // çarpýþma yoksa "Hayýr" yazdýr


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'ýn boyutunu belirle

                            // Noktayý çizmek için bir fýrça oluþturun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = nokta1x + pictureBox1.Width / 2;
                            int pointY = -nokta1y + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                            // Kullanýlan nesneleri temizleyin
                            brush.Dispose();
                        }
                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Çemberin içini çizmek için bir kalem oluþturun
                            Pen pen = new Pen(Color.Black);

                            // Çemberi çizin
                            int diameter = çemberyarýçap1 * 2;
                            int centerX = çember1x - çemberyarýçap1 + pictureBox1.Width / 2;
                            int centerY = çember1y - çemberyarýçap1 + pictureBox1.Height / 2;
                            g.DrawEllipse(pen, centerX, centerY, diameter, diameter);

                            // Kullanýlan nesneleri temizleyin
                            pen.Dispose();
                        }
                    }

                    break;

                case 2:
                    int d2solustx = int.Parse(textBox1.Text);
                    int d2solusty = int.Parse(textBox2.Text);
                    int d2saðaltx = int.Parse(textBox3.Text);
                    int d2saðalty = int.Parse(textBox4.Text);
                    int d3solustx = int.Parse(textBox7.Text);
                    int d3solusty = int.Parse(textBox8.Text);
                    int d3saðaltx = int.Parse(textBox9.Text);
                    int d3saðalty = int.Parse(textBox10.Text);

                    dikdörtgen d2 = new dikdörtgen
                    {
                        SolUstKose = new Nokta { X = d2solustx, Y = d2solusty },
                        SagAltKose = new Nokta { X = d2saðaltx, Y = d2saðalty }
                    };


                    dikdörtgen d3 = new dikdörtgen
                    {
                        SolUstKose = new Nokta { X = d3solustx, Y = d3solusty },
                        SagAltKose = new Nokta { X = d3saðaltx, Y = d3saðalty }
                    };

                    if (d2.dortgenlercarpýþtýmý(d3))
                    {
                        pictureBox1.Size = new Size(284, 459);

                        labelSonuç.Text = "Çarpþýyorlar"; // çarpýþma varsa "Evet" yazdýr
                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Pen pen1 = new Pen(Color.Red, 2);
                            Pen pen2 = new Pen(Color.Blue, 2);

                            // dikdörtgen 2'yi çizdir
                            int d2Width = Math.Abs(d2saðaltx - d2solustx);
                            int d2Height = Math.Abs(d2saðalty - d2solusty);
                            int d2TopLeftX = d2solustx + pictureBox1.Width / 2;
                            int d2TopLeftY = d2solusty + pictureBox1.Height / 2;
                            g.DrawRectangle(pen1, d2TopLeftX, d2TopLeftY, d2Width, d2Height);

                            int d3Width = Math.Abs(d3saðaltx - d3solustx);
                            int d3Height = Math.Abs(d3saðalty - d3solusty);
                            int d3TopLeftX = d3solustx + pictureBox1.Width / 2;
                            int d3TopLeftY = d3solusty + pictureBox1.Height / 2;
                            g.DrawRectangle(pen2, d3TopLeftX, d3TopLeftY, d3Width, d3Height);

                            pen1.Dispose();
                            pen2.Dispose();


                        }
                    }
                    else
                    {
                        labelSonuç.Text = "Çarpýþmýyorlar"; // çarpýþma yoksa "Hayýr" yazdýr
                        pictureBox1.Size = new Size(284, 459);

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Pen pen1 = new Pen(Color.Red, 2);
                            Pen pen2 = new Pen(Color.Blue, 2);

                            // dikdörtgen 2'yi çizdir
                            int d2Width = Math.Abs(d2saðaltx - d2solustx);
                            int d2Height = Math.Abs(d2saðalty - d2solusty);
                            int d2TopLeftX = d2solustx + pictureBox1.Width / 2;
                            int d2TopLeftY = d2solusty + pictureBox1.Height / 2;
                            g.DrawRectangle(pen1, d2TopLeftX, d2TopLeftY, d2Width, d2Height);

                            int d3Width = Math.Abs(d3saðaltx - d3solustx);
                            int d3Height = Math.Abs(d3saðalty - d3solusty);
                            int d3TopLeftX = d3solustx + pictureBox1.Width / 2;
                            int d3TopLeftY = d3solusty + pictureBox1.Height / 2;
                            g.DrawRectangle(pen2, d3TopLeftX, d3TopLeftY, d3Width, d3Height);

                            pen1.Dispose();
                            pen2.Dispose();



                        }

                        }


                        break;

                case 3:
                    int çember2x = int.Parse(textBox2.Text);
                    int çember2y = int.Parse(textBox3.Text);
                    int çemberyarýçap2 = int.Parse(textBox4.Text);
                    int d4solustx = int.Parse(textBox7.Text);
                    int d4solusty = int.Parse(textBox8.Text);
                    int d4saðaltx = int.Parse(textBox9.Text);
                    int d4saðalty = int.Parse(textBox10.Text);

                    dikdörtgen d4 = new dikdörtgen
                    {
                        SolUstKose = new Nokta { X = d4solustx, Y = d4solusty },
                        SagAltKose = new Nokta { X = d4saðaltx, Y = d4saðalty }
                    };

                    Cember cember2 = new Cember { Merkez = new Nokta { X = çember2x, Y = çember2y }, YariCap = çemberyarýçap2 };



                    if (d4.cemberdörtgencarpýþtýmý(cember2))
                    {
                        labelSonuç.Text = "Çarpþýyorlar"; // çarpýþma varsa "Evet" yazdýr

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Çemberin içini çizmek için bir kalem oluþturun
                            Pen pen = new Pen(Color.Black);
                            pictureBox1.Size = new Size(284, 459);

                            // Çemberi çizin
                            int diameter = çemberyarýçap2 * 2;
                            int centerX = çember2x - çemberyarýçap2 + pictureBox1.Width / 2;
                            int centerY = çember2y - çemberyarýçap2 + pictureBox1.Height / 2;
                            g.DrawEllipse(pen, centerX, centerY, diameter, diameter);

                            // Kullanýlan nesneleri temizleyin
                            pen.Dispose();
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Pen pen1 = new Pen(Color.Red, 2);
                           

                            // dikdörtgen 2'yi çizdir
                            int d2Width = Math.Abs(d4saðaltx - d4solustx);
                            int d2Height = Math.Abs(d4saðalty - d4solusty);
                            int d2TopLeftX = d4solustx + pictureBox1.Width / 2;
                            int d2TopLeftY = d4solusty + pictureBox1.Height / 2;
                            g.DrawRectangle(pen1, d2TopLeftX, d2TopLeftY, d2Width, d2Height);
                            pen1.Dispose();

                        }
                    }
                    else
                    {
                        labelSonuç.Text = "Çarpýþmýyorlar"; // çarpýþma yoksa "Hayýr" yazdýr

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Çemberin içini çizmek için bir kalem oluþturun
                            Pen pen = new Pen(Color.Black);
                            pictureBox1.Size = new Size(284, 459);

                            // Çemberi çizin
                            int diameter = çemberyarýçap2 * 2;
                            int centerX = çember2x - çemberyarýçap2 + pictureBox1.Width / 2;
                            int centerY = çember2y - çemberyarýçap2 + pictureBox1.Height / 2;
                            g.DrawEllipse(pen, centerX, centerY, diameter, diameter);

                            // Kullanýlan nesneleri temizleyin
                            pen.Dispose();
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Pen pen1 = new Pen(Color.Red, 2);
                            pictureBox1.Size = new Size(284, 459);


                            // dikdörtgen 2'yi çizdir
                            int d2Width = Math.Abs(d4saðaltx - d4solustx);
                            int d2Height = Math.Abs(d4saðalty - d4solusty);
                            int d2TopLeftX = d4solustx + pictureBox1.Width / 2;
                            int d2TopLeftY = d4solusty + pictureBox1.Height / 2;
                            g.DrawRectangle(pen1, d2TopLeftX, d2TopLeftY, d2Width, d2Height);
                            pen1.Dispose();

                        }





                    }

                    break;


                case 4:
                    int çember3x = int.Parse(textBox2.Text);
                    int çember3y = int.Parse(textBox3.Text);
                    int çemberyarýçap3 = int.Parse(textBox4.Text);
                    int çember4x = int.Parse(textBox8.Text);
                    int çember4y = int.Parse(textBox9.Text);
                    int çemberyarýçap4 = int.Parse(textBox10.Text);


                    Cember cember3 = new Cember { Merkez = new Nokta { X = çember3x, Y = çember3y }, YariCap = çemberyarýçap3 };
                    Cember cember4 = new Cember { Merkez = new Nokta { X = çember4x, Y = çember4y }, YariCap = çemberyarýçap4 };

                    bool a = Cember.CemberCemberCarpisiyorMu(cember3, cember4);

                    if (a)
                    {
                        labelSonuç.Text = "Çarpþýyorlar"; // çarpýþma varsa "Evet" yazdýr

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Çemberin içini çizmek için bir kalem oluþturun
                            Pen pen = new Pen(Color.Black);
                            pictureBox1.Size = new Size(284, 459);

                            // Çemberi çizin
                            int diameter = çemberyarýçap3 * 2;
                            int centerX = çember3x - çemberyarýçap3 + pictureBox1.Width / 2;
                            int centerY = çember3y - çemberyarýçap3 + pictureBox1.Height / 2;
                            g.DrawEllipse(pen, centerX, centerY, diameter, diameter);

                            // Kullanýlan nesneleri temizleyin
                            pen.Dispose();
                        }

                        using(Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Çemberin içini çizmek için bir kalem oluþturun
                            Pen pen = new Pen(Color.Black);
                            pictureBox1.Size = new Size(284, 459);

                            // Çemberi çizin
                            int diameter = çemberyarýçap4 * 2;
                            int centerX = çember4x - çemberyarýçap4 + pictureBox1.Width / 2;
                            int centerY = çember4y - çemberyarýçap4 + pictureBox1.Height / 2;
                            g.DrawEllipse(pen, centerX, centerY, diameter, diameter);

                            // Kullanýlan nesneleri temizleyin
                            pen.Dispose();
                        }


                    }
                    else
                    {
                        labelSonuç.Text = "Çarpýþmýyorlar"; // çarpýþma yoksa "Hayýr" yazdýr
                    }

                    break;

                case 5:

                    int nokta3x = int.Parse(textBox5.Text);
                    int nokta3y = int.Parse(textBox6.Text);
                    int nokta3z = int.Parse(textBox4.Text);
                    int kurex = int.Parse(textBox7.Text);
                    int kurey = int.Parse(textBox8.Text);
                    int kurez = int.Parse(textBox9.Text);
                    int kureyarýçap = int.Parse(textBox10.Text);

                    ucboyutlunokta nokta3 = new ucboyutlunokta { X = nokta3x, Y = nokta3y, Z = nokta3z };
                    kure kure1 = new kure { merkezkure = new ucboyutlunokta { X = kurex, Y = kurey, Z = kurez }, YariCap = kureyarýçap };

                    bool b = kure1.kurenokta(nokta3);

                    if (b)
                    {
                        labelSonuç.Text = "Çarpþýyorlar"; // çarpýþma varsa "Evet" yazdýr

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin çapý ve merkez koordinatlarý
                            int diameter = kureyarýçap;
                            int centerX = kurex - kureyarýçap + pictureBox1.Width / 2;
                            int centerY =kurey-kureyarýçap+ pictureBox1.Height / 2;

                            // Daireyi çizdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlarý ve merkez koordinatlarý
                            int ellipseWidth = kureyarýçap;
                            int ellipseHeight = 35;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi çizdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullanýlan nesneleri temizle
                            pen.Dispose();
                        }



                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'ýn boyutunu belirle

                            // Noktayý çizmek için bir fýrça oluþturun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = nokta3x + pictureBox1.Width / 2;
                            int pointY = -nokta3y + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                            // Kullanýlan nesneleri temizleyin
                            brush.Dispose();
                        }




                    }
                    else
                    {
                        labelSonuç.Text = "Çarpýþmýyorlar"; // çarpýþma yoksa "Hayýr" yazdýr

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin çapý ve merkez koordinatlarý
                            int diameter = kureyarýçap;
                            int centerX = kurex - kureyarýçap + pictureBox1.Width / 2;
                            int centerY = kurey - kureyarýçap + pictureBox1.Height / 2;

                            // Daireyi çizdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlarý ve merkez koordinatlarý
                            int ellipseWidth = kureyarýçap;
                            int ellipseHeight = 35;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi çizdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullanýlan nesneleri temizle
                            pen.Dispose();
                        }



                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'ýn boyutunu belirle

                            // Noktayý çizmek için bir fýrça oluþturun
                            Brush brush = new SolidBrush(Color.Red);

                            Brush brush2 = new SolidBrush(Color.Red);
                            int pointX = nokta3x + pictureBox1.Width / 2;
                            int pointY = -nokta3y + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 10, 10);
                            brush.Dispose();

                            // Kullanýlan nesneleri temizleyin
                            brush.Dispose();
                        }

                      
                    }
                    break;

                case 6:

                    int nokta4x = int.Parse(textBox5.Text);
                    int nokta4y = int.Parse(textBox6.Text);
                    int nokta4z = int.Parse(textBox4.Text);
                    int prizmamerkezx = int.Parse(textBox1.Text);
                    int prizmamerkezy = int.Parse(textBox2.Text);
                    int prizmamerkezz = int.Parse(textBox3.Text);
                    int prizmayukseklik = int.Parse(textBox7.Text);
                    int prizmageniþlik = int.Parse(textBox8.Text);
                    int prizmauzunluk = int.Parse(textBox9.Text);

                    ucboyutlunokta nokta4 = new ucboyutlunokta { X = nokta4x, Y = nokta4y, Z = nokta4z };

                    dikdörtgenprizmasý prizma = new dikdörtgenprizmasý
                    {
                        MerkezPrizma = new ucboyutlunokta { X = prizmamerkezx, Y = prizmamerkezy, Z = prizmamerkezz },
                        Yukseklik = prizmayukseklik,
                        Uzunluk = prizmauzunluk,
                        Genislik = prizmageniþlik
                    };

                    bool c = prizma.prizmanoktaçarpýþma(nokta4);


                    if (c)
                    {
                        labelSonuç.Text = "Çarpþýyorlar"; // çarpýþma varsa "Evet" yazdýr


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikdörtgen oluþturuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizmageniþlik, prizmageniþlik);


                            // Prizmanýn yüzeylerini çiziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizmageniþlik / 2, 0), new Point(75 + prizmageniþlik + prizmageniþlik / 2, 0), new Point(75 + prizmageniþlik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizmauzunluk), new Point(75 + prizmageniþlik / 2, prizmauzunluk), new Point(75 + prizmageniþlik + prizmageniþlik / 2, prizmauzunluk), new Point(75 + prizmageniþlik, 75 + prizmauzunluk) };
                            Point[] points3 = { new Point(75 + prizmageniþlik, 75), new Point(75 + prizmageniþlik / 2 + prizmageniþlik, 0), new Point(75 + prizmageniþlik / 2 + prizmageniþlik, prizmauzunluk), new Point(75 + prizmageniþlik, 75 + prizmauzunluk) };
                            
                            // Dikdörtgenleri ve prizmanýn yüzeylerini çiziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);

                           
                           
                        }



                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'ýn boyutunu belirle

                            // Noktayý çizmek için bir fýrça oluþturun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = nokta4x + pictureBox1.Width / 2;
                            int pointY = -nokta4y + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                            // Kullanýlan nesneleri temizleyin
                            brush.Dispose();
                        }


                    }
                    else
                    {
                        labelSonuç.Text = "Çarpýþmýyorlar"; // çarpýþma yoksa "Hayýr" yazdýr

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikdörtgen oluþturuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizmageniþlik, prizmageniþlik);


                            // Prizmanýn yüzeylerini çiziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizmageniþlik / 2, 0), new Point(75 + prizmageniþlik + prizmageniþlik / 2, 0), new Point(75 + prizmageniþlik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizmauzunluk), new Point(75 + prizmageniþlik / 2, prizmauzunluk), new Point(75 + prizmageniþlik + prizmageniþlik / 2, prizmauzunluk), new Point(75 + prizmageniþlik, 75 + prizmauzunluk) };
                            Point[] points3 = { new Point(75 + prizmageniþlik, 75), new Point(75 + prizmageniþlik / 2 + prizmageniþlik, 0), new Point(75 + prizmageniþlik / 2 + prizmageniþlik, prizmauzunluk), new Point(75 + prizmageniþlik, 75 + prizmauzunluk) };

                            // Dikdörtgenleri ve prizmanýn yüzeylerini çiziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);


                        }



                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'ýn boyutunu belirle

                            // Noktayý çizmek için bir fýrça oluþturun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = nokta4x + pictureBox1.Width / 2;
                            int pointY = -nokta4y + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                            // Kullanýlan nesneleri temizleyin
                            brush.Dispose();
                        }





                    }
                    break;


                case 7:

                    int nokta5x = int.Parse(textBox5.Text);
                    int nokta5y = int.Parse(textBox6.Text);
                    int nokta5z = int.Parse(textBox4.Text);
                    int silindirmerkezx = int.Parse(textBox1.Text);
                    int silindirmerkezy = int.Parse(textBox2.Text);
                    int silindirmerkezz = int.Parse(textBox3.Text);
                    int silindiryukseklik = int.Parse(textBox7.Text);
                    int silindiryarýçap = int.Parse(textBox8.Text);

                    ucboyutlunokta nokta5 = new ucboyutlunokta { X = nokta5x, Y = nokta5y, Z = nokta5z };

                    silindir silindir = new silindir
                    {
                        silindirmerkez = new ucboyutlunokta { X = silindirmerkezx, Y = silindirmerkezy, Z = silindirmerkezz },
                        YariCap = silindiryarýçap,
                        Yukseklik = silindiryukseklik

                    };

                    if (silindir.silindirnokta(nokta5))
                    {
                        labelSonuç.Text = "Çarpþýyorlar"; // çarpýþma varsa "Evet" yazdýr

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindirmerkezx;
                            int y = silindirmerkezy;
                            int r = silindiryarýçap;
                            int h = silindiryukseklik;

                            Pen pen = new Pen(Color.Black, 2);
                        

                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol üst
                            Point p3 = new Point(x + r, y + h); // sað üst
                            Point p4 = new Point(x + r, y); // sað alt

                            // taban yüzeyi ile sol yan yüzeyi birleþtir
                            g.DrawLine(pen, p1, p2);
                            // sol yan yüzeyi ile üst yüzeyi birleþtir
                            g.DrawLine(pen, p2, p3);
                            // üst yüzeyi ile sað yan yüzeyi birleþtir
                            g.DrawLine(pen, p3, p4);
                            // sað yan yüzeyi ile taban yüzeyi birleþtir
                            g.DrawLine(pen, p4, p1);
                        
                            // Sol elipsin merkez noktasýný hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sað elipsin merkez noktasýný hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey çizgileri çiz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan yüzeyi çiz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'ýn boyutunu belirle

                            // Noktayý çizmek için bir fýrça oluþturun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = nokta5x + pictureBox1.Width / 2;
                            int pointY = -nokta5y + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                            // Kullanýlan nesneleri temizleyin
                            brush.Dispose();
                        }



                    }


                    else
                    {
                        labelSonuç.Text = "Çarpýþmýyorlar"; // çarpýþma yoksa "Hayýr" yazdýr

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindirmerkezx;
                            int y = silindirmerkezy;
                            int r = silindiryarýçap;
                            int h = silindiryukseklik;

                            Pen pen = new Pen(Color.Black, 2);
                           

                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol üst
                            Point p3 = new Point(x + r, y + h); // sað üst
                            Point p4 = new Point(x + r, y); // sað alt

                            // taban yüzeyi ile sol yan yüzeyi birleþtir
                            g.DrawLine(pen, p1, p2);
                            // sol yan yüzeyi ile üst yüzeyi birleþtir
                            g.DrawLine(pen, p2, p3);
                            // üst yüzeyi ile sað yan yüzeyi birleþtir
                            g.DrawLine(pen, p3, p4);
                            // sað yan yüzeyi ile taban yüzeyi birleþtir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktasýný hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sað elipsin merkez noktasýný hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey çizgileri çiz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan yüzeyi çiz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));

                        }


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'ýn boyutunu belirle

                            // Noktayý çizmek için bir fýrça oluþturun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = nokta5x + pictureBox1.Width / 2;
                            int pointY = -nokta5y + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                            // Kullanýlan nesneleri temizleyin
                            brush.Dispose();
                        }




                    }

                    break;


                case 8:
                    int silindir1merkezx = int.Parse(textBox1.Text);
                    int silindir1merkezy = int.Parse(textBox2.Text);
                    int silindir1merkezz = int.Parse(textBox3.Text);
                    int silindir1yukseklik = int.Parse(textBox7.Text);
                    int silindir1yarýçap = int.Parse(textBox8.Text);
                    int silindir2merkezy = int.Parse(textBox5.Text);
                    int silindir2merkezz = int.Parse(textBox6.Text);
                    int silindir2merkezx = int.Parse(textBox4.Text);
                    int silindir2yukseklik = int.Parse(textBox9.Text);
                    int silindir2yarýcap = int.Parse(textBox10.Text);


                    silindir silindir1 = new silindir
                    {
                        silindirmerkez = new ucboyutlunokta { X = silindir1merkezx, Y = silindir1merkezy, Z = silindir1merkezz },
                        YariCap = silindir1yarýçap,
                        Yukseklik = silindir1yukseklik

                    };

                    silindir silindir2 = new silindir
                    {
                        silindirmerkez = new ucboyutlunokta { X = silindir2merkezx, Y = silindir2merkezy, Z = silindir2merkezz },
                        YariCap = silindir2yarýcap,
                        Yukseklik = silindir2yukseklik

                    };

                    bool silindirlerCarpisiyorMu = silindir1.silindirsilindire(silindir2);



                    if (silindirlerCarpisiyorMu)
                    {
                        labelSonuç.Text = "Çarpþýyorlar"; // çarpýþma varsa "Evet" yazdýr


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir1merkezx;
                            int y = silindir1merkezy;
                            int r = silindir1yarýçap;
                            int h = silindir1yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol üst
                            Point p3 = new Point(x + r, y + h); // sað üst
                            Point p4 = new Point(x + r, y); // sað alt

                            // taban yüzeyi ile sol yan yüzeyi birleþtir
                            g.DrawLine(pen, p1, p2);
                            // sol yan yüzeyi ile üst yüzeyi birleþtir
                            g.DrawLine(pen, p2, p3);
                            // üst yüzeyi ile sað yan yüzeyi birleþtir
                            g.DrawLine(pen, p3, p4);
                            // sað yan yüzeyi ile taban yüzeyi birleþtir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktasýný hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sað elipsin merkez noktasýný hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey çizgileri çiz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan yüzeyi çiz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir2merkezx;
                            int y = silindir2merkezy;
                            int r = silindir2yarýcap;
                            int h = silindir2yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol üst
                            Point p3 = new Point(x + r, y + h); // sað üst
                            Point p4 = new Point(x + r, y); // sað alt

                            // taban yüzeyi ile sol yan yüzeyi birleþtir
                            g.DrawLine(pen, p1, p2);
                            // sol yan yüzeyi ile üst yüzeyi birleþtir
                            g.DrawLine(pen, p2, p3);
                            // üst yüzeyi ile sað yan yüzeyi birleþtir
                            g.DrawLine(pen, p3, p4);
                            // sað yan yüzeyi ile taban yüzeyi birleþtir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktasýný hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sað elipsin merkez noktasýný hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey çizgileri çiz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan yüzeyi çiz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }




                    }
                    else
                    {
                        labelSonuç.Text = "Çarpýþmýyorlar"; // çarpýþma yoksa "Hayýr" yazdýr


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir1merkezx;
                            int y = silindir1merkezy;
                            int r = silindir1yarýçap;
                            int h = silindir1yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol üst
                            Point p3 = new Point(x + r, y + h); // sað üst
                            Point p4 = new Point(x + r, y); // sað alt

                            // taban yüzeyi ile sol yan yüzeyi birleþtir
                            g.DrawLine(pen, p1, p2);
                            // sol yan yüzeyi ile üst yüzeyi birleþtir
                            g.DrawLine(pen, p2, p3);
                            // üst yüzeyi ile sað yan yüzeyi birleþtir
                            g.DrawLine(pen, p3, p4);
                            // sað yan yüzeyi ile taban yüzeyi birleþtir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktasýný hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sað elipsin merkez noktasýný hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey çizgileri çiz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan yüzeyi çiz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir2merkezx;
                            int y = silindir2merkezy;
                            int r = silindir2yarýcap;
                            int h = silindir2yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol üst
                            Point p3 = new Point(x + r, y + h); // sað üst
                            Point p4 = new Point(x + r, y); // sað alt

                            // taban yüzeyi ile sol yan yüzeyi birleþtir
                            g.DrawLine(pen, p1, p2);
                            // sol yan yüzeyi ile üst yüzeyi birleþtir
                            g.DrawLine(pen, p2, p3);
                            // üst yüzeyi ile sað yan yüzeyi birleþtir
                            g.DrawLine(pen, p3, p4);
                            // sað yan yüzeyi ile taban yüzeyi birleþtir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktasýný hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sað elipsin merkez noktasýný hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey çizgileri çiz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan yüzeyi çiz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }

                    }
                    break;

                case 9:

                    int silindir3merkezx = int.Parse(textBox1.Text);
                    int silindir3merkezy = int.Parse(textBox2.Text);
                    int silindir3merkezz = int.Parse(textBox3.Text);
                    int silindir3yukseklik = int.Parse(textBox7.Text);
                    int silindir3yarýçap = int.Parse(textBox8.Text);
                    int küre1merkezz = int.Parse(textBox9.Text);
                    int küre1yarýçap = int.Parse(textBox10.Text);
                    int küre1merkezx = int.Parse(textBox4.Text);
                    int küre1merkezy = int.Parse(textBox5.Text);


                    silindir silindir3 = new silindir
                    {
                        silindirmerkez = new ucboyutlunokta { X = silindir3merkezx, Y = silindir3merkezy, Z = silindir3merkezz },
                        YariCap = silindir3yarýçap,
                        Yukseklik = silindir3yukseklik

                    };

                    kure küre1 = new kure
                    {
                        merkezkure = new ucboyutlunokta { X = küre1merkezx, Y = küre1merkezy, Z = küre1merkezz },
                        YariCap = küre1yarýçap
                    };

                    if (küre1.TamamenIci(silindir3))
                    {
                        labelSonuç.Text = "Küre tamamen silindirin içinde.";

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir3merkezx;
                            int y = silindir3merkezy;
                            int r = silindir3yarýçap;
                            int h = silindir3yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol üst
                            Point p3 = new Point(x + r, y + h); // sað üst
                            Point p4 = new Point(x + r, y); // sað alt

                            // taban yüzeyi ile sol yan yüzeyi birleþtir
                            g.DrawLine(pen, p1, p2);
                            // sol yan yüzeyi ile üst yüzeyi birleþtir
                            g.DrawLine(pen, p2, p3);
                            // üst yüzeyi ile sað yan yüzeyi birleþtir
                            g.DrawLine(pen, p3, p4);
                            // sað yan yüzeyi ile taban yüzeyi birleþtir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktasýný hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sað elipsin merkez noktasýný hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey çizgileri çiz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan yüzeyi çiz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin çapý ve merkez koordinatlarý
                            int diameter = küre1yarýçap;
                            int centerX = küre1merkezx - küre1yarýçap + pictureBox1.Width / 2;
                            int centerY = küre1merkezy - küre1yarýçap + pictureBox1.Height / 2;

                            // Daireyi çizdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlarý ve merkez koordinatlarý
                            int ellipseWidth = küre1yarýçap;
                            int ellipseHeight = 35;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi çizdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullanýlan nesneleri temizle
                            pen.Dispose();
                        }





                    }
                    else if (küre1.silindirküre(silindir3))
                    {
                        labelSonuç.Text = "Küre silindir ile çarpýþtý.";

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir3merkezx;
                            int y = silindir3merkezy;
                            int r = silindir3yarýçap;
                            int h = silindir3yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol üst
                            Point p3 = new Point(x + r, y + h); // sað üst
                            Point p4 = new Point(x + r, y); // sað alt

                            // taban yüzeyi ile sol yan yüzeyi birleþtir
                            g.DrawLine(pen, p1, p2);
                            // sol yan yüzeyi ile üst yüzeyi birleþtir
                            g.DrawLine(pen, p2, p3);
                            // üst yüzeyi ile sað yan yüzeyi birleþtir
                            g.DrawLine(pen, p3, p4);
                            // sað yan yüzeyi ile taban yüzeyi birleþtir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktasýný hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sað elipsin merkez noktasýný hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey çizgileri çiz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan yüzeyi çiz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin çapý ve merkez koordinatlarý
                            int diameter = küre1yarýçap;
                            int centerX = küre1merkezx - küre1yarýçap + pictureBox1.Width / 2;
                            int centerY = küre1merkezy - küre1yarýçap + pictureBox1.Height / 2;

                            // Daireyi çizdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlarý ve merkez koordinatlarý
                            int ellipseWidth = küre1yarýçap;
                            int ellipseHeight = 35;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi çizdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullanýlan nesneleri temizle
                            pen.Dispose();
                        }




                    }
                    else
                    {
                        labelSonuç.Text = "Küre ne silindirin içinde ne de silindir ile çarpýþtý.";
                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir3merkezx;
                            int y = silindir3merkezy;
                            int r = silindir3yarýçap;
                            int h = silindir3yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol üst
                            Point p3 = new Point(x + r, y + h); // sað üst
                            Point p4 = new Point(x + r, y); // sað alt

                            // taban yüzeyi ile sol yan yüzeyi birleþtir
                            g.DrawLine(pen, p1, p2);
                            // sol yan yüzeyi ile üst yüzeyi birleþtir
                            g.DrawLine(pen, p2, p3);
                            // üst yüzeyi ile sað yan yüzeyi birleþtir
                            g.DrawLine(pen, p3, p4);
                            // sað yan yüzeyi ile taban yüzeyi birleþtir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktasýný hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sað elipsin merkez noktasýný hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey çizgileri çiz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan yüzeyi çiz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin çapý ve merkez koordinatlarý
                            int diameter = küre1yarýçap;
                            int centerX = küre1merkezx - küre1yarýçap + pictureBox1.Width / 2;
                            int centerY = küre1merkezy - küre1yarýçap + pictureBox1.Height / 2;

                            // Daireyi çizdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlarý ve merkez koordinatlarý
                            int ellipseWidth = küre1yarýçap;
                            int ellipseHeight = 35;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi çizdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullanýlan nesneleri temizle
                            pen.Dispose();
                        }



                    }


                    break;


                case 10:
                    int küre2merkezx = int.Parse(textBox7.Text);
                    int küre2merkezy = int.Parse(textBox8.Text);
                    int küre2merkezz = int.Parse(textBox9.Text);
                    int küre2yarýçap = int.Parse(textBox10.Text);
                    int küre3merkezx = int.Parse(textBox4.Text);
                    int küre3merkezy = int.Parse(textBox5.Text);
                    int küre3merkezz = int.Parse(textBox3.Text);
                    int küre3yarýçap = int.Parse(textBox6.Text);

                    kure küre2 = new kure
                    {
                        merkezkure = new ucboyutlunokta { X = küre2merkezx, Y = küre2merkezy, Z = küre2merkezz },
                        YariCap = küre2yarýçap
                    };

                    kure küre3 = new kure
                    {
                        merkezkure = new ucboyutlunokta { X = küre3merkezx, Y = küre3merkezy, Z = küre3merkezz },
                        YariCap = küre3yarýçap
                    };

                    bool k = küre2.kurekure(küre3);


                    if (k)
                    {
                        labelSonuç.Text = "Çarpþýyorlar"; // çarpýþma varsa "Evet" yazdýr

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin çapý ve merkez koordinatlarý
                            int diameter = küre2yarýçap;
                            int centerX = küre2merkezx - küre2yarýçap + pictureBox1.Width / 2;
                            int centerY = küre2merkezy - küre2yarýçap + pictureBox1.Height / 2;

                            // Daireyi çizdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlarý ve merkez koordinatlarý
                            int ellipseWidth = küre2yarýçap;
                            int ellipseHeight = 20;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi çizdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullanýlan nesneleri temizle
                            pen.Dispose();
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin çapý ve merkez koordinatlarý
                            int diameter = küre3yarýçap;
                            int centerX = küre3merkezx - küre3yarýçap + pictureBox1.Width / 2;
                            int centerY = küre3merkezy - küre3yarýçap + pictureBox1.Height / 2;

                            // Daireyi çizdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlarý ve merkez koordinatlarý
                            int ellipseWidth = küre3yarýçap;
                            int ellipseHeight = 20;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi çizdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullanýlan nesneleri temizle
                            pen.Dispose();
                        }


                    }
                    else
                    {
                        labelSonuç.Text = "Çarpýþmýyorlar"; // çarpýþma yoksa "Hayýr" yazdýr

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin çapý ve merkez koordinatlarý
                            int diameter = küre2yarýçap;
                            int centerX = küre2merkezx - küre2yarýçap + pictureBox1.Width / 2;
                            int centerY = küre2merkezy - küre2yarýçap + pictureBox1.Height / 2;

                            // Daireyi çizdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlarý ve merkez koordinatlarý
                            int ellipseWidth = küre2yarýçap;
                            int ellipseHeight = 20;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi çizdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullanýlan nesneleri temizle
                            pen.Dispose();
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin çapý ve merkez koordinatlarý
                            int diameter = küre3yarýçap;
                            int centerX = küre3merkezx - küre3yarýçap + pictureBox1.Width / 2;
                            int centerY = küre3merkezy - küre3yarýçap + pictureBox1.Height / 2;

                            // Daireyi çizdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlarý ve merkez koordinatlarý
                            int ellipseWidth = küre3yarýçap;
                            int ellipseHeight = 20;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi çizdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullanýlan nesneleri temizle
                            pen.Dispose();
                        }





                    }
                    break;




                case 11:
                    int prizma1merkezx = int.Parse(textBox1.Text);
                    int prizma1merkezy = int.Parse(textBox2.Text);
                    int prizma1merkezz = int.Parse(textBox3.Text);
                    int prizma1yukseklik = int.Parse(textBox7.Text);
                    int prizma1geniþlik = int.Parse(textBox8.Text);
                    int prizma1uzunluk = int.Parse(textBox9.Text);
                    int küre4merkezx = int.Parse(textBox4.Text);
                    int küre4merkezy = int.Parse(textBox5.Text);
                    int küre4merkezz = int.Parse(textBox10.Text);
                    int küre4yarýçap = int.Parse(textBox6.Text);

                    dikdörtgenprizmasý prizma2 = new dikdörtgenprizmasý
                    {
                        MerkezPrizma = new ucboyutlunokta { X = prizma1merkezx, Y = prizma1merkezy, Z = prizma1merkezz },
                        Yukseklik = prizma1yukseklik,
                        Uzunluk = prizma1uzunluk,
                        Genislik = prizma1geniþlik
                    };

                    kure küre4 = new kure
                    {
                        merkezkure = new ucboyutlunokta { X = küre4merkezx, Y = küre4merkezy, Z = küre4merkezz },
                        YariCap = küre4yarýçap

                    };


                    bool d = prizma2.prizmaküreçarpýþma(küre4);


                    if (d)
                    {
                        labelSonuç.Text = "Çarpþýyorlar"; // çarpýþma varsa "Evet" yazdýr

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin çapý ve merkez koordinatlarý
                            int diameter = küre4yarýçap;
                            int centerX = küre4merkezx - küre4yarýçap + pictureBox1.Width / 2;
                            int centerY = küre4merkezy - küre4yarýçap + pictureBox1.Height / 2;

                            // Daireyi çizdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlarý ve merkez koordinatlarý
                            int ellipseWidth = küre4yarýçap;
                            int ellipseHeight = 20;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi çizdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullanýlan nesneleri temizle
                            pen.Dispose();
                        }


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikdörtgen oluþturuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizma1geniþlik, prizma1geniþlik);


                            // Prizmanýn yüzeylerini çiziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizma1geniþlik / 2, 0), new Point(75 + prizma1geniþlik + prizma1geniþlik / 2, 0), new Point(75 + prizma1geniþlik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizma1uzunluk), new Point(75 + prizma1geniþlik / 2, prizma1uzunluk), new Point(75 + prizma1geniþlik + prizma1geniþlik / 2, prizma1uzunluk), new Point(75 + prizma1geniþlik, 75 + prizma1uzunluk) };
                            Point[] points3 = { new Point(75 + prizma1geniþlik, 75), new Point(75 + prizma1geniþlik / 2 + prizma1geniþlik, 0), new Point(75 + prizma1geniþlik / 2 + prizma1geniþlik, prizma1uzunluk), new Point(75 + prizma1geniþlik, 75 + prizma1uzunluk) };

                            // Dikdörtgenleri ve prizmanýn yüzeylerini çiziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);


                        }



                    }
                    else
                    {
                        labelSonuç.Text = "Çarpýþmýyorlar"; // çarpýþma yoksa "Hayýr" yazdýr

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin çapý ve merkez koordinatlarý
                            int diameter = küre4yarýçap;
                            int centerX = küre4merkezx - küre4yarýçap + pictureBox1.Width / 2;
                            int centerY = küre4merkezy - küre4yarýçap + pictureBox1.Height / 2;

                            // Daireyi çizdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlarý ve merkez koordinatlarý
                            int ellipseWidth = küre4yarýçap;
                            int ellipseHeight = 20;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi çizdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullanýlan nesneleri temizle
                            pen.Dispose();
                        }


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikdörtgen oluþturuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizma1geniþlik, prizma1geniþlik);


                            // Prizmanýn yüzeylerini çiziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizma1geniþlik / 2, 0), new Point(75 + prizma1geniþlik + prizma1geniþlik / 2, 0), new Point(75 + prizma1geniþlik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizma1uzunluk), new Point(75 + prizma1geniþlik / 2, prizma1uzunluk), new Point(75 + prizma1geniþlik + prizma1geniþlik / 2, prizma1uzunluk), new Point(75 + prizma1geniþlik, 75 + prizma1uzunluk) };
                            Point[] points3 = { new Point(75 + prizma1geniþlik, 75), new Point(75 + prizma1geniþlik / 2 + prizma1geniþlik, 0), new Point(75 + prizma1geniþlik / 2 + prizma1geniþlik, prizma1uzunluk), new Point(75 + prizma1geniþlik, 75 + prizma1uzunluk) };

                            // Dikdörtgenleri ve prizmanýn yüzeylerini çiziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);


                        }




                    }
                    break;

                case 12:

                    int prizma4merkezx = int.Parse(textBox1.Text);
                    int prizma4merkezy = int.Parse(textBox2.Text);
                    int prizma4merkezz = int.Parse(textBox3.Text);
                    int prizma4yukseklik = int.Parse(textBox7.Text);
                    int prizma4geniþlik = int.Parse(textBox8.Text);
                    int prizma4uzunluk = int.Parse(textBox9.Text);

                    int prizma3merkezx = int.Parse(textBox4.Text);
                    int prizma3merkezy = int.Parse(textBox5.Text);
                    int prizma3merkezz = int.Parse(textBox6.Text);
                    int prizma3yukseklik = int.Parse(textBox10.Text);
                    int prizma3geniþlik = int.Parse(textBox11.Text);
                    int prizma3uzunluk = int.Parse(textBox12.Text);


                    dikdörtgenprizmasý prizma4 = new dikdörtgenprizmasý
                    {
                        MerkezPrizma = new ucboyutlunokta { X = prizma4merkezx, Y = prizma4merkezy, Z = prizma4merkezz },
                        Yukseklik = prizma4yukseklik,
                        Uzunluk = prizma4uzunluk,
                        Genislik = prizma4geniþlik
                    };


                    dikdörtgenprizmasý prizma3 = new dikdörtgenprizmasý
                    {
                        MerkezPrizma = new ucboyutlunokta { X = prizma3merkezx, Y = prizma3merkezy, Z = prizma3merkezz },
                        Yukseklik = prizma3yukseklik,
                        Uzunluk = prizma3uzunluk,
                        Genislik = prizma3geniþlik
                    };

                    bool sonuc3 = prizma3.DikdortgenPrizmaCarpisma(prizma3, prizma4);


                    if (sonuc3)
                    {
                        labelSonuç.Text = "Çarpþýyorlar"; // çarpýþma varsa "Evet" yazdýr

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikdörtgen oluþturuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizma3geniþlik, prizma3geniþlik);


                            // Prizmanýn yüzeylerini çiziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizma3geniþlik / 2, 0), new Point(75 + prizma3geniþlik + prizma3geniþlik / 2, 0), new Point(75 + prizma3geniþlik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizma3uzunluk), new Point(75 + prizma3geniþlik / 2, prizma3uzunluk), new Point(75 + prizma3geniþlik + prizma3geniþlik / 2, prizma3uzunluk), new Point(75 + prizma3geniþlik, 75 + prizma3uzunluk) };
                            Point[] points3 = { new Point(75 + prizma3geniþlik, 75), new Point(75 + prizma3geniþlik / 2 + prizma3geniþlik, 0), new Point(75 + prizma3geniþlik / 2 + prizma3geniþlik, prizma3uzunluk), new Point(75 + prizma3geniþlik, 75 + prizma3uzunluk) };

                            // Dikdörtgenleri ve prizmanýn yüzeylerini çiziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);


                        }


                        using(Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikdörtgen oluþturuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizma4geniþlik, prizma4geniþlik);


                            // Prizmanýn yüzeylerini çiziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizma4geniþlik / 2, 0), new Point(75 + prizma4geniþlik + prizma4geniþlik / 2, 0), new Point(75 + prizma4geniþlik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizma4uzunluk), new Point(75 + prizma4geniþlik / 2, prizma4uzunluk), new Point(75 + prizma4geniþlik + prizma4geniþlik / 2, prizma4uzunluk), new Point(75 + prizma4geniþlik, 75 + prizma4uzunluk) };
                            Point[] points3 = { new Point(75 + prizma4geniþlik, 75), new Point(75 + prizma4geniþlik / 2 + prizma4geniþlik, 0), new Point(75 + prizma4geniþlik / 2 + prizma4geniþlik, prizma4uzunluk), new Point(75 + prizma4geniþlik, 75 + prizma4uzunluk) };

                            // Dikdörtgenleri ve prizmanýn yüzeylerini çiziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);


                        }


                    }
                    else
                    {
                        labelSonuç.Text = "Çarpýþmýyorlar"; // çarpýþma yoksa "Hayýr" yazdýr

            
                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikdörtgen oluþturuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizma3geniþlik, prizma3geniþlik);


                            // Prizmanýn yüzeylerini çiziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizma3geniþlik / 2, 0), new Point(75 + prizma3geniþlik + prizma3geniþlik / 2, 0), new Point(75 + prizma3geniþlik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizma3uzunluk), new Point(75 + prizma3geniþlik / 2, prizma3uzunluk), new Point(75 + prizma3geniþlik + prizma3geniþlik / 2, prizma3uzunluk), new Point(75 + prizma3geniþlik, 75 + prizma3uzunluk) };
                            Point[] points3 = { new Point(75 + prizma3geniþlik, 75), new Point(75 + prizma3geniþlik / 2 + prizma3geniþlik, 0), new Point(75 + prizma3geniþlik / 2 + prizma3geniþlik, prizma3uzunluk), new Point(75 + prizma3geniþlik, 75 + prizma3uzunluk) };

                            // Dikdörtgenleri ve prizmanýn yüzeylerini çiziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);


                        }


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikdörtgen oluþturuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizma4geniþlik, prizma4geniþlik);


                            // Prizmanýn yüzeylerini çiziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizma4geniþlik / 2, 0), new Point(75 + prizma4geniþlik + prizma4geniþlik / 2, 0), new Point(75 + prizma4geniþlik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizma4uzunluk), new Point(75 + prizma4geniþlik / 2, prizma4uzunluk), new Point(75 + prizma4geniþlik + prizma4geniþlik / 2, prizma4uzunluk), new Point(75 + prizma4geniþlik, 75 + prizma4uzunluk) };
                            Point[] points3 = { new Point(75 + prizma4geniþlik, 75), new Point(75 + prizma4geniþlik / 2 + prizma4geniþlik, 0), new Point(75 + prizma4geniþlik / 2 + prizma4geniþlik, prizma4uzunluk), new Point(75 + prizma4geniþlik, 75 + prizma4uzunluk) };

                            // Dikdörtgenleri ve prizmanýn yüzeylerini çiziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);


                        }





                    }
                    break;


                case 13:
                    int silindir4merkezx = int.Parse(textBox1.Text);
                    int silindir4merkezy = int.Parse(textBox2.Text);
                    int silindir4merkezz = int.Parse(textBox3.Text);
                    int silindir4yukseklik = int.Parse(textBox7.Text);
                    int silindir4yarýçap = int.Parse(textBox8.Text);
                    int yüzeyen = int.Parse(textBox4.Text);
                    int yüzeyderinlik = int.Parse(textBox5.Text);


                    silindir silindir4 = new silindir
                    {
                        silindirmerkez = new ucboyutlunokta { X = silindir4merkezx, Y = silindir4merkezy, Z = silindir4merkezz },
                        YariCap = silindir4yarýçap,
                        Yukseklik = silindir4yukseklik

                    };

                    yüzey yuzey = new yüzey(yüzeyen, yüzeyderinlik);
                    bool sonuc4 = silindir4.silindiryüzey(yuzey);


                    if (sonuc4)
                    {
                        labelSonuç.Text = "Çarpþýyorlar"; // çarpýþma varsa "Evet" yazdýr

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Point[] points2 = { new Point(75, 75 + yüzeyderinlik), new Point(75 + yüzeyen / 2, yüzeyderinlik), new Point(75 + yüzeyen + yüzeyen / 2, yüzeyderinlik), new Point(75 + yüzeyen, 75 + yüzeyderinlik) };
                            g.DrawPolygon(Pens.Black, points2);

                        }
                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir4merkezx;
                            int y = silindir4merkezy;
                            int r = silindir4yarýçap;
                            int h = silindir4yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol üst
                            Point p3 = new Point(x + r, y + h); // sað üst
                            Point p4 = new Point(x + r, y); // sað alt

                            // taban yüzeyi ile sol yan yüzeyi birleþtir
                            g.DrawLine(pen, p1, p2);
                            // sol yan yüzeyi ile üst yüzeyi birleþtir
                            g.DrawLine(pen, p2, p3);
                            // üst yüzeyi ile sað yan yüzeyi birleþtir
                            g.DrawLine(pen, p3, p4);
                            // sað yan yüzeyi ile taban yüzeyi birleþtir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktasýný hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sað elipsin merkez noktasýný hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey çizgileri çiz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan yüzeyi çiz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }






                    }
                    else
                    {
                        labelSonuç.Text = "Çarpýþmýyorlar"; // çarpýþma yoksa "Hayýr" yazdýr


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Point[] points2 = { new Point(75, 75 + yüzeyderinlik), new Point(75 + yüzeyen / 2, yüzeyderinlik), new Point(75 + yüzeyen + yüzeyen / 2, yüzeyderinlik), new Point(75 + yüzeyen, 75 + yüzeyderinlik) };
                            g.DrawPolygon(Pens.Black, points2);

                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir4merkezx;
                            int y = silindir4merkezy;
                            int r = silindir4yarýçap;
                            int h = silindir4yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol üst
                            Point p3 = new Point(x + r, y + h); // sað üst
                            Point p4 = new Point(x + r, y); // sað alt

                            // taban yüzeyi ile sol yan yüzeyi birleþtir
                            g.DrawLine(pen, p1, p2);
                            // sol yan yüzeyi ile üst yüzeyi birleþtir
                            g.DrawLine(pen, p2, p3);
                            // üst yüzeyi ile sað yan yüzeyi birleþtir
                            g.DrawLine(pen, p3, p4);
                            // sað yan yüzeyi ile taban yüzeyi birleþtir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktasýný hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sað elipsin merkez noktasýný hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey çizgileri çiz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan yüzeyi çiz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }






                    }
                    break;

                case 14:

                    int küre5merkezx = int.Parse(textBox7.Text);
                    int küre5merkezy = int.Parse(textBox8.Text);
                    int küre5merkezz = int.Parse(textBox9.Text);
                    int küre5yarýçap = int.Parse(textBox10.Text);
                    int yüzey1en = int.Parse(textBox4.Text);
                    int yüzey1derinlik = int.Parse(textBox5.Text);

                    yüzey yuzey1 = new yüzey(yüzey1en, yüzey1derinlik);

                    kure küre5 = new kure
                    {
                        merkezkure = new ucboyutlunokta { X = küre5merkezx, Y = küre5merkezy, Z = küre5merkezz },
                        YariCap = küre5yarýçap

                    };


                    if (yuzey1.yüzeyküre(küre5))


                    {
                        labelSonuç.Text = "Çarpþýyorlar"; // çarpýþma varsa "Evet" yazdýr

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Point[] points2 = { new Point(75, 75 + yüzey1derinlik), new Point(75 + yüzey1en / 2, yüzey1derinlik), new Point(75 + yüzey1en + yüzey1en / 2, yüzey1derinlik), new Point(75 + yüzey1en, 75 + yüzey1derinlik) };
                            g.DrawPolygon(Pens.Black, points2);

                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin çapý ve merkez koordinatlarý
                            int diameter = küre5yarýçap;
                            int centerX = küre5merkezx - küre5yarýçap + pictureBox1.Width / 2;
                            int centerY = küre5merkezy - küre5yarýçap + pictureBox1.Height / 2;

                            // Daireyi çizdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlarý ve merkez koordinatlarý
                            int ellipseWidth = küre5yarýçap;
                            int ellipseHeight = 20;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi çizdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullanýlan nesneleri temizle
                            pen.Dispose();
                        }




                    }
                    else
                    {
                        labelSonuç.Text = "Çarpýþmýyorlar"; // çarpýþma yoksa "Hayýr" yazdýr



                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Point[] points2 = { new Point(75, 75 + yüzey1derinlik), new Point(75 + yüzey1en / 2, yüzey1derinlik), new Point(75 + yüzey1en + yüzey1en / 2, yüzey1derinlik), new Point(75 + yüzey1en, 75 + yüzey1derinlik) };
                            g.DrawPolygon(Pens.Black, points2);

                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin çapý ve merkez koordinatlarý
                            int diameter = küre5yarýçap;
                            int centerX = küre5merkezx - küre5yarýçap + pictureBox1.Width / 2;
                            int centerY = küre5merkezy - küre5yarýçap + pictureBox1.Height / 2;

                            // Daireyi çizdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlarý ve merkez koordinatlarý
                            int ellipseWidth = küre5yarýçap;
                            int ellipseHeight = 20;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi çizdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullanýlan nesneleri temizle
                            pen.Dispose();
                        }
                    }

                    break;

                case 15:
                    int prizma5merkezx = int.Parse(textBox1.Text);
                    int prizma5merkezy = int.Parse(textBox2.Text);
                    int prizma5merkezz = int.Parse(textBox3.Text);
                    int prizma5yukseklik = int.Parse(textBox7.Text);
                    int prizma5geniþlik = int.Parse(textBox8.Text);
                    int prizma5uzunluk = int.Parse(textBox9.Text);
                    int yüzey2en = int.Parse(textBox4.Text);
                    int yüzey2derinlik = int.Parse(textBox5.Text);

                    dikdörtgenprizmasý prizma5 = new dikdörtgenprizmasý
                    {
                        MerkezPrizma = new ucboyutlunokta { X = prizma5merkezx, Y = prizma5merkezy, Z = prizma5merkezz },
                        Yukseklik = prizma5yukseklik,
                        Uzunluk = prizma5uzunluk,
                        Genislik = prizma5geniþlik
                    };


                    yüzey yuzey2 = new yüzey(yüzey2en, yüzey2derinlik);



                    if (yuzey2.CarpisiyorMu(prizma5))
                    {
                        labelSonuç.Text = "Çarpþýyorlar"; // çarpýþma varsa "Evet" yazdýr


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Point[] points2 = { new Point(75, 75 + yüzey2derinlik), new Point(75 + yüzey2en / 2, yüzey2derinlik), new Point(75 + yüzey2en + yüzey2en / 2, yüzey2derinlik), new Point(75 + yüzey2en, 75 + yüzey2derinlik) };
                            g.DrawPolygon(Pens.Black, points2);

                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikdörtgen oluþturuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizma5geniþlik, prizma5geniþlik);


                            // Prizmanýn yüzeylerini çiziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizma5geniþlik / 2, 0), new Point(75 + prizma5geniþlik + prizma5geniþlik / 2, 0), new Point(75 + prizma5geniþlik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizma5uzunluk), new Point(75 + prizma5geniþlik / 2, prizma5uzunluk), new Point(75 + prizma5geniþlik + prizma5geniþlik / 2, prizma5uzunluk), new Point(75 + prizma5geniþlik, 75 + prizma5uzunluk) };
                            Point[] points3 = { new Point(75 + prizma5geniþlik, 75), new Point(75 + prizma5geniþlik / 2 + prizma5geniþlik, 0), new Point(75 + prizma5geniþlik / 2 + prizma5geniþlik, prizma5uzunluk), new Point(75 + prizma5geniþlik, 75 + prizma5uzunluk) };

                            // Dikdörtgenleri ve prizmanýn yüzeylerini çiziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);


                        }


                    }
                    else
                    {
                        labelSonuç.Text = "Çarpýþmýyorlar"; // çarpýþma yoksa "Hayýr" yazdýr




                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Point[] points2 = { new Point(75, 75 + yüzey2derinlik), new Point(75 + yüzey2en / 2, yüzey2derinlik), new Point(75 + yüzey2en + yüzey2en / 2, yüzey2derinlik), new Point(75 + yüzey2en, 75 + yüzey2derinlik) };
                            g.DrawPolygon(Pens.Black, points2);

                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikdörtgen oluþturuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizma5geniþlik, prizma5geniþlik);


                            // Prizmanýn yüzeylerini çiziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizma5geniþlik / 2, 0), new Point(75 + prizma5geniþlik + prizma5geniþlik / 2, 0), new Point(75 + prizma5geniþlik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizma5uzunluk), new Point(75 + prizma5geniþlik / 2, prizma5uzunluk), new Point(75 + prizma5geniþlik + prizma5geniþlik / 2, prizma5uzunluk), new Point(75 + prizma5geniþlik, 75 + prizma5uzunluk) };
                            Point[] points3 = { new Point(75 + prizma5geniþlik, 75), new Point(75 + prizma5geniþlik / 2 + prizma5geniþlik, 0), new Point(75 + prizma5geniþlik / 2 + prizma5geniþlik, prizma5uzunluk), new Point(75 + prizma5geniþlik, 75 + prizma5uzunluk) };

                            // Dikdörtgenleri ve prizmanýn yüzeylerini çiziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);


                        }

                    }

                    break;



            }

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {

            textBox1.Visible = false; textBox2.Visible = false; textBox3.Visible = false; textBox4.Visible = false;
            textBox5.Visible = false; textBox6.Visible = false; textBox7.Visible = false; textBox8.Visible = false;
            textBox9.Visible = false; textBox10.Visible = false; textBox11.Visible = false; textBox12.Visible = false;



            label1.Visible = false; label2.Visible = false; label3.Visible = false; label4.Visible = false;
            label5.Visible = false; label6.Visible = false; label7.Visible = false; label8.Visible = false;
            label9.Visible = false; label10.Visible = false; label11.Visible = false; label12.Visible = false;
            label13.Visible = false; label14.Visible = false; label15.Visible = false; label16.Visible = false;
            label17.Visible = false; label18.Visible = false; label19.Visible = false; label20.Visible = false;
            label21.Visible = false; label22.Visible = false; label23.Visible = false; label24.Visible = false;
            label25.Visible = false; label26.Visible = false; label27.Visible = false; label32.Visible = false;
            label28.Visible = false; label29.Visible = false; label30.Visible = false; label31.Visible = false;
            label33.Visible = false; label34.Visible = false; label35.Visible = false; label36.Visible = false;
            label37.Visible = false; label38.Visible = false; label39.Visible = false; label40.Visible = false; label41.Visible = false;
            label42.Visible = false; label43.Visible = false; label44.Visible = false; label45.Visible = false;
            label46.Visible = false; label47.Visible = false; label48.Visible = false; label49.Visible = false; label50.Visible = false;
            labelSonuç.Visible = false;


            pictureBox1.Invalidate(); // PictureBox içindeki çizimi siler

        }
    }
}



    
