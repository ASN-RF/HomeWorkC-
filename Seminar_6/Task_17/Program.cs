/* Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
                                                                            0, 7, 8, -2, -2 -> 2
                                                                            1, -7, 567, 89, 223-> 3 */
int CountPolNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
void printArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]} --> ");
}
Console.WriteLine("Привествую! Сколько чисел Вам очень хочеться ввести?");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Это очень крутое число! Вам сегодня крупно повезет!");
int[] array = new int[M];
Console.WriteLine("Теперь введите " + M + " Ваших любимых числа(ел). После каждого числа нажмите клавишу -ENTER-");
for (int i = 0; i < M; i++) array[i] = Convert.ToInt32(Console.ReadLine());
printArray(array);
Console.WriteLine(CountPolNumbers(array));
Console.WriteLine("100% ВАМ повезет!!! Сейчас мы это докажем:");
Console.WriteLine("Из Ваших " + M + " чисел " + CountPolNumbers(array) + " являются больше 0!");
Console.WriteLine("Теперь если мы суммируем все эти числа, затем умножим на 0, а после прибавим 1, то получим 1, а это ДА - ДА тебе повезет!!!");