﻿using System.Globalization;
using System.Runtime;

internal class Program
{
    private static void Main(string[] args)
    {
        //Task1();
        //Task2();
        //Task3();
        //Task4();
        //Task5();
        //Task6();
        //Task7();
        //Task8();
        //Task9();
        //Task10();
        Task11();
        //Task12();
        //Task13();
        //Task14();
        //Task15();
        //Task16();
        //Task17();
        //Task18();
        //Task19();
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
        int count;
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
        int[] arr = new int[5] { 2, 7, 4, 5, 9 };
        int[] arr2 = new int[5];
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[i])
                {
                    arr2[i] = arr[i];
                    arr[i] = arr[j];
                    arr[j] = arr2[i];
                }
            }
        }
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
    public static void Task7()
    {
        int max1, max2;
        Console.Write("Enter size of array: ");
        int x = int.Parse(Console.ReadLine());
        int[] arr = new int[x];
        for (int i = 0; i < x; i++)
        {
            Console.Write($"element - {i}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        if (arr[1] > arr[0])
        {
            max1 = arr[1];
            max2 = arr[0];
        }
        else
        {
            max2 = arr[1];
            max1 = arr[0];
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max1)
            {
                max2 = max1;
                max1 = arr[i];
            }
            else
            {
                max2 = arr[i];
            }
        }
        Console.WriteLine("The First largest element in the array is: " + max1);
        Console.WriteLine("The Second largest element in the array is: " + max2);

    }
    public static void Task8()
    {
        int min1, min2;
        Console.Write("Enter size of array: ");
        int x = int.Parse(Console.ReadLine());
        int[] arr = new int[x];
        for (int i = 0; i < x; i++)
        {
            Console.Write($"element - {i}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        if (arr[0] < arr[1])
        {
            min1 = arr[0];
            min2 = arr[1];
        }
        else
        {
            min2 = arr[0];
            min1 = arr[1];
        }
        for (int i = 2; i < arr.Length; i++)
        {
            if (arr[i] < min1)
            {
                min2 = min1;
                min1 = arr[i];
            }
            else if (arr[i] < min2)
            {
                min2 = arr[i];

            }
        }
        Console.WriteLine("The First smallest  element in the array is: " + min1);
        Console.WriteLine("The Second smallest  element in the array is: " + min2);
    }
    public static void Task9()
    {
        int[,] arr1 = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("element - [{0},{1}] : ", i, j);
                arr1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("The matrix: ");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("\n");
            for (int j = 0; j < 3; j++)
                Console.Write("{0}\t", arr1[i, j]);
        }
        Console.Write("\n\n");
    }
    public static void Task10()
    {
        int[,] arr1 = new int[50, 50];
        int[,] arr2 = new int[50, 50];
        int[,] arr3 = new int[50, 50];
        Console.Write("Enter size of first array: ");
        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("element - [{0},{1}] : ", i, j);
                arr1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("Enter size of second array: ");
        x = int.Parse(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("element - [{0},{1}] : ", i, j);
                arr2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("The First matrix is : ");
        for (int i = 0; i < x; i++)
        {
            Console.Write("\n");
            for (int j = 0; j < x; j++)
                Console.Write("{0}\t", arr1[i, j]);
        }

        Console.Write("\nThe Second matrix is :\n");
        for (int i = 0; i < x; i++)
        {
            Console.Write("\n");
            for (int j = 0; j < x; j++)
                Console.Write("{0}\t", arr2[i, j]);
        }
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                arr3[i, j] = arr1[i, j] + arr2[i, j];
            }
        }
        Console.Write("\nThe Sum of two matrix is : \n");
        for (int i = 0; i < x; i++)
        {
            Console.Write("\n");
            for (int j = 0; j < x; j++)
                Console.Write("{0}\t", arr3[i, j]);
        }
        Console.Write("\n\n");

    }
    public static void Task11()
    {
        int[,] arr = new int[255, 255];
        Console.WriteLine("Enter rows size of matrix: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter columns size of matrix: ");
        int columns = int.Parse(Console.ReadLine());
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("element - [{0},{1}] : ", i, j);
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("The matrix is: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("The Transpose of a matrix is: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(arr[j, i]);
            }
            Console.WriteLine();
        }
    }
    public static void Task12()
    {
        int sum = 0;
        int[,] arr = new int[2, 2];
        Console.WriteLine("Enter rows size of matrix: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter columns size of matrix: ");
        int columns = int.Parse(Console.ReadLine());
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("element - [{0},{1}] : ", i, j);
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
                if (i == j)
                {
                    sum += arr[i, j];
                }
            }
        }
        Console.WriteLine("The matrix is: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Addition of the right Diagonal elements is: " + sum);
    }
    public static void Task13()
    {
        int sum = 0;
        int[,] arr = new int[2, 2];
        Console.WriteLine("Enter rows size of matrix: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter columns size of matrix: ");
        int columns = int.Parse(Console.ReadLine());
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("element - [{0},{1}] : ", i, j);
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("The matrix is: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
        }
        if (rows == columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == j)
                    {
                        sum += arr[j, i];
                    }
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("Addition of the left Diagonal elements is: " + sum);
    }
    public static void Task14()
    {
        int[,] arr = new int[10, 10];
        int[] rowsum = new int[10];
        int[] colsum = new int[10];
        Console.Write("Input the size of the matrix : ");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write($"element - {i},{j}: ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("The matrix: ");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
        }
        for (int i = 0; i < x; i++)
        {
            rowsum[i] = 0;
            for (int j = 0; j < x; j++)
                rowsum[i] += arr[i, j];
        }
        for (int i = 0; i < x; i++)
        {
            colsum[i] = 0;
            for (int j = 0; j < x; j++)
                colsum[i] += arr[j, i];
        }
        Console.Write("The sum of row and column of the matrix :\n");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
                Console.Write("{0} ", arr[i, j]);
            Console.Write("{0}", rowsum[i]);
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int j = 0; j < x; j++)
        {
            Console.Write("{0}   ", colsum[j]);
        }
    }
    public static void Task15()
    {
        int[,] arr = new int[10, 10];
        Console.Write("Input the size of the matrix : ");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write($"element - {i},{j}: ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("The matrix: ");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
        }
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < x; j++)
            {
                if (i >= j)
                {
                    Console.Write(arr[i, j]);
                }
                else
                {
                    Console.Write("");
                }
            }
        }
    }
    public static void Task16()
    {
        int[,] arr = new int[10, 10];
        Console.Write("Input the size of the matrix : ");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write($"element - {i},{j}: ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("The matrix: ");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
        }
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < x; j++)
            {
                if (i <= j)
                {
                    Console.Write(arr[i, j]);
                }
                else
                {
                    Console.Write("");
                }
            }
        }
    }
    public static void Task17()
    {
        int[,] arr1 = new int[10, 10];
        int[,] arr2 = new int[10, 10];

        Console.Write("Input size of first matrix: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Input size of second matrix: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("First matrix");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write($"element - {i},{j}: ");
                arr1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write(arr1[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Second matrix");
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write($"element - {i},{j}: ");
                arr2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write(arr2[i, j]);
            }
            Console.WriteLine();
        }
        bool b = true;
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                if (arr1[i, j] == arr2[i, j])
                {
                    b = true;
                }
                else
                {
                    b = false;

                }
            }
        }
        if (b)
        {
            Console.WriteLine("Matrices are equal");
        }
        else
        {
            Console.WriteLine("Matrices are not equal");

        }
    }
    public static void Task18()
    {
        Console.Write("Enter size of array: ");
        int x = int.Parse(Console.ReadLine());
        int[] arr = new int[x];
        for (int i = 0; i < x; i++)
        {
            Console.Write($"element - {i}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 1)
            {
                Console.Write($"Odd numbers are {arr[i]}");
            }
        }
    }
    public static void Task19()
    {
        object[] obj1 = new object[8];
        obj1[0] = 25;
        obj1[1] = "Anna";
        obj1[2] = false;
        obj1[3] = 25;
        obj1[4] = "4 / 15 / 2021 12:10:51 PM";
        obj1[5] = 112.22;
        obj1[6] = "Anna";
        obj1[7] = false;

        object [] obj2= obj1.Distinct().ToArray();
        for (int i = 0; i < obj2.Length; i++)
        {
            Console.WriteLine(obj2[i]);
        }

    }
}