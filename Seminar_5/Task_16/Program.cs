/* Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
             элементов массива.
                               [3 7 22 2 78] -> 76 */
Console.WriteLine("Приветсвую! Помогите! Надо СРОЧНО задать размерность массива!!! Введите число!!! Жизнь программы в Ваших пальцах!");
int razmer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Все отлично справился! Решил задачу!!! Наверное!");
double[] a = new double[razmer];
double min = 0;
double max = 0;
double sum;
Console.Write("[");
for (int i = 0; i < razmer; i++)
{
    a[i] = new Random().Next(-99, 99);
    if (i < razmer - 1) Console.Write(a[i] + " ");
    if (i >= razmer - 1) Console.Write(a[i] + "]");
}
max = a[0];
min = a[0];
for (int i = 0; i < razmer; i++)
{
    if (a[i] > max) max = a[i];
    if (a[i] < min) min = a[i];
}
sum = max + min;
Console.WriteLine(" --> " + sum);
Console.WriteLine("Максимальноое значение = " + max);
Console.WriteLine("Минимальное значение = " + min);
if (min < 0)
{
    Console.WriteLine(max + " - " + " (" + min + ") " + " = " + sum);
}
else
{
    Console.WriteLine(max + " - " + min + " = " + sum);
}
