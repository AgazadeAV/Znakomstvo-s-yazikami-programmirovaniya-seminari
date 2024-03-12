// Записать трёхзначное число без второй цифры.

// 1-ый вариант

int num = 654;
int result = (num / 100) * 10 + (num % 10);
Console.WriteLine("The num without second digit is " + result);

// 2-ой вариант

int first = num / 100;
int second = num % 10;
Console.Write("The num without second digit is " + first + second);