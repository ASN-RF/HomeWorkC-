/* Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
             какое число большее, а какое меньшее. (a = 5; b = 7 -> max = 7
                                                    a = 2 b = 10 -> max = 10
                                                    a = -9 b = -3 -> max = -3) */
Console.WriteLine("Привет!");
Console.WriteLine("Введите ваше любимое число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ваше НЕ любимое число: ");

int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
        Console.WriteLine("Поздравляем! Ваше любимое число больше чем НЕ любимое! ");
        Console.Write("max = ");
        Console.WriteLine(a);
        Console.Write("min = ");
        Console.WriteLine(b);        
}
else 
{
        Console.WriteLine("Не может быть! Ваше НЕ любимое число больше чем любимое! ");
        Console.Write("max = ");
        Console.WriteLine(b); 
        Console.Write("min = ");
        Console.WriteLine(a);  
}
 Console.Write("До встречи мой друг!!!");
