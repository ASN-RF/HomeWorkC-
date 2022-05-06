/* Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
             стоящих на нечётных позициях.
                                         [3, 7, 23, 12] -> 19
                                         [-4, -6, 89, 6] -> 0 */
Console.WriteLine("Приветсвую! Помогите! Надо СРОЧНО задать размерность массива!!! Введите число!!! Жизнь программы в Ваших пальцах!");
int razmer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Все отлично справился! Решил задачу!!! Наверное!");
int[] a = new int[razmer];
int rand = 0;
Console.Write("[");
for (int i = 0; i < razmer; i++)
{
    a[i] = new Random().Next(0, 99);
    if (i < razmer - 1) Console.Write(a[i] + " ");
    if (i >= razmer - 1) Console.Write(a[i] + "]");
}
for (int i = 0; i < razmer; i++)
{
    if (i % 2 == 0) rand = rand + a[i];    /*Если правильно понял "индекс(i) != "позиция". Позиция (1,  2, 3, ... n)
                                                                                                   [12, 4, 5, ... n]
                                                                                            Индекс (0,  1, 2, ... n) */
}
Console.Write(" --> " + rand);
Console.WriteLine();
Console.WriteLine("Сумма элементов стоящих на нечетных позициях в массиве с размерностью - " + razmer + " => " + rand);
