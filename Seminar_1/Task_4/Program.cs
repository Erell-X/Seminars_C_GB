// Напишите программу, которая на вход принимает одно число (N), а на выходе 
// показывает все целые числа в промежутке от -N до N. 
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Clear();

int N, Count;

Console.WriteLine("Введите число:");

N = Convert.ToInt32(Console.ReadLine());
Count = -N;

while (Count <= N)

{
  Console.WriteLine(Count);
  Count ++;
}


// // Напишите программу, которая на вход принимает одно
// // число (N), а на выходе показывает все целые числа 
// // в промежутке от -N до N. 
// // 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// // 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите Число: ");

// int n = Convert.ToInt32(Console.ReadLine());

// int count = -n;

// while (count < n+1)
// {
//     Console.WriteLine(count + " ");
//     count ++;
// }
// // Напишите программу, которая принимает на вход трёхзначное число и на выходе
// // показывает последнюю цифру этого числа. Например, 456->6 782->2 918->8

// Console.WriteLine ("Введите трехзначное число: ");

// int a = int.Parse(Console.ReadLine());

// Console.WriteLine(a % 10);