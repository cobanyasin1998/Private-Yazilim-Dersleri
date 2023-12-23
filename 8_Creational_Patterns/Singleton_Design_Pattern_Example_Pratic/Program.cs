



//new Example();
//new Example();
//new Example();
//new Example();
//new Example();
//new Example();

Example ex = Example.GetInstance;
Example ex1 = Example.GetInstance;
Example ex2 = Example.GetInstance;
Example ex3 = Example.GetInstance;
Example ex4 = Example.GetInstance;
Example ex5 = Example.GetInstance;
Example ex6 = Example.GetInstance;

Console.ReadLine();


class Example
{
    private Example()
    {
        Console.WriteLine($"{nameof(Example)} nesnesi oluşturuldu.");
    }
    static Example()
    {
        _example = new Example();
    }
    static Example _example;
    public static Example GetInstance
    {
      
        get
        {
            #region 1.Yöntem
            //if (_example == null)
            //    _example = new Example();
            //return _example;
            #endregion
            #region
            return _example;
            #endregion

        }
    }

}




















