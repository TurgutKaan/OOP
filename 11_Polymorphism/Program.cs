/*
        Polymorphism (Çok Biçimlilik) => Base sınıfların üyelerinin alt sınıflarda farklı davranabilmesidir.
 
 */

using _11_Polymorphism;

Console.WriteLine("--------------Vırtual Üyeler-----------------");


Kus k = new Kus();
k.Tur = "Serçe";
k.Ses(); // Cik Cik

Karga ka = new Karga();
ka.Tur = "Ak";
ka.Ses(); // Gak Gak

Console.WriteLine("--------------------");

HayvanlarAlemi[] hayvanatBahcesi = new HayvanlarAlemi[3];
hayvanatBahcesi[0] = k;
hayvanatBahcesi[1] = ka;
hayvanatBahcesi[2] = new Kedi();

foreach(HayvanlarAlemi item in hayvanatBahcesi)
{
    item.Ses(); 
}