
//Sıralama Algoritmalari -> Bubble Sort(Baloncuk Sıralaması)

int[] numbers = { 9, 5, 7, 3, 1, 8, 6, 2, 4, 0 };
string[] names = { "Ali", "Veli", "Ayşe", "Fatma", "Hayriye", "Mehmet", "Hasan", "Hüseyin", "Hakkı", "Hülya" };

BubbleSort(numbers);

Console.WriteLine("Numbers: " + string.Join(", ", numbers));

//Space Complexity: O(1)
//Time Complexity: O(n^2)
void BubbleSort<T>(T[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (Comparer<T>.Default.Compare(array[j], array[j + 1]) > 0)
            {
                T temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;

                //yada 

                //(array[j], array[j + 1]) = (array[j + 1], array[j]);
            }
        }
    }
}
