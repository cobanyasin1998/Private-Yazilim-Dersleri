




ExampleArray exampleArray = new();
var maxElement = exampleArray.MaxArrayElement();
var minElement = exampleArray.MinArrayElement();
var aritmetikMeanElement = exampleArray.ArithmeticMeanElement();
var standartSapma = exampleArray.StandartSapma();

Console.WriteLine(maxElement);
Console.WriteLine(minElement);
Console.WriteLine(aritmetikMeanElement);
Console.WriteLine(standartSapma);





class ExampleArray
{
    public ExampleArray()
    {
        Numbers = new int[] { 485, 5000, 1, 2, 3, 66, 88, 99, 1000, 1001, 55 };
    }
    public int[] Numbers { get; set; }

    public int MaxArrayElement()
    {
        int result = Numbers[0];

        foreach (var number in Numbers)
        {
            if (number > result)
            {
                result = number;
            }
        }
        return result;
    }
    public int MinArrayElement()
    {
        int result = Numbers[0];

        foreach (var number in Numbers)
        {
            if (number < result)
            {
                result = number;
            }
        }
        return result;
    }
    public int ArithmeticMeanElement()
    {
        int result = 0;

        foreach (var number in Numbers)
        {
            result += number;
        }
        return result;
    }
    public double StandartSapma()
    {
        double aritmetikOrtalama = this.ArithmeticMeanElement();
        double t = 0, f = 0;
        for (int i = 0; i < Numbers.Length; i++)
        {
            f = Numbers[i] - aritmetikOrtalama;
            t += Math.Pow(f, 2);
        }
        return Math.Sqrt(t / (Numbers.Length - 1));

    }
}


