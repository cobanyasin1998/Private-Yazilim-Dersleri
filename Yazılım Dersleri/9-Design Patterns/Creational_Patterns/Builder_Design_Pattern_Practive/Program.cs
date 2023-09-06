
//Mercedes
Araba mercedes = new Araba();
mercedes.KM = 1;
mercedes.Marka = "Mercedes";
mercedes.Model = "...";
mercedes.Vites = true;
//BMW
Araba bmw = new Araba();
bmw.KM = 30;
bmw.Marka = "bmw";
bmw.Model = "...";
bmw.Vites = false;



ArabaDirector director = new ArabaDirector();
Araba opel = director.Build(new OpelBuilder());

Console.WriteLine(opel.ToString());

class Araba
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public double KM { get; set; }
    public bool Vites { get; set; }
    public override string ToString()
    {
        Console.WriteLine($"{Marka} marka araba {Model} modelinde {KM} kilometrede {Vites} vites olarak üretilmiştir.");
        return base.ToString();
    }
}



#region Interface ile tasarlama


////Abstract Builder
//interface IArabaBuilder
//{
//    Araba Araba { get; }
//    IArabaBuilder SetMarka();
//    IArabaBuilder SetModel();
//    IArabaBuilder SetVites();
//    IArabaBuilder SetKM();
//}
////Concrete Builder
//class OpelBuilder : IArabaBuilder
//{
//    public OpelBuilder() => Araba = new();
//    public Araba Araba { get; }

//    public IArabaBuilder SetKM()
//    {
//        Araba.KM = 0;
//        return this;
//    }

//    public IArabaBuilder SetMarka()
//    {
//        Araba.Marka = "Opel";
//        return this;
//    }

//    public IArabaBuilder SetModel()
//    {
//        Araba.Model = "...";
//        return this;
//    }

//    public IArabaBuilder SetVites()
//    {
//        Araba.Vites = true;
//        return this;
//    }
//}
//class MercedesBuilder : IArabaBuilder
//{
//    public MercedesBuilder() => Araba = new();
//    public Araba Araba { get; }

//    public IArabaBuilder SetKM()
//    {
//        Araba.KM = 0;
//        return this;
//    }

//    public IArabaBuilder SetMarka()
//    {
//        Araba.Marka = "MERCEDES";
//        return this;
//    }

//    public IArabaBuilder SetModel()
//    {
//        Araba.Model = "...";
//        return this;
//    }

//    public IArabaBuilder SetVites()
//    {
//        Araba.Vites = true;
//        return this;
//    }
//}
//class BMWBuilder : IArabaBuilder
//{
//    public BMWBuilder() => Araba = new();
//    public Araba Araba { get; }
//    public IArabaBuilder SetKM()
//    {
//        Araba.KM = 0;
//        return this;
//    }

//    public IArabaBuilder SetMarka()
//    {
//        Araba.Marka = "BMW";
//        return this;
//    }

//    public IArabaBuilder SetModel()
//    {
//        Araba.Model = "...";
//        return this;
//    }

//    public IArabaBuilder SetVites()
//    {
//        Araba.Vites = true;
//        return this;
//    }
//}

////Director
//class ArabaDirector
//{
//    public Araba Build(IArabaBuilder arabaBuilder)
//    {
//        //arabaBuilder.SetMarka();
//        //arabaBuilder.SetModel();
//        //arabaBuilder.SetVites();
//        //arabaBuilder.SetKM();

//        arabaBuilder
//            .SetMarka()
//            .SetModel()
//            .SetVites()
//            .SetKM();

//        return arabaBuilder.Araba;
//    }
//}



#endregion


#region Abstract ile tasarlama

abstract class ArabaBuilder
{
    protected Araba araba;
    public Araba Araba { get => araba; }
    public ArabaBuilder()
        => araba = new Araba();
    public abstract ArabaBuilder SetMarka();
    public abstract ArabaBuilder SetModel();
    public abstract ArabaBuilder SetVites();
    public abstract ArabaBuilder SetKM();

}
//Concrete Builder
class OpelBuilder : ArabaBuilder
{
    public override ArabaBuilder SetKM()
    {
        araba.KM = 0;
        return this;
    }

    public override ArabaBuilder SetMarka()
    {
        araba.Marka = "Opel";
        return this;
    }

    public override ArabaBuilder SetModel()
    {
        araba.Model = "...";
        return this;
    }

    public override ArabaBuilder SetVites()
    {
        araba.Vites = true;
        return this;
    }
}
class MercedesBuilder : ArabaBuilder
{


   

    public override ArabaBuilder SetKM()
    {
        araba.KM = 0;
        return this;
    }

    public override ArabaBuilder SetMarka()
    {
        araba.Marka = "MERCEDES";
        return this;
    }

    public override ArabaBuilder SetModel()
    {
        araba.Model = "...";
        return this;
    }

    public override ArabaBuilder SetVites()
    {
        araba.Vites = true;
        return this;
    }
}
class BMWBuilder : ArabaBuilder
{


    public override ArabaBuilder SetKM()
    {
        araba.KM = 0;
        return this;
    }
    public override ArabaBuilder SetMarka()
    {
        araba.Marka = "BMW";
        return this;
    }
    public override ArabaBuilder SetModel()
    {
        araba.Model = "...";
        return this;
    }
    public override ArabaBuilder SetVites()
    {
        araba.Vites = true;
        return this;
    }
}

//Director
class ArabaDirector
{
    public Araba Build(ArabaBuilder arabaBuilder)
    {
        //arabaBuilder.SetMarka();
        //arabaBuilder.SetModel();
        //arabaBuilder.SetVites();
        //arabaBuilder.SetKM();

        arabaBuilder
            .SetMarka()
            .SetModel()
            .SetVites()
            .SetKM();

        return arabaBuilder.Araba;
    }
}
#endregion
