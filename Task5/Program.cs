// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали с индексами (0,0); (1;1) и т.д. и на обратной диагонали.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12
// Сумма элементов обратной диагонали: 8 + 9 + 7 = 24


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("{ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3}\t");
        }
        Console.Write("}");
        Console.WriteLine();
    }
}

int Sum1(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + array[i, j];
            }
        }
    }
    return sum;
}

int Sum2(int[,] array)
{
    int k = 0;
    int l = 0;
    if (array.GetLength(0) < array.GetLength(1)) k = array.GetLength(0);
    else k = array.GetLength(1);
    int sum2 = 0;
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < k; j++)
        {
            if (j == k - 1 - l)
            {
                if (i == l)
                {
                    sum2 = sum2 + array[i, j];
                    l = l + 1;
                }
            }
        }
    }
    return sum2;
}


Console.WriteLine("Введите количество строк двумерного массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
Console.WriteLine($"Сгенерирован массив из {array.GetLength(0)} строк и {array.GetLength(1)} столбцов:");
PrintArray(array);
Console.WriteLine($"Сумма элементов по главной диагонали массива равна = {Sum1(array)}");
Console.WriteLine($"Сумма элементов по обратной диагонали массива равна = {Sum2(array)}");