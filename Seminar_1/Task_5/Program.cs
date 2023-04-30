// Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает последнюю цифру этого числа. 
// 456 -> 6 
// 782 -> 2 
// 918 -> 8

int Number, aNumber, LastFigure;

Console.Clear();
Console.WriteLine("Введите трёхзначное число");

Number = Convert.ToInt32(Console.ReadLine());
aNumber = Number;

if (Number<0)
{
  Number=-aNumber;
}

if (Number>99 && Number<1000)
{
  LastFigure = Number % 10;
  Console.WriteLine($"Последняя цифра числа {aNumber} равна {LastFigure}");
}

else
{
  Console.WriteLine($"Число {aNumber} не является трёхзначным");
}