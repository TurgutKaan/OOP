using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Constructors
{
    internal class Urun
    {
        // constructor (ctor) => yapıcı metotlar. Bir sınıftan instance alındığında tetiklenen metotlardır veya bir sınıftan instance almanızı sağlayan metotlardır. ctor ile sınıf isimleri aynı olmalıdır.

        // ctor'lar genelde ilk değerleri set etmek için kullanılır.

        // ctor'lar özel metotlardır, dönüş tipi belirtilmez. Bu sadece instance alındığında tetiklenen metottur.
        internal Urun() // Urun sınıfının constroctur'ı.
        {
        }

        internal Urun(decimal _fiyat, byte _stok)
        {
            Fiyat = _fiyat;
            stok = _stok;
        }

        internal decimal Fiyat;
        internal byte stok;
    }
}
