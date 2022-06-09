/* Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
             которая будет построчно выводить массив, добавляя индексы каждого элемента.
                                                    массив размером 2 x 2 x 2
                                                      12(0,0,0) 22(0,0,1)
                                                      75(0,1,0) 31(0,1,1)
                                                      45(1,0,0) 53(1,0,1)
                                                      32(1,1,0) 23(1,1,1) */
int[] CreateArray(int x, int y, int w) // ФУНКЦИЯ создает одномерный массив данных из последовательных чисел, затем все эелементы случайным образом перемещивает
{
    int[] Array = new int[x * y * w];
    int count = 10; // 10-т.к. двузначных
    int temp = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = count;
        count++;
    }
    for (int i = 0; i < Array.Length / 2; i++)   // Немного перемещиваем :) Хотя в условии про это не написано.
    {
        int j = new Random().Next((Array.Length / 2), Array.Length);
        temp = Array[i];
        Array[i] = Array[j];
        Array[j] = temp;
    }
    return Array;
}
void ConsolPleasePrintMoyArray(int x, int y, int w, int[] Array) // Просим любимую консоль вывести массив
{
    int[,,] Array3D = new int[x, y, w];
    int count = 0;
    for (int i = 0; i < Array3D.GetLength(0); i++)
    {
        for (int j = 0; j < Array3D.GetLength(1); j++)
        {
            for (int z = 0; z < Array3D.GetLength(2); z++)
            {
                Array3D[i, j, z] = Array[count];
                count++;
                Console.Write($"{Array3D[i, j, z]}{(i, j, z)} ");
            }
            Console.WriteLine();
        }
    }
}
Console.WriteLine("Здравствуйте! Если Вы хотите увидеть решение, согласно примера с трехмерным массивом размером 2х2х2, то введите 1 и нажмите 'Enter', если хотите ввести сами размерность, то введите 2 и нажмите 'Enter'");
Console.WriteLine("1 и 'Enter' - как в примере");
Console.WriteLine("2 и 'Enter' - самостоятельно ввести");
int Vubor1 = Convert.ToInt32(Console.ReadLine());
if (Vubor1 == 1)
{
    ConsolPleasePrintMoyArray(2, 2, 2, CreateArray(2, 2, 2));
}
if (Vubor1 == 2)
{
    Console.WriteLine("Введите кооринату x:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кооринату y:");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кооринату z:");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    ConsolPleasePrintMoyArray(a, b, c, CreateArray(a, b, c));
}
else
{
    Console.WriteLine("К сожалению, при реализации данной программы было предусмотренно всего 2 варианта выбора! Желаем удачи!");
}


