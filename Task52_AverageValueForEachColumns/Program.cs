/* Задача 52
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. */

// Метод генерации массива (с элементами в промежутке [-99; 99]).
int[,] CreateArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(-99, 100);
        }
    }
    return array;
}

// Метод вывода массива.
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Поиск среднее арифметическое элементов в каждом столбце
double[] CalculateAverage(int[,] matrix)
{
    double[] averageValues = new double[matrix.GetLength(1)];
    int sumOfValues = 0;
    for (int col = 0; col<matrix.GetLength(1); col++)
    {
        for (int row = 0; row<matrix.GetLength(0); row++)
        {
            sumOfValues = sumOfValues + matrix[row, col];
        }
        averageValues[col] = Math.Round(1.0 * sumOfValues / matrix.GetLength(0), 2);
        sumOfValues = 0;
    }
    return averageValues;
} 

int[,] randomArray = CreateArray(row: new Random().Next(2, 15), col: new Random().Next(2, 15)); // Массив случайного размера [2; 14].
Console.WriteLine("Случайный массив целых чисел:");
PrintArray(randomArray);
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", CalculateAverage(randomArray))}");