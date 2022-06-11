/*Задача: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел 
        (без разделителя). В массиве data хранится информация о количестве бит, которые занимают числа 
        из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива 
        data с учётом информации из массива info.
        Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); 
        третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)
                                                            Пример:
                                                            входные данные:
                                                            data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
                                                            info = {2, 3, 3, 1 }
                                                            выходные данные:
                                                            1, 7, 0, 1              */
int[] ArrayDat = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] ArrayInf = { 2, 3, 3, 1 };
void PrintArray(int[] Array)
{
    Console.Write(" = {");
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        if (i < Array.GetLength(0) - 1)
        {
            Console.Write($"{Array[i]}, ");
        }
        else
        {
            {
                Console.Write(Array[i]);
            }
        }
    }
    Console.Write("}");
    Console.WriteLine();
}
void MagicArray(int[] ArrayInfo, int[] ArrayData)
{
    Console.WriteLine("Выходные данные:");
    int count = 0;
    for (int i = 0; i < ArrayInfo.Length; i++)
    {
        int nakopitel = 0;
        for (int j = 0; j < ArrayInfo[i]; j++)
        {
            nakopitel = nakopitel + ArrayData[count] * (int)Math.Pow(2, (ArrayInfo[i] - 1) - j);
            count++;
        }
        if (i < ArrayInfo.Length - 1)
        {
            Console.Write(nakopitel + ", ");
        }
        else
        {
            Console.Write(nakopitel);
        }
    }
}
Console.WriteLine("Вводные данные:");
Console.Write("data");
PrintArray(ArrayDat);
Console.Write("info");
PrintArray(ArrayInf);
MagicArray(ArrayInf, ArrayDat);