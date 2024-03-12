// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] array = [0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01];
double min = array[0];
double max = array[0];

foreach (double minimum in array)
{
    if (minimum < min)
    {
        min = minimum;
    }
}

foreach (double maximum in array)
{
    if (maximum > max)
    {
        max = maximum;
    }
}

Console.Write(max - min);