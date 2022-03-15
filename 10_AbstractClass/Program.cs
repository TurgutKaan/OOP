/*
    Soyutlama => Nesnelerin soyutlanmasıdır.

    Abstract Class => Soyut sınıf. Sadece miraz vermek için kullanılır.

 */

using _10_AbstractClass;

Telefon tl = new Telefon();
tl.Marka = "Iphone";
tl.Fiyat = 15000;
tl.Model = "XR";
// tl.Kdv = 8;  Read Only property.

TV tv = new TV();
tv.Marka = "Samsung";
tv.Model = "S22";
tv.Fiyat = 8000;

//Urun u = new Urun(); instance alamıyoruz çünkü Urun sınıfı abstract sınıfıdır.

int a = 1;
Urun[] urunSepeti = new Urun[3]; 
//urunSepeti[0] = new Urun(); urunden instance alınmaz.
urunSepeti[0] = tl;
urunSepeti[1] = tv;
urunSepeti[2] = new Telefon();
urunSepeti[2].Marka = "Samsung";
urunSepeti[2].Model = "Galaxy";
urunSepeti[2].Fiyat = 5000;

foreach(Urun item in urunSepeti)
{
    if(item is TV)
    {
        TV tempNesne = (TV)item;
        tempNesne.KdvHesapla();
    }
    else if(item is Telefon)
    {
        Telefon temp = (Telefon)item;
        temp.KdvHesapla();
    }
    
    Console.WriteLine($"{item.Marka} {item.Model} {item.Fiyat} {item.KdvliFiyat}");
}
