// Задача 3. Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.

Console.Clear();

Random rnd = new Random();
int lines,
    columns;

void getSize()
{
    lines = rnd.Next(3, 9);
    columns = rnd.Next(3, 9);
    if (lines * columns > 50) getSize();
}
getSize();

int[,] arr = new int[lines, columns];

int getElement()
{
    bool isPresent = false;
    int elem = rnd.Next(10, 100);

    foreach (int e in arr)
    {
        if (e == elem)
        {
            isPresent = true;
            break;
        }
    }
    return (isPresent) ? getElement() : elem;
}

for (int i = 0; i < lines; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arr[i, j] = getElement();
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}
