// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];//первая переменная задаёт строки, вторая - столбцы
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void ReplaceRows(int[,] arr)
{
    if (arr.GetLength(0) <= 1)
    {
        return;
    }
    int lastRow = arr.GetLength(0) - 1;

    for (int = 0; int < arr.GetLength(1); int++)
    {
        int temp = arr[0, i];
        arr[0, i] = lastRow;
        lastRow = temp;
    }
}
int rows = Asknumber("Введите количество строк: ");
int cols = Asknumber("Введите количество колонок: ");

int[,] arr = new int[rows, cols];
GetArray

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

// void ReplaceRows(int[,] arr)
// {
//  if (arr.GetLength(0) <= 1)
//  {
//   return;
//  }

//  int lastRow = arr.GetLength(0) - 1;

//  for (int i = 0; i < arr.GetLength(1); i++)
//  {
//   int temp = arr[0, i];
//   arr[0, i] = arr[lastRow, i];
//   arr[lastRow, i] = temp;
//  }
// }

// int rows = AskNumber("Введите колличество строк: ");
// int cols = AskNumber("Введите колличество колонок: ");

// int[,] arr = new int[rows, cols];
// FillArray(arr, 0, 20);
// PrintNumbers(arr);
// Console.WriteLine("__________");
// ReplaceRows(arr);
// PrintNumbers(arr);