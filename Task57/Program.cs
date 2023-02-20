// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

int[] Arr2TOArr1(int[,] array)
{
    int[,] result2 = new int[array.GetLength(0), array.GetLength(1)];
    int[] result1 = new int[array.GetLength(0) * array.GetLength(1)];
    int z = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result1[z] = result2[i, j];
            z++;
        }
    }
    return result1;
}

void PrintNumbers2(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintNumbers1(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int AskNumber(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

int rows = AskNumber("Введите число строк: ");
int cols = AskNumber("Введите число колонок: ");

int[,] arr2 = GetArray(rows, cols, 0, 10);
PrintNumbers2(arr2);
int[,] arr1 = Arr2TOArr1(arr1);
PrintNumbers1(arr1);


// ВАНЯ
// int AskNumber(string msg)
// {
//  Console.Write(msg);
//  return int.Parse(Console.ReadLine());
// }

// void FillArray(int[,] arr, int minValue, int maxValue)
// {
//  Random rand = new Random();

//  for (int i = 0; i < arr.GetLength(0); i++)
//  {
//   for (int j = 0; j < arr.GetLength(1); j++)
//   {
//    arr[i, j] = rand.Next(minValue, maxValue);
//   }
//  }
// }

// void PrintNumbers(int[,] arr)
// {
//  for (int i = 0; i < arr.GetLength(0); i++)
//  {
//   for (int j = 0; j < arr.GetLength(1); j++)
//   {
//    Console.Write(arr[i, j] + " ");
//   }
//   Console.WriteLine();
//  }
// }

// int[,] GetRepetitiveNumbers(int[,] arr)
// {
//  int[,] res = new int[arr.GetLength(0) * arr.GetLength(1), 2];
//  int count = 0;

//  for (int i = 0; i < arr.GetLength(0); i++)
//  {
//   for (int j = 0; j < arr.GetLength(1); j++)
//   {
//    int val = arr[i, j];
//    int index = Find(res, val);

//    if (index == -1)
//    {
//     res[count, 0] = val;
//     res[count, 1] = 1;
//     count++;
//    }
//    else
//    {
//     res[index, 1]++;
//    }
//   }
//  }

//  return res;
// }

// int Find(int[,] arr, int val)
// {
//  for (int i = 0; i < arr.GetLength(0); i++)
//  {
//   if (arr[i, 0] == val)
//   {
//    return i;
//   }
//  }

//  return -1;
// }

// int rows = AskNumber("Enter number of rows: ");
// int cols = AskNumber("Enter number of columns: ");

// int[,] arr = new int[rows, cols];
// FillArray(arr, 0, 20);
// PrintNumbers(arr);
// Console.WriteLine("____________________");
// int[,] res = GetRepetitiveNumbers(arr);
// PrintNumbers(res);

// Эльвира
// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());
// int[,] array = GetArray(rows, columns, -10, 10);
// PrintArray(array);
// Console.WriteLine();
// int[] rowAr = GetRowArray(array);
// SortArray(rowAr);
// Console.WriteLine(String.Join(" ", rowAr));
// PrintData(rowAr);

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return result;
// }

// int[] GetRowArray(int[,] inArray)
// {
//     int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
//     int index = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             result[index] = inArray[i, j];
//             index++;
//         }
//     }
//     return result;
// }

// void SortArray(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         for (int j = i + 1; j < inArray.Length; j++)
//         {
//             if (inArray[i] > inArray[j])
//             {
//                 int k = inArray[i];
//                 inArray[i] = inArray[j];
//                 inArray[j] = k;
//             }
//         }
//     }
// }


// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void PrintData(int[] inArray)
// {
//     int el = inArray[0];
//     int count = 1;
//     for (int i = 1; i < inArray.Length; i++)
//     {
//         if (inArray[i] != el)
//         {
//             Console.WriteLine($"{el} встречается {count}");
//             el = inArray[i];
//             count = 1;
//         }
//         else
//         {
//             count++;
//         }
//     }
//     //Console.WriteLine($"{el} встречается {count}");
// }