

//Abstract Product

using System.Data;
DatabaseCreator databaseCreator = new DatabaseCreator();
databaseCreator.Create(new MySqlDatabaseFactory());








enum ConnectionState
{
    Open,Close  
}
abstract class Connection
{
    public abstract bool Connect();
    public abstract bool Disconnect();
    public abstract ConnectionState State { get; set; }
 
}
abstract class Command
{
    public abstract void Execute(string query);
}

//Concrete Product

class MsSqlConnection : Connection
{
    public override ConnectionState State { get; set; }

    public override bool Connect()
    {
        Console.WriteLine("MSSQL Connc Bağlandı");
        State = ConnectionState.Open;

        return true;
    }

    public override bool Disconnect()
    {
        Console.WriteLine("MSSQL Connc Bağlantı Koparıldı");
        State = ConnectionState.Close;
        return true;
    }
}
class MySqlConnection : Connection
{
    public override ConnectionState State { get; set; }

    public override bool Connect()
    {
        Console.WriteLine("MySQL Connc Bağlandı");
        State = ConnectionState.Open;

        return true;
    }

    public override bool Disconnect()
    {
        Console.WriteLine("MySQL Connc Bağlantı Koparıldı");
        State = ConnectionState.Close;
        return true;
    }

}
class MySqlCommand : Command
{
    public override void Execute(string query)
    {
        Console.Write(query);
    }
}
class MsSqlCommand:Command
{
    public override void Execute(string query)
    {
        Console.Write(query);
    }
}


//Abstract Factory
abstract class DatabaseFactory
{
   public abstract Connection CreateConnection();
    public abstract Command CreateCommand();
}
//Concrete Factory
class MsSqlDatabaseFactory : DatabaseFactory
{
    public override Command CreateCommand()
    {
        MsSqlCommand msSqlCommand = new MsSqlCommand();
        return msSqlCommand;
    }

    public override Connection CreateConnection()
    {
        MsSqlConnection msSqlConnection = new MsSqlConnection();
        return msSqlConnection;
    }
}

class MySqlDatabaseFactory : DatabaseFactory
{
    public override Command CreateCommand()
    {
        MySqlCommand msSqlCommand = new MySqlCommand();
        return msSqlCommand;
    }

    public override Connection CreateConnection()
    {
        MySqlConnection msSqlConnection = new MySqlConnection();
        return msSqlConnection;
    }
}


class DatabaseCreator
{
    public Database Create(DatabaseFactory databaseFactory)
    {
        return new Database()
        {
            Command = databaseFactory.CreateCommand(),
            Connection = databaseFactory.CreateConnection()
        };
    }
}

class Database
{
    public Connection Connection { get; set; }
    public Command Command { get; set; }

}
