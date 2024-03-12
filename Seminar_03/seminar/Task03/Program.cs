// Создать массив, элементы которого будут равняться произведению
// элементов, симментрично расположенных в массиве array.

int[] array = [1, 3, 2, 4, 3, 4, 8];
int[] res = new int[array.Length / 2];

for (int i = 0; i < array.Length / 2; i++)
{
    res[i] = array[i] * array[array.Length - 1 - i];
    Console.Write(res[i] + " ");
}