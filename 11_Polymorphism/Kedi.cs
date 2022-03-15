using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Polymorphism
{
    public class Kedi : HayvanlarAlemi
    {
        // Eğer override yazarsanız base'den gelen ezilebilir üyeleri görürsünüz.
        public override void Ses()
        {
            //base.Ses(); Base;HayvanlarAlemi Ses;Cik Cik otomatik geliyor bu kısım. aşağıdaki gibi yazıyoruz.
            Console.WriteLine("Miyav");
        }
    }
}
