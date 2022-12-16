// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.Clear();
const int n = 4;
const int cellWidth = 3;

int[,] matrix = new int[n, n];

FillArray(matrix);
PrintArray(matrix);

void FillArray(int[,] mat)
{
    int razmer = mat.GetLength(0);
    int a = 1;
    for (int i = 0; i < razmer; i++) // Переходим по строкам
    {
            mat[0, i] = a;
            a++;
    }
    for (int j = 1; j < razmer; j++)
    {
        mat[j, 3] = a;
        a++;
    }
    for (int i = 1; i < razmer; i++)
    {
        mat[3, razmer - i - 1] = a;
        a++;
    }
    for (int j = 1; j < razmer - 1; j++)
    {
        mat[razmer - j - 1, 0] = a;
        a++;
    }
    for (int i = 1; i < razmer - 1; i++)
    {
        mat[1, i] = a;
        a++;
    }
     for (int j = 2; j < razmer - 1; j++)
    {
        mat[j, 2] = a;
        a++;
    }
    for (int i = 2; i < razmer - 1; i++)
    {
        mat[2, razmer - i - 1] = a;
        a++;
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // Переходим по строкам
    {
        for (int j = 0; j < matr.GetLength(1); j++) // Переходим по столбцам
        {
            Console.Write($"{matr[i, j], cellWidth}");
        }
        Console.WriteLine();
    }
}