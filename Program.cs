﻿// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// void ShowNumbers (int M, int N)
// {
//     if (M > N)
//     {
//         return;
//     }
//     Console.Write($"{M} ");
//     ShowNumbers (M+1, N);
// }

// Console.WriteLine ("Введите число M:");
// int M = Convert.ToInt32 (Console.ReadLine ());
// Console.WriteLine ("Введите число N:");
// int N = Convert.ToInt32 (Console.ReadLine ());

// ShowNumbers (M,N);


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// int Ackermann(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n == 0)
//     {
//         return Ackermann(m - 1, 1);
//     }
//     else
//     {
//         return Ackermann(m - 1, Ackermann(m, n - 1));
//     }
// }

// Console.WriteLine($"Результат: {Ackermann (3,5)}");


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void PrintArray (int [] array, int index)
{
    if (index < 0)
    {
       return;
    }
    Console.Write ($"{array[index]} ");
    PrintArray(array, index-1);
}
int [] arr = {1,2,5,0,10,34};
PrintArray(arr, arr.Length-1);