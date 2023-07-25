// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Print2dMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Create2dMassive(int rows, int colums, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue);
        }
    }
    return matrix;
}

void FindAndPrintElement(int[,] array, int x, int y)
{
    if (x < 0 || x >= array.GetLength(0) || y < 0 || y >= array.GetLength(1))
    {
        Console.WriteLine($"Числа по адресу {x}:{y} нет в массиве");
    }
    else
    {
        int c = array[x, y];
        Console.WriteLine($"По адресу {x}:{y} находится число {c}");
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
int[,] massive = Create2dMassive(m, n, -99, 99);
Print2dMassive(massive);
int x = GetInput("Введите адрес x: ");
int y = GetInput("Ввудите адрес y: ");
FindAndPrintElement(massive, x, y);
