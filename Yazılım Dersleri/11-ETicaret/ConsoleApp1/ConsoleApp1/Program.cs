using System;

class MainClass
{

    public static string StringChallenge(string str)
    {

        if (string.IsNullOrWhiteSpace(str))
        {
            return "Error. Input is null";
        }

        string[] times = str.Split("-");


        HashSet<DateTime> result = new HashSet<DateTime>();
      


        foreach (string s in times)
        {
            bool isTime = DateTime.TryParse(s, out var t);
            if (isTime)
            {
                result.Add(t);
            }
            else
            {
                return $"Time Format Error: {s}";
             
            }

        }

       var data =  (result.Max() - result.Min().AddHours(12)).Minutes;



        return data.ToString();

    }

    static void Main()
    {

        // keep this function call here
        Console.WriteLine(StringChallenge("1:23am-1:08am"));

    }

}