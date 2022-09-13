// Задача 1: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

Random rnd = new Random();
int lines = rnd.Next(3, 9);
int columns = rnd.Next(3, 9);
int maxValue = rnd.Next(9, 29);
int minSum = maxValue * columns;
int res = 0;
int[,] arr = new int[lines, columns];

for (int i = 0; i < lines; i++)
{
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
        arr[i, j] = rnd.Next(maxValue);
        sum += arr[i, j];
        Console.Write(arr[i, j] + "\t");
    }
    if (sum < minSum)
    {
        minSum = sum;
        res = i;
    }
    Console.WriteLine();
}

Console.WriteLine(new string('_', columns * 7));
Console.WriteLine($"{res + 1}-я строка");
