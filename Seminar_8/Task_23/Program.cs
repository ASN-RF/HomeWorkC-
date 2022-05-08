/* Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
             с наименьшей суммой элементов.
                                                Например, задан массив:
                                                1 4 7 2
                                                5 9 2 3
                                                8 4 2 4
                                                5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка.*/
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
void FindingMinSumStr(int[,] array)
{
    int sum = 0;
    int minSum = int.MaxValue;
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            count = i + 1;
        }
    }
    Console.WriteLine("Наименьшая сумма элементов, находится в строке " + count + " и равна --> " + minSum);
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
}
Console.WriteLine("Здравствуйте! Введите количество строк Вашей матрицы (оно должно быть больше 0):");
Console.Write("m  = ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m + 1;  // !!!Чтобы матрица была прямоугольная!!!
int[,] matrix = new int[m, n];
Console.WriteLine("Вот такая красивая матрица у Вас получилась:");
RandomMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Решение:");
FindingMinSumStr(matrix);
