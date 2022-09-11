/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Write("ВВедите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,]matrix = new double[m,n];
FillArray (matrix);
Console.WriteLine();
PrintArray(matrix);

// Метод заполнения массива случайными числами
void FillArray (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-10,21)/10.0;
        }
    }
    return;
}
Console.WriteLine();

// Метод вывода массива на печать 
void PrintArray (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}");
            Console.Write("  ");
        }
        Console.WriteLine();
    }
}
