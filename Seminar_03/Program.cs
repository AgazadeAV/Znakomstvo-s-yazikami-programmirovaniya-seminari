// Семинарское занятие

// Первое задание

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

// Второе задание

int[] array1 = [-5, 6, 7, -3, 0];
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = array1[i] * -1;
    Console.Write(array1[i] + " ");
}

// Третье задание (вариант преподователя)

int[] array2 = [1, 3, 2, 4, 3, 4, 8];
int[] res = new int[array2.Length / 2];
for (int i = 0; i < array2.Length / 2; i++)
{
    res[i] = array2[i] * array2[array2.Length - 1 - i];
    Console.Write(res[i] + " ");
}

// Третье задание (мой вариант)

int[] array3 = [-5, 6, 7, -3, 0, 6];

if (array3.Length % 2 == 0)
{
    int[] newArray = new int[array3.Length / 2];
    for (int i = 0; i < array3.Length / 2; i++)
    {
        newArray[i] = array3[i] * array3[array3.Length - 1 - i];
        Console.Write(newArray[i] + " ");
    }
}
else
{
    int[] newArray = new int[array3.Length / 2 + 1];
    for (int i = 0; i < array3.Length / 2; i++)
    {
        newArray[i] = array3[i] * array3[array3.Length - 1 - i];
        Console.Write(newArray[i] + " ");
    }
}

// Домашнее задание

//  Первое задание
int[] array4 = [1, 5, 10, 20, 30, 40, 99, 4, 90, 3];
int count = 0;
int minRange = 10;
int maxRange = 90;

for (int i = 0; i < array4.Length; i++)
{
    if (array4[i] >= minRange && array4[i] <= maxRange)
    {
        count++;
    }
}
Console.Write(count);

// Второе задание
int[] array5 = [1, 5, 10, 20, 30, 40, 99, 4, 90, 3];
int count1 = 0;

foreach (int even in array5)
{
    if (even % 2 == 0)
    {
        count1++;
    }
}
Console.Write(count1);

// Третье задание
double[] array6 = [0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01];
double min = array6[0];
double max = array6[0];
foreach (double minimum in array6)
{
    if (minimum < min)
    {
        min = minimum;
    }
}

foreach (double maximum in array6)
{
    if (maximum > max)
    {
        max = maximum;
    }
}

Console.Write(max - min);

// Четвертое задание

int number = 61651;
int digitsQuantity = number;
int tenPower = 1;
int size = 0;

while (digitsQuantity >= 1)
{
    digitsQuantity /= 10;
    tenPower *= 10;
    size++;
}

int[] array7 = new int[size];

Console.Write("[");
while (tenPower > 1)
{
    int arrayElement = number / (tenPower / 10);
    tenPower /= 10;
    array7[^size] = arrayElement % 10;
    if (tenPower > 1)
    {
        Console.Write(array7[^size] + " ");
    }
    else
    {
        Console.Write(array7[^size]);
    }
    size--;
}
Console.Write("]");
