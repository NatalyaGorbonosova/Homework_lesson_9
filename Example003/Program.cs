// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int FunctionAccerman(int m, int n)
{
    if(m == 0) return n + 1;
    else
    {
        if(m > 0 && n == 0) return FunctionAccerman(m - 1, 1);
        else return FunctionAccerman(m - 1, FunctionAccerman(m, n - 1));
    }
}
try
{
    Console.WriteLine("Введите два неотрицательных числа: ");
    int M = Convert.ToInt32(Console.ReadLine());
    int N = Convert.ToInt32(Console.ReadLine());
    if(M > -1 && N > -1) Console.WriteLine(FunctionAccerman(M, N));
    else Console.WriteLine("Числа должны быть целыми и неотрицательными!!!");
}
catch
{
    Console.WriteLine("Числа должны быть целыми и неотрицательными!!!");
}