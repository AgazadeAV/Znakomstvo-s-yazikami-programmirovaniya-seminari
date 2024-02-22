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

// int[] array = new int[] { -5, 6, 7, -3, 0 };
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] * -1;
//     Console.Write(array[i] + " ");
// }

// Найдите произведения пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новый массив.

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

int [] array = new int [] {1,3,2,4,3,4,8};
int [] res = new int [array.Length/2];
for(int i=0;i<array.Length/2; i++){
    res[i] = array[i] * array[array.Length-1-i];
    Console.Write(res[i]+" ");
}

