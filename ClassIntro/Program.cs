string adi = "Muhammed";
int yas = 22;

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Muhammed Batuhan Gültekin";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Egitmen = "Ebrar Recep Gültekin";
kurs2.IzlenmeOrani = 50;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.Egitmen = "Ömer Emirhan Gültekin";
kurs3.IzlenmeOrani = 90;

Kurs kurs4 = new Kurs();
kurs4.KursAdi = "C++";
kurs4.Egitmen = "İbrahim Gültekin";
kurs4.IzlenmeOrani = 24;



//Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
}




class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}



