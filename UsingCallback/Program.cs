using System;

namespace UsingCallback
{
    delegate int Compare(int a, int b);
    class Program
    {
        static int AscendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static int DescendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
                
        }

        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i=0;
            int j=0;
            int temp = 0;
            for(i=0;i<DataSet.Length-1;i++)
                for (j = 0; j < DataSet.Length - 1; j++)
                {
                    if (Comparer(DataSet[i], DataSet[j]) > 0)
                    {
                        //swap
                        temp = DataSet[i];
                        DataSet[i] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
        }
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };
            
            Console.WriteLine("Original array");
            for (int i = 0; i < array.Length - 1; i++)
                Console.WriteLine(array[i]);

            Console.WriteLine("Sorting ascending order");
            BubbleSort(array, new Compare(AscendCompare));
            for (int i = 0; i < array.Length - 1; i++)
                Console.WriteLine(array[i]);

            Console.WriteLine("\nSorting Descending order");
            BubbleSort(array, new Compare(DescendCompare));
            for (int i = 0; i < array.Length - 1; i++)
                Console.WriteLine(array[i]);

        }
    }
}
