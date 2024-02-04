// Задание 1. Совместная работа
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

int number = 678;
int firstDigit = number / 100; 
int  thirdDigit = number % 10;
int result = firstDigit * 10 + thirdDigit;
Console.WriteLine($"В числе {number} => {result} ");