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
            // Textboxlar� form'a ekle ve visible �zelli�ini false olarak ayarla

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

        private void comboBoxSe�im_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSe�im.SelectedIndex == 0) // E�er "Nokta, Dikd�rtgen
            {

                textBox3.Visible = true; textBox4.Visible = true; textBox5.Visible = true; label3.Visible = true;
                textBox1.Visible = true; textBox2.Visible = true; textBox6.Visible = true; label1.Visible = true;
                label4.Visible = true; label2.Visible = true; label5.Visible = true; label6.Visible = true; labelSonu�.Visible = true;


            }

            if (comboBoxSe�im.SelectedIndex == 1) //nokta �ember
            {
                label7.Visible = true; label8.Visible = true; label9.Visible = true; label5.Visible = true;
                label6.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox4.Visible = true;
                textBox5.Visible = true; textBox6.Visible = true; labelSonu�.Visible = true;


            }

            if (comboBoxSe�im.SelectedIndex == 2) //dikd�rtgen dikd�rtgen
            {
                label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox4.Visible = true;

                label10.Visible = true; label11.Visible = true; label12.Visible = true; label13.Visible = true;
                textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true; textBox10.Visible = true; labelSonu�.Visible = true;



            }

            if (comboBoxSe�im.SelectedIndex == 3) // dikd�rtgen �ember
            {
                label7.Visible = true; label8.Visible = true; label9.Visible = true; label10.Visible = true;
                label11.Visible = true; label12.Visible = true; label13.Visible = true;
                textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true; textBox10.Visible = true;
                textBox2.Visible = true; textBox3.Visible = true; textBox4.Visible = true; labelSonu�.Visible = true;

            }

            if (comboBoxSe�im.SelectedIndex == 4) // �ember �ember
            {
                label7.Visible = true; label8.Visible = true; label9.Visible = true; label12.Visible = true;
                label13.Visible = true; label14.Visible = true; textBox2.Visible = true; textBox3.Visible = true;
                textBox4.Visible = true; textBox8.Visible = true; textBox9.Visible = true; textBox10.Visible = true; labelSonu�.Visible = true;
            }

            if (comboBoxSe�im.SelectedIndex == 5) //nokta k�re
            {
                label5.Visible = true; label6.Visible = true; textBox4.Visible = true; textBox5.Visible = true;
                label17.Visible = true; textBox6.Visible = true; label18.Visible = true; label19.Visible = true;
                label20.Visible = true; label21.Visible = true; textBox7.Visible = true;
                textBox8.Visible = true; textBox9.Visible = true; textBox10.Visible = true; labelSonu�.Visible = true;

            }

            if (comboBoxSe�im.SelectedIndex == 6) // nokta prizma
            {
                label5.Visible = true; label6.Visible = true; textBox6.Visible = true;
                textBox5.Visible = true; textBox4.Visible = true; label17.Visible = true; label22.Visible = true;
                label23.Visible = true; label24.Visible = true; label25.Visible = true; label26.Visible = true;
                label27.Visible = true; textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true;
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; labelSonu�.Visible = true;



            }


            if (comboBoxSe�im.SelectedIndex == 7) //silindir nokta
            {

                label5.Visible = true; label6.Visible = true; textBox6.Visible = true; textBox5.Visible = true; textBox4.Visible = true;
                label17.Visible = true; label28.Visible = true; label29.Visible = true; labelSonu�.Visible = true;
                label30.Visible = true; label31.Visible = true; label32.Visible = true;
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true;
                textBox7.Visible = true; textBox8.Visible = true;


            }

            if (comboBoxSe�im.SelectedIndex == 8) //silindir silindir

            {
                label28.Visible = true; label29.Visible = true; label30.Visible = true; textBox8.Visible = true; labelSonu�.Visible = true;
                label31.Visible = true; label32.Visible = true; textBox2.Visible = true; label37.Visible = true;
                label33.Visible = true; label34.Visible = true; label36.Visible = true; label35.Visible = true;
                textBox1.Visible = true; textBox3.Visible = true; textBox7.Visible = true; textBox9.Visible = true;
                textBox4.Visible = true; textBox5.Visible = true; textBox6.Visible = true; textBox10.Visible = true;
            }


            if (comboBoxSe�im.SelectedIndex == 9) //silindir k�re
            {
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox7.Visible = true; textBox8.Visible = true;
                label28.Visible = true; label29.Visible = true; label30.Visible = true; label31.Visible = true; label32.Visible = true;
                label20.Visible = true; label21.Visible = true; textBox9.Visible = true; textBox10.Visible = true; labelSonu�.Visible = true;
                label38.Visible = true; label39.Visible = true; textBox4.Visible = true; textBox5.Visible = true;


            }

            if (comboBoxSe�im.SelectedIndex == 10)//k�re k�re
            {
                textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true; textBox10.Visible = true; labelSonu�.Visible = true;
                label18.Visible = true; label19.Visible = true; label20.Visible = true; label21.Visible = true;
                textBox3.Visible = true; textBox4.Visible = true; textBox5.Visible = true; textBox6.Visible = true;
                label38.Visible = true; label39.Visible = true; label40.Visible = true; label41.Visible = true;
            }

            if (comboBoxSe�im.SelectedIndex == 11)//dikd�rtgen prizmas� k�re
            {
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; labelSonu�.Visible = true;
                textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true;
                label22.Visible = true; label23.Visible = true; label24.Visible = true; label25.Visible = true;
                label26.Visible = true; label27.Visible = true;
                textBox4.Visible = true; textBox5.Visible = true; textBox6.Visible = true; textBox10.Visible = true;
                label38.Visible = true; label39.Visible = true; label42.Visible = true; label41.Visible = true;

            }


            if (comboBoxSe�im.SelectedIndex == 12) //prizma prizma �arp��mas�
            {
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; labelSonu�.Visible = true;
                textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true;
                label22.Visible = true; label23.Visible = true; label24.Visible = true; label25.Visible = true;
                label26.Visible = true; label27.Visible = true;
                textBox4.Visible = true; textBox5.Visible = true; textBox6.Visible = true;
                textBox10.Visible = true; textBox11.Visible = true; textBox12.Visible = true;
                label43.Visible = true; label44.Visible = true; label45.Visible = true; label46.Visible = true;
                label47.Visible = true; label48.Visible = true;

            }
            if (comboBoxSe�im.SelectedIndex == 13) //silindir y�zey
            {
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox7.Visible = true; textBox8.Visible = true;
                label28.Visible = true; label29.Visible = true; label30.Visible = true; label31.Visible = true; label32.Visible = true;
                label49.Visible = true; label50.Visible = true; textBox4.Visible = true; textBox5.Visible = true; labelSonu�.Visible = true;

            }


            if (comboBoxSe�im.SelectedIndex == 14)//k�re y�zey
            {
                textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true; textBox10.Visible = true; labelSonu�.Visible = true;
                label49.Visible = true; label50.Visible = true; textBox4.Visible = true; textBox5.Visible = true;
                label18.Visible = true; label19.Visible = true; label20.Visible = true; label21.Visible = true;
            }

            if (comboBoxSe�im.SelectedIndex == 15)  //prizma y�zey
            {
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; labelSonu�.Visible = true;
                textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true;
                label22.Visible = true; label23.Visible = true; label24.Visible = true; label25.Visible = true;
                label26.Visible = true; label27.Visible = true; label49.Visible = true; label50.Visible = true;
                textBox4.Visible = true; textBox5.Visible = true;


            }

        }

        private void buttonKontrol_Click(object sender, EventArgs e)
        {
            switch (comboBoxSe�im.SelectedIndex)
            {
                case 0:

                    // Textbox'lardaki de�erleri al
                    int x1 = int.Parse(textBox1.Text);
                    int y1 = int.Parse(textBox2.Text);
                    int x2 = int.Parse(textBox3.Text);
                    int y2 = int.Parse(textBox4.Text);
                    int x3 = int.Parse(textBox5.Text);
                    int y3 = int.Parse(textBox6.Text);

                    dikd�rtgen d1 = new dikd�rtgen
                    {
                        SolUstKose = new Nokta { X = x1, Y = y1 },
                        SagAltKose = new Nokta { X = x2, Y = y2 }
                    };

                    Nokta nokta = new Nokta { X = x3, Y = y3 };

                    bool carpismaVarMi = d1.dikd�rtgennokta�arp��ma(nokta);

                    if (carpismaVarMi)
                    {
                        labelSonu�.Text = "�arp��yorlar"; // �arp��ma varsa "Evet" yazd�r
                        
                        
                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'�n boyutunu belirle

                            // Noktay� �izmek i�in bir f�r�a olu�turun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = x3 + pictureBox1.Width / 2;
                            int pointY = -y3 + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                            // dikd�rtgenin i�ini �izmek i�in bir kalem olu�turun
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
                        labelSonu�.Text = "�arp��m�yorlar"; // �arp��ma yoksa "Hay�r" yazd�r
                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'�n boyutunu belirle

                            // Noktay� �izmek i�in bir f�r�a olu�turun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = x3 + pictureBox1.Width / 2;
                            int pointY = -y3 + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                            // dikd�rtgenin i�ini �izmek i�in bir kalem olu�turun
                            Pen pen = new Pen(Color.Black);


                            // dikd�rtgenin i�ini �izmek i�in bir kalem olu�turun
                            int width = Math.Abs(x2 - x1);
                            int height = Math.Abs(y2 - y1);
                            int topLeftX = x1 + pictureBox1.Width / 2;
                            int topLeftY = y1 + pictureBox1.Height / 2;
                            g.DrawRectangle(pen, topLeftX, topLeftY, width, height);
                            pen.Dispose();

                            // Kullan�lan nesneleri temizleyin
                            pen.Dispose();



                        }


                    }

                    break;


                case 1:

                    int nokta1x = int.Parse(textBox5.Text);
                    int nokta1y = int.Parse(textBox6.Text);
                    int �ember1x = int.Parse(textBox2.Text);
                    int �ember1y = int.Parse(textBox3.Text);
                    int �emberyar��ap1 = int.Parse(textBox4.Text);

                    Nokta nokta1 = new Nokta { X = nokta1x, Y = nokta1y };
                    Cember cember = new Cember { Merkez = new Nokta { X = �ember1x, Y = �ember1y }, YariCap = �emberyar��ap1 };

                    bool Carp = cember.�arp��t�larm�(nokta1);

                    if (Carp)
                    {
                        labelSonu�.Text = "�arp��yorlar"; // �arp��ma varsa "Evet" yazd�r

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'�n boyutunu belirle

                            // Noktay� �izmek i�in bir f�r�a olu�turun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = nokta1x + pictureBox1.Width / 2;
                            int pointY = -nokta1y + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                        }
                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // �emberin i�ini �izmek i�in bir kalem olu�turun
                            Pen pen = new Pen(Color.Black);

                            // �emberi �izin
                            int diameter = �emberyar��ap1 * 2;
                            int centerX = �ember1x - �emberyar��ap1 + pictureBox1.Width / 2;
                            int centerY = �ember1y - �emberyar��ap1 + pictureBox1.Height / 2;
                            g.DrawEllipse(pen, centerX, centerY, diameter, diameter);

                            // Kullan�lan nesneleri temizleyin
                            pen.Dispose();
                        }


                    }
                    else
                    {
                        labelSonu�.Text = "�arp��m�yorlar"; // �arp��ma yoksa "Hay�r" yazd�r


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'�n boyutunu belirle

                            // Noktay� �izmek i�in bir f�r�a olu�turun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = nokta1x + pictureBox1.Width / 2;
                            int pointY = -nokta1y + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                            // Kullan�lan nesneleri temizleyin
                            brush.Dispose();
                        }
                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // �emberin i�ini �izmek i�in bir kalem olu�turun
                            Pen pen = new Pen(Color.Black);

                            // �emberi �izin
                            int diameter = �emberyar��ap1 * 2;
                            int centerX = �ember1x - �emberyar��ap1 + pictureBox1.Width / 2;
                            int centerY = �ember1y - �emberyar��ap1 + pictureBox1.Height / 2;
                            g.DrawEllipse(pen, centerX, centerY, diameter, diameter);

                            // Kullan�lan nesneleri temizleyin
                            pen.Dispose();
                        }
                    }

                    break;

                case 2:
                    int d2solustx = int.Parse(textBox1.Text);
                    int d2solusty = int.Parse(textBox2.Text);
                    int d2sa�altx = int.Parse(textBox3.Text);
                    int d2sa�alty = int.Parse(textBox4.Text);
                    int d3solustx = int.Parse(textBox7.Text);
                    int d3solusty = int.Parse(textBox8.Text);
                    int d3sa�altx = int.Parse(textBox9.Text);
                    int d3sa�alty = int.Parse(textBox10.Text);

                    dikd�rtgen d2 = new dikd�rtgen
                    {
                        SolUstKose = new Nokta { X = d2solustx, Y = d2solusty },
                        SagAltKose = new Nokta { X = d2sa�altx, Y = d2sa�alty }
                    };


                    dikd�rtgen d3 = new dikd�rtgen
                    {
                        SolUstKose = new Nokta { X = d3solustx, Y = d3solusty },
                        SagAltKose = new Nokta { X = d3sa�altx, Y = d3sa�alty }
                    };

                    if (d2.dortgenlercarp��t�m�(d3))
                    {
                        pictureBox1.Size = new Size(284, 459);

                        labelSonu�.Text = "�arp��yorlar"; // �arp��ma varsa "Evet" yazd�r
                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Pen pen1 = new Pen(Color.Red, 2);
                            Pen pen2 = new Pen(Color.Blue, 2);

                            // dikd�rtgen 2'yi �izdir
                            int d2Width = Math.Abs(d2sa�altx - d2solustx);
                            int d2Height = Math.Abs(d2sa�alty - d2solusty);
                            int d2TopLeftX = d2solustx + pictureBox1.Width / 2;
                            int d2TopLeftY = d2solusty + pictureBox1.Height / 2;
                            g.DrawRectangle(pen1, d2TopLeftX, d2TopLeftY, d2Width, d2Height);

                            int d3Width = Math.Abs(d3sa�altx - d3solustx);
                            int d3Height = Math.Abs(d3sa�alty - d3solusty);
                            int d3TopLeftX = d3solustx + pictureBox1.Width / 2;
                            int d3TopLeftY = d3solusty + pictureBox1.Height / 2;
                            g.DrawRectangle(pen2, d3TopLeftX, d3TopLeftY, d3Width, d3Height);

                            pen1.Dispose();
                            pen2.Dispose();


                        }
                    }
                    else
                    {
                        labelSonu�.Text = "�arp��m�yorlar"; // �arp��ma yoksa "Hay�r" yazd�r
                        pictureBox1.Size = new Size(284, 459);

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Pen pen1 = new Pen(Color.Red, 2);
                            Pen pen2 = new Pen(Color.Blue, 2);

                            // dikd�rtgen 2'yi �izdir
                            int d2Width = Math.Abs(d2sa�altx - d2solustx);
                            int d2Height = Math.Abs(d2sa�alty - d2solusty);
                            int d2TopLeftX = d2solustx + pictureBox1.Width / 2;
                            int d2TopLeftY = d2solusty + pictureBox1.Height / 2;
                            g.DrawRectangle(pen1, d2TopLeftX, d2TopLeftY, d2Width, d2Height);

                            int d3Width = Math.Abs(d3sa�altx - d3solustx);
                            int d3Height = Math.Abs(d3sa�alty - d3solusty);
                            int d3TopLeftX = d3solustx + pictureBox1.Width / 2;
                            int d3TopLeftY = d3solusty + pictureBox1.Height / 2;
                            g.DrawRectangle(pen2, d3TopLeftX, d3TopLeftY, d3Width, d3Height);

                            pen1.Dispose();
                            pen2.Dispose();



                        }

                        }


                        break;

                case 3:
                    int �ember2x = int.Parse(textBox2.Text);
                    int �ember2y = int.Parse(textBox3.Text);
                    int �emberyar��ap2 = int.Parse(textBox4.Text);
                    int d4solustx = int.Parse(textBox7.Text);
                    int d4solusty = int.Parse(textBox8.Text);
                    int d4sa�altx = int.Parse(textBox9.Text);
                    int d4sa�alty = int.Parse(textBox10.Text);

                    dikd�rtgen d4 = new dikd�rtgen
                    {
                        SolUstKose = new Nokta { X = d4solustx, Y = d4solusty },
                        SagAltKose = new Nokta { X = d4sa�altx, Y = d4sa�alty }
                    };

                    Cember cember2 = new Cember { Merkez = new Nokta { X = �ember2x, Y = �ember2y }, YariCap = �emberyar��ap2 };



                    if (d4.cemberd�rtgencarp��t�m�(cember2))
                    {
                        labelSonu�.Text = "�arp��yorlar"; // �arp��ma varsa "Evet" yazd�r

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // �emberin i�ini �izmek i�in bir kalem olu�turun
                            Pen pen = new Pen(Color.Black);
                            pictureBox1.Size = new Size(284, 459);

                            // �emberi �izin
                            int diameter = �emberyar��ap2 * 2;
                            int centerX = �ember2x - �emberyar��ap2 + pictureBox1.Width / 2;
                            int centerY = �ember2y - �emberyar��ap2 + pictureBox1.Height / 2;
                            g.DrawEllipse(pen, centerX, centerY, diameter, diameter);

                            // Kullan�lan nesneleri temizleyin
                            pen.Dispose();
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Pen pen1 = new Pen(Color.Red, 2);
                           

                            // dikd�rtgen 2'yi �izdir
                            int d2Width = Math.Abs(d4sa�altx - d4solustx);
                            int d2Height = Math.Abs(d4sa�alty - d4solusty);
                            int d2TopLeftX = d4solustx + pictureBox1.Width / 2;
                            int d2TopLeftY = d4solusty + pictureBox1.Height / 2;
                            g.DrawRectangle(pen1, d2TopLeftX, d2TopLeftY, d2Width, d2Height);
                            pen1.Dispose();

                        }
                    }
                    else
                    {
                        labelSonu�.Text = "�arp��m�yorlar"; // �arp��ma yoksa "Hay�r" yazd�r

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // �emberin i�ini �izmek i�in bir kalem olu�turun
                            Pen pen = new Pen(Color.Black);
                            pictureBox1.Size = new Size(284, 459);

                            // �emberi �izin
                            int diameter = �emberyar��ap2 * 2;
                            int centerX = �ember2x - �emberyar��ap2 + pictureBox1.Width / 2;
                            int centerY = �ember2y - �emberyar��ap2 + pictureBox1.Height / 2;
                            g.DrawEllipse(pen, centerX, centerY, diameter, diameter);

                            // Kullan�lan nesneleri temizleyin
                            pen.Dispose();
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Pen pen1 = new Pen(Color.Red, 2);
                            pictureBox1.Size = new Size(284, 459);


                            // dikd�rtgen 2'yi �izdir
                            int d2Width = Math.Abs(d4sa�altx - d4solustx);
                            int d2Height = Math.Abs(d4sa�alty - d4solusty);
                            int d2TopLeftX = d4solustx + pictureBox1.Width / 2;
                            int d2TopLeftY = d4solusty + pictureBox1.Height / 2;
                            g.DrawRectangle(pen1, d2TopLeftX, d2TopLeftY, d2Width, d2Height);
                            pen1.Dispose();

                        }





                    }

                    break;


                case 4:
                    int �ember3x = int.Parse(textBox2.Text);
                    int �ember3y = int.Parse(textBox3.Text);
                    int �emberyar��ap3 = int.Parse(textBox4.Text);
                    int �ember4x = int.Parse(textBox8.Text);
                    int �ember4y = int.Parse(textBox9.Text);
                    int �emberyar��ap4 = int.Parse(textBox10.Text);


                    Cember cember3 = new Cember { Merkez = new Nokta { X = �ember3x, Y = �ember3y }, YariCap = �emberyar��ap3 };
                    Cember cember4 = new Cember { Merkez = new Nokta { X = �ember4x, Y = �ember4y }, YariCap = �emberyar��ap4 };

                    bool a = Cember.CemberCemberCarpisiyorMu(cember3, cember4);

                    if (a)
                    {
                        labelSonu�.Text = "�arp��yorlar"; // �arp��ma varsa "Evet" yazd�r

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // �emberin i�ini �izmek i�in bir kalem olu�turun
                            Pen pen = new Pen(Color.Black);
                            pictureBox1.Size = new Size(284, 459);

                            // �emberi �izin
                            int diameter = �emberyar��ap3 * 2;
                            int centerX = �ember3x - �emberyar��ap3 + pictureBox1.Width / 2;
                            int centerY = �ember3y - �emberyar��ap3 + pictureBox1.Height / 2;
                            g.DrawEllipse(pen, centerX, centerY, diameter, diameter);

                            // Kullan�lan nesneleri temizleyin
                            pen.Dispose();
                        }

                        using(Graphics g = pictureBox1.CreateGraphics())
                        {
                            // �emberin i�ini �izmek i�in bir kalem olu�turun
                            Pen pen = new Pen(Color.Black);
                            pictureBox1.Size = new Size(284, 459);

                            // �emberi �izin
                            int diameter = �emberyar��ap4 * 2;
                            int centerX = �ember4x - �emberyar��ap4 + pictureBox1.Width / 2;
                            int centerY = �ember4y - �emberyar��ap4 + pictureBox1.Height / 2;
                            g.DrawEllipse(pen, centerX, centerY, diameter, diameter);

                            // Kullan�lan nesneleri temizleyin
                            pen.Dispose();
                        }


                    }
                    else
                    {
                        labelSonu�.Text = "�arp��m�yorlar"; // �arp��ma yoksa "Hay�r" yazd�r
                    }

                    break;

                case 5:

                    int nokta3x = int.Parse(textBox5.Text);
                    int nokta3y = int.Parse(textBox6.Text);
                    int nokta3z = int.Parse(textBox4.Text);
                    int kurex = int.Parse(textBox7.Text);
                    int kurey = int.Parse(textBox8.Text);
                    int kurez = int.Parse(textBox9.Text);
                    int kureyar��ap = int.Parse(textBox10.Text);

                    ucboyutlunokta nokta3 = new ucboyutlunokta { X = nokta3x, Y = nokta3y, Z = nokta3z };
                    kure kure1 = new kure { merkezkure = new ucboyutlunokta { X = kurex, Y = kurey, Z = kurez }, YariCap = kureyar��ap };

                    bool b = kure1.kurenokta(nokta3);

                    if (b)
                    {
                        labelSonu�.Text = "�arp��yorlar"; // �arp��ma varsa "Evet" yazd�r

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin �ap� ve merkez koordinatlar�
                            int diameter = kureyar��ap;
                            int centerX = kurex - kureyar��ap + pictureBox1.Width / 2;
                            int centerY =kurey-kureyar��ap+ pictureBox1.Height / 2;

                            // Daireyi �izdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlar� ve merkez koordinatlar�
                            int ellipseWidth = kureyar��ap;
                            int ellipseHeight = 35;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi �izdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullan�lan nesneleri temizle
                            pen.Dispose();
                        }



                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'�n boyutunu belirle

                            // Noktay� �izmek i�in bir f�r�a olu�turun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = nokta3x + pictureBox1.Width / 2;
                            int pointY = -nokta3y + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                            // Kullan�lan nesneleri temizleyin
                            brush.Dispose();
                        }




                    }
                    else
                    {
                        labelSonu�.Text = "�arp��m�yorlar"; // �arp��ma yoksa "Hay�r" yazd�r

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin �ap� ve merkez koordinatlar�
                            int diameter = kureyar��ap;
                            int centerX = kurex - kureyar��ap + pictureBox1.Width / 2;
                            int centerY = kurey - kureyar��ap + pictureBox1.Height / 2;

                            // Daireyi �izdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlar� ve merkez koordinatlar�
                            int ellipseWidth = kureyar��ap;
                            int ellipseHeight = 35;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi �izdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullan�lan nesneleri temizle
                            pen.Dispose();
                        }



                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'�n boyutunu belirle

                            // Noktay� �izmek i�in bir f�r�a olu�turun
                            Brush brush = new SolidBrush(Color.Red);

                            Brush brush2 = new SolidBrush(Color.Red);
                            int pointX = nokta3x + pictureBox1.Width / 2;
                            int pointY = -nokta3y + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 10, 10);
                            brush.Dispose();

                            // Kullan�lan nesneleri temizleyin
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
                    int prizmageni�lik = int.Parse(textBox8.Text);
                    int prizmauzunluk = int.Parse(textBox9.Text);

                    ucboyutlunokta nokta4 = new ucboyutlunokta { X = nokta4x, Y = nokta4y, Z = nokta4z };

                    dikd�rtgenprizmas� prizma = new dikd�rtgenprizmas�
                    {
                        MerkezPrizma = new ucboyutlunokta { X = prizmamerkezx, Y = prizmamerkezy, Z = prizmamerkezz },
                        Yukseklik = prizmayukseklik,
                        Uzunluk = prizmauzunluk,
                        Genislik = prizmageni�lik
                    };

                    bool c = prizma.prizmanokta�arp��ma(nokta4);


                    if (c)
                    {
                        labelSonu�.Text = "�arp��yorlar"; // �arp��ma varsa "Evet" yazd�r


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikd�rtgen olu�turuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizmageni�lik, prizmageni�lik);


                            // Prizman�n y�zeylerini �iziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizmageni�lik / 2, 0), new Point(75 + prizmageni�lik + prizmageni�lik / 2, 0), new Point(75 + prizmageni�lik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizmauzunluk), new Point(75 + prizmageni�lik / 2, prizmauzunluk), new Point(75 + prizmageni�lik + prizmageni�lik / 2, prizmauzunluk), new Point(75 + prizmageni�lik, 75 + prizmauzunluk) };
                            Point[] points3 = { new Point(75 + prizmageni�lik, 75), new Point(75 + prizmageni�lik / 2 + prizmageni�lik, 0), new Point(75 + prizmageni�lik / 2 + prizmageni�lik, prizmauzunluk), new Point(75 + prizmageni�lik, 75 + prizmauzunluk) };
                            
                            // Dikd�rtgenleri ve prizman�n y�zeylerini �iziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);

                           
                           
                        }



                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'�n boyutunu belirle

                            // Noktay� �izmek i�in bir f�r�a olu�turun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = nokta4x + pictureBox1.Width / 2;
                            int pointY = -nokta4y + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                            // Kullan�lan nesneleri temizleyin
                            brush.Dispose();
                        }


                    }
                    else
                    {
                        labelSonu�.Text = "�arp��m�yorlar"; // �arp��ma yoksa "Hay�r" yazd�r

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikd�rtgen olu�turuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizmageni�lik, prizmageni�lik);


                            // Prizman�n y�zeylerini �iziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizmageni�lik / 2, 0), new Point(75 + prizmageni�lik + prizmageni�lik / 2, 0), new Point(75 + prizmageni�lik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizmauzunluk), new Point(75 + prizmageni�lik / 2, prizmauzunluk), new Point(75 + prizmageni�lik + prizmageni�lik / 2, prizmauzunluk), new Point(75 + prizmageni�lik, 75 + prizmauzunluk) };
                            Point[] points3 = { new Point(75 + prizmageni�lik, 75), new Point(75 + prizmageni�lik / 2 + prizmageni�lik, 0), new Point(75 + prizmageni�lik / 2 + prizmageni�lik, prizmauzunluk), new Point(75 + prizmageni�lik, 75 + prizmauzunluk) };

                            // Dikd�rtgenleri ve prizman�n y�zeylerini �iziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);


                        }



                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'�n boyutunu belirle

                            // Noktay� �izmek i�in bir f�r�a olu�turun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = nokta4x + pictureBox1.Width / 2;
                            int pointY = -nokta4y + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                            // Kullan�lan nesneleri temizleyin
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
                    int silindiryar��ap = int.Parse(textBox8.Text);

                    ucboyutlunokta nokta5 = new ucboyutlunokta { X = nokta5x, Y = nokta5y, Z = nokta5z };

                    silindir silindir = new silindir
                    {
                        silindirmerkez = new ucboyutlunokta { X = silindirmerkezx, Y = silindirmerkezy, Z = silindirmerkezz },
                        YariCap = silindiryar��ap,
                        Yukseklik = silindiryukseklik

                    };

                    if (silindir.silindirnokta(nokta5))
                    {
                        labelSonu�.Text = "�arp��yorlar"; // �arp��ma varsa "Evet" yazd�r

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindirmerkezx;
                            int y = silindirmerkezy;
                            int r = silindiryar��ap;
                            int h = silindiryukseklik;

                            Pen pen = new Pen(Color.Black, 2);
                        

                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol �st
                            Point p3 = new Point(x + r, y + h); // sa� �st
                            Point p4 = new Point(x + r, y); // sa� alt

                            // taban y�zeyi ile sol yan y�zeyi birle�tir
                            g.DrawLine(pen, p1, p2);
                            // sol yan y�zeyi ile �st y�zeyi birle�tir
                            g.DrawLine(pen, p2, p3);
                            // �st y�zeyi ile sa� yan y�zeyi birle�tir
                            g.DrawLine(pen, p3, p4);
                            // sa� yan y�zeyi ile taban y�zeyi birle�tir
                            g.DrawLine(pen, p4, p1);
                        
                            // Sol elipsin merkez noktas�n� hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sa� elipsin merkez noktas�n� hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey �izgileri �iz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan y�zeyi �iz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'�n boyutunu belirle

                            // Noktay� �izmek i�in bir f�r�a olu�turun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = nokta5x + pictureBox1.Width / 2;
                            int pointY = -nokta5y + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                            // Kullan�lan nesneleri temizleyin
                            brush.Dispose();
                        }



                    }


                    else
                    {
                        labelSonu�.Text = "�arp��m�yorlar"; // �arp��ma yoksa "Hay�r" yazd�r

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindirmerkezx;
                            int y = silindirmerkezy;
                            int r = silindiryar��ap;
                            int h = silindiryukseklik;

                            Pen pen = new Pen(Color.Black, 2);
                           

                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol �st
                            Point p3 = new Point(x + r, y + h); // sa� �st
                            Point p4 = new Point(x + r, y); // sa� alt

                            // taban y�zeyi ile sol yan y�zeyi birle�tir
                            g.DrawLine(pen, p1, p2);
                            // sol yan y�zeyi ile �st y�zeyi birle�tir
                            g.DrawLine(pen, p2, p3);
                            // �st y�zeyi ile sa� yan y�zeyi birle�tir
                            g.DrawLine(pen, p3, p4);
                            // sa� yan y�zeyi ile taban y�zeyi birle�tir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktas�n� hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sa� elipsin merkez noktas�n� hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey �izgileri �iz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan y�zeyi �iz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));

                        }


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            pictureBox1.Size = new Size(284, 459);  // PictureBox'�n boyutunu belirle

                            // Noktay� �izmek i�in bir f�r�a olu�turun
                            Brush brush = new SolidBrush(Color.Magenta);

                            Brush brush2 = new SolidBrush(Color.Magenta);
                            int pointX = nokta5x + pictureBox1.Width / 2;
                            int pointY = -nokta5y + pictureBox1.Height / 2;
                            g.FillEllipse(brush, pointX - 5, pointY - 5, 5, 5);
                            brush.Dispose();

                            // Kullan�lan nesneleri temizleyin
                            brush.Dispose();
                        }




                    }

                    break;


                case 8:
                    int silindir1merkezx = int.Parse(textBox1.Text);
                    int silindir1merkezy = int.Parse(textBox2.Text);
                    int silindir1merkezz = int.Parse(textBox3.Text);
                    int silindir1yukseklik = int.Parse(textBox7.Text);
                    int silindir1yar��ap = int.Parse(textBox8.Text);
                    int silindir2merkezy = int.Parse(textBox5.Text);
                    int silindir2merkezz = int.Parse(textBox6.Text);
                    int silindir2merkezx = int.Parse(textBox4.Text);
                    int silindir2yukseklik = int.Parse(textBox9.Text);
                    int silindir2yar�cap = int.Parse(textBox10.Text);


                    silindir silindir1 = new silindir
                    {
                        silindirmerkez = new ucboyutlunokta { X = silindir1merkezx, Y = silindir1merkezy, Z = silindir1merkezz },
                        YariCap = silindir1yar��ap,
                        Yukseklik = silindir1yukseklik

                    };

                    silindir silindir2 = new silindir
                    {
                        silindirmerkez = new ucboyutlunokta { X = silindir2merkezx, Y = silindir2merkezy, Z = silindir2merkezz },
                        YariCap = silindir2yar�cap,
                        Yukseklik = silindir2yukseklik

                    };

                    bool silindirlerCarpisiyorMu = silindir1.silindirsilindire(silindir2);



                    if (silindirlerCarpisiyorMu)
                    {
                        labelSonu�.Text = "�arp��yorlar"; // �arp��ma varsa "Evet" yazd�r


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir1merkezx;
                            int y = silindir1merkezy;
                            int r = silindir1yar��ap;
                            int h = silindir1yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol �st
                            Point p3 = new Point(x + r, y + h); // sa� �st
                            Point p4 = new Point(x + r, y); // sa� alt

                            // taban y�zeyi ile sol yan y�zeyi birle�tir
                            g.DrawLine(pen, p1, p2);
                            // sol yan y�zeyi ile �st y�zeyi birle�tir
                            g.DrawLine(pen, p2, p3);
                            // �st y�zeyi ile sa� yan y�zeyi birle�tir
                            g.DrawLine(pen, p3, p4);
                            // sa� yan y�zeyi ile taban y�zeyi birle�tir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktas�n� hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sa� elipsin merkez noktas�n� hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey �izgileri �iz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan y�zeyi �iz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir2merkezx;
                            int y = silindir2merkezy;
                            int r = silindir2yar�cap;
                            int h = silindir2yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol �st
                            Point p3 = new Point(x + r, y + h); // sa� �st
                            Point p4 = new Point(x + r, y); // sa� alt

                            // taban y�zeyi ile sol yan y�zeyi birle�tir
                            g.DrawLine(pen, p1, p2);
                            // sol yan y�zeyi ile �st y�zeyi birle�tir
                            g.DrawLine(pen, p2, p3);
                            // �st y�zeyi ile sa� yan y�zeyi birle�tir
                            g.DrawLine(pen, p3, p4);
                            // sa� yan y�zeyi ile taban y�zeyi birle�tir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktas�n� hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sa� elipsin merkez noktas�n� hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey �izgileri �iz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan y�zeyi �iz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }




                    }
                    else
                    {
                        labelSonu�.Text = "�arp��m�yorlar"; // �arp��ma yoksa "Hay�r" yazd�r


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir1merkezx;
                            int y = silindir1merkezy;
                            int r = silindir1yar��ap;
                            int h = silindir1yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol �st
                            Point p3 = new Point(x + r, y + h); // sa� �st
                            Point p4 = new Point(x + r, y); // sa� alt

                            // taban y�zeyi ile sol yan y�zeyi birle�tir
                            g.DrawLine(pen, p1, p2);
                            // sol yan y�zeyi ile �st y�zeyi birle�tir
                            g.DrawLine(pen, p2, p3);
                            // �st y�zeyi ile sa� yan y�zeyi birle�tir
                            g.DrawLine(pen, p3, p4);
                            // sa� yan y�zeyi ile taban y�zeyi birle�tir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktas�n� hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sa� elipsin merkez noktas�n� hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey �izgileri �iz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan y�zeyi �iz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir2merkezx;
                            int y = silindir2merkezy;
                            int r = silindir2yar�cap;
                            int h = silindir2yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol �st
                            Point p3 = new Point(x + r, y + h); // sa� �st
                            Point p4 = new Point(x + r, y); // sa� alt

                            // taban y�zeyi ile sol yan y�zeyi birle�tir
                            g.DrawLine(pen, p1, p2);
                            // sol yan y�zeyi ile �st y�zeyi birle�tir
                            g.DrawLine(pen, p2, p3);
                            // �st y�zeyi ile sa� yan y�zeyi birle�tir
                            g.DrawLine(pen, p3, p4);
                            // sa� yan y�zeyi ile taban y�zeyi birle�tir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktas�n� hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sa� elipsin merkez noktas�n� hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey �izgileri �iz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan y�zeyi �iz
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
                    int silindir3yar��ap = int.Parse(textBox8.Text);
                    int k�re1merkezz = int.Parse(textBox9.Text);
                    int k�re1yar��ap = int.Parse(textBox10.Text);
                    int k�re1merkezx = int.Parse(textBox4.Text);
                    int k�re1merkezy = int.Parse(textBox5.Text);


                    silindir silindir3 = new silindir
                    {
                        silindirmerkez = new ucboyutlunokta { X = silindir3merkezx, Y = silindir3merkezy, Z = silindir3merkezz },
                        YariCap = silindir3yar��ap,
                        Yukseklik = silindir3yukseklik

                    };

                    kure k�re1 = new kure
                    {
                        merkezkure = new ucboyutlunokta { X = k�re1merkezx, Y = k�re1merkezy, Z = k�re1merkezz },
                        YariCap = k�re1yar��ap
                    };

                    if (k�re1.TamamenIci(silindir3))
                    {
                        labelSonu�.Text = "K�re tamamen silindirin i�inde.";

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir3merkezx;
                            int y = silindir3merkezy;
                            int r = silindir3yar��ap;
                            int h = silindir3yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol �st
                            Point p3 = new Point(x + r, y + h); // sa� �st
                            Point p4 = new Point(x + r, y); // sa� alt

                            // taban y�zeyi ile sol yan y�zeyi birle�tir
                            g.DrawLine(pen, p1, p2);
                            // sol yan y�zeyi ile �st y�zeyi birle�tir
                            g.DrawLine(pen, p2, p3);
                            // �st y�zeyi ile sa� yan y�zeyi birle�tir
                            g.DrawLine(pen, p3, p4);
                            // sa� yan y�zeyi ile taban y�zeyi birle�tir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktas�n� hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sa� elipsin merkez noktas�n� hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey �izgileri �iz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan y�zeyi �iz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin �ap� ve merkez koordinatlar�
                            int diameter = k�re1yar��ap;
                            int centerX = k�re1merkezx - k�re1yar��ap + pictureBox1.Width / 2;
                            int centerY = k�re1merkezy - k�re1yar��ap + pictureBox1.Height / 2;

                            // Daireyi �izdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlar� ve merkez koordinatlar�
                            int ellipseWidth = k�re1yar��ap;
                            int ellipseHeight = 35;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi �izdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullan�lan nesneleri temizle
                            pen.Dispose();
                        }





                    }
                    else if (k�re1.silindirk�re(silindir3))
                    {
                        labelSonu�.Text = "K�re silindir ile �arp��t�.";

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir3merkezx;
                            int y = silindir3merkezy;
                            int r = silindir3yar��ap;
                            int h = silindir3yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol �st
                            Point p3 = new Point(x + r, y + h); // sa� �st
                            Point p4 = new Point(x + r, y); // sa� alt

                            // taban y�zeyi ile sol yan y�zeyi birle�tir
                            g.DrawLine(pen, p1, p2);
                            // sol yan y�zeyi ile �st y�zeyi birle�tir
                            g.DrawLine(pen, p2, p3);
                            // �st y�zeyi ile sa� yan y�zeyi birle�tir
                            g.DrawLine(pen, p3, p4);
                            // sa� yan y�zeyi ile taban y�zeyi birle�tir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktas�n� hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sa� elipsin merkez noktas�n� hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey �izgileri �iz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan y�zeyi �iz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin �ap� ve merkez koordinatlar�
                            int diameter = k�re1yar��ap;
                            int centerX = k�re1merkezx - k�re1yar��ap + pictureBox1.Width / 2;
                            int centerY = k�re1merkezy - k�re1yar��ap + pictureBox1.Height / 2;

                            // Daireyi �izdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlar� ve merkez koordinatlar�
                            int ellipseWidth = k�re1yar��ap;
                            int ellipseHeight = 35;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi �izdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullan�lan nesneleri temizle
                            pen.Dispose();
                        }




                    }
                    else
                    {
                        labelSonu�.Text = "K�re ne silindirin i�inde ne de silindir ile �arp��t�.";
                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir3merkezx;
                            int y = silindir3merkezy;
                            int r = silindir3yar��ap;
                            int h = silindir3yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol �st
                            Point p3 = new Point(x + r, y + h); // sa� �st
                            Point p4 = new Point(x + r, y); // sa� alt

                            // taban y�zeyi ile sol yan y�zeyi birle�tir
                            g.DrawLine(pen, p1, p2);
                            // sol yan y�zeyi ile �st y�zeyi birle�tir
                            g.DrawLine(pen, p2, p3);
                            // �st y�zeyi ile sa� yan y�zeyi birle�tir
                            g.DrawLine(pen, p3, p4);
                            // sa� yan y�zeyi ile taban y�zeyi birle�tir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktas�n� hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sa� elipsin merkez noktas�n� hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey �izgileri �iz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan y�zeyi �iz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin �ap� ve merkez koordinatlar�
                            int diameter = k�re1yar��ap;
                            int centerX = k�re1merkezx - k�re1yar��ap + pictureBox1.Width / 2;
                            int centerY = k�re1merkezy - k�re1yar��ap + pictureBox1.Height / 2;

                            // Daireyi �izdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlar� ve merkez koordinatlar�
                            int ellipseWidth = k�re1yar��ap;
                            int ellipseHeight = 35;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi �izdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullan�lan nesneleri temizle
                            pen.Dispose();
                        }



                    }


                    break;


                case 10:
                    int k�re2merkezx = int.Parse(textBox7.Text);
                    int k�re2merkezy = int.Parse(textBox8.Text);
                    int k�re2merkezz = int.Parse(textBox9.Text);
                    int k�re2yar��ap = int.Parse(textBox10.Text);
                    int k�re3merkezx = int.Parse(textBox4.Text);
                    int k�re3merkezy = int.Parse(textBox5.Text);
                    int k�re3merkezz = int.Parse(textBox3.Text);
                    int k�re3yar��ap = int.Parse(textBox6.Text);

                    kure k�re2 = new kure
                    {
                        merkezkure = new ucboyutlunokta { X = k�re2merkezx, Y = k�re2merkezy, Z = k�re2merkezz },
                        YariCap = k�re2yar��ap
                    };

                    kure k�re3 = new kure
                    {
                        merkezkure = new ucboyutlunokta { X = k�re3merkezx, Y = k�re3merkezy, Z = k�re3merkezz },
                        YariCap = k�re3yar��ap
                    };

                    bool k = k�re2.kurekure(k�re3);


                    if (k)
                    {
                        labelSonu�.Text = "�arp��yorlar"; // �arp��ma varsa "Evet" yazd�r

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin �ap� ve merkez koordinatlar�
                            int diameter = k�re2yar��ap;
                            int centerX = k�re2merkezx - k�re2yar��ap + pictureBox1.Width / 2;
                            int centerY = k�re2merkezy - k�re2yar��ap + pictureBox1.Height / 2;

                            // Daireyi �izdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlar� ve merkez koordinatlar�
                            int ellipseWidth = k�re2yar��ap;
                            int ellipseHeight = 20;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi �izdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullan�lan nesneleri temizle
                            pen.Dispose();
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin �ap� ve merkez koordinatlar�
                            int diameter = k�re3yar��ap;
                            int centerX = k�re3merkezx - k�re3yar��ap + pictureBox1.Width / 2;
                            int centerY = k�re3merkezy - k�re3yar��ap + pictureBox1.Height / 2;

                            // Daireyi �izdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlar� ve merkez koordinatlar�
                            int ellipseWidth = k�re3yar��ap;
                            int ellipseHeight = 20;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi �izdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullan�lan nesneleri temizle
                            pen.Dispose();
                        }


                    }
                    else
                    {
                        labelSonu�.Text = "�arp��m�yorlar"; // �arp��ma yoksa "Hay�r" yazd�r

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin �ap� ve merkez koordinatlar�
                            int diameter = k�re2yar��ap;
                            int centerX = k�re2merkezx - k�re2yar��ap + pictureBox1.Width / 2;
                            int centerY = k�re2merkezy - k�re2yar��ap + pictureBox1.Height / 2;

                            // Daireyi �izdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlar� ve merkez koordinatlar�
                            int ellipseWidth = k�re2yar��ap;
                            int ellipseHeight = 20;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi �izdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullan�lan nesneleri temizle
                            pen.Dispose();
                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin �ap� ve merkez koordinatlar�
                            int diameter = k�re3yar��ap;
                            int centerX = k�re3merkezx - k�re3yar��ap + pictureBox1.Width / 2;
                            int centerY = k�re3merkezy - k�re3yar��ap + pictureBox1.Height / 2;

                            // Daireyi �izdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlar� ve merkez koordinatlar�
                            int ellipseWidth = k�re3yar��ap;
                            int ellipseHeight = 20;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi �izdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullan�lan nesneleri temizle
                            pen.Dispose();
                        }





                    }
                    break;




                case 11:
                    int prizma1merkezx = int.Parse(textBox1.Text);
                    int prizma1merkezy = int.Parse(textBox2.Text);
                    int prizma1merkezz = int.Parse(textBox3.Text);
                    int prizma1yukseklik = int.Parse(textBox7.Text);
                    int prizma1geni�lik = int.Parse(textBox8.Text);
                    int prizma1uzunluk = int.Parse(textBox9.Text);
                    int k�re4merkezx = int.Parse(textBox4.Text);
                    int k�re4merkezy = int.Parse(textBox5.Text);
                    int k�re4merkezz = int.Parse(textBox10.Text);
                    int k�re4yar��ap = int.Parse(textBox6.Text);

                    dikd�rtgenprizmas� prizma2 = new dikd�rtgenprizmas�
                    {
                        MerkezPrizma = new ucboyutlunokta { X = prizma1merkezx, Y = prizma1merkezy, Z = prizma1merkezz },
                        Yukseklik = prizma1yukseklik,
                        Uzunluk = prizma1uzunluk,
                        Genislik = prizma1geni�lik
                    };

                    kure k�re4 = new kure
                    {
                        merkezkure = new ucboyutlunokta { X = k�re4merkezx, Y = k�re4merkezy, Z = k�re4merkezz },
                        YariCap = k�re4yar��ap

                    };


                    bool d = prizma2.prizmak�re�arp��ma(k�re4);


                    if (d)
                    {
                        labelSonu�.Text = "�arp��yorlar"; // �arp��ma varsa "Evet" yazd�r

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin �ap� ve merkez koordinatlar�
                            int diameter = k�re4yar��ap;
                            int centerX = k�re4merkezx - k�re4yar��ap + pictureBox1.Width / 2;
                            int centerY = k�re4merkezy - k�re4yar��ap + pictureBox1.Height / 2;

                            // Daireyi �izdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlar� ve merkez koordinatlar�
                            int ellipseWidth = k�re4yar��ap;
                            int ellipseHeight = 20;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi �izdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullan�lan nesneleri temizle
                            pen.Dispose();
                        }


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikd�rtgen olu�turuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizma1geni�lik, prizma1geni�lik);


                            // Prizman�n y�zeylerini �iziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizma1geni�lik / 2, 0), new Point(75 + prizma1geni�lik + prizma1geni�lik / 2, 0), new Point(75 + prizma1geni�lik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizma1uzunluk), new Point(75 + prizma1geni�lik / 2, prizma1uzunluk), new Point(75 + prizma1geni�lik + prizma1geni�lik / 2, prizma1uzunluk), new Point(75 + prizma1geni�lik, 75 + prizma1uzunluk) };
                            Point[] points3 = { new Point(75 + prizma1geni�lik, 75), new Point(75 + prizma1geni�lik / 2 + prizma1geni�lik, 0), new Point(75 + prizma1geni�lik / 2 + prizma1geni�lik, prizma1uzunluk), new Point(75 + prizma1geni�lik, 75 + prizma1uzunluk) };

                            // Dikd�rtgenleri ve prizman�n y�zeylerini �iziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);


                        }



                    }
                    else
                    {
                        labelSonu�.Text = "�arp��m�yorlar"; // �arp��ma yoksa "Hay�r" yazd�r

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin �ap� ve merkez koordinatlar�
                            int diameter = k�re4yar��ap;
                            int centerX = k�re4merkezx - k�re4yar��ap + pictureBox1.Width / 2;
                            int centerY = k�re4merkezy - k�re4yar��ap + pictureBox1.Height / 2;

                            // Daireyi �izdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlar� ve merkez koordinatlar�
                            int ellipseWidth = k�re4yar��ap;
                            int ellipseHeight = 20;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi �izdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullan�lan nesneleri temizle
                            pen.Dispose();
                        }


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikd�rtgen olu�turuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizma1geni�lik, prizma1geni�lik);


                            // Prizman�n y�zeylerini �iziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizma1geni�lik / 2, 0), new Point(75 + prizma1geni�lik + prizma1geni�lik / 2, 0), new Point(75 + prizma1geni�lik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizma1uzunluk), new Point(75 + prizma1geni�lik / 2, prizma1uzunluk), new Point(75 + prizma1geni�lik + prizma1geni�lik / 2, prizma1uzunluk), new Point(75 + prizma1geni�lik, 75 + prizma1uzunluk) };
                            Point[] points3 = { new Point(75 + prizma1geni�lik, 75), new Point(75 + prizma1geni�lik / 2 + prizma1geni�lik, 0), new Point(75 + prizma1geni�lik / 2 + prizma1geni�lik, prizma1uzunluk), new Point(75 + prizma1geni�lik, 75 + prizma1uzunluk) };

                            // Dikd�rtgenleri ve prizman�n y�zeylerini �iziyoruz

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
                    int prizma4geni�lik = int.Parse(textBox8.Text);
                    int prizma4uzunluk = int.Parse(textBox9.Text);

                    int prizma3merkezx = int.Parse(textBox4.Text);
                    int prizma3merkezy = int.Parse(textBox5.Text);
                    int prizma3merkezz = int.Parse(textBox6.Text);
                    int prizma3yukseklik = int.Parse(textBox10.Text);
                    int prizma3geni�lik = int.Parse(textBox11.Text);
                    int prizma3uzunluk = int.Parse(textBox12.Text);


                    dikd�rtgenprizmas� prizma4 = new dikd�rtgenprizmas�
                    {
                        MerkezPrizma = new ucboyutlunokta { X = prizma4merkezx, Y = prizma4merkezy, Z = prizma4merkezz },
                        Yukseklik = prizma4yukseklik,
                        Uzunluk = prizma4uzunluk,
                        Genislik = prizma4geni�lik
                    };


                    dikd�rtgenprizmas� prizma3 = new dikd�rtgenprizmas�
                    {
                        MerkezPrizma = new ucboyutlunokta { X = prizma3merkezx, Y = prizma3merkezy, Z = prizma3merkezz },
                        Yukseklik = prizma3yukseklik,
                        Uzunluk = prizma3uzunluk,
                        Genislik = prizma3geni�lik
                    };

                    bool sonuc3 = prizma3.DikdortgenPrizmaCarpisma(prizma3, prizma4);


                    if (sonuc3)
                    {
                        labelSonu�.Text = "�arp��yorlar"; // �arp��ma varsa "Evet" yazd�r

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikd�rtgen olu�turuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizma3geni�lik, prizma3geni�lik);


                            // Prizman�n y�zeylerini �iziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizma3geni�lik / 2, 0), new Point(75 + prizma3geni�lik + prizma3geni�lik / 2, 0), new Point(75 + prizma3geni�lik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizma3uzunluk), new Point(75 + prizma3geni�lik / 2, prizma3uzunluk), new Point(75 + prizma3geni�lik + prizma3geni�lik / 2, prizma3uzunluk), new Point(75 + prizma3geni�lik, 75 + prizma3uzunluk) };
                            Point[] points3 = { new Point(75 + prizma3geni�lik, 75), new Point(75 + prizma3geni�lik / 2 + prizma3geni�lik, 0), new Point(75 + prizma3geni�lik / 2 + prizma3geni�lik, prizma3uzunluk), new Point(75 + prizma3geni�lik, 75 + prizma3uzunluk) };

                            // Dikd�rtgenleri ve prizman�n y�zeylerini �iziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);


                        }


                        using(Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikd�rtgen olu�turuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizma4geni�lik, prizma4geni�lik);


                            // Prizman�n y�zeylerini �iziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizma4geni�lik / 2, 0), new Point(75 + prizma4geni�lik + prizma4geni�lik / 2, 0), new Point(75 + prizma4geni�lik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizma4uzunluk), new Point(75 + prizma4geni�lik / 2, prizma4uzunluk), new Point(75 + prizma4geni�lik + prizma4geni�lik / 2, prizma4uzunluk), new Point(75 + prizma4geni�lik, 75 + prizma4uzunluk) };
                            Point[] points3 = { new Point(75 + prizma4geni�lik, 75), new Point(75 + prizma4geni�lik / 2 + prizma4geni�lik, 0), new Point(75 + prizma4geni�lik / 2 + prizma4geni�lik, prizma4uzunluk), new Point(75 + prizma4geni�lik, 75 + prizma4uzunluk) };

                            // Dikd�rtgenleri ve prizman�n y�zeylerini �iziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);


                        }


                    }
                    else
                    {
                        labelSonu�.Text = "�arp��m�yorlar"; // �arp��ma yoksa "Hay�r" yazd�r

            
                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikd�rtgen olu�turuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizma3geni�lik, prizma3geni�lik);


                            // Prizman�n y�zeylerini �iziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizma3geni�lik / 2, 0), new Point(75 + prizma3geni�lik + prizma3geni�lik / 2, 0), new Point(75 + prizma3geni�lik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizma3uzunluk), new Point(75 + prizma3geni�lik / 2, prizma3uzunluk), new Point(75 + prizma3geni�lik + prizma3geni�lik / 2, prizma3uzunluk), new Point(75 + prizma3geni�lik, 75 + prizma3uzunluk) };
                            Point[] points3 = { new Point(75 + prizma3geni�lik, 75), new Point(75 + prizma3geni�lik / 2 + prizma3geni�lik, 0), new Point(75 + prizma3geni�lik / 2 + prizma3geni�lik, prizma3uzunluk), new Point(75 + prizma3geni�lik, 75 + prizma3uzunluk) };

                            // Dikd�rtgenleri ve prizman�n y�zeylerini �iziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);


                        }


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikd�rtgen olu�turuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizma4geni�lik, prizma4geni�lik);


                            // Prizman�n y�zeylerini �iziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizma4geni�lik / 2, 0), new Point(75 + prizma4geni�lik + prizma4geni�lik / 2, 0), new Point(75 + prizma4geni�lik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizma4uzunluk), new Point(75 + prizma4geni�lik / 2, prizma4uzunluk), new Point(75 + prizma4geni�lik + prizma4geni�lik / 2, prizma4uzunluk), new Point(75 + prizma4geni�lik, 75 + prizma4uzunluk) };
                            Point[] points3 = { new Point(75 + prizma4geni�lik, 75), new Point(75 + prizma4geni�lik / 2 + prizma4geni�lik, 0), new Point(75 + prizma4geni�lik / 2 + prizma4geni�lik, prizma4uzunluk), new Point(75 + prizma4geni�lik, 75 + prizma4uzunluk) };

                            // Dikd�rtgenleri ve prizman�n y�zeylerini �iziyoruz

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
                    int silindir4yar��ap = int.Parse(textBox8.Text);
                    int y�zeyen = int.Parse(textBox4.Text);
                    int y�zeyderinlik = int.Parse(textBox5.Text);


                    silindir silindir4 = new silindir
                    {
                        silindirmerkez = new ucboyutlunokta { X = silindir4merkezx, Y = silindir4merkezy, Z = silindir4merkezz },
                        YariCap = silindir4yar��ap,
                        Yukseklik = silindir4yukseklik

                    };

                    y�zey yuzey = new y�zey(y�zeyen, y�zeyderinlik);
                    bool sonuc4 = silindir4.silindiry�zey(yuzey);


                    if (sonuc4)
                    {
                        labelSonu�.Text = "�arp��yorlar"; // �arp��ma varsa "Evet" yazd�r

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Point[] points2 = { new Point(75, 75 + y�zeyderinlik), new Point(75 + y�zeyen / 2, y�zeyderinlik), new Point(75 + y�zeyen + y�zeyen / 2, y�zeyderinlik), new Point(75 + y�zeyen, 75 + y�zeyderinlik) };
                            g.DrawPolygon(Pens.Black, points2);

                        }
                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir4merkezx;
                            int y = silindir4merkezy;
                            int r = silindir4yar��ap;
                            int h = silindir4yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol �st
                            Point p3 = new Point(x + r, y + h); // sa� �st
                            Point p4 = new Point(x + r, y); // sa� alt

                            // taban y�zeyi ile sol yan y�zeyi birle�tir
                            g.DrawLine(pen, p1, p2);
                            // sol yan y�zeyi ile �st y�zeyi birle�tir
                            g.DrawLine(pen, p2, p3);
                            // �st y�zeyi ile sa� yan y�zeyi birle�tir
                            g.DrawLine(pen, p3, p4);
                            // sa� yan y�zeyi ile taban y�zeyi birle�tir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktas�n� hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sa� elipsin merkez noktas�n� hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey �izgileri �iz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan y�zeyi �iz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }






                    }
                    else
                    {
                        labelSonu�.Text = "�arp��m�yorlar"; // �arp��ma yoksa "Hay�r" yazd�r


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Point[] points2 = { new Point(75, 75 + y�zeyderinlik), new Point(75 + y�zeyen / 2, y�zeyderinlik), new Point(75 + y�zeyen + y�zeyen / 2, y�zeyderinlik), new Point(75 + y�zeyen, 75 + y�zeyderinlik) };
                            g.DrawPolygon(Pens.Black, points2);

                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            int x = silindir4merkezx;
                            int y = silindir4merkezy;
                            int r = silindir4yar��ap;
                            int h = silindir4yukseklik;

                            Pen pen = new Pen(Color.Black, 2);


                            Point p1 = new Point(x - r, y); // sol alt
                            Point p2 = new Point(x - r, y + h); // sol �st
                            Point p3 = new Point(x + r, y + h); // sa� �st
                            Point p4 = new Point(x + r, y); // sa� alt

                            // taban y�zeyi ile sol yan y�zeyi birle�tir
                            g.DrawLine(pen, p1, p2);
                            // sol yan y�zeyi ile �st y�zeyi birle�tir
                            g.DrawLine(pen, p2, p3);
                            // �st y�zeyi ile sa� yan y�zeyi birle�tir
                            g.DrawLine(pen, p3, p4);
                            // sa� yan y�zeyi ile taban y�zeyi birle�tir
                            g.DrawLine(pen, p4, p1);

                            // Sol elipsin merkez noktas�n� hesapla
                            int solElipsX = x - r;
                            int solElipsY = y + (h / 2);

                            // Sa� elipsin merkez noktas�n� hesapla
                            int sagElipsX = x + r;
                            int sagElipsY = y + (h / 2);

                            // Dikey �izgileri �iz
                            g.DrawLine(pen, new Point(solElipsX, y), new Point(solElipsX, y + h));
                            g.DrawLine(pen, new Point(sagElipsX, y), new Point(sagElipsX, y + h));

                            // Yan y�zeyi �iz
                            g.DrawBezier(pen, new Point(solElipsX, y), new Point(solElipsX - (r / 2), y - (h / 4)), new Point(sagElipsX + (r / 2), y - (h / 4)), new Point(sagElipsX, y));
                            g.DrawBezier(pen, new Point(solElipsX, y + h), new Point(solElipsX - (r / 2), y + h + (h / 4)), new Point(sagElipsX + (r / 2), y + h + (h / 4)), new Point(sagElipsX, y + h));
                        }






                    }
                    break;

                case 14:

                    int k�re5merkezx = int.Parse(textBox7.Text);
                    int k�re5merkezy = int.Parse(textBox8.Text);
                    int k�re5merkezz = int.Parse(textBox9.Text);
                    int k�re5yar��ap = int.Parse(textBox10.Text);
                    int y�zey1en = int.Parse(textBox4.Text);
                    int y�zey1derinlik = int.Parse(textBox5.Text);

                    y�zey yuzey1 = new y�zey(y�zey1en, y�zey1derinlik);

                    kure k�re5 = new kure
                    {
                        merkezkure = new ucboyutlunokta { X = k�re5merkezx, Y = k�re5merkezy, Z = k�re5merkezz },
                        YariCap = k�re5yar��ap

                    };


                    if (yuzey1.y�zeyk�re(k�re5))


                    {
                        labelSonu�.Text = "�arp��yorlar"; // �arp��ma varsa "Evet" yazd�r

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Point[] points2 = { new Point(75, 75 + y�zey1derinlik), new Point(75 + y�zey1en / 2, y�zey1derinlik), new Point(75 + y�zey1en + y�zey1en / 2, y�zey1derinlik), new Point(75 + y�zey1en, 75 + y�zey1derinlik) };
                            g.DrawPolygon(Pens.Black, points2);

                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin �ap� ve merkez koordinatlar�
                            int diameter = k�re5yar��ap;
                            int centerX = k�re5merkezx - k�re5yar��ap + pictureBox1.Width / 2;
                            int centerY = k�re5merkezy - k�re5yar��ap + pictureBox1.Height / 2;

                            // Daireyi �izdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlar� ve merkez koordinatlar�
                            int ellipseWidth = k�re5yar��ap;
                            int ellipseHeight = 20;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi �izdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullan�lan nesneleri temizle
                            pen.Dispose();
                        }




                    }
                    else
                    {
                        labelSonu�.Text = "�arp��m�yorlar"; // �arp��ma yoksa "Hay�r" yazd�r



                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Point[] points2 = { new Point(75, 75 + y�zey1derinlik), new Point(75 + y�zey1en / 2, y�zey1derinlik), new Point(75 + y�zey1en + y�zey1en / 2, y�zey1derinlik), new Point(75 + y�zey1en, 75 + y�zey1derinlik) };
                            g.DrawPolygon(Pens.Black, points2);

                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            // Dairenin �ap� ve merkez koordinatlar�
                            int diameter = k�re5yar��ap;
                            int centerX = k�re5merkezx - k�re5yar��ap + pictureBox1.Width / 2;
                            int centerY = k�re5merkezy - k�re5yar��ap + pictureBox1.Height / 2;

                            // Daireyi �izdir
                            Pen pen = new Pen(Color.Black);
                            g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);

                            // Elipsin boyutlar� ve merkez koordinatlar�
                            int ellipseWidth = k�re5yar��ap;
                            int ellipseHeight = 20;
                            int ellipseX = centerX;
                            int ellipseY = centerY;

                            // Elipsi �izdir
                            Rectangle ellipseRect = new Rectangle(ellipseX - ellipseWidth / 2, ellipseY - ellipseHeight / 2, ellipseWidth, ellipseHeight);
                            g.DrawEllipse(pen, ellipseRect);

                            // Kullan�lan nesneleri temizle
                            pen.Dispose();
                        }
                    }

                    break;

                case 15:
                    int prizma5merkezx = int.Parse(textBox1.Text);
                    int prizma5merkezy = int.Parse(textBox2.Text);
                    int prizma5merkezz = int.Parse(textBox3.Text);
                    int prizma5yukseklik = int.Parse(textBox7.Text);
                    int prizma5geni�lik = int.Parse(textBox8.Text);
                    int prizma5uzunluk = int.Parse(textBox9.Text);
                    int y�zey2en = int.Parse(textBox4.Text);
                    int y�zey2derinlik = int.Parse(textBox5.Text);

                    dikd�rtgenprizmas� prizma5 = new dikd�rtgenprizmas�
                    {
                        MerkezPrizma = new ucboyutlunokta { X = prizma5merkezx, Y = prizma5merkezy, Z = prizma5merkezz },
                        Yukseklik = prizma5yukseklik,
                        Uzunluk = prizma5uzunluk,
                        Genislik = prizma5geni�lik
                    };


                    y�zey yuzey2 = new y�zey(y�zey2en, y�zey2derinlik);



                    if (yuzey2.CarpisiyorMu(prizma5))
                    {
                        labelSonu�.Text = "�arp��yorlar"; // �arp��ma varsa "Evet" yazd�r


                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Point[] points2 = { new Point(75, 75 + y�zey2derinlik), new Point(75 + y�zey2en / 2, y�zey2derinlik), new Point(75 + y�zey2en + y�zey2en / 2, y�zey2derinlik), new Point(75 + y�zey2en, 75 + y�zey2derinlik) };
                            g.DrawPolygon(Pens.Black, points2);

                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikd�rtgen olu�turuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizma5geni�lik, prizma5geni�lik);


                            // Prizman�n y�zeylerini �iziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizma5geni�lik / 2, 0), new Point(75 + prizma5geni�lik + prizma5geni�lik / 2, 0), new Point(75 + prizma5geni�lik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizma5uzunluk), new Point(75 + prizma5geni�lik / 2, prizma5uzunluk), new Point(75 + prizma5geni�lik + prizma5geni�lik / 2, prizma5uzunluk), new Point(75 + prizma5geni�lik, 75 + prizma5uzunluk) };
                            Point[] points3 = { new Point(75 + prizma5geni�lik, 75), new Point(75 + prizma5geni�lik / 2 + prizma5geni�lik, 0), new Point(75 + prizma5geni�lik / 2 + prizma5geni�lik, prizma5uzunluk), new Point(75 + prizma5geni�lik, 75 + prizma5uzunluk) };

                            // Dikd�rtgenleri ve prizman�n y�zeylerini �iziyoruz

                            g.DrawRectangle(Pens.Black, rect1);
                            g.DrawPolygon(Pens.Black, points1);
                            g.DrawPolygon(Pens.Black, points2);
                            g.DrawPolygon(Pens.Black, points3);


                        }


                    }
                    else
                    {
                        labelSonu�.Text = "�arp��m�yorlar"; // �arp��ma yoksa "Hay�r" yazd�r




                        using (Graphics g = pictureBox1.CreateGraphics())
                        {
                            Point[] points2 = { new Point(75, 75 + y�zey2derinlik), new Point(75 + y�zey2en / 2, y�zey2derinlik), new Point(75 + y�zey2en + y�zey2en / 2, y�zey2derinlik), new Point(75 + y�zey2en, 75 + y�zey2derinlik) };
                            g.DrawPolygon(Pens.Black, points2);

                        }

                        using (Graphics g = pictureBox1.CreateGraphics())
                        {

                            // 2 tane dikd�rtgen olu�turuyoruz
                            Rectangle rect1 = new Rectangle(75, 75, prizma5geni�lik, prizma5geni�lik);


                            // Prizman�n y�zeylerini �iziyoruz
                            Point[] points1 = { new Point(75, 75), new Point(75 + prizma5geni�lik / 2, 0), new Point(75 + prizma5geni�lik + prizma5geni�lik / 2, 0), new Point(75 + prizma5geni�lik, 75) };
                            Point[] points2 = { new Point(75, 75 + prizma5uzunluk), new Point(75 + prizma5geni�lik / 2, prizma5uzunluk), new Point(75 + prizma5geni�lik + prizma5geni�lik / 2, prizma5uzunluk), new Point(75 + prizma5geni�lik, 75 + prizma5uzunluk) };
                            Point[] points3 = { new Point(75 + prizma5geni�lik, 75), new Point(75 + prizma5geni�lik / 2 + prizma5geni�lik, 0), new Point(75 + prizma5geni�lik / 2 + prizma5geni�lik, prizma5uzunluk), new Point(75 + prizma5geni�lik, 75 + prizma5uzunluk) };

                            // Dikd�rtgenleri ve prizman�n y�zeylerini �iziyoruz

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
            labelSonu�.Visible = false;


            pictureBox1.Invalidate(); // PictureBox i�indeki �izimi siler

        }
    }
}



    
