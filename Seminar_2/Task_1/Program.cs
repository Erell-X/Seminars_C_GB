// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Console.Clear();

int Num;

Num = new Random().Next(10,100);

Console.WriteLine(Num);

if (Num / 10 > Num % 10)
{
  Console.WriteLine(Num / 10);
}

else if (Num / 10 < Num % 10)
{
  Console.WriteLine(Num % 10);
}

else if (Num / 10 == Num % 10)
{
  Console.WriteLine(Num % 10);
}