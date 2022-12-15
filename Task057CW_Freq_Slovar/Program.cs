// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

Console.Clear();
const int m = 3;
const int n = 3;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 10;

int[,] matrix = new int [m, n];

FillArray(matrix, LEFTRANGE, RIGHTRANGE);
PrintArray(matrix);

CountDigits(matrix);

void CountDigits (int[,] mas)
{
    int digit, count;
    int strok = mas.GetLength(0);
    int stolbcov = mas.GetLength(1);
    for (int i = 0; i < 10; i++)
    {
        digit = i;
        count = 0;
        for (int k = 0; k < strok; k++)
        {
            for (int n = 0; n < stolbcov; n++)
                {
                    if (digit == mas[k, n]) count++;                    
                }
            }
            if (count > 0) Console.WriteLine($"{digit} встречается {count} раз"); 
        }
    }

void FillArray (int[,] mat, int leftRange, int rightRange)
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