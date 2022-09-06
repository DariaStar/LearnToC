// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8


// int GenerateRandomNumbers()
// {
//     int n = new Random().Next(10, 100);
//     return n;
// }

// void CompraiseNumbers()
// {
//     int n = GenerateRandomNumbers();
//     Console.WriteLine(n);
//     int a = n / 10;
//     int b = n % 10;
//     if (a > b)
//         Console.WriteLine(a);
//     else if (b < a)
//         Console.WriteLine(b);
//     else
//         Console.WriteLine("=");
// }

// CompraiseNumbers();

//11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int GenerateRandomNumber()
// {
//     int n = new Random().Next(100, 1000);
//     return n;
// }

// void CompraiseNumbers()
// {
//     int n = GenerateRandomNumber();
//     Console.WriteLine(n);
//     int a = n / 100;
//     int b = n % 10;
//     Console.WriteLine(a * 10 + b);
// }

// CompraiseNumbers();

//или

// int GenerateRandomNumber()
// {
//     int n = new Random().Next(100, 1000);
//     return n;
// }

// void CompraiseNumbers()
// {
//     int n = GenerateRandomNumber();
//     Console.WriteLine(n);
//     Console.Write(Convert.ToString(n)[0]);
//     Console.Write(Convert.ToString(n)[2]);
// } 

// CompraiseNumbers();

// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


// Console.Clear();
// void InputNumbers()
// {
//     int n = Convert.ToInt32(Console.ReadLine());
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(n + " " + m);
//     if (n % m == 0)
//         Console.WriteLine("yes");
//     else
//         Console.WriteLine(n % m);
// }

// InputNumbers();



// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// void InputNumbers()
// {
//     int n = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine(n);
//     if (n % 7 == 0 && n % 23 == 0)
//         Console.WriteLine("yes");
//     else
//         Console.WriteLine("no");
// }

// InputNumbers();

// Console.Clear();
// void InputNumbers()
// {
//     int n = Convert.ToInt32(Console.ReadLine());
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(n + " " + m);
//     if (n % m == 0)
//         Console.WriteLine("yes");
//     else
//         Console.WriteLine(n % m);
// }

// InputNumbers();

// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// void InputNumbers()
// {
//     int n = Convert.ToInt32(Console.ReadLine());
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(n + " " + m);
//     if(n * n == m || m * m == n)
//         Console.WriteLine("yes");
//     else
//         Console.WriteLine("no");
// }

// InputNumbers();

int[] array = { 1, 2, 3, 4, 5, 6, 7, 0, 8, 9, 0 };
int max1 = array[0];
int max2 = array[1];
int i = 0;

void MaxNumber1()
{
for (i = 0; i < array.Length; i++)
{
  
    if(max1 < array[i])
        max1 = array[i];
        Console.WriteLine("First maximum " + max1);
    else if (array[i] == 0) return max1;
} 

