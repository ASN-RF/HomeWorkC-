/*Задача 8: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
            между ними в 3D пространстве.
                                         A (3,6,8); B (2,1,-7), -> 15.84
                                         A (7,-5, 0); B (1,-1,9) -> 11.53 
                                                                          */
void Coordian(double numX1, double numY1, double numZ1, double numX2, double numY2, double numZ2)
{
    double Xin2 = Math.Pow((numX2 - numX1), 2);
    double Yin2 = Math.Pow((numY2 - numY1), 2);
    double Zin2 = Math.Pow((numZ2 - numZ1), 2);
    double rezult = Xin2 + Yin2 + Zin2;
    Console.WriteLine("Расстояние между точками " + "А(" + numX1 + ";" + numY1 + "; " + numZ1 + ")" + " и " + "B(" + numX2 + "; " + numY2 + "; " + numZ2 + ")" + " равно " + Math.Sqrt(rezult));
}
double x, y, z, x1, y1, z1;
Console.Write("Введите координату по X точки A: ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Y точки A: ");
y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Z точки A: ");
z = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по X точки B: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Y точки B: ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Z точки B: ");
z1 = Convert.ToDouble(Console.ReadLine());
Coordian(x, y, z, x1, y1, z1);



