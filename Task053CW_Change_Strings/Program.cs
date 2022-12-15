// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

Console.Clear();
const int m = 7;
const int n = 4;

int[,] matrix = new int [m, n];

int strokaFirst = 0;
int strokaLast = matrix.GetLength(0) - 1;

FillArray(matrix);
PrintArray(matrix);
ChangeStrings(matrix);
Console.WriteLine();
PrintArray(matrix);

void ChangeStrings (int[,] mas)
{
    int temp = 0;
    for (int i =0; i < mas.GetLength(1); i++)
    {
        temp = mas[strokaFirst, i];
        mas[strokaFirst, i] = mas[strokaLast, i];
        mas[strokaLast, i] = temp;
    }
}

void FillArray (int[,] mat)
{
    Random rand = new Random();
    for (int i = 0; i < mat.GetLength(0); i++) // Переходим по строкам
    {
        for (int j = 0; j < mat.GetLength(1); j++) // Переходим по столбцам
        {
            mat[i, j] = rand.Next(-100, 101);
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