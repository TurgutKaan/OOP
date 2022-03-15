using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AbstractClass
{
    // abstract class => Soyut sınıf. Soyut sadece miraz veren sınıflardır. Abstract class'lardan instance alınmaz.
    public abstract class Urun
    {
        // Protected => Sınıf içerisinden ve miras alan sınıflardan erişilebilir.
        public decimal KdvliFiyat { get; protected set; }
        public string Marka { get; set; }

        public string Model { get; set; }

        public int Fiyat { get; set; }

        protected int Demo { get; set; }
    }
}
