namespace SortingAlgorithms;

class Program
{
    static void Main()
    {
        int[] numbers = new[] { 12, 5, 6, 8, 29, 17 };
        //Call any sorting algorith here. For Ex:
        MergeSort.Sort(numbers);
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        
    }
    
    //O(n^2) - Time
    //O(1) - Space
    private static void BubbleSort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }
    }
}
