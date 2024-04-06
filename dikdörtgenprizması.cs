/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** PROGRAMLAMAYA GİRİŞİ DERSİ
**
** ÖDEV NUMARASI: PROJE 1
** ÖĞRENCİ ADI: ŞEVVAL DUYGU ÖRKLEMEZ
** ÖĞRENCİ NUMARASI.: G221210082
** DERS GRUBU…………: B GRUBU 2. ÖĞRETİM
YOUTUBE LİNKİ: https://www.youtube.com/watch?v=U2JuDn4Npo8&list=PLAUxJCTQFTjwpREMuUni7Yq-K3N1IiAp5
****************************************************************************/





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class dikdörtgenprizması
    {

        public ucboyutlunokta MerkezPrizma { get; set; }
        public double Uzunluk { get; set; }
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }
        public ucboyutlunokta KoseA { get; set; } = new ucboyutlunokta();
        public ucboyutlunokta KoseB { get; set; } = new ucboyutlunokta();
        public ucboyutlunokta KoseC { get; set; } = new ucboyutlunokta();
        public ucboyutlunokta KoseD { get; set; } = new ucboyutlunokta();


        public bool prizmanoktaçarpışma(ucboyutlunokta nokta)
        {
            double minX = MerkezPrizma.X - (Uzunluk / 2);
            double maxX = MerkezPrizma.X + (Uzunluk / 2);
            double minY = MerkezPrizma.Y - (Genislik / 2);
            double maxY = MerkezPrizma.Y + (Genislik / 2);
            double minZ = MerkezPrizma.Z - (Yukseklik / 2);
            double maxZ = MerkezPrizma.Z + (Yukseklik / 2);

            if (nokta.X < minX || nokta.X > maxX)
                return false;

            if (nokta.Y < minY || nokta.Y > maxY)
                return false;

            if (nokta.Z < minZ || nokta.Z > maxZ)
                return false;

            return true;
        }


        public bool prizmaküreçarpışma(kure kure)
        {
            double enUzakNoktaX = Math.Max(Math.Min(kure.merkezkure.X, Genislik / 2.0), -Genislik / 2.0);
            double enUzakNoktaY = Math.Max(Math.Min(kure.merkezkure.Y, Yukseklik / 2.0), -Yukseklik / 2.0);
            double enUzakNoktaZ = Math.Max(Math.Min(kure.merkezkure.Z, Uzunluk / 2.0), -Uzunluk / 2.0);

            double mesafe = Math.Sqrt((enUzakNoktaX - kure.merkezkure.X) * (enUzakNoktaX - kure.merkezkure.X) +
                                      (enUzakNoktaY - kure.merkezkure.Y) * (enUzakNoktaY - kure.merkezkure.Y) +
                                      (enUzakNoktaZ - kure.merkezkure.Z) * (enUzakNoktaZ - kure.merkezkure.Z));

            return mesafe <= kure.YariCap;
        }


        public bool DikdortgenPrizmaCarpisma(dikdörtgenprizması prizma1, dikdörtgenprizması prizma2)
        {
            // İki prizmanın çarpışıp çarpışmadığını kontrol etmek için her iki prizmanın köşe noktalarını kullanacağız
            ucboyutlunokta[] prizma1Koseleri = { prizma1.KoseA, prizma1.KoseB, prizma1.KoseC, prizma1.KoseD };
            ucboyutlunokta[] prizma2Koseleri = { prizma2.KoseA, prizma2.KoseB, prizma2.KoseC, prizma2.KoseD };

            // İki prizmanın herhangi bir kenarının diğer prizmanın içinde kalıp kalmadığını kontrol etmek için iki tane for döngüsü kullanacağız
            for (int i = 0; i < prizma1Koseleri.Length; i++)
            {
                for (int j = 0; j < prizma2Koseleri.Length; j++)
                {
                    double mesafe = prizma1Koseleri[i].MesafeHesapla3(prizma2Koseleri[j]); // İki köşe arasındaki mesafeyi hesapla

                    if (mesafe < 0.00001) // Köşeler aynı ise çarpışma vardır, o halde fonksiyondan hemen çık
                    {
                        return true;
                    }

                    // Köşeler arasındaki mesafenin prizmaların yarısı kadar olması gerekir, eğer bu durum sağlanmazsa çarpışma yoktur
                    if (mesafe < (prizma1.Uzunluk / 2 + prizma2.Uzunluk / 2) &&
                        mesafe < (prizma1.Genislik / 2 + prizma2.Genislik / 2) &&
                        mesafe < (prizma1.Yukseklik / 2 + prizma2.Yukseklik / 2))
                    {
                        return true;
                    }
                }
            }

            // Tüm köşeler arasında çarpışma yoksa, çarpışma yoktur
            return false;
        }




    }
}
