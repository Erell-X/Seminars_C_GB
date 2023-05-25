// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N

// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int square = 1;
// while (num >= square)
// {
//   double Mult = Math.Pow(square, 2);
//   square++;
//   System.Console.Write($"{Mult} ");
// }

for (int i = 1; i <= num; i++)
{
  double Lin = Math.Pow(i, 2);
  System.Console.Write($"{Lin} ");
}
