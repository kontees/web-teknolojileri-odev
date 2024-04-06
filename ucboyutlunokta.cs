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
    internal class ucboyutlunokta
    {

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public double MesafeHesapla3(ucboyutlunokta baskaNokta)
        {
            double mesafe = Math.Sqrt(Math.Pow(baskaNokta.X - X, 2) + Math.Pow(baskaNokta.Y - Y, 2) + Math.Pow(baskaNokta.Z - Z, 2));
            return mesafe;


        }
    }
}