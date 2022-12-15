// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

Console.Clear();
const int m = 3;
const int n = 5;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 10;

int[,] matrix = new int [m, n];

FillArray(matrix, LEFTRANGE, RIGHTRANGE);
PrintArray(matrix);
(int strokaM, int stolbecM) = FindMin(matrix);
Console.WriteLine($"Мнимальное значение в массиве = {matrix[strokaM, stolbecM]} в позиции {strokaM} {stolbecM}");
NewArray(matrix, strokaM, stolbecM);

void NewArray(int[,] table, int strD, int stolbD)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (strD == i || stolbD == j); 
            else Console.Write($"{table[i, j]} ");
        }
        if (strD != i) Console.WriteLine();
    }
}

(int, int) FindMin(int[,] mas)
{
    int stroka = 0, stolbec = 0;
    int min = mas[stroka, stolbec];
    for (int k = 0; k < mas.GetLength(0); k++)
    {
        for (int n = 0; n < mas.GetLength(1); n++)
        {
            if (min > mas[k, n]) 
            {
                min = mas[k, n];
                stroka = k;
                stolbec = n;
            }
        }
    }
    return (stroka, stolbec);
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