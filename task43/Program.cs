// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("В соответствии с заданными уравнениями прямых (y = k1 * x + b1, y = k2 * x + b2), введите");
Console.Write("b1 : ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1 : ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 : ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 : ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1==k2)
    if (b1==b2) {Console.WriteLine("Заданные прямые совпадают");}
    else {Console.WriteLine("Заданные прямые параллельны");}
else {
double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;
Console.WriteLine($"Заданные прямые пересекаются в точке (x,y) : ({x}, {y})");
}