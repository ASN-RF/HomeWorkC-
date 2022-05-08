/* Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
             строки двумерного массива.
                         Например, задан массив:        В итоге получается вот такой массив:
                                1 4 7 2                             1 2 4 7
                                5 9 2 3                             2 3 5 9
                                8 4 2 4                             2 4 4 8 */
void RandomMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void ArrangeMatrix1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxToJ = j;
            for (int x = j + 1; x < array.GetLength(1); x++)
                if (array[i, x] > array[i, maxToJ])
                {
                    maxToJ = x;
                }
            int temporary = array[i, j];
            array[i, j] = array[i, maxToJ];
            array[i, maxToJ] = temporary;
        }
    }
}
void ArrangeMatrix2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxToJ = j;
            for (int x = j + 1; x < array.GetLength(1); x++)
                if (array[i, x] < array[i, maxToJ])
                {
                    maxToJ = x;
                }
            int temporary = array[i, j];
            array[i, j] = array[i, maxToJ];
            array[i, maxToJ] = temporary;
        }
    }
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Здравствуйте! Введите количество строк:");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
Console.WriteLine("Вот такая красивая матрица у Вас получилась:");
RandomMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("В связи с тем что условие задания и пример расходятся, какое решения хотели бы увидеть?");
Console.WriteLine("Если решение согласно условия задания, то введите 1 и нажмите -Enter-");
Console.WriteLine("Если согласно примера, то 2 и тоже -Enter-");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
    ArrangeMatrix1(matrix);
    Console.WriteLine("С Вашего позволения я упорядочил по убыванию элементы каждой строки Вашей красивой матрицы:");
    PrintMatrix(matrix);
}
else
{
    ArrangeMatrix2(matrix);
    Console.WriteLine("С Вашего позволения я упорядочил по возрастанию элементы каждой строки Вашей красивой матрицы:");
    PrintMatrix(matrix);
};





