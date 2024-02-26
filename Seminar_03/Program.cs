// // Семинарское занятие

// // Первое задание

// int num = 8;
// int[] array = new int[] { 1, 3, 4, 19, 8 };

// bool flag = false;

// foreach (int item in array)
// {
//     if (item == num)
//     {
//         flag = true;
//     }
// }
// if (flag)
// {
//     Console.Write("Да");
// }
// else
// {
//     Console.Write("Нет");
// }

// // Второе задание

// int[] array = new int[] { -5, 6, 7, -3, 0 };
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] * -1;
//     Console.Write(array[i] + " ");
// }

// // Третье задание (вариант преподователя)

// int [] array = new int [] {1,3,2,4,3,4,8};
// int [] res = new int [array.Length/2];
// for(int i=0;i<array.Length/2; i++){
//     res[i] = array[i] * array[array.Length-1-i];
//     Console.Write(res[i]+" ");
// }

// // Третье задание (мой вариант)

// int[] array = new int[] { -5, 6, 7, -3, 0, 6 };

// if (array.Length % 2 == 0)
// {
//     int[] newArray = new int[array.Length / 2];
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         newArray[i] = array[i] * array[array.Length - 1 - i];
//         Console.Write(newArray[i] + " ");
//     }
// }
// else
// {
//     int[] newArray = new int[array.Length / 2 + 1];
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         newArray[i] = array[i] * array[array.Length - 1 - i];
//         Console.Write(newArray[i] + " ");
//     }
// }

// // Домашнее задание

// //  Первое задание
// int[] array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
// int count = 0;
// int minRange = 10;
// int maxRange = 90;

// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] >= minRange && array[i] <= maxRange)
//     {
//         count++;
//     }         
// }
// Console.Write(count);

// // Второе задание
// int[] array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
// int count = 0;

// foreach(int even in array)
// {
//     if(even%2==0)
//     {
//         count++;
//     }
// }
// Console.Write(count);

// // Третье задание
// int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
// double min = numbers[0];
// double max = numbers[0];
// foreach(double minimum in numbers)
// {
//     if(minimum < min)
//     {
//         min = minimum;
//     }
// }

// foreach(double maximum in numbers)
// {
//     if(maximum > max)
//     {
//         max = maximum;
//     }
// }

// Console.Write(max - min);

// Четвертое задание

int number = 61651;
int digitsQuantity = number;
int arrayElement = number;
int tenPower = 1;
int size = 0;

while (digitsQuantity >= 1)
{
    digitsQuantity /= 10;
    tenPower *= 10;
    size++;
}

int[] array = new int[size];

Console.Write("[");
while (tenPower > 1)
{
    arrayElement = number / (tenPower / 10);
    tenPower /= 10;
    array[array.Length - size] = arrayElement % 10;
    if(tenPower > 1)
    {
        Console.Write(array[array.Length - size] + " ");
    }
    else
    {
        Console.Write(array[array.Length - size]);
    }
    size--;
}
Console.Write("]");