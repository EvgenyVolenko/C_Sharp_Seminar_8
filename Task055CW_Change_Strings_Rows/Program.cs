// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();
const int m = 4;
const int n = 4;

int[,] matrix = new int [m, n];

FillArray(matrix);
PrintArray(matrix);

if (matrix.GetLength(0) != matrix.GetLength(1))
{
    Console.WriteLine($"В массиве с неравным колличеством строк {matrix.GetLength(0)} и столбцов {matrix.GetLength(1)} нельзя все строки заменить на все столбцы");
}
else
{
    ChangeStringsRows(matrix);
    Console.WriteLine();
    PrintArray(matrix);
}

void ChangeStringsRows (int[,] mas)
{
    int temp = 0;
    int razmer = mas.GetLength(0);
    for (int i = 0; i < razmer; i++)
    {
        for (int j = 1 + i; j < razmer; j++)
        {
        temp = mas[i, j];
        mas[i, j] = mas[j, i];
        mas[j, i] = temp;
        }        
    }
}

void FillArray (int[,] mat)
{
    Random rand = new Random();
    for (int i = 0; i < mat.GetLength(0); i++) // Переходим по строкам
    {
        for (int j = 0; j < mat.GetLength(1); j++) // Переходим по столбцам
        {
            mat[i, j] = rand.Next(0, 10);
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