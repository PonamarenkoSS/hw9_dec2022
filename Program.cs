// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите M: ");
// int M = int.Parse(Console.ReadLine()!);

// Console.Write("Введите N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbers(M,N));

// string PrintNumbers(int start, int end){
//     if(start == end) return start.ToString();
//     return(end + " " + PrintNumbers(start, end-1));
// }

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите M: ");
// int M = int.Parse(Console.ReadLine()!);

// Console.Write("Введите N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(SumNumbers(M,N));

// int SumNumbers(int start, int end){
//     if(start == end) return start;
//     return(start + SumNumbers(start + 1, end));
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите M: ");
// int M = int.Parse(Console.ReadLine()!);

// Console.Write("Введите N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(AckermannFunction(M,N));

// int AckermannFunction(int m, int n){
//     if (m == 0) return n+1;
//     if (m>0 && n==0) return AckermannFunction(m-1,1);
//     return(AckermannFunction(m-1, AckermannFunction(m, n-1)));
// }
