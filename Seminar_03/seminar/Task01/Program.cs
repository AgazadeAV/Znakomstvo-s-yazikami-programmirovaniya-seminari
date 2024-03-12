// Узнать находится ли число num в массиве array.

int num = 8;
int[] array = [1, 3, 4, 19, 8];
bool flag = false;

foreach (int item in array)
{
    if (item == num)
    {
        flag = true;
    }
}

if (flag)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}