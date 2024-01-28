namespace SortingAlgorithms;

public class MergeSort
{
    // O(nlogn) - Time
    // O(n) - Space
    public static void Sort(int[] array)
    {
        int length = array.Length;
        if (length <= 1) return;
        int middle = length / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[length - middle];

        int i = 0;
        int j = 0;
        for (; i < length; i++)
        {
            if (i < middle)
            {
                leftArray[i] = array[i];
            }
            else
            {
                rightArray[j] = array[i];
                j++;
            }
        }

        Sort(leftArray);
        Sort(rightArray);
        Merge(leftArray, rightArray, array);
    }

    private static void Merge(int[] leftArray, int[] rightArray, int[] array)
    {
        int leftSize = array.Length / 2;
        int rightSize = array.Length - leftSize;
        int i = 0, l = 0, r = 0;
        while (l < leftSize && r < rightSize)
        {
            if (leftArray[l] < rightArray[r])
            {
                array[i] = leftArray[l];
                i++;
                l++;
            }
            else
            {
                array[i] = rightArray[r];
                i++;
                r++;
            }
        }

        while (l < leftSize)
        {
            array[i] = leftArray[l];
            i++;
            l++;
        }

        while (r < rightSize)
        {
            array[i] = rightArray[r];
            i++;
            r++;
        }
    }
}