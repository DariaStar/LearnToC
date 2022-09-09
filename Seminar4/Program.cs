// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// double n = Convert.ToInt32(Console.ReadLine());
// Console.Write(((n + 1) / 2) * n);

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Enter number ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while(n > 0)
// {
//     n /= 10;
//     count++;
// }
// Console.WriteLine(count);

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Enter number ");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 1;

// for(int i = 1; i < n + 1; i++)
// sum = sum * i;

// Console.WriteLine(sum);

// int n = Convert.ToInt32(Console.ReadLine());
// int res = 1;
// int i = 2;
// while (i <= n)
// {
//     res *= i; // res = res * i
//     i++;
// }
// Console.WriteLine(res);

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];

// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 2);

// Console.WriteLine("[" + string.Join(", ", array) + "]");

//или

// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];

// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 3);
//     // array[0] = 0/1;
//     // array[1] = 0/1;
//     // array[2] = 0/1;   

// Console.WriteLine("[" + string.Join(", ", array) + "]");
