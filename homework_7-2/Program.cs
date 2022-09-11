/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,]matrix = new int[m,n];
FillArray (matrix);
Console.WriteLine();
PrintArray(matrix);
FindNumber(matrix);

// 1. Метод заполнения массива случайными числами
void FillArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-10,21);
        }
    }
    return;
}
//Console.WriteLine();

// 2. Метод вывода массива на печать 
void PrintArray (int[,] matrix)
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

// 3.Метод нахождения и вывода искомого элемента массива:
int FindNumber (int[,] matrix)
{
    Console.WriteLine("Введите координаты искомого элемента массива I и J:");
    int I = Convert.ToInt32(Console.ReadLine());
    int J = Convert.ToInt32(Console.ReadLine());
    int number;   
    
    if ((I < matrix.GetLength(0)) && (J < matrix.GetLength(1)))
    {
        number = matrix[I,J];
        Console.WriteLine("Искомый элемент = " + number);
    }
    else Console.WriteLine("Такого элемента нет в данном массиве");
    
    return(1);
}
    