namespace Algorithms.ArraySort;

public static class Sort
{
    public static void SelectionSort(this int[] array)
    {
        var arrayLength = array.Length;

        for (int i = 0; i < arrayLength - 1; i++)
        {
            var smallestValueIndex = i;

            for (int j = i + 1; j < arrayLength; j++)
            {
                if (array[j] < array[smallestValueIndex])
                    smallestValueIndex = j;
            }

            (array[smallestValueIndex], array[i]) = (array[i], array[smallestValueIndex]);
        }
    }
}