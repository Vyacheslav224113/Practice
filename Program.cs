// Задание 1. Совместная работа
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// int number = 678;
// int firstDigit = number / 100; 
// int  thirdDigit = number % 10;
// int result = firstDigit * 10 + thirdDigit;
// Console.WriteLine($"В числе {number} => {result} ");

// Задание 2. Обсуждение решений
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4

int number = 925;
int secondDigit = number / 10 % 10;
int thirdDigit = number % 10;
int result = (int)Math.Pow(secondDigit, thirdDigit);
// Результат переводится в целое число с помощью int
Console.WriteLine($"{secondDigit} ^ {thirdDigit} = {result}");

