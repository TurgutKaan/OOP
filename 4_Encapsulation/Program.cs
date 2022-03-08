/*
 
Encapsulation (kapsülleme) => oop yaklaşımlarından birisidir. Bir sınıfın üyelerine (gerektiğinde) erişim kısıtlanmasıdır. (Engellenmesi veya sadece kısıtlı şekilde erişilmesidir.)
 
 */

using _4_Encapsulation;

// Öğrencinin yaşı 18'den küçük olamaz. Eğer 18'den küçük değer girilirse öğrencinin yaşı 18 kabul edilsin.

//int disardangelendeger = 15;
Ogrenci ogr = new Ogrenci();
ogr.ad = "İlyas";
ogr.SetYas(15);
Console.WriteLine(ogr.GetYas());

//if(disardangelendeger < 18)
//{
//    ogr.yas = 18;
//}
//else
//ogr.yas = disardangelendeger;

//if (ogr.yas < 18)
//{
//    ogr.yas = 18;
//}


Ogrenci ogr1 = new Ogrenci();
ogr1.ad = "Kaan";
ogr1.SetYas(24);
Console.WriteLine(ogr1.ad);
Console.WriteLine(ogr1.GetYas());

Ogrenci ogr2 = new Ogrenci();
ogr2.ad = "Tanem";
ogr2.SetYas(17);
Console.WriteLine(ogr2.GetYas());

Ogrenci ogr3 = new Ogrenci();
ogr3.ad = "Kartal";
Console.WriteLine(ogr3.GetYas()); // Yaş belirtmediğimiz (set metodu kullanmadığımız) için 0 gelir.