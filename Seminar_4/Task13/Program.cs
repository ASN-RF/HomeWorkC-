/* Задача 13: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
                                                          1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
                                                          6, 1, 33 -> [6, 1, 33] */

int[] ArrayNew()
{
    int x = 8;
    int[] array = new int[x];
    for (int i = 0; i < x; i++) array[i] = new Random().Next(0, 99);
    return array;
}
void PrintArrayNew(int[] array)
{
    for (int i = 0; i < 7; i++) Console.Write($"{array[i]}, ");
    Console.Write(array[7] + " --> [");
    for (int i = 0; i < 7; i++) Console.Write($"{array[i]}, ");
    Console.WriteLine(array[7] + "]");
}
Console.WriteLine("Hello!!! Start of the program.");
int[] array1 = ArrayNew();
PrintArrayNew(array1);
Console.WriteLine("End of the program. Goodbye!!");








