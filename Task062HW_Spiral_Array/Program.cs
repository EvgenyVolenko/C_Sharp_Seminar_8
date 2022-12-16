// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.Clear();
const int n = 10;
const int cellWidth = 4;

int[,] matrix = new int[n, n];

FillArray(matrix);
PrintArray(matrix);

void FillArray(int[,] mat)
{
    int razmer = mat.GetLength(0);
    int a = 1;
    int x = 1;
    for (int i = razmer; i > 0; i--)
    {
        mat[0, razmer - i] = a;
        a++;
    }
    for (int i = 0; i < razmer - 1; i++)
    {
        for (int n = x; n < razmer - i; n++)
        {
            mat[n, razmer - x] = a;
            a++;
        }

        for (int n = x; n < razmer - i; n++)
        {
            mat[razmer - x, razmer - n - 1] = a;
            a++;
        }

         for (int n = x; n < razmer - 1 - i; n++)
        {
            mat[razmer - n - 1, x - 1] = a;
            a++;
        }

        for (int n = x; n < razmer - 1 - i; n++)
        {
             mat[x, n] = a;
             a++;
        }

        x++;
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // Переходим по строкам
    {
        for (int j = 0; j < matr.GetLength(1); j++) // Переходим по столбцам
        {
            Console.Write($"{matr[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
}