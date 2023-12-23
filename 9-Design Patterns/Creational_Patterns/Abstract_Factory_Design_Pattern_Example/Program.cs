

//Database mssql = new();

//mssql.Connection = new();
//mssql.Connection.ConnectionString = "";

//mssql.Command = new();

//bool res = mssql.Connection.Connect();
//if (res && mssql.Connection.State == ConnectionState.Open)
//    mssql.Command.Execute("");
//mssql.Connection.Disconnect();

using System.Xml.Linq;

DatabaseCreator creator = new();
Database database = creator.Create(new OracleDatabaseFactory());
abstract class AbstractConnection
{
    public abstract string ConnectionString { get; set; }
    public abstract ConnectionState State { get; set; }
    public abstract bool Connect();
    public abstract bool Disconnect();

}
abstract class AbstractCommon
{
    public abstract void Execute(string query);
}




enum DatabaseType
{
    Oracle, Mssql, Mysql, Postresql, Mongodb
}
enum ConnectionState
{
    Open, Close
}
class Database
{
    public Database()
    {

    }

    public Database(DatabaseType type, Connection connection, Command command)
    {
        Type = type;
        Connection = connection;
        Command = command;
    }

    public DatabaseType Type { get; set; }
    public AbstractConnection Connection { get; set; }
    public AbstractCommon Command { get; set; }
}
class Connection : AbstractConnection
{

    string _connectionString;
    public Connection()
    {

    }

    public Connection(string connectionString)
    {
        _connectionString = connectionString;
    }
    public override string ConnectionString { get => _connectionString; set => _connectionString = value; }
    public override ConnectionState State { get; set; }
    public override bool Connect()
    {
        // ...
        State = ConnectionState.Open;
        return true;
    }
    public override bool Disconnect()
    {
        // ...
        State &= ~ConnectionState.Close;
        return true;
    }
}
class Command : AbstractCommon
{
    public override void Execute(string query)
    {
        //...executing...
    }
}

//Abstract Factory
abstract class DatabaseFactory
{
    public abstract AbstractConnection CreateConnection();
    public abstract AbstractCommon CreateCommon();
}
//Concrete Factory
class MSSQLDatabaseFactory : DatabaseFactory
{
    public override AbstractCommon CreateCommon()
    {
        Command command = new Command();
        return command;

    }

    public override AbstractConnection CreateConnection()
    {
        Connection connection = new Connection();
        connection.ConnectionString = "MSSQL ConnString";
        return connection;
    }
}
class OracleDatabaseFactory : DatabaseFactory
{
    public override AbstractCommon CreateCommon()
    {
        Command command = new Command();
        return command;

    }

    public override AbstractConnection CreateConnection()
    {
        Connection connection = new Connection();
        connection.ConnectionString = "Oracle ConnString";
        return connection;
    }
}
class MySqlDatabaseFactory : DatabaseFactory
{
    public override AbstractCommon CreateCommon()
    {
        Command command = new Command();
        return command;

    }

    public override AbstractConnection CreateConnection()
    {
        Connection connection = new Connection();
        connection.ConnectionString = "MySql ConnString";
        return connection;
    }
}
class PostresqlDatabaseFactory : DatabaseFactory
{
    public override AbstractCommon CreateCommon()
    {
        Command command = new Command();
        return command;

    }

    public override AbstractConnection CreateConnection()
    {
        Connection connection = new Connection();
        connection.ConnectionString = "MySql ConnString";
        return connection;
    }
}

//Creator

class DatabaseCreator
{
    AbstractConnection _connection;
    AbstractCommon _command;

    public Database Create(DatabaseFactory databaseFactory)
    {
        _connection = databaseFactory.CreateConnection();
        _command = databaseFactory.CreateCommon();

        return new Database()
        {
            Command = _command,
            Connection = _connection,
            Type = (DatabaseType)Enum.Parse(typeof(DatabaseType), databaseFactory.GetType().Name.Replace("Factory", ""))
        };
    }
}