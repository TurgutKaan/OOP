using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_Class
{
    internal class Ogrenci
    {
        //Sınıfları oluşturan yapılara class members(sınıf üyeleri denir.)
        // field => class'ların alanlarıdır. Veriler bu üyelerde saklanır. Örneğin ogrenciAdi, urunfiyati vb...
        // property => özel bir konudur. field veya method yerine kullanılabilir. (Encapsulation konusunda detaylandıracağız.)
        // method => class içerisinde yazdığımız programlarımız. OgrenciKaydi, DiziElemanSıralaması vb...
        internal string adisoyadi;
        internal float vize;
        internal float final;

        //geriye float dönen method

        // NOT: class üyeleri class seviyesinde erişilemez. Sadece üye içerisinden erişilebilir.
        // internal float ortalama = vize;
        internal float ortalama()
        {
            return vize * 0.4f + final * 0.6f;
        }
    }
}
