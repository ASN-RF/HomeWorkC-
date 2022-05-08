/* Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
             и возвращает значение этого элемента или же указание, что такого элемента нет.
                                                            Например, задан массив:
                                                            1 4 7 2
                                                            5 9 2 3
                                                            8 4 2 4
                                                            1 7 -> такого числа в массиве нет */
void RandomMatrix(int line, int column)
{
    int m = 3;     // Можно поменять
    int n = 4;    // Можно поменять
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    if (line < 0 | line > m - 1 | column < 0 | column > n - 1)
    {
        Console.WriteLine("(" + line + ", " + column + ")" + " --> " + "Такого элемента в массиве нет. Место вакантно!");
    }
    else
    {
        Console.WriteLine("Значение элемента массива с координатами" + " (" + (line + 1) + ", " + (column+1) + ")" + " --> " + matrix[line, column]);
    }
}
Console.WriteLine("Здравствуйте! Укажите номер строки (цифра от 1 до 3): ");
int stroka = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("А теперь, номер столбца (цифра от 1 до 4): ");
int stolb = Convert.ToInt32(Console.ReadLine()) - 1;
RandomMatrix(stroka, stolb);

// При вводе номера строки и (или) столбца <= 0, при выводе будет отрицательное число