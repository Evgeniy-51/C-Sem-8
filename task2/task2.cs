// Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

Random rnd = new Random();
int size = rnd.Next(2, 4);

int[,] arr1 = new int[size, size];
int[,] arr2 = new int[size, size];
int[,] resArr = new int[size, size];

void fillArrays()
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            arr1[i, j] = rnd.Next(-10, 11);
            arr2[i, j] = rnd.Next(-10, 11);
        }
    }
}

int getElement(int k, int n)
{
    int elem = 0;
    for (int i = 0; i < size; i++)
    {
        elem += arr1[k, i] * arr2[i, n];
    }
    return elem;
}

void getResult()
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            resArr[i, j] = getElement(i, j);
        }
    }
}

void printLine(int[,] arr, int line)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write(arr[line, i] + "\t");
    }
    Console.Write("\t");
}

void showResult()
{
    for (int i = 0; i < size; i++)
    {
        printLine(arr1, i);
        printLine(arr2, i);
        Console.Write("| ");
        printLine(resArr, i);
        Console.WriteLine();
    }
}

fillArrays();
getResult();
showResult();