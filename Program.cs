/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
//вопрос по первой задачи, как вывести вещественные числа без знака после запятой 
//================= Task 1 27min ===========================

// void CreateAndShow2DArray(int rows, int cols, int min, int max)
// {
//     double[,] array = new double[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().NextDouble() + new Random().Next(min, max);
//             Console.Write($"{array[i, j]:0.0} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write($"Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write($"Enter number of cols: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.Write($"Enter min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Enter max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// CreateAndShow2DArray(rows, columns, min, max);

/*
Задача 50. Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
//================= Task 2 25 min ===========================

// int[,] Create2DArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }

// void Show2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j< array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindArrayElementPosition(int[,] array, int row, int col)
// {
//     if(row >= array.GetLength(0) || col >= array.GetLength(1)) 
//         Console.Write("A number is absent in array.");
//     else 
//     {
//         Console.Write($"Value is {array[row, col]}");
//     }
// }
// int[,] array  = Create2DArray(4, 4, 1, 9);
// Show2DArray(array);

// Console.Write("Enter row`s number: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter column`s number");
// int column = Convert.ToInt32(Console.ReadLine());

// FindArrayElementPosition(array, row, column);


/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
//================= Task 3 ===========================
int[,] Create2DArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ShowColumnAvaregeValue(int[,] array)
{
    double averageSum = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for(int j = 0; j < array.GetLength(0); j++)
        {
           sum += array[j,i];
        }
        averageSum = sum/array.GetLength(0);
        if(i != array.GetLength(1)-1) Console.Write($"{averageSum:0.00}; ");
        else Console.Write($"{averageSum:0.00}.");
        


    }
}

int rows = new Random().Next(2, 5);
int columns = new Random().Next(2, 5);
int min = 1;
int max = 10;
int[,] array = Create2DArray(rows, columns, min, max);
Show2DArray(array);
Console.WriteLine();
ShowColumnAvaregeValue(array);