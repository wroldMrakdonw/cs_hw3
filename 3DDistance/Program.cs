// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
System.Console.Write("Напише координату x первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Напише координату y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Напише координату z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Напише координату x второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Напише координату y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Напише координату z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
System.Console.WriteLine(result);