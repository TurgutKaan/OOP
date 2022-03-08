using _1_1_Class; // Namespace => dosyamızda kullanacağımız komutun genel adıdır. C# dilinde bütün komutlar namespace'ler içerisindedir. Namespace'leri solution gibi düşünebiliriz.

//Öğrenci
// ogr => Ogrenci tipinde bir nesne

//Ogrenci ogr => Ogrenci tipinde ogr değişkeni (nesne)
//new Ogrenci() => ogr'ye bllekte yeni bir referans açar. Bütün alanlar ogr'ye bağlıdır.
Ogrenci ogr = new Ogrenci();
ogr.adisoyadi = "Kaan";
ogr.vize = 50;
ogr.final = 70;

Console.WriteLine($"{ogr.adisoyadi} {ogr.ortalama()}");

Ogrenci ogr2 = new Ogrenci();
ogr2.vize = 90;
ogr2.final = 60;
ogr2.adisoyadi = "Turgut";

Console.WriteLine($"{ogr2.adisoyadi} {ogr2.ortalama()}");

Ogrenci ogr3 = new Ogrenci();
ogr3.vize = 30;
ogr3.final = 100;
ogr3.adisoyadi = "Tanem";

Console.WriteLine($"{ogr3.adisoyadi} {ogr3.ortalama()}");

