// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermannFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (n != 0 && m == 0)
    {
        return AckermannFunction(n - 1, 1);
    }
    else
    {
        return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
    }
}

Console.Write(AckermannFunction(2, 3));