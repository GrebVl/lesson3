/* 
программа принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double getDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double disttens = Math.Sqrt(Math.Pow((x2 - x1), 2)
    + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

    return disttens;
}

Console.WriteLine("Введите кардинаты точки A:");

Console.WriteLine("точка A кордината X");
int aX = int.Parse(Console.ReadLine());

Console.WriteLine("точка A кордината Y");
int aY = int.Parse(Console.ReadLine());

Console.WriteLine("точка A кордината Z");
int aZ = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кардинаты точки B:");

Console.WriteLine("точка B кордината X");
int bX = int.Parse(Console.ReadLine());

Console.WriteLine("точка B кордината Y");
int bY = int.Parse(Console.ReadLine());

Console.WriteLine("точка B кордината Z");
int bZ = int.Parse(Console.ReadLine());

double distance = getDistance(aX, aY, aZ, bX, bY, bZ);
Console.WriteLine(distance);
