using _5_Encapsulation;

string e = "Deneme";
string a = "Kaan T";
string s = "Deneme deneme deneme deneme";

MusteriFormu form = new MusteriFormu();
form.SetEmail(e);
form.adisoyadi = a;
form.SetSikayet(s);


MusteriFormu form1 = new MusteriFormu();
Console.WriteLine("Adınız Soyadınız");
form1.adisoyadi=Console.ReadLine();

Console.WriteLine("E mail Adresiniz");
form1.SetEmail(Console.ReadLine());

Console.WriteLine("Şikayetiniz");
form1.SetSikayet(Console.ReadLine());

MusteriFormu form2 = new MusteriFormu();
form2.SetEmail("bt@btakademi.com");
form2.SetSikayet("Havalar çok soğuk");
form2.adisoyadi = "T K T";

Console.WriteLine(form2.GetEmail());
Console.WriteLine(form2.GetSikayet());
Console.WriteLine(form2.adisoyadi);