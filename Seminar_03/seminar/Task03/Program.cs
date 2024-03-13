// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и 
// последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив.

int[] array = [1, 3, 2, 4, 3, 4, 8];
int[] res = new int[array.Length / 2];

for (int i = 0; i < array.Length / 2; i++)
{
    res[i] = array[i] * array[array.Length - 1 - i];
    Console.Write(res[i] + " ");
}