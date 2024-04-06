using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class Nokta
    {
      public int X { get; set; }
      public int Y { get; set; }


        // diğer noktalar ile arasındaki mesafeyi hesaplamak için

        public double MesafeHesapla(Nokta diğerNokta)
        {
            int Xfark = this.X - diğerNokta.X;
            int yFark = this.Y - diğerNokta.Y;

            return Math.Sqrt(Xfark * Xfark + yFark * yFark);

        }


    }
}
