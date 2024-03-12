// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

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

int[] array = new int[size];

Console.Write("[");

while (tenPower > 1)
{
    int arrayElement = number / (tenPower / 10);
    tenPower /= 10;
    array[^size] = arrayElement % 10; // ^size = array.Length - size
    if (tenPower > 1)
    {
        Console.Write(array[^size] + " ");
    }
    else
    {
        Console.Write(array[^size]);
    }
    size--;
}

Console.Write("]");
