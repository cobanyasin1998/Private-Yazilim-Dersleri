//Data Structures => LinkedList
using LinkedList;

CustomLinkedList<int> list = new();

list.AddFirst(1);
list.AddLast(3);
list.AddLast(new[] { 4, 5 });
list.AddMiddle(5);



Print();
Console.ReadLine();




void Print()
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }

}