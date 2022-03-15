using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Polymorphism
{
    public class Karga : HayvanlarAlemi
    {
        // Override => Base'den gelen ezilebilir üyeleri ezmek için kullanılır.
        public override void Ses()
        {
            Console.WriteLine("Gak Gak");
        }
    }
}
