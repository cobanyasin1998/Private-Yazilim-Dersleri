
// Init only properties

MyClass myClass = new MyClass()
{
    //MyProperty = 3 // Error
    MyProperty1 = 3 // OK //Init only property
};
MyClass myClass2 = new MyClass()
{
    //MyProperty = 3 // Error
    MyProperty1 = 3 // OK //Init only property
};
//myClass.MyProperty1 = 4; // Error

Console.WriteLine(myClass.Equals(myClass2));// False

//Records

Person person1 = new() { FirstName = "John", LastName = "Doe" };
Person person2 = new() { FirstName = "John", LastName = "Doe" };


Console.WriteLine(person1.Equals(person2));  // True




//With Expression

Person person3 = person1 with { FirstName = "Jane" };





class MyClass
{
    public int MyProperty { get; } = 3;
    public int MyProperty1 { get; init; }
}




public record Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
}



/*
 Önemli Not


+Class'lar da verisel olarak nesne ön plandadır ve bir farklı referansa sahip olan nesne farklı değer olarak algılanmaktadır.
+Dolayısıyla Equals metodu ile karşılaştırıldığında false dönmektedir.
 
 

+Record'lar da ise veri ön plandadır ve bir farklı referansa sahip olan nesne aynı değer olarak algılanmaktadır.
+Dolayısıyla Equals metodu ile karşılaştırıldığında true dönmektedir.
 */


