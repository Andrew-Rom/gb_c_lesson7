/* Задача 50
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет
(row ,colum - входные данные). */

// Метод генерации массива.
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

// Метод получения данных при вводе.
int[] GetArrayFromString(string stringArray)
{
    string[] strArray = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] numArray = new int[strArray.Length];
    for (int i = 0; i < strArray.Length; i++)
    {
        numArray[i] = int.Parse(strArray[i]);
    }
    return numArray;
}

Console.Write("Укажите номер строки и номер столбца массива для вывода числа (через пробел): ");
int[] findIndex = GetArrayFromString(Console.ReadLine());
int[,] randomArray = CreateArray(row: new Random().Next(15), col: new Random().Next(15));
Console.WriteLine("В массиве ");
PrintArray(randomArray);
if (findIndex[0] >= 0 && findIndex[0] < randomArray.GetLength(0) 
    && findIndex[1] >= 0 && findIndex[1] < randomArray.GetLength(1))
{
    Console.WriteLine($"Значение искомого элемента: {randomArray[findIndex[0], findIndex[1]]}.");
}
else
{
    Console.WriteLine("Искомого элемента нет.");
}