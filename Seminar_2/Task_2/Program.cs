// Напишите программу, которая выводит случайное трехзначное число и 
// удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();

int num, digit1, digit3;

num = new Random().Next(100,1000);
Console.WriteLine($"Случайное трёхзначное число равно {num}");

digit1 = num / 100;
digit3 = num % 10;

Console.WriteLine($"Число после удаления 2-й цифры равно {digit1}{digit3}");