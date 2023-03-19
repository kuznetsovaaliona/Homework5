//ДЗ

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumbers (int n)
// {
// if (n>1)
// {
//     ShowNumbers(n-1);
// }
// Console.Write(n+" ");
// }
// Console.WriteLine ("Input N: ");
// int n =Convert.ToInt32(Console.ReadLine());
// ShowNumbers(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumNumbers (int m, int n)
// {
//     if (m<n)
//     {
//         return SumNumbers(m+1, n)+m;
//     }

// else if (m>n)
// {
//     return SumNumbers(m,n+1)+n;
// }
// return n;
// }
// Console.WriteLine ("Input m ");
// int m = Convert.ToInt32 (Console.ReadLine ());
// Console.WriteLine ("Input n ");
// int n = Convert.ToInt32 (Console.ReadLine ());
// Console.WriteLine ($"M={m}; N={n} ->{SumNumbers(m,n)}");
