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
    internal class kure
    {
        
            public ucboyutlunokta merkezkure { get; set; }
            public double YariCap { get; set; }

            public bool kurenokta(ucboyutlunokta nokta)
            {
                double mesafe = merkezkure.MesafeHesapla3(nokta);
                if (mesafe <= YariCap)
                    return true;
                else
                    return false;
            }

        public bool silindirküre(silindir silindir)
        {
            // Kürenin merkezi ile silindirin merkezi arasındaki uzaklık
            double uzaklik = Math.Sqrt(Math.Pow(merkezkure.X - silindir.silindirmerkez.X, 2) +
                                       Math.Pow(merkezkure.Y - silindir.silindirmerkez.Y, 2) +
                                       Math.Pow(merkezkure.Z - silindir.silindirmerkez.Z, 2));

            // Kürenin merkezi taban düzleminin üzerinde değilse çarpışma yok
            if (merkezkure.Z < silindir.silindirmerkez.Z || merkezkure.Z > silindir.silindirmerkez.Z + silindir.Yukseklik)
            {
                return false;
            }

            // Kürenin merkezi silindirin yan yüzeyine çarpmadıysa çarpışma yok
            if (uzaklik > YariCap + silindir.YariCap)
            {
                return false;
            }

            return true;
        }

        public bool TamamenIci(silindir silindir)
        {
            // Kürenin merkezinin silindirin taban düzlemi üzerinde veya içinde olduğunu kontrol etme
            if (merkezkure.Z < silindir.silindirmerkez.Z || merkezkure.Z > silindir.silindirmerkez.Z + silindir.Yukseklik)
            {
                return false;
            }

            // Kürenin merkezinin silindirin yan yüzeyine çarpmadığını kontrol etme
            double uzaklik = Math.Sqrt(Math.Pow(merkezkure.X - silindir.silindirmerkez.X, 2) +
                                       Math.Pow(merkezkure.Y - silindir.silindirmerkez.Y, 2));
            if (uzaklik > silindir.YariCap - YariCap)
            {
                return false;
            }

            return true;
        }


        public bool kurekure(kure baskaKure)
        {
            double mesafe = merkezkure.MesafeHesapla3(baskaKure.merkezkure);
            double toplamYariCap = YariCap + baskaKure.YariCap;
            return mesafe <= toplamYariCap;
        }
        //2 kürenin çarpışıp çarpışmadığını anlamak için noktalar
        //arasındaki mesafe hesaplanır.
        //Eğer 2 kürenin merkezleri arasındaki mesafe,
        //kürelerin yarıçaplarının toplamından küçükse,
        //küreler birbirine çarpmış demektir




    }
}
