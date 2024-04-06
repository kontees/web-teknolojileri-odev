using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class silindir
    {

        public ucboyutlunokta silindirmerkez { get; set; }
        public double YariCap { get; set; }
        public double Yukseklik { get; set; }

        // Silindir, noktaya çarpıyor mu kontrolü yapılır
        // Eğer çarpıyorsa true, değilse false döndürülür.


        public bool silindirnokta(ucboyutlunokta nokta)
        {
            // Silindirin taban düzlemine dik olan doğrunun denklemi
            // ax + by + cz + d = 0
            // burada a = x1 - x2, b = y1 - y2, c = z1 - z2
            // ve d = -(a*x1 + b*y1 + c*z1) şeklindedir.
            double a = silindirmerkez.X - nokta.X;
            double b = silindirmerkez.Y - nokta.Y;
            double c = silindirmerkez.Z - nokta.Z;
            double d = -(a * silindirmerkez.X + b * silindirmerkez.Y + c * silindirmerkez.Z);

            // Noktanın silindirin tabanına en yakın noktasını bulma
            double tabanUzaklik = Math.Sqrt(a * a + b * b + c * c);
            ucboyutlunokta tabanNoktasi = new ucboyutlunokta
            {
                X = nokta.X + (a / tabanUzaklik) * YariCap,
                Y = nokta.Y + (b / tabanUzaklik) * YariCap,
                Z = nokta.Z + (c / tabanUzaklik) * YariCap
            };

            // Noktanın silindirin tabanı veya tavanı arasında mı kontrolü yapılır
            bool tabanTavanCarpismasi = tabanUzaklik <= YariCap &&
                                        tabanNoktasi.Z >= silindirmerkez.Z &&
                                        tabanNoktasi.Z <= silindirmerkez.Z + Yukseklik;

            // Noktanın silindirin yan yüzeyine çarpıp çarpmadığı kontrol edilir
            double uzaklik = Math.Sqrt((tabanNoktasi.X - silindirmerkez.X) * (tabanNoktasi.X - silindirmerkez.X) +
                                       (tabanNoktasi.Y - silindirmerkez.Y) * (tabanNoktasi.Y - silindirmerkez.Y));
            bool yuzeyCarpismasi = uzaklik <= YariCap && tabanNoktasi.Z <= silindirmerkez.Z + Yukseklik && tabanNoktasi.Z >= silindirmerkez.Z;

            return tabanTavanCarpismasi || yuzeyCarpismasi;
        }

        // Silindir, silindire çarpıyor mu kontrolü yapılır
        // Eğer çarpıyorsa true, değilse false döndürülür.

        public bool silindirsilindire(silindir baskasilindir)
        {
            // Silindirlerin merkez noktaları arasındaki uzaklık
            double uzaklik = Math.Sqrt(Math.Pow(silindirmerkez.X - baskasilindir.silindirmerkez.X, 2) +
                                       Math.Pow(silindirmerkez.Y - baskasilindir.silindirmerkez.Y, 2) +
                                       Math.Pow(silindirmerkez.Z - baskasilindir.silindirmerkez.Z, 2));

            // İki silindirin birbirine değdiği koşulunu sağlayan ifade
            bool carpismaKosulu = uzaklik <= (YariCap + baskasilindir.YariCap);

            return carpismaKosulu;
        }


        public bool silindiryüzey(yüzey yuzey)
        {
            // Yüzeyin boyutları
            double en = yuzey.En;
            double derinlik = yuzey.Derinlik;

            // Silindirin boyutları

            double yaricap = YariCap;
            double yukseklik = Yukseklik;

            // Silindirin x ve y koordinatları
            double x = 0;
            double y = 0;

            // Yüzeyin x ve y koordinatları
            double yuzeyX = yuzey.En / 2;
            double yuzeyY = yuzey.Derinlik / 2;

            // Silindirin merkezinin yüzeyin içinde mi kontrol edilir
            if (Math.Pow((x - yuzeyX), 2) + Math.Pow((y - yuzeyY), 2) <= Math.Pow(yaricap, 2))
            {
                return true;
            }

            // Silindirin yüksekliğinin yüzeyin içinde mi kontrol edilir
            if (yukseklik <= 0)
            {
                return false;
            }
            else if (y <= 0 || y >= derinlik)
            {
                return false;
            }

            // Silindirin uzunluğunun yüzeyin içinde mi kontrol edilir
            double silindirUzunluk = Math.Sqrt(Math.Pow(yukseklik, 2) + Math.Pow(en, 2));
            if (silindirUzunluk <= yaricap)
            {
                return true;
            }

            return false;
        }
    }



}
