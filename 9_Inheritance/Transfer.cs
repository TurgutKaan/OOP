using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Inheritance
{
    // SOLİD Prensibleri;
    // todo : S => Single Responsibility prensibi araştırınız.. githuba örnek proje ile ekleyiniz..
    // todo : Poliymorphisim (Çok biçimlilik), Soyutlama (Abstract)
    internal class Transfer
    {
        public void ParaGonder(OdemeIslemi transfer)
        {
            if (transfer is EftIslemi) // transger'in tipi EftIslemi mi?
            {
                EftIslemi eft = (EftIslemi)transfer;
                //EftIslemi eft = transfer as EftIslemi; // transferi (referansı) EftIslemi olarak döndür.
                eft.IslemYap();
            }
            else if (transfer is HavaleIslemi) // transfer Havale mi?
            {
                HavaleIslemi hvl = (HavaleIslemi)transfer;
                hvl.IslemYap();
            }
        }
    }
}
