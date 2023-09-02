




using System.Collections.Generic;


var msSql = Database.GetInstance("MSSQL");
msSql.ConnectionString("asd");

msSql.Connection();
var oracle = Database.GetInstance("Oracle");
var mongoDB = Database.GetInstance("MongoDB");

var msSql2 = Database.GetInstance("MSSQL");
var oracle2 = Database.GetInstance("Oracle");
var mongoDB2 = Database.GetInstance("MongoDB");
class Database
{
    private Database()
    {
        Console.WriteLine($"{nameof(Database)} nesnesi üretildi.");
    }


    static Dictionary<string, Database> _databases = new Dictionary<string, Database>();

    public static Database GetInstance(string key)
    {
        if (!_databases.ContainsKey(key)) {
            _databases[key] = new Database(); 
        }
        
        return _databases[key];
    }

    public void Connection()
    {
        Console.WriteLine("Connected");
    }
    public void DisConnect()
    {
        Console.WriteLine("Disconnect");

    }
    public void ConnectionString(string connString)
    {
        //
    }

}






