/*
    Inheritance => OOP yaklaşımlarında kapsülleme'den sonra gelen yaklaşımdır.
Inheritance oop'nin önemli bir yaklaşımıdr. Diğer oop yaklaşımları inheritance üzerine kurgulanmıştır. Hatta bir çok yazılım prensibi ve yazılım pattern'i için de kullanılan yaklaşımdır..
   
    Inheritance ( Miras veya Kalıtım ) => Nesnelerimizi başka nesleneler de türetme işlemidir. Veya bir nesnenin özelliklerini başka bir nesneye devretme işlemidir...
    
    Inheritance c# dilindede kullanılan bir yaklaşımdır. yani c# temel konusudur. Object sınıfı buna en güzel örnektir.
    
    Miras operatörü c# dilinde :'dir. Yani miras almak istersek miras alacağımız sınıfı : ile kullanırız..
    
    Miras veren sınıflar base class olarak, Miras alan sınıflar Derived class olarak adlandırılır..
    
    Derived sınıflar base sınıflar gibi davrandığı için c# dilinde bir class sadece bir classtan türetilebilir.
 */

using _8_Inheritance;

object o; // c# dilinde herşey object sınıfından türetilmiştir.. ToString() metodu object sınıfının üyesidir. bu metoda bütün c# varlıklardan erişebiliriz..yani object bütün tiplerimizin atasıdır...

Insan i = new Insan();

Ogrenci ogr = new Ogrenci();
ogr.AdiSoyAdi = "Recep";
ogr.Cinsiyet = 'E';
ogr.BilgiGoster();
ogr.Dusunce();

Hoca hc = new Hoca();
hc.AdiSoyAdi = "Ekrem";
hc.Cinsiyet = 'E';
hc.BilgiGoster();
hc.Dusunce();

i = ogr; // ogr nesnesi i'ye atanabilir. çünkü ogr i'den türemiştir...

