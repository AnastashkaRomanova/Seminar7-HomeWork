/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = GetArray(rows, columns, 5, 30);
PrintArray(newArray);

Console.WriteLine();
double[]middleArray= FindArithmeticMean(newArray);
PrintArithmeticMean(middleArray);


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
double[] FindArithmeticMean(int[,] array)
{
    double sum = 0;
    double [] middle = new double[array.GetLength(1)];
    
    for (int i= 0; i < array.GetLength(1); i++)
    {
        
        for (int j = 0; j < array.GetLength(0);j++)
        {
            sum = sum + array[j, i];
        }
        middle[i] = sum / rows;
        middle[i]= Math.Round(middle[i],2);
        sum=0;
    }
    return middle;
}

void PrintArithmeticMean(double[]array)
{
       for (int i = 0; i < array.GetLength(0); i++)
    {
        
        {
            Console.Write($"{array[i]} ");
        }
        
        
    }
}