// Поменять знаки элементов в массиве на противополжный.

int[] array = [-5, 6, 7, -3, 0];

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write(array[i] + " ");
}