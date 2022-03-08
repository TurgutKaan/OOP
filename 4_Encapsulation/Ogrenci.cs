using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Encapsulation
{
    // bir sınıf sadece internal veya public tanımlanabilir. (NOT: Bundan sonra bütün sınıflarımızı public olarak kullanacağız.) Sınıfların default erişim seviyeleri internal'dır.
    // üyelerin default erişim seviyesi private'tır.
    internal class Ogrenci
    {
        //private üyeler sınıf scope'ları dışından erişilemez.

        internal string ad;
        //internal int yas;

        //kapsüllenecek üye sınıf dışına kapatılır. Bir üyenin sınıf dışına kapatılması için erişim seviyesi private olmalıdır.

        private int yas;

        // eğer kapsüllenen alana değer dışarıdan atanacaksa setter metot yazılır. Setter metorlar üyelere değer atamak için kullanılır.

        internal void SetYas(int _yas)
        {
            if(_yas >= 18)
            {
                yas = _yas;
            }
            else
            {
                yas = 18;
            }
            
        }
        internal int GetYas()
        {
            return yas;
        }

        //NOT: üyelerin default erişim seviyesi private'tır.
        string adres;
    }

    /*
        access modifiers (erişim belirticiler) => Proje içerisindeki objelerimizin erişim seviyesini belirlemek için kullanılır.
    private    => (class üyeleri için kullanılır, sadece class scope'ları içerisinde erişilebilir.
    protected  => (class üyeleri için kullanılır, sadece class ve class'tan türeyecek üyeler için kullanılır. (inheritance konusunda değinilecek)
    internal   => her şey için kullanılır, sadece proje içerisinden erişilebilir.
    protected internal => protected ve internal karışımıdır.
    public     => heryerden erişmek için kullanılır.

     */
}
