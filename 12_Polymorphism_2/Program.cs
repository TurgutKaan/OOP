using _12_Polymorphism_2;

Console.WriteLine("---------------Abstract Üyeler------------------");

// ABSTRACT SINIFLARDA INSTANCE ALAMAZSIN!




Tufek t = new Tufek();
Tabanca ta = new Tabanca();

Silah s1 = t;

Silah s2 = ta;


Console.WriteLine("-----------------Nesne Üzerinden----------------");
t.AtesEt();
ta.AtesEt();

Console.WriteLine("-----------------Base Üzerinden-----------------");
s1.AtesEt();
s2.AtesEt();