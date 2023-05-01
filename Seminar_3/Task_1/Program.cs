// Решение задачи из семинара №2 другим способом.

// Напишите программу, которая выводит случайное трехзначное число и 
// удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int NewNumber(int N)         // Функциональная зависимость N от NewNumber
{
  int digit1 = N / 100;
  int digit3 = N % 10;
  int result = digit1 * 10 + digit3;

  return result;
}

int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное число: {number}");
int result = NewNumber(number);                     // На основе модели метода вводим аналогичный алгоритм, но с другой переменной.

Console.WriteLine(result);