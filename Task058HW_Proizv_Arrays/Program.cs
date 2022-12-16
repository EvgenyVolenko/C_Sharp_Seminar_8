// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.Clear();
const int m = 4;
const int n = 4;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 10;

int[,] matrix = new int[m, n];
int[,] matrix1 = new int[m, n];

FillArray(matrix, LEFTRANGE, RIGHTRANGE);
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix1, LEFTRANGE, RIGHTRANGE);
PrintArray(matrix1);
Console.WriteLine();
ProductDigits(matrix, matrix1);
PrintArray(matrix1);

void ProductDigits(int[,] mas, int[,] mas1)
{
    int strok = mas.GetLength(0);
    int stolbcov = mas.GetLength(1);
    int prod;

    for (int i = 0; i < strok; i++)
    {
        for (int j = 0; j < stolbcov; j++)
        {
            mas1[i, j] = mas[i, j] * mas1[i, j];
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