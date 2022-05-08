/* Задача 4: Заполните спирально массив 4 на 4.
             На выходе получается вот такой массив:
                                                    1 2 3 4
                                                    12 13 14 5
                                                    11 16 15 6
                                                    10 9 8 7 */
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
int[,] SpiralArray(int m)
{
    int[,] matrix = new int[m, m];
    int count = 1, stroka = m, columns = m, a = 0, b = 0;
    while (a < stroka)
    {
        for (int j = a; j < stroka; j++)
        {
            matrix[b, j] = count;
            count++;
        }
        stroka = stroka - 1;
        for (int i = (b + 1); i < columns; i++)
        {
            matrix[i, columns - 1] = count;
            count++;
        }
        columns = columns - 1;
        for (int j = (stroka - 1); j >= a; j = j - 1)
        {
            matrix[stroka, j] = count;
            count++;
        }
        for (int i = (columns - 1); i > b; i = i - 1)
        {
            matrix[i, a] = count;
            count++;
        }
        a++; b++;
    }
    return matrix;
}
Console.WriteLine("Здравствуйте! Введите размер (порядок) квадратной матрицы (лучше ввести 4): ");
int m = Convert.ToInt32(Console.ReadLine());
PrintMatrix(SpiralArray(m));
