using _6_Property;

MusteriFormu frm = new MusteriFormu();
frm.Email = "deneme@bt.com"; // set etmek.
frm.Sikayet = "Havalar çok soğudu"; // set
frm.Adsoyad = "Kaan Turan"; // set
frm.Adsoyad = "Ders"; // set
frm.Telefon = "123456"; // set
frm.Yas = 13; // set

string s = frm.Email; // get etmek
Console.WriteLine(frm.Email); // get etmek
Console.WriteLine(frm.Sikayet); // get
Console.WriteLine(frm.Adsoyad); // get
Console.WriteLine(frm.Konu);
Console.WriteLine(frm.Telefon);
Console.WriteLine(frm.Yas);
