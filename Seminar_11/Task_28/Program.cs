/*Задача: Дополнить решение домашней задачи прошлого семинара, добавив возможность ввода массивов info и data 
          пользователем. Проработать возможные частные случаи несоответствия данных в этих массивах.
УСЛОВИЕ ЗАДАЧИ С ПРОШЛОГО СЕМИНАРА.
Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел 
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
                                                            1, 7, 0, 1              
                                                            */
int[] ArrayData1 = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] ArrayInfo1 = { 2, 3, 3, 1 };
int[] ArrayData2 = { 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 2, 3 };
int[] ArrayInfo2 = { 2, 3, 3, 5 };
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
            Console.WriteLine(nakopitel);
        }
    }
    // Console.WriteLine();
}
void Reshenie(int[] ArrayInfo, int[] ArrayData)
{
    int summa = 0;
    for (int i = 0; i < ArrayInfo.Length; i++)
    {
        summa += ArrayInfo[i];
    }
    if (summa < ArrayData.Length)
    {
        MagicArray(ArrayInfo, ArrayData);
        Console.WriteLine("Работа программы завершена, однако есть двоичные значения, которые не были использованы: "); // Коментарий преподавателя, был включен в условие задачи (Запись семинара 11 (1:02:20))
        Console.Write("{");
        for (int i = summa; i < ArrayData.Length; i++)
        {
            if (i < ArrayData.Length - 1)
            {
                Console.Write(ArrayData[i] + ", ");
            }
            else
            {
                Console.Write(ArrayData[i]);
            }
        }
        Console.Write("}");
        Console.WriteLine();
    }
    if (summa > ArrayData.Length)
    {
        int[] NewArrayData = new int[summa];
        for (int i = 0; i < summa - ArrayInfo[ArrayInfo.Length - 1]; i++)
        {
            NewArrayData[i] = ArrayData[i];
        }
        for (int i = summa - ArrayInfo[ArrayInfo.Length - 1]; i < 2 * summa - ArrayInfo[ArrayInfo.Length - 1] - ArrayData.Length; i++)
        {
            NewArrayData[i] = 0;
        }
        int counter = 0;
        for (int i = 2 * summa - ArrayInfo[ArrayInfo.Length - 1] - ArrayData.Length; i < NewArrayData.Length; i++)
        {
            NewArrayData[i] = ArrayData[((summa - ArrayInfo[ArrayInfo.Length - 1])) + counter];
            counter++;
        }
        Console.Write("UpDate data");
        PrintArray(NewArrayData);
        Console.WriteLine();
        MagicArray(ArrayInfo, NewArrayData);
    }
    if (summa == ArrayData.Length)
    {
        MagicArray(ArrayInfo, ArrayData);
    }
    Console.WriteLine();
}
Console.Clear();  // Для удобства отоброжения (очистка консоли)
Console.WriteLine("Для удобства проверки задания можем предложить Вам 4 варианта:");
Console.WriteLine("1 вариант - использовать пример, где массива 'data' содержит объем информации, РАВНЫЙ охвату массива 'info' (пример из задания)\n2 вариант - использовать пример, где массива 'data' содержит БОЛЬШЕ информации, чем охватывает массива 'info'");
Console.WriteLine("3 вариант - использовать пример, где массива 'data' содержит МЕНЬШЕ информации, чем требуется массиву 'info'\n4 вариант - самостоятельно ввести массивы 'data' и 'info'");
int variant = Convert.ToInt32(Console.ReadLine());
if (variant == 1)
{
    Console.WriteLine("Вводные данные:");
    Console.Write("data");
    PrintArray(ArrayData1);
    Console.Write("info");
    PrintArray(ArrayInfo1);
    Console.WriteLine();
    Reshenie(ArrayInfo1, ArrayData1);
}
if (variant == 2)
{
    Console.WriteLine("Вводные данные:");
    Console.Write("data");
    PrintArray(ArrayData2);
    Console.Write("info");
    PrintArray(ArrayInfo1);
    Console.WriteLine();
    Reshenie(ArrayInfo1, ArrayData2);
}
if (variant == 3)
{
    Console.WriteLine("Вводные данные:");
    Console.Write("data");
    PrintArray(ArrayData1);
    Console.Write("info");
    PrintArray(ArrayInfo2);
    Console.WriteLine();
    Reshenie(ArrayInfo2, ArrayData1);
}
if (variant == 4)
{
    Console.WriteLine("Сколько чисел Вам хочеться, чтобы содержал массив 'data'?");
    int NumberData = Convert.ToInt32(Console.ReadLine());
    int[] ArrayDataInput = new int[NumberData];
    Console.WriteLine("Теперь введите " + NumberData + " числа(ел). После каждого числа нажмите клавишу -ENTER-");
    Console.WriteLine("!Незабудьте, что в массив 'data', может содержать значения только '0' и '1'");
    for (int i = 0; i < NumberData; i++) ArrayDataInput[i] = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Так, теперь подскажите сколько чисел Вам хочеться, чтобы содержал массив 'info'?");
    int NumberInfo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ого!");
    int[] ArrayInfoInput = new int[NumberInfo];
    Console.WriteLine("Теперь введите " + NumberInfo + " Ваших любимых числа(ел). После каждого числа нажмите клавишу -ENTER-");
    for (int i = 0; i < NumberInfo; i++) ArrayInfoInput[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Итак Ваши вводные данные:");
    Console.Write("data");
    PrintArray(ArrayDataInput);
    Console.Write("info");
    PrintArray(ArrayInfoInput);
    Console.WriteLine();
    Reshenie(ArrayInfoInput, ArrayDataInput);
}
if (variant < 1 | variant > 4)
{
    Console.WriteLine("К сожалению, при реализации данной программы было предусмотренно всего 4 варианта выбора! Желаем удачи!");
}