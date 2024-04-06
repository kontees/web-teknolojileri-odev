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
    internal class yüzey
    {

        public double En { get; set; }
        public double Derinlik { get; set; }

        public yüzey(double en, double derinlik)
        {
            En = en;
            Derinlik = derinlik;
        }

        public bool yüzeyküre(kure kure)
        {
            double yuzeyX = En / 2;
            double yuzeyY = Derinlik / 2;

            double kureMerkezX = kure.merkezkure.X;
            double kureMerkezY = kure.merkezkure.Y;
            double kureMerkezZ = kure.merkezkure.Z;
            double kureYaricap = kure.YariCap;

            double uzaklıkx = Math.Abs(kureMerkezX - yuzeyX);
            double uzaklıky = Math.Abs(kureMerkezY - yuzeyY);

            if (uzaklıkx > (En / 2 + kureYaricap))
            {
                return false;
            }
            if (uzaklıky > (Derinlik / 2 + kureYaricap))
            {
                return false;
            }

            if (uzaklıkx <= (En / 2))
            {
                return true;
            }
            if (uzaklıky <= (Derinlik / 2))
            {
                return true;
            }

            double dx = uzaklıkx - En / 2;
            double dy = uzaklıky - Derinlik / 2;
            return (dx * dx + dy * dy <= (kureYaricap * kureYaricap));
        }

        public bool CarpisiyorMu(dikdörtgenprizması prizma)
        {
            double yuzeyX = En / 2;
            double yuzeyY = Derinlik / 2;

            ucboyutlunokta prizmaKoseA = prizma.KoseA;
            ucboyutlunokta prizmaKoseC = prizma.KoseC;

            double prizmaMinX = Math.Min(prizmaKoseA.X, prizmaKoseC.X);
            double prizmaMaxX = Math.Max(prizmaKoseA.X, prizmaKoseC.X);
            double prizmaMinY = Math.Min(prizmaKoseA.Y, prizmaKoseC.Y);
            double prizmaMaxY = Math.Max(prizmaKoseA.Y, prizmaKoseC.Y);
            double prizmaMinZ = Math.Min(prizmaKoseA.Z, prizmaKoseC.Z);
            double prizmaMaxZ = Math.Max(prizmaKoseA.Z, prizmaKoseC.Z);

            double distX = Math.Abs(prizma.MerkezPrizma.X - yuzeyX);
            double distY = Math.Abs(prizma.MerkezPrizma.Y - yuzeyY);

            if (distX > (En / 2 + prizma.Uzunluk / 2))
            {
                return false;
            }
            if (distY > (Derinlik / 2 + prizma.Genislik / 2))
            {
                return false;
            }

            if (distX <= (En / 2) || distY <= (Derinlik / 2))
            {
                return true;
            }

            double dx = distX - En / 2;
            double dy = distY - Derinlik / 2;

            if ((dx * dx + dy * dy) <= ((prizma.Uzunluk / 2) * (prizma.Uzunluk / 2)))
            {
                return true;
            }

            if ((dx * dx + dy * dy) <= ((prizma.Genislik / 2) * (prizma.Genislik / 2)))
            {
                return true;
            }

            if ((prizmaMaxX <= yuzeyX && prizmaMinX >= yuzeyX) && (prizmaMaxY <= yuzeyY && prizmaMinY >= yuzeyY))
            {
                return true;
            }

            return false;
        }



    }


}
  