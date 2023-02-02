// Задача 19.
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckPallindrom (int number) 
{
    if (number > 9999 && number < 100000)
    {
        int units = number % 10;
        int dozens = (number / 10) % 10;
        int hund = (number / 100) % 10;
        int thous = (number / 1000) % 10;
        int dozThous = number / 10000;

            if (units == dozThous && dozens == thous)
            {
                Console.WriteLine("This is pallindrom");
            }
            else Console.WriteLine("This is not pallindrom");

    }
    else Console.WriteLine("This is incorrect number!");
}
Console.Write("Input 5digits number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
CheckPallindrom(user_number);

// Задача 21.
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double DistanceAB (int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;
    double distAB = Math.Round(Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ), 2);
    return distAB;
}

Console.Write("Input X coordinat of A: ");
int xAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinat of A: ");
int yAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z coordinat of A: ");
int zAcoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Input X coordinat of B: ");
int xBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinat of B: ");
int yBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z coordinat of B: ");
int zBcoord = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistanceAB(xAcoord, yAcoord, zAcoord, xBcoord, yBcoord, zBcoord);
Console.WriteLine($"Distance between A & B {distanceAB}");

double distanceAB1 = DistanceAB(xAcoord, yAcoord, zAcoord, xBcoord, yBcoord, zBcoord);
Console.WriteLine($"Distance between A & B {distanceAB1:f2}");
*/

// Задача 23.
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
void Cube (int uN)
{
    int current = 1;
    while (current <= uN)
    {
        int res = current * current * current;
        Console.Write($"{res}, ");
        current ++;
    }
    Console.WriteLine("\b\b."); // \ убирает последний символ. 
                                //В данном случае обратные слеши убирает пробел и запятую.
}

Console.Write("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number >= 1)
{
    Console.Write($"{user_number} -> ");
    Cube(user_number);
}
else Console.WriteLine("Impossible value!");
*/