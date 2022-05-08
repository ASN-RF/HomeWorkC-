/* Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
             которая будет построчно выводить массив, добавляя индексы каждого элемента.
                                                    массив размером 2 x 2 x 2
                                                      12(0,0,0) 22(0,0,1)
                                                      75(0,1,0) 31(0,1,1)
                                                      45(1,0,0) 53(1,0,1)
                                                      32(1,1,0) 23(1,1,1) */
void RandomMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                array[i, j, k] = new Random().Next(10, 99);
        }
    }
}
void PrintMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} {(i, j, k)} ");
            }
            Console.WriteLine();
        }
    }
}
int m = 2;
int n = 2;
int l = 2;
int[,,] matrix = new int[m, n, l];
Console.WriteLine("Решение задачи 3 ДЗ к семинару 8:");
RandomMatrix(matrix);
PrintMatrix (matrix);