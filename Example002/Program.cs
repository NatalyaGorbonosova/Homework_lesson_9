// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumSegment(int M, int N)
{
    if (N== M - 1) return 0;
    return SumSegment(M, N-1) + N;
}
try
{
    Console.WriteLine("Введите натуральные числа");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(SumSegment(m, n));
}
catch
{
    Console.WriteLine("Введите натуральное число!!!");
}

