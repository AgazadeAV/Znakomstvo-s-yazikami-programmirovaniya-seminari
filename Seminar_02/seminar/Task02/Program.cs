// Напишите программу, которая принимает на вход трёхзначное число и
// возводит вторую цифру этого числа в степень, равную третьей цифре.

int num = 483;
int firstDigit = num / 100;
int thirdDigit = num % 10;
int secondDigit = (num - (firstDigit * 100) - thirdDigit) / 10;
int result = 1;

for (int i = 1; i <= thirdDigit; i++)
{
    result *= secondDigit;
}

Console.WriteLine(result);