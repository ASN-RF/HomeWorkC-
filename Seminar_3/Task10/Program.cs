/*Задача 10: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
             чисел от 1 до N.
                                3 -> 1, 8, 27
                                5 -> 1, 8, 27, 64, 125 */
void Cub(double number)
{
    double num = 1;
    double rezult;
    while (num <= number)
    {
        rezult = Math.Pow(num,3);
        Console.Write(rezult);
        Console.Write(", ");
        num = num + 1;
    }
}
double x;
Console.Write("Введите Ваше любимое положительно число: ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write(x + " --> ");
Cub(x);
