

//String
string firstName = "Yasin";
string lastName = "ÇOBAN";

string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

Console.WriteLine(string.Concat(firstName, ' ', lastName));

//string.Format()

string fullName2 = string.Format("{0} {1}", firstName, lastName);

Console.WriteLine(fullName2);

//String Interpolation

string fullName3 = $"{firstName} {lastName}";
Console.WriteLine(fullName3);
string name = @" ""Yasin"" ";
//String Escape Characters

string name2 = " \"Yasin\" ";

//RawStringLiteral
string json = string.Empty;
json = $$"""
{
    "firstName": {{firstName}},
    "lastName": {{lastName}},
    "age": 25,
    "isMarried": true,
    "address": {
        "street": "123 Main St",
        "city": "Ankara",
        "state"": "TR"
    }
}
""";
Console.WriteLine(json);