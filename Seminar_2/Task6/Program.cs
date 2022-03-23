/*Задача 6: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
            что третьей цифры нет.     645 -> 5
                                       78 -> третьей цифры нет
                                       32679 -> 6 */
void Simvol3(int num)
{
    int N = num;
    while (N > 1000)
    {
        N = N / 10;
    }
    while (N < -1000)
    {
        N = N / 10;
    }
    if (N < 100 && N > -100)
    {
        Console.Write(num + " --> " + "Третье цифры в данном числе НЕТ");
    }
    else
    {
        if (N < 0)
        {
            Console.Write(num + " --> " + (N % 10) * (-1));
        }
        else
        {
            Console.Write(num + " --> " + N % 10);
        }

    }
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Simvol3(number);
