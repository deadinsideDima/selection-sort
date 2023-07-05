using System;

// ReSharper disable InconsistentNaming
namespace SelectionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with selection sort algorithm.
        /// </summary>
        public static void SelectionSort(this int[]? array)
        {
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < array[i])
                        {
                            int min_value = array[j];
                            array[j] = array[i];
                            array[i] = min_value;
                        }
                    }
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(array));
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive selection sort algorithm.
        /// </summary>
        public static void RecursiveSelectionSort(this int[]? array)
        {
            SelectionSort(array);
        }
    }
}
