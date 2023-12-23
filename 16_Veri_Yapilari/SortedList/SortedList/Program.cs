

//Data Structures => SortedList

using SortedList;

CustomSortedList<int, string> list = new CustomSortedList<int, string>();

list.Add(1, "one");
list.Add(2, "two");
list.Add(3, "three");
list.Add(4, "four");

list.Contains(3);
list.IndexOfValue("one");


foreach (var item in list)
{
    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
}

