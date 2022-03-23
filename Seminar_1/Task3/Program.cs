/* Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
   является ли число чётным (делится ли оно на два без остатка). (4 -> да
                                                                 -3 -> нет
                                                                  7 -> нет*/
Console.WriteLine("Привет!");
Console.WriteLine("Введите ваше любимое число: ");
int a = Convert.ToInt32(Console.ReadLine());
/* int = a = Convert.ToInt32(Console.ReadLine()); */
if (a%2 == 0)
{
    Console.WriteLine("ДА! и Ещё раз ДА! Поздравляем! Ваше любимое число ЧЕТНОЕ!");
    Console.Write(a); 
    Console.WriteLine(" - ЧЕТНОЕ");
}
else
{
    Console.WriteLine("НЕТ! и Ещё раз НЕТ! К сожалению! Ваше любимое число НЕЧЕТкОЕ! ОЙ НЕЧЕТНОЕ!");
    Console.Write(a); 
    Console.WriteLine(" - НЕЧЕТНОЕ");
}