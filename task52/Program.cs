// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = random.Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}

void ArithmeticMean(int[,] numbers)
{
    int n = numbers.GetLength(0);
    int m = numbers.GetLength(1);
    double[] averages = new double[m];
    for (int j = 0; j < m; j++)
    {
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += numbers[i, j];
        }
        averages[j] = sum / n;
    }
    Console.Write("Средее арифмитическое каждого столбца: ");
    foreach (double avarage in averages)
    {
        Console.Write(avarage + "; ");
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
int[,] massive = Create2dMassive(m, n, 0, 10);
Print2dMassive(massive);
ArithmeticMean(massive);
