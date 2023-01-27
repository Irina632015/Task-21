// SНапишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
int x1 = ReadInt("Координата X первой точки: ");
int y1 = ReadInt("Координата Y первой точки: ");
int z1 = ReadInt("Координата Z первой точки: ");
int x2 = ReadInt("Координата X второй точки: ");
int y2 = ReadInt("Координата Y второй точки: ");
int z2 = ReadInt("Координата Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double Length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {Length}");

int ReadInt(string msg)
{
 Console.Write(msg);
 return Convert.ToInt32(Console.ReadLine());
}