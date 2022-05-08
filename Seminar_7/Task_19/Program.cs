/* Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
                                                                            m = 3, n = 4.
                                                                            0,5 7 -2 -0,2
                                                                            1 -3,3 8 -9,9
                                                                            8 7,8 -7,1 9 */
//1 вариант
/*double[,] MatrixMxN(int m, int n)
{
    double[,] matrix = new double[m, n];           //!вещественные числа
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().Next(-99, 100) + new Random().NextDouble(), 2);
        }
    }
    return matrix;
}
void PrintMatrixMxN<T>(T[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк:");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = MatrixMxN(m, n);
PrintMatrixMxN(matrix);
Console.WriteLine();*/

// 2 вариант
void RandomMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            // matrix[i, j] = new Random().Next(-99, 100);
            matrix[i, j] = Math.Round(new Random().Next(-99, 100) + new Random().NextDouble(), 2);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
RandomMatrix(3, 4);

