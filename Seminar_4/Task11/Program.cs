/* Задача 11: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
              натуральную степень B.
                                    3, 5 -> 243 (3⁵)
                                    2, 4 -> 16 */
/* В решение не использовалась библиотека "Math", даже в отношении модуля */
void Degree(int c, int d)
{
    int l = 1;
    int x = c; 
    int y = d; /*Переменные c и d требуются для отображения в консоле первоначального значения 
                 принимаемых на ввод отрицательных чисел*/
    if (c < 0)
    {
        c = c * (-1);
    }
    if (d < 0)
    {
        d = d * (-1);
    }
    int rezult = c;
    while (l < d)
    {
        rezult = rezult * c;
        l++;
    }
    Console.WriteLine(x + ", " + y + "--> " + rezult);
}
int A, B;
Console.WriteLine("Введите первое число (А): ");
A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число (B): ");
B = Convert.ToInt32(Console.ReadLine());
Degree(A, B);