/* Задача 47
Задайте двумерный массив размером m × n, заполненный случайными вещественными числами. */

// Метод считывания
int GetNumFromUser(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

// Метод проверки введенных данных для размера массива.
bool IsValidSizeOfArray(int m, int n)
{
    return (m > 0 && n > 0);
}

// Метод генерации массива.
double[,] CreateArray(int row, int col)
{
    double[,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = Math.Round((new Random().NextDouble() * new Random().Next(-9, 10)), 2);
        }
    }
    return array;
}

// Метод вывода массива.
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

int m = GetNumFromUser("Введите количество строк генерируемого массива: ");
int n = GetNumFromUser("Введите количество столбцов генерируемого массива: ");
bool isValid = IsValidSizeOfArray(m, n);
if (isValid)
{
    double[,] randomArray = CreateArray(m, n);
    PrintArray(randomArray);
}
else
{
    Console.WriteLine("Введены некорректные данные.");
}