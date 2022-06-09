void PrintArray(int[,] array) // Функция вывода в консоль правильного Треугольника Паскаля
{
    int razmer = array.GetLength(0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1) - 1; j >= 0; j--)  // перебираем с последнего элемента в строке
        {
            if (array[i, j] > 0)
            {
                Console.Write(array[i, j] + EmptyValue(array[i, j], array.GetLength(0))); // если условие соблюдается, печатаем элемент массива и отступ с права от него 
            }
            else
            {
                if (razmer <= 20)
                {
                    Console.Write("   "); // Длина смещения от левого края - 3 "пробела"
                }
                if (razmer > 20 && razmer <= 27)
                {
                    Console.Write("    "); // Длина смещения от левого края - 4 "пробела". 
                }
                if (razmer > 27)
                {
                    Console.Write("     "); // Длина смещения от левого края - 5 "пробелов" 
                }

            }
        }
        Console.WriteLine();
    }
}
int[,] CreateTriangle(int size) // Функция создания Треугольника Паскаля
{
    int[,] triangle = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        triangle[i, 0] = 1;  // заполнение левого ребра
        triangle[i, i] = 1; // заполнение диагоналей
    }
    for (int i = 2; i < size; i++)
    {
        for (int j = 1; j < i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
    PrintArray(triangle);
    return triangle;
}
string EmptyValue(int array, int razmer1) // Функция отступов после элемента
{
    string Empty = "";
    int RazmerElement = Convert.ToString(array).Length; // Число знаков в строку, в нашем случае будет считать кол-во знаков в элементе
    if (razmer1 <= 20)  // razmer1 - количество строк в Треугольнике.
    {
        for (int i = 0; i < 6 - RazmerElement; i++) // (6=2*3 пробела). Строго связанны с количеством пробелов от левого края. Требуется для симметрии треугольника.
        {
            Empty = Empty + " ";
        }
    }
    if (razmer1 > 20 && razmer1 <= 27)
    {
        for (int i = 0; i < 8 - RazmerElement; i++) // (8=2*4 пробела). Строго связанны с количеством пробелов от левого края. Требуется для симметрии треугольника.
        {
            Empty = Empty + " ";
        }
    }
    if (razmer1 > 27)
    {
        for (int i = 0; i < 10 - RazmerElement; i++) // (10=2*5 пробела). Строго связанны с количеством пробелов от левого края. Требуется для симметрии треугольника.?
        {
            Empty = Empty + " ";
        }
    }

    return Empty;
}

Console.Clear();  // Для удобства отоброжения (очистка консоли)
Console.WriteLine("Здравствуйте! Какое количество строк треугольника Паскаля, желаете наблюдать: ");
int KolichestvoStrok = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();  // Технологический пропуск строки 
CreateTriangle(KolichestvoStrok);
Console.WriteLine();  // Технологический пропуск строки