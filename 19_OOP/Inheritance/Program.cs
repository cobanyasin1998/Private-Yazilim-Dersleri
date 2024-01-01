

Muhasebeci muhasebeci = new Muhasebeci();
muhasebeci.Adi = "Mehmet";
muhasebeci.Soyadi = "Kaya";
muhasebeci.MedeniHali = MedeniDurum.Bekar;
muhasebeci.Musavir = true;

class Personel
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public MedeniDurum MedeniHali { get; set; }
}

class Muhasebeci : Personel
{
    public bool Musavir { get; set; }
}

class Yazilimci : Personel
{
    public string[] KullandigiDiller { get; set; }
}
class Mudur : Personel
{
  
}
enum MedeniDurum
{
    Bekar = 1,
    Evli = 2
}