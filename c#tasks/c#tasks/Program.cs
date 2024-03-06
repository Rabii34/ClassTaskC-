// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//ARRAY
//Console.WriteLine("ARRAY");
using System.ComponentModel;

int[] num = new int[14];
num[0] = 1;
num[1] = 3;
num[2] = 42;
num[3] = 20;
num[4] = 97;
num[5] = 65;
num[6] = 88;
num[7] = 43;
num[8] = 64;
num[9] = 20;
num[10] = 12;
num[11] = 48;
num[12] = 24;
num[13] = 38;

//Q1:Find the sum of all the integers in the array.
//int arr = 0;
//for (int i = 0; i < num.Length; i++)
//{
//    Console.WriteLine(num[i]);
//    arr =arr+ num[i];

//}
//Console.WriteLine($"The sum of all integers are:{arr} ");

//Q2:Find the maximum and minimum values in the array.
////Min VALUE
//Console.WriteLine("MINIMUM VALUE");
//int min = num.Min();
//Console.WriteLine($"The minimun value in the array is:{min}");
//MAX VALUE
//Console.WriteLine("MAXIMUM VALUE");
//int max = num.Max();
//Console.WriteLine($"The maximum value in the array is:{max}");

//Q3:Count the number of even and odd integers in the array.
//int array = num.GetLength(0);
//int even = 0;
//int odd = 0;
//for (int j = 0; j < array; j++)
//{
//    if (num[j] % 2 == 0)
//    {
//        even++;
//    }
//    else
//    {
//        odd++;
//    }
//}
//Console.WriteLine("Sum of even numbers in array");
//    Console.WriteLine($"The sum of even is:{even}");
//Console.WriteLine("Sum of odd numbers in array");
//Console.WriteLine($"The sum of odd is:{odd}");

//Q4:Calculate the average of all the integers in the array.
//int sum = 0;
//for (int i = 0; i < num.Length; i++)
//{

//    sum = sum + num[i];

//}
//double avg = (double)sum / num.Length;
//Console.WriteLine("AVERAGE VALUE IN ARRAY");
//Console.WriteLine($"The sum of all integers are:{avg:0.###} ");

//Q5:Check if a specific integer is present in the array.
//Console.WriteLine("CHECK A NUMBER PRESENT OR NOT IN A ARRRAY");
//Console.WriteLine("Enter number present or not in array");
//int user = Convert.ToInt32(Console.ReadLine());
//switch (user)
//{
//    case 1:
//        Console.WriteLine("Yes it is present in a arrray");
//        break;
//    case 3:
//        Console.WriteLine("Yes it is present in a arrray");
//        break;
//    case 42:
//        Console.WriteLine("Yes it is present in a arrray");
//        break;
//    case 20:
//        Console.WriteLine("Yes it is present in a arrray");
//        break;
//    case 97:
//        Console.WriteLine("Yes it is present in a arrray");
//        break;
//    case 65:
//        Console.WriteLine("Yes it is present in a arrray");
//        break;
//    case 88:
//        Console.WriteLine("Yes it is present in a arrray");
//        break;
//    case 43:
//        Console.WriteLine("Yes it is present in a arrray");
//        break;
//    case 64:
//        Console.WriteLine("Yes it is present in a arrray");
//        break;
//    case 12:
//        Console.WriteLine("Yes it is present in a arrray");
//        break;
//    case 48:
//        Console.WriteLine("Yes it is present in a arrray");
//        break;
//    case 24:
//        Console.WriteLine("Yes it is present in a arrray");
//        break;
//    case 38:
//        Console.WriteLine("Yes it is present in a arrray");
//        break;
//    default:
//        Console.WriteLine("No it is not present in a arrray");
//        break;
//}

//Q6:Create two dimensional Array.
//Create a program that finds the sum of all elements in a two-dimensional array (matrix).
//Console.WriteLine("The sum of all elements in a two-dimensional array (matrix)");
//int[,] ar2d = new int[3, 5]
//{
//    {1,2,3,4,5 },
//    {6,7,8,9,10 },
//    {11,12,13,14,15 },
//};
//int row = ar2d.GetLength(0);
//int col = ar2d.GetLength(1);
//int count = 0;
//for (int i = 0; i < row; i++)
//{

//    for (int j = 0; j < col; j++)

//    {
//        count = count + ar2d[i, j];
//    }
//}
//    Console.WriteLine($"The total row is:{row}");
//    Console.WriteLine($"The total column is:{col}");
//Console.WriteLine($"The total elements are: {count}");


