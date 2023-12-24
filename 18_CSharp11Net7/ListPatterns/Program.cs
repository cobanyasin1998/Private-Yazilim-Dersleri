

//List Patterns 

var dayNames = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

//Joker: _, ..(length between 0 && --)
var result = dayNames switch
{
    [] => "",
    ["Monday"] => "Only day is Monday",
    ["Monday", _] => "First day is Monday and length ==2",
    ["Monday", ..] => "First day is Monday with rest",
    [_] => "Single Item",
    _ => "Default"
};

Console.WriteLine($"Result: {result}");
Console.ReadLine();