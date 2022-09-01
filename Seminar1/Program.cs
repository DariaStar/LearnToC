//Console.WriteLine("Enter your number");

//int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(n * n);

//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 5; b = 25 -> да
//a = 2 b = 10 -> нет
//a = 9; b = -3 -> нет
//a = -3 b = 9 -> да

//Console.Write("Enter number 1: ");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter number 2: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//if (num2 == num1 * num1)
//  Console.WriteLine("yes");
//else
//  Console.WriteLine("no");

//Console.Write("Enter number: ");

//int a = 1;
//int b = 2;
//int c = 3;
//int d = 4;
//int f = 5;
//int g = 6;
//int h = 7;
//int k = Convert.ToInt32(Console.ReadLine());

//while (1 < K || K > 7)
//{
//    Console.Write("Try again");
//}
//if (a == k)
//    Console.Write("Monday");
//else if (b == k)
// Console.Write("Thuesday");
// else if (c == k)
//Console.Write("Wednsday");
// else if (d == k)
// Console.Write("Thursday");
// else if (f == k)
// Console.Write("Friday");
// else if (g == k)
// Console.Write("Saturday");
// else if (h == k)
// Console.Write("Sunday");



//Console.Write("Input number: ");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = (-1) * n; i <= n; i++)
//Console.Write(i + " ");


//Console.Write("Input number: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int i = (-1) * n;
//while (i <= n)
//{
//Console.Write(i);
//Console.Write(", ");
//i++;
//}


Console.Write("Input 3-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
int ld = 0;
while(n < 100 || n > 999)
{
   Console.Write("Try again");
}
ld = n % 10;
Console.Write(ld);