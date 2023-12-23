
using System;

Person person1 = new Person("Yasin", "Çoban", Departmant.A, 100, 10);
Person person2 = (Person)person1.Clone();
person2.Name = "Meltem";
person2.Salary = 500;
//Person person2 = new Person("Meltem", "Çoban", Departmant.A, 500, 10);




class Person : ICloneable
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


   public object Clone()
    {
        return base.MemberwiseClone();
    }
}

enum Departmant
{
    A, B, C
}