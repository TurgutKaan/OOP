using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Polymorphism_2
{
    public abstract class Silah
    {
   // Abstract üyeler => Gövdesi alt sınıflar tarafından tanımlanan metotlardır. Yani abstract üyelerin gövdeleri olmaz.

        // Virtual üyeler => Gövdeleri base ve alt sınıflar tarafından tanımlanır. Gövde tanımlanmak zorunludur.

        // Abstract üyeler alt sınıflar tarafından ezilmek zorundador.
        // Virtual üyelerde böyle bir zorunluluk yoktur. Override ile çağırırsan ezersin çağırmazsan ezmezsin.

        // Virtual üyeler bütün sınıflarda yazılabilir.
        // Abstract üyeler sadece abstract class'larda yazılabilir.
        // Virtual üyeler bütün sınıflarda yazılabilir.
        public abstract void AtesEt();
        public abstract decimal Menzil();

        public void Deneme()
        {

        }
        public string temp { get; set; }

    }
}
