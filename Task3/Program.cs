﻿/* Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
   является ли число чётным (делится ли оно на два без остатка). (4 -> да
                                                                 -3 -> нет
                                                                  7 -> нет*/
Console.WriteLine("Привет!");
Console.WriteLine("Введите ваше любимое число: ");
/* Так как в задаче не было указанно, что число должно быть целым, 
   был использован оператор double, в связи с тем что множестов чисел doble > integer
   Однако после команды double, в коменнариях приводится команда с оператором int, 
   которая была протестирована на работоспособность*/ 

double a = Convert.ToDouble(Console.ReadLine());
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
        
       