using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Property
{
    internal class MusteriFormu
    {
        // Veriler sınıflarda field'larda saklanır. Bu yüzden field'lar sınıfların en önemli üyeleridir.

        // Metotlar sınıflar içerisindeki altprogramlarımız veya üyelere erişim için kullanılan program bloklarıdır.

        // Property => Hem field hem de method yerine kullanılabilen yapılardır. Özellikle field'lara erişim söz konusu ise property kullanırız.

        /*
         
        erisimSeviye veriTipi PropertyAd
        {
            set; // değer atamak için.
            get; // değer okumak için
        }

        // Property içerisindeki set parametre, alan void methodu, get geriye değer donustipli methodu ifade eder. Propery tipi parametrenin get methodunun donustipini belirler.
         
         */

        private string email;

        internal string Email
        {
            set // setter methos
            {
                if (value.Contains("@"))
                {
                    if (value.Contains("."))
                        email = value;
                }
                else
                    throw new Exception("Geçersiz Email Adresi");
            }

            get // getter method
            {
                return email;
            }
        }

        private string sikayet;
        internal string Sikayet 
        {
            get 
            { 
                return sikayet; 
            }
            set
            { 
                if(value.Length > 10)
                    sikayet = value.Substring(0,10);
                else
                    sikayet = value;
            }
        }

        // kısıtlaması olmayan bir field
        private string adsoyad;
        internal string Adsoyad
        {
            set { adsoyad = value; }
            get { return adsoyad; }
        }

        // Eğer field'lar kapsüllenmeyecekse property'ler field yerine tanımlanabilir ve kullanılabilir. Property'lerde get ve set bloğu ezilmezse (açılmazsa) gizli bir field kullanılır.

        internal string Konu { get; set; } // konu property's, bizde görmediğimiz ancak çalışma zamanında oluşan gizli bir field'i işaret ederler.

        internal string Telefon { get; set; }

        internal int Yas { get; set; }

    }
}
