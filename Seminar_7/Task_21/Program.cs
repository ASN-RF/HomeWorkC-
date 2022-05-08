/* Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
                                                    Например, задан массив:
                                                    1 4 7 2
                                                    5 9 2 3
                                                    8 4 2 4
                                                    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
void RandomMatrix(int[,] array)
{
   // int[,] matrix = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
// void Srednee(int[,] array) // первый вариант
// {
//     float sum = 0;
//     float SredneeZnach = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum = sum + array[i, j];
//         }
//         SredneeZnach = sum / array.GetLength(0);
//         Console.Write(Math.Round(SredneeZnach, 2) + "; ");
//         sum = 0;
//         SredneeZnach = 0;
//     }
// }
void Srednee(int[,] array) // второй вариант, в отличие от первого выводит текст "среднее арифметическое n-го столбца" к каждому столбцу 
{
    float sum = 0;
    float SredneeZnach = 0;
    int x = 1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        SredneeZnach = sum / array.GetLength(0);
        Console.WriteLine("Среднее арифметическое " + x + "-го столбца: " + Math.Round(SredneeZnach, 2) + "; ");
        x++;
        sum = 0;
        SredneeZnach = 0;
    }
}
Console.WriteLine("Введите количество строк:");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m, n];
RandomMatrix(matrix);
//Console.WriteLine ("Среднее арифметическое каждого столбца равна: "); // активировать для первого варианта
Srednee(matrix);