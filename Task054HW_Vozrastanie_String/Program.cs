// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.Clear();
const int m = 3;
const int n = 5;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 10;

int[,] matrix = new int[m, n];

FillArray(matrix, LEFTRANGE, RIGHTRANGE);
PrintArray(matrix);
Console.WriteLine();
DigitsByRange(matrix);
PrintArray(matrix);

void DigitsByRange(int[,] mas)
{
    int strok = mas.GetLength(0);
    int stolbcov = mas.GetLength(1);
    int[] tempArr = new int[stolbcov];

    for (int i = 0; i < strok; i++)
    {
        for (int j = 0; j < stolbcov; j++)
        {
            tempArr[j] = mas[i, j];
        }
        Array.Sort(tempArr);
        for (int j = 0; j < stolbcov; j++)
        {
            mas[i, j] = tempArr[j];
        }
    }
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