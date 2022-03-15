using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Polymorphism
{
    public class HayvanlarAlemi
    {
        public string Tur { get; set; }

        public void Bilgileri()
        {
            Console.WriteLine(Tur);
        }

        // Virtual üyeler => Alt sınıflar tarafından gövdesi ezilebilir üyelerdir. Alt sınıflar tarafından override komutu ile ezilebilirler.
        public virtual void Ses()
        {
            Console.WriteLine("Cik Cik");
        }
    }
}
