// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
const int m = 4;
const int n = 4;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 10;

int[,] matrix = new int[m, n];

FillArray(matrix, LEFTRANGE, RIGHTRANGE);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine($"Номер строки с минимальной суммой {SumDigits(matrix, LEFTRANGE, RIGHTRANGE)}");


int SumDigits(int[,] mas, int leftRange, int rightRange)
{
    int strok = mas.GetLength(0);
    int stolbcov = mas.GetLength(1);
    int minS = mas.GetLength(1) * (rightRange - leftRange);
    int minSumStr = 0;
    int sum = 0;

    for (int i = 0; i < strok; i++)
    {
        for (int j = 0; j < stolbcov; j++)
        {
            sum += mas[i, j];
        }
        if (sum < minS) 
        {
            minSumStr = i;
            minS = sum;
        }
        sum = 0;
    }
    return minSumStr;
}

void FillArray(int[,] mat, int leftRange, int rightRange)
{
    Random rand = new Random();
    for (int i = 0; i < mat.GetLength(0); i++) // Переходим по строкам
    {
        for (int j = 0; j < mat.GetLength(1); j++) // Переходим по столбцам
        {
            mat[i, j] = rand.Next(leftRange, rightRange);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // Переходим по строкам
    {
        for (int j = 0; j < matr.GetLength(1); j++) // Переходим по столбцам
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}