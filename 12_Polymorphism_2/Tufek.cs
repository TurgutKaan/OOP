using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Polymorphism_2
{
    public class Tufek : Silah
    {
        // Eğer abstract üye varsa miraz alan sınıf hata verecektir. Bu hatanın önüne geçmek için base üyelerin override edilmesi gerekir. Override yazarak veya 

        public override void AtesEt()
        {
            Console.WriteLine("Tak Tak");
        }

        public override decimal Menzil()
        {
            return 500;
        }
    }
}
