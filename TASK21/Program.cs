// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double n1 = x2 - x1;
    double n2 = y2 - y1;
    double n3 = z2 - z1;
    return Math.Sqrt(n1*n1 + n2*n2 + n3*n3);
}
Console.WriteLine("Введите координаты первой точки (x + enter, y + enter, z + enter):");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки (x + enter, y + enter, z + enter):");
double xB = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());
double zB = Convert.ToDouble(Console.ReadLine());
double dist = FindDistance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками - {dist}");