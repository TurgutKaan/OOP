using _3_Constructors;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// value type     (değer)    => Değer tutan tipler
// reference type (referans) => Referans tutan tipler

/*
    Stack   |   Heap
-----------------------------
Value Type  |  Reference Type

*/

// instance => new ifadesi ile bir değişkene referans oluşturma işlemidir. Bellekte yeni bir alan açarsınız.

int sayi = 1;
int sonuc = sayi + 2;

int[] sayis = new int[3];
sayis[0] = 1;

// result değişkendir
int result = 5 + sayis[0];    

// ogr nesnedir
Ogrenci ogr = new Ogrenci();
ogr.adi = "Turgut";
ogr.soyadi = "Turan";
ogr.yas = 30;

Ogrenci ogr1 = new Ogrenci();
ogr1.adi = "Tanem";

Ogrenci ogr2 = ogr;
ogr2.adi = "Kaan";
ogr2.yas = 25;

Console.WriteLine(ogr.adi);
Console.WriteLine(ogr2.adi);

Urun u = new Urun();
u.Fiyat = 44;
u.stok = 100;

Urun ıı = new Urun(110, 1);
Console.WriteLine(ıı.Fiyat);

char[] ichar = { 'k', 'a', 'a', 'n' };
string str2 = new string(ichar);
Console.WriteLine(str2);

