



public class Computer
{
    public void Start()
    {
        //Start
    }
    public void Stop()
    {
        //Stop
    }
}

public class Laptop : Computer
{
    public void OpenLid()
    {
        //Kapak Aç
    }
    public void CloseLid()
    {
        //Kapak Kapat
    }
}



public class LaptopDecorator : Laptop
{
    public virtual void OpenLid()
    {
        //do something
        base.OpenLid();
    }
    public virtual void CloseLid()
    {
        //do something
        base.CloseLid();
    }
}


public class DellLaptop : LaptopDecorator
{
    public override void OpenLid()
    {
        //Do something
        base.OpenLid();
    }
    public override void CloseLid()
    {
        base.CloseLid();
    }

}
public class AppleLaptop : LaptopDecorator
{
    public void OpenLid()
    {
        //do something
        base.OpenLid();
    }
    public void CloseLid()
    {
        //do something
        base.CloseLid();
    }

}