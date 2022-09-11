/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("ВВедите количество строк m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("ВВедите количество строк n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[m, n];
        FillArray(matrix);
        PrintArray(matrix);
        SredneArifCol(matrix);


        // Метод заполнения массива случайными числами
        void FillArray(int[,] matrix)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = new Random().Next(-10, 21);
                }
            }
            //return;
        }
        Console.WriteLine();

        // Метод вывода массива на печать 
        void PrintArray(int[,] matrix)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j]}");
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        // Метод нахождения среднеарифметического в столбцах
        decimal SredneArifCol(int[,] matrix)
        {
            //double SA = Convert.ToDouble(Console.ReadLine());
            decimal SA = 0;
            //int SUM = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                decimal SUM = 0;
                for (int j = 0; j < n; j++)
                {
                    SUM += matrix[j, i];
                }
                SA = Math.Round((SUM / m),2);
                Console.WriteLine("Среднее арифметическое столбца  " + i + "  =  " + SA);
            }
            return(SA);
        }
    }
}
