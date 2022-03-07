class Program
{
    static void Main()
    {

        Console.WriteLine("Merhaba OOP");
        /*
         OOP (Object Oriented Programming) - (Nesne Yönelimli Programlama)

        - Mantıksal işlemler yerine modelleme yaklaşımıdır.
        - Bir defa yazıp sürekli kullanma mantığıdır.

        Yazılım literatüründe her şey bir varlıktır. (Entity)
        OOP günlük hayattaki varlıkları yazılım ortamında modellemeyi sağlar.

        Bir e ticaret sitesinin sanal kart entegrasyonunu düşünelim...
        (KartNo, SonKullanımTarihi, AdiSoyadi, GüvenlikKodu)
        Bir üniversitenin öğrenci otomasyonu geliştiriliyor, Ortalama hesaplama modülünü düşünelim.
        (DersAdi, OgrenciAdiSoyadi, Vize, Final)
        Kütüphane otomasyonu, 
        (KitapBilgileri, AlisTarihi, TeslimTarihi)

        OOOP'nin ilkeleri/yaklaşımları;
        1) Encapsulation (Kapsülleme)
        2) Abstraction (Soyutlama)
        3) Inheritence (Miras)
        4) Poliymorphism (Çok biçimlilik)

        * Class OOP'nin en temel taşıdır.
        * Class => Nesne üretmek için kullanılan yapı. (Birden fazla değişkeni farklı tipler ile bir arada tutan çatı)
        * Class'lar günlük hayattaki varlıkları modellediğimiz yapılardır. Class eklemek için solutiondaki projeye sağ tıklayıp add class diyerek yeni bir class ekleyebiliriz. Oluşturulacak class'lara mantıklı bir isim vermekte fayda var. Aslında class'lar kendimize ait oluşturduğumuz tiplerimizdir. Bu tipleri değişkenlerde de kullanırız. Bu değişkenlere nesne deriz.
         */

        // (Class)[soyut varlıklar]

        // (Nesne)[somut varlıklar]

        string ogrenciAdi = "Kaan", soyadi = "Turan";
        int yas = 30;

        string ogrenciAdi1 = "Hakan", soyadi1 = "Turan";
        int yas1 = 60;

        // new Ogrenci() ifadesi ile ogr nesnesi oluştururuz. Bu nesne bellekte kullanılabilir yeni bir nesnedir. (Instance almak)

        //Ogrenci oluşturduğumuz Class.
        // ogr ve/veya ogr1 bizim nesnemizdir.
        Ogrenci ogr=new Ogrenci();
        ogr.adi = "Kaan";
        ogr.soyadi = "Turan";
        ogr.yas = 30;

        Ogrenci ogr1 = new Ogrenci();//ogr1 nesnesi oluşturur.
        ogr1.adi = "Hakan";
        ogr1.soyadi = "Turan";
        ogr1.yas = 60;



    }
}