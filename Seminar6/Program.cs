// //Задача 39.

// int[] array = new int[6];
// int aux = 0;

// void FillArray()
// {
// for(int i = 0; i < array.Length; i ++)
//     array[i] = new Random().Next(1, 10);
 
// Console.WriteLine("Array [" + string.Join(", ", array) + "]");
// }

// void SwapPalces()
// {
// if(array.Length % 2 == 0)
// {
//     for(int i = 0; i < array.Length / 2; i ++)
//     {
//     aux = array[i];
//     array[i] = array[array.Length - i - 1];
//     array[array.Length - i - 1] = aux;
//     }
// }
// else
// {
// for(int i = 0; i < array.Length / 2 - 1; i ++)   
//   {
//     aux = array[i];
//     array[i] = array[array.Length - i - 1];
//     array[array.Length - i - 1] = aux;
//     }
// }
// Console.WriteLine("New array [" + string.Join(", ", array) + "]");
// }
// FillArray();
// SwapPalces();

//или

// Console.Clear();

// void InputArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// array[i] = new Random().Next(1, 10);
// }


// void Reverse(int[] array)
// {
// for (int i = 0; i < array.Length / 2; i++)
// {
// int x = array[i];
// array[i] = array[array.Length - i - 1];
// array[array.Length - i - 1] = x;
// }
// }


// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// Reverse(array);
// Console.WriteLine("[" + string.Join(", ", array) + "]");

//Task 40.

// Console.WriteLine("Enter num1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter num2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter num3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if(num1 + num2 > num3 && num1 + num3 > num2 && num2 + num3 > num1)
// Console.WriteLine("There could be a triangle");
// else
// Console.WriteLine("That is not a triangle");


//Task 42.


// int n = Convert.ToInt32(Console.ReadLine());
// string result = "";
// while (n > 0)
// {
// int x = n % 2;
// result = Convert.ToString(x) + result;
// n = n / 2;
// }
// Console.WriteLine(result);

// //or

// Console.Clear();
// string f(int n)
// {
// if (n == 0 || n == 1)
// return Convert.ToString(n);

// return f(n / 2) + Convert.ToString(n % 2);
// }

// Console.WriteLine(f(11));

//
// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int x, a0 = 0, a1 = 1;
// for (int i = 0; i < n; i++)
// {
// Console.Write(a0 + " ");
// x = a0 + a1;
// a0 = a1;
// a1 = x;
// }

// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// array[0] = 0;
// array[1] = 1;
// for (int i = 1; i < n - 1; i++)
// {
// array[i + 1] = array[i] + array[i - 1];
// }
// Console.WriteLine("[" + string.Join(", ", array) + "]");


//copy massive

// Console.Clear();
// int[] array = {1, 2};
// int[] array1 = new int[array.Length];
// for (int i = 0; i < array.Length; i++)
// array1[i] = array[i];
// array1[0] = 10;
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine(string.Join(", ", array1));