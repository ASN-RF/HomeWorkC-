/*Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
            все чётные числа от 1 до N. ( 5 -> 2, 4
                                          8 -> 2, 4, 6, 8*/
Console.WriteLine("Привет!");
Console.WriteLine("Введите ваше любимое число: ");
/* Так как в задаче не было указанно, что число должно быть целым, 
   был использован оператор double, в связи с тем что множестов чисел doble > integer
   Однако после команды double, в коменнариях приводится команда с оператором int, 
   которая была протестирована на работоспособность*/ 

double N = Convert.ToDouble(Console.ReadLine());
/* int = N = Convert.ToInt32(Console.ReadLine()); */
int a = 2;
 if (N > 0)
 {
   while (a <= N)
   {
    Console.Write(a);
    Console.Write(", ");
    a = a + 2;
   }
 }
 else
 {
    a = a * 0;
     while (a >= N)
   {
    Console.Write(a);
    Console.Write(", ");
    a = a - 2;
   }
     
 }