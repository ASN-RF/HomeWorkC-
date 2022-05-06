/* Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
   которая покажет количество чётных чисел в массиве.
                                                    [345, 897, 568, 234] -> 2*/
Console.WriteLine("Приветсвую! Помогите! Надо СРОЧНО задать размерность массива!!! Введите число!!! Жизнь программы в Ваших пальцах!");
int razmer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Все отлично справился! Решил задачу!!! Наверное!");
int[] a = new int[razmer];
int pol = 0;
Console.Write("[");
for (int i = 0; i < razmer; i++)
{
    a[i] = new Random().Next(100, 999);
    if (i < razmer - 1) Console.Write(a[i] + " ");
    if (i >= razmer - 1) Console.Write(a[i] + "]");
}
for (int i = 0; i < razmer; i++)
{
    if (a[i] % 2 == 0) pol++;
}
Console.Write(" --> " + pol);
Console.WriteLine();
Console.WriteLine("Количество чётных чисел в массиве с размерностью - " + razmer + " => " + pol);
