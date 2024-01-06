interface IArea
{
    double Calculate();
}
interface IPerimeter
{
    double Calculate();
}
class Calculator : IArea, IPerimeter
{
    //Explicit interface member implementation:
    double IPerimeter.Calculate()
    {
        return 0;
    }

    double IArea.Calculate()
    {
        return 0;
    }
}

//Default interface implementation:C# 8.0
interface IAreaa
{
    double Calculate()
    {
        return 0;
    }
}
class Calculatorr : IAreaa
{
    //No need to implement Calculate() method
}