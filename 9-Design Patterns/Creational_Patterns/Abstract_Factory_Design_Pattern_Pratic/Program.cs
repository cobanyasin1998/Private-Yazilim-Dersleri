

ComputerCreator creater = new();

Computer asus = creater.CreateComputer(ComputerType.Asus);
Computer TOSHİBA = creater.CreateComputer(ComputerType.Toshiba);

class Computer
{
    public Computer()
    {

    }

    public Computer(CPU cPU, RAM rAM, VideoCard videoCard)
    {
        CPU = cPU;
        RAM = rAM;
        VideoCard = videoCard;
    }

    public CPU CPU { get; set; }
    public RAM RAM { get; set; }
    public VideoCard VideoCard { get; set; }

}

#region Abstract Products
interface ICPU { }
interface IRAM { }
interface IVideoCard { }
#endregion

#region Concrete Products
class CPU : ICPU
{
    public CPU(string text)
    {
        Console.WriteLine(text);
    }
}
class RAM : IRAM
{
    public RAM(string text)
    {
        Console.WriteLine(text);
    }
}
class VideoCard : IVideoCard
{
    public VideoCard(string text)
    {
        Console.WriteLine(text);
    }
}
#endregion

#region Abstract Factory

interface IComputerFactory
{
    ICPU CreateCPU();
    IRAM CreateRAM();
    IVideoCard CreateVideoCard();
}
#endregion


#region Concrete Factories
class AsusFactory : IComputerFactory
{
    public ICPU CreateCPU()
    => new CPU("Asus CPU Üretildi");

    public IRAM CreateRAM()
   => new RAM("Asus RAM Üretildi");

    public IVideoCard CreateVideoCard()
  => new VideoCard("Asus VideoCard Üretildi");

}
class ToshibaFactory : IComputerFactory
{
    public ICPU CreateCPU()
    => new CPU("Toshiba CPU Üretildi");

    public IRAM CreateRAM()
   => new RAM("Toshiba RAM Üretildi");

    public IVideoCard CreateVideoCard()
  => new VideoCard("Toshiba VideoCard Üretildi");

}

#endregion
#region Creator
public enum ComputerType
{
    Asus,Toshiba
}
class ComputerCreator
{
    ICPU _cpu;
    IRAM _ram;
    IVideoCard _videoCard;

    public Computer CreateComputer(ComputerType computerType)
    {
        IComputerFactory _computerFactory = computerType switch
        {
            ComputerType.Asus => new AsusFactory(),
            ComputerType.Toshiba => new ToshibaFactory(),
        };

      

        _cpu = _computerFactory.CreateCPU();
        _ram = _computerFactory.CreateRAM();
        _videoCard = _computerFactory.CreateVideoCard();

        return new Computer(_cpu as CPU, _ram as RAM, _videoCard as VideoCard);
    }
}

#endregion







