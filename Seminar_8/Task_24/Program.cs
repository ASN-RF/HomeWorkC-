/* Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
             которая будет построчно выводить массив, добавляя индексы каждого элемента.
                                                    массив размером 2 x 2 x 2
                                                      12(0,0,0) 22(0,0,1)
                                                      75(0,1,0) 31(0,1,1)
                                                      45(1,0,0) 53(1,0,1)
                                                      32(1,1,0) 23(1,1,1) */
/*void ArrayNoRandom(int y)
{
    int x = 10;
    int[] array0 = new int[y];
    int i = 0;
    while (x < 99)
    {
        array0[i] = x;
        x++;
        Console.Write($"{array0[i]} , ");
        i++;
    }
    while (x == 99)
    {
        array0[i] = x;
        x++;
        Console.Write($"{array0[i]}");
        i++;
    }
}
void GetRandomArr(ref int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        var num = random.Next(min, max);

        if (arr.Contains(num))
        {
            i--;
        }
        else
        {
            arr[i] = num;
        }
    }
}*/

/*void RandomMatrix(int[,,] array)
{
    int x = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 99);
            }
        }
        while (array[i] = array[j])
        {
            array[i]++;
        }
    }

}*/
int[,,] CreateKub(int row, int col, int layer)
{
    int[,,] array = new int[row, col, layer];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < layer; k++)
            {
                bool flag = true;
                while (flag)
                {
                    flag = false;
                    int kandidat = new Random().Next(10, 99);
                    for (int i1 = 0; i1 < row; i1++)
                    {
                        for (int j1 = 0; j1 < col; j1++)
                        {
                            for (int k1 = 0; k1 < layer; k1++)
                            {
                                if (array[i1, j1, k1] == kandidat) flag = true;

                            }
                        }
                    }
                    if (!flag) array[i, j, k] = kandidat;

                }

            }
        }
    }
    return array;
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
PrintMatrix(matrix);
