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