

ILogger logger = new FileLogger();
logger.Log("Hello World");


interface ILogger
{
    void Log(string message);
    void Log(IEnumerable<string> messages);
}


class BufferedFileLoggerProxy : ILogger
{
    private readonly FileLogger _filelogger;
    private readonly int _bufferSize;

    private List<string> _logs;

    public BufferedFileLoggerProxy(int bufferSize)
    {
        _filelogger = new FileLogger();
        _bufferSize = bufferSize;
        _logs = new List<string>(capacity:bufferSize);
    }

    public void Log(string message)
    {
        _logs.Add(message);
        if (_logs.Count >= _bufferSize)
        {
            _filelogger.Log(_logs);
            _logs.Clear();
        }
    }

    public void Log(IEnumerable<string> messages)
    {
        _filelogger.Log(messages);
    }
}

class FileLogger : ILogger
{
    public void Log(string message)
    {
        message = $"[{DateTime.Now:dd.MM.yyyy}] - {message}";

        File.AppendAllText("message.log", message);
    }
    public void Log(IEnumerable<string> messages)
    {     

        File.AppendAllText("message.log", string.Join(Environment.NewLine, messages));
    }
}