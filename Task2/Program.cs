// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.


Console.Write("Enter the coordinate of point X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Enter the coordinate of point Y: ");
int Y = int.Parse(Console.ReadLine());

if (X == 0 || Y == 0)
{
    Console.WriteLine("Условие не выполняется");
}
else
if (X > 0 && Y > 0)
{
    Console.WriteLine("The point is located in the first quadrant");
}
if (X < 0 && Y > 0)
{
    Console.WriteLine("The point is located in the second quadrant");
}
if (X < 0 && Y < 0)
{
    Console.WriteLine("The point is located in the third quadrant");
}
if (X > 0 && Y < 0)
{
    Console.WriteLine("The point is located in the fourth quadrant");
}