

//Generic Math


using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

var sum = SumDouble(numbers);

Console.WriteLine(sum);

Console.ReadLine();

T SumDouble<T>(IEnumerable<T> numbers) where T:INumber<T>
{
    T sum = T.Zero;

    foreach (var number in numbers)
    {
        sum += number;
    }

    return sum;
}

