// Дополнительная задача из дз:
// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int max_f = n;
// int max_s = -1;
// while (n != 0)
// {
//     n = Convert.ToInt32(Console.ReadLine());
//     if (n > max_f)
//     {
//         max_s = max_f;
//         max_f = n;
//     }
//     else if (n > max_s)
//     {
//         max_s = n;
//     }
// }
// Console.WriteLine(max_s);

// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Enter X ");
// int x = Covert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y ");
// int y = Covert.ToInt32(Console.ReadLine());

// if(x == 0 || y == 0)
// Console.WriteLine("Wrong, try again");

// if(0 < x && 0 < y)
// Console.WriteLine("I");
// else if(0 > x && 0 < y)
// Console.WriteLine('II');
// if(0 > x && 0 > y)
// Console.WriteLine('III');
// else if(0 > x && 0 < y)
// Console.WriteLine('IV');

//Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 1 || n > 4)
//     n = Convert.ToInt32(Console.ReadLine());

// if (n == 1)
//     Console.WriteLine("x > 0 and y > 0");
// if (n == 2)
//     Console.WriteLine("x < 0 and y > 0");
// if (n == 3)
//     Console.WriteLine("x < 0 and y < 0");
// if (n == 4)
//     Console.WriteLine("x > 0 and y < 0");

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Enter x1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y1");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter x2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y2");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double distance = Math.Sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1));
// Console.WriteLine(distance);

//double L = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)); - квадрат и квадаратный корень

//Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Enter number ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// int j = 0;

// for (i = 1; i < 5; i++)
// {
// j = Math.Pow( i, 2);
// Console.WriteLine(j);
// }

// или

// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
//     Console.WriteLine(i + "^2 = " + i * i);







