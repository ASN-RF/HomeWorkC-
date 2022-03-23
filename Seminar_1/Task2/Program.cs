/* Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
             из этих чисел. (2, 3, 7 -> 7
                             44 5 78 -> 78
                             22 3 9 -> 22)    */ 
Console.WriteLine("Привет!");
Console.WriteLine("Введите ваше любимое число: ");
/* Так как в задаче не было указанно, что число должно быть целым, 
   был использован оператор double, в связи с тем что множестов чисел doble > integer
   Однако после команды double, в коменнариях приводится команда с оператором int, 
   которая была протестирована на работоспособность*/ 

double a = Convert.ToDouble(Console.ReadLine());
/* int = a = Convert.ToInt32(Console.ReadLine()); */

Console.WriteLine("Введите ваше НЕ любимое число: ");

double b = Convert.ToDouble(Console.ReadLine());
/* int = b = Convert.ToInt32(Console.ReadLine()); */

Console.WriteLine("Ты молодец! А теперь можешь указать любой случайное число: ");

double c = Convert.ToDouble(Console.ReadLine());
/* int = c = Convert.ToInt32(Console.ReadLine()); */

if (a == b)
{
    if (b == c)
    {
       Console.WriteLine("Ого! Какая у тебя фантазия мой друг! Все твои числа равны! Почитай Джеффри Рихтера CLR via C# - и фантазии прибавиться!"); 
    }
    else
    {
         if (b > c)
    {
       Console.WriteLine("Вот это ДА! Твои любимое и не любое числа РАВНЫ и больше чем твоё случайное число!"); 
       Console.Write("max = ");
       Console.Write(a);
       Console.Write(", ");
       Console.WriteLine(b);
       Console.Write("min = ");
       Console.WriteLine(c);     
    }
       else
       {
       Console.WriteLine("Интересно! Твоё случайное самое большое число, а твои любимое и не любое числа РАВНЫ и немного меньше! Не расстраивайся почитай Джеффри Рихтера CLR via C# - и все наладиться!"); 
       Console.Write("max = ");
       Console.WriteLine(c);  
       Console.Write("min = ");
       Console.Write(a);
       Console.Write(", ");
       Console.WriteLine(b);
       }
    }
}
else
{
     if (b == c)
    {
         if (a > b)
        {
       Console.WriteLine("КРУТО! Твои любимое число самое большое! А не любимое и случайное РАВНЫ!"); 
       Console.Write("max = ");
       Console.WriteLine(a); 
       Console.Write("min = ");
       Console.Write(b);
       Console.Write(", ");
       Console.WriteLine(c);  
        }

       else
       {
       Console.WriteLine("Ach! Твоё любимое число самое маленькое, а не любимое и случайное равна и немного больше!"); 
       Console.Write("max = ");
       Console.Write(b);
       Console.Write(", ");
       Console.WriteLine(c);
       Console.Write("min = ");
       Console.WriteLine(a);  
       }
    }

    else
    {
        if (a > b)
       {
         if (a > c)
           {
           Console.WriteLine("Да!Да!Да! Твоё любимое число самое большое, остальные меньше! УРА!"); 
           Console.Write("max = ");
           Console.WriteLine(a);  
           Console.Write("min = ");
           Console.Write(b);
           Console.Write(", ");
           Console.WriteLine(c);
           }
         else
           {
           Console.WriteLine("Интересно! Твоё случайное самое большое число, а твои любимое и не любое числа немного меньше! Не расстраивайся почитай Джеффри Рихтера CLR via C# - и все наладиться!"); 
           Console.Write("max = ");
           Console.WriteLine(c);  
           Console.Write("min = ");
           Console.Write(a);
           Console.Write(", ");
           Console.WriteLine(b);
           }
       }
      else
        {
             if (b > c)
           {
           Console.WriteLine("О,нет! Твоё НЕ любимое число самое большое, остальные меньше! Брр!"); 
           Console.Write("max = ");
           Console.WriteLine(b);  
           Console.Write("min = ");
           Console.Write(a);
           Console.Write(", ");
           Console.WriteLine(c);
           }

            else
           {
           Console.WriteLine("Интересно! Твоё случайное самое большое число, а твои любимое и не любое числа немного меньше! Не расстраивайся почитай Джеффри Рихтера CLR via C# - и все наладиться!"); 
           Console.Write("max = ");
           Console.WriteLine(c);  
           Console.Write("min = ");
           Console.Write(a);
           Console.Write(", ");
           Console.WriteLine(b);
           }
        }
    }
}