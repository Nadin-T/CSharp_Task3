// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void ShowNumbers (int M, int N)
{
    if (M > N)
    {
        return;
    }
    Console.Write($"{M} ");
    ShowNumbers (M+1, N);
}

Console.WriteLine ("Введите число M:");
int M = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите число N:");
int N = Convert.ToInt32 (Console.ReadLine ());

ShowNumbers (M,N);