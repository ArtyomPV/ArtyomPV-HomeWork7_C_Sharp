/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
//вопрос по первой задачи, как вывести вещественные числа без занка после запятой 
//================= Task 1 27min ===========================

void CreateAndShow2DArray(int rows, int cols, int min, int max)
{
    double[,] array = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().NextDouble() + new Random().Next(min, max);
            Console.Write($"{array[i, j]:0.0} ");
        }
        Console.WriteLine();
    }
}

Console.Write($"Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write($"Enter number of cols: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write($"Enter min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter max: ");
int max = Convert.ToInt32(Console.ReadLine());
CreateAndShow2DArray(rows, columns, min, max);

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
//================= Task 2 ===========================

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
//================= Task 3 ===========================