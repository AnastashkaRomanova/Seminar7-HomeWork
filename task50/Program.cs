// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//(на вход именно поступает позиция элемента, можете разбить на две переменные или прописать в одну строку и
//конвертировать в два числа, комментарии в конце семинара по этой задаче)

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.WriteLine("Введите номер строки: ");
int rowsNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int columnsNum = Convert.ToInt32(Console.ReadLine());

int[,] newArray = GetArray(10, 10, 5, 30);
PrintArray(newArray);
Console.WriteLine();
FindElement(newArray, rowsNum, columnsNum);




int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}
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

void FindElement(int[,] array, int rowsNum, int columnsNum)
{

    if (rowsNum <= array.GetLength(0) && columnsNum <= array.GetLength(1))
    {
        Console.WriteLine($"Элемент в позиции ({rowsNum},{columnsNum}) = {array[rowsNum-1, columnsNum-1]}");
    }
    else
    {
        Console.WriteLine("Такого элемента не существует!");
    }
    Console.WriteLine();
}

