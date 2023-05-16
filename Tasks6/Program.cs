using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Console.ReadLine();
    }

    public static void Task1()
    {
        int[] arr1 = new int[3] { 15, 10, 12 };
        int[] arr2 = new int[3];
        Array.Copy(arr1, arr2, 3);
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.WriteLine(arr2[i]);
        }

    }
    public static void Task2()
    {
        int count = 0;
        int[] arr1 = new int[3] { 1, 5, 1 };
        for (int i = 0; i < arr1.Length; i++)
        {
            count = 0;
            for (int j = 0; j < i - 1; j++)
            {
                if (arr1[i] == arr1[j])
                {
                    count++;
                }
            }
            for (int k = i + 1; k < arr1.Length; k++)
            {
                if (arr1[i] == arr1[k])
                {
                    count++;
                }
                if (arr1[i] == arr1[i + 1])
                {
                    i++;
                }
            }
            if (count == 0)
            {
                Console.Write("{0} ", arr1[i]);
            }
        }
    }
    public static void Task3()
    {
        int[] arr = { 45, 21, 25 };
        Console.WriteLine("Maximum element of array is" + " " + arr.Max());
        Console.WriteLine("Minimum element of array is" + " " + arr.Min());
    }
    public static void Task4()
    {
        int[] arr = new int[] { 25, 47, 42, 56, 32 };

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                Console.WriteLine($"Even number: {arr[i]}");
            }
            else
            {
                Console.WriteLine($"Odd number: {arr[i]}");
            }
        }
    }
    public static void Task5()
    {
        int[] arr = new int[] { 2, 7, 4, 5, 9 };
        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    public static void Task6()
    {
        int[] arr1 = new int[3] { 5, 9, 1 };
        int[] arr2 = new int[3];

        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 1 + i; j < arr1.Length; j++)
            {
                if (arr1[i] < arr1[j])
                {
                    arr2[i] = arr1[i];
                    arr1[i] = arr1[j];
                    arr1[j] = arr2[i];
                }
            }
        }
        Console.WriteLine();
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine(arr1[i]);
        }

    }
}
 

