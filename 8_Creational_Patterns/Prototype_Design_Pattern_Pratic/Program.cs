
Person person1 = new Person("Yasin", "Çoban", Departmant.A, 100, 10);
Person person2 = person1.Clone();
person2.Name = "Meltem";
person2.Salary = 500;
//Person person2 = new Person("Meltem", "Çoban", Departmant.A, 500, 10);

//Abstract Prototype
interface IPersonClonable
{
    Person Clone();
}

//Concrete Prototype

class Person : IPersonClonable
{
    public Person(string name, string surname, Departmant departmant, int salary, int premium)
    {
        Name = name;
        Surname = surname;
        Departmant = departmant;
        Salary = salary;
        Premium = premium;
        Console.WriteLine("Person nesnesi üretildi");

    }
    public string Name { get; set; }
    public string Surname { get; set; }
    public Departmant Departmant { get; set; }
    public int Salary { get; set; }
    public int Premium { get; set; }

    public Person Clone()
    {
        return (Person)base.MemberwiseClone();
    }
}

enum Departmant
{
    A, B, C
}