



MyClass myClass = new MyClass();

//Bunlar Object sınıfından gelen metotlardır.
myClass.GetType();
myClass.ToString();
myClass.GetHashCode();
myClass.Equals(myClass);




Personel personel = new Personel();
personel.Ad = "Ahmet";


class MyClass : Object //Object sınıfından kalıtım aldık. Yazılmasa da olur.
{


}


class Insan
{
    public string Ad { get; set; }//Name Hiding
  
}

class Personel :Insan
{
    public new string Ad { get; set; }//Name Hiding. Bu şekilde Ad property'si Insan sınıfındaki Ad property'sini gizler. Günümüzde kullanılmaz.
    public string Soyad { get; set; }
    public int Yas { get; set; }
    public override string ToString()
    {
        return $"{Ad} {Soyad} {Yas}";
    }
}

