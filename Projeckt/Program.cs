using System;
int x, y;
Console.WriteLine("Введите x");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y");
y = Convert.ToInt32(Console.ReadLine());

//Вариант 1
//int z = x;
//x = y;
//y = z;

////Вариант 2
//x = x - y;
//y = x + y;
//x = y - x;

Console.WriteLine($"x = {x}, y = {y}");

Console.ReadKey();
