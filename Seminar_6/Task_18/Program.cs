/* Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. Вывести массив в 
             виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.
                                                                        3, 4 ->
                                                                        1 1 1 1
                                                                        1 0 0 1
                                                                        1 1 1 1 */
void NewMatrix(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (i == 0 || i == matrix1.GetLength(0) - 1) matrix1[i, j] = 1;
            else if (j == 0 || j == matrix1.GetLength(1) - 1) matrix1[i, j] = 1;
            else matrix1[i, j] = 0;
        }
    }
}
void printmatrix1ix(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"{matrix1[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Здравствуйте! Приступаю к решению задачи 2 ДЗ к 6-му семинару.");
Console.WriteLine("Ввидите количестов строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввидите количестов столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
Console.WriteLine(row + ", " + column + " -> ");
NewMatrix(matrix);
printmatrix1ix(matrix);