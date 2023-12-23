
//Sıralama Algoritmaları - Insertion Sort (Ekleyerek Sıralama)

int[] numbers = { 9, 4, 2, 7, 3, 1, 5, 8, 6 };
string[] names = { "Ali", "Veli", "Ayşe", "Fatma", "Hayriye", "Hasan", "Hüseyin", "Hülya", "Hakkı", "Hikmet" };

InsertionSort(numbers);
InsertionSort(names);

Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine(string.Join(" ", names));

void InsertionSort<T>(T[] array) where T: IComparable
{
    for (int i = 1; i < array.Length; i++)
    {
        T temp = array[i];
        int j = i - 1;

        while (j >= 0 && array[j].CompareTo(temp) > 0)
        {
            array[j + 1] = array[j];
            j--;
        }

        array[j + 1] = temp;
    }
}
