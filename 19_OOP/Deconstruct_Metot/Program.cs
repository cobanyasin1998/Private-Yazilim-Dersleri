


Person person = new Person { FirstName = "Ali", Age = 25 };
var (name, age) = person;



class Person
{
    public required string FirstName { get; set; }
    public int Age { get; set; }

    public void Deconstruct(out string name, out int age)
    {
        name = FirstName;
        age = Age;
    }
}