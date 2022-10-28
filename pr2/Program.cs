// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int Coordinate(string message)
{
    Console.WriteLine (message);
    int coordinate = int.Parse(Console.ReadLine());
    return coordinate;
}

int x1 = Coordinate("Введите координату х точки А");
int y1 = Coordinate("Введите координату y точки А");
int z1 = Coordinate("Введите координату z точки А");

int x2 = Coordinate("Введите координату х точки B");
int y2 = Coordinate("Введите координату y точки B");
int z2 = Coordinate("Введите координату z точки B");

double distance = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine(distance);