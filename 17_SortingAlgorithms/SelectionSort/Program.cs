
// Sıralama Algoritmaları - Selection Sort (Seçerek Sıralama)


int[] numbers = { 9, 4, 2, 7, 3, 1, 5, 8, 6 };
string[] names = { "Ali", "Veli", "Ayşe", "Fatma", "Hayriye", "Hasan", "Hüseyin", "Hülya", "Hakkı", "Hikmet" };
SelectionSort(numbers);
SelectionSort(names);
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine(string.Join(" ", names));
void SelectionSort<T>(T[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minIndex = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (Comparer<T>.Default.Compare(array[j], array[minIndex]) < 0)
            {
                minIndex = j;
            }
        }

        if (minIndex != i)
        {
            T temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
    }
}