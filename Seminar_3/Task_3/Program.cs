// Напишите программу, которая по заданному номеру четверти показывает 
// диапазон возможных координат точек в этой четверти (x и y).

// int Quater (int N)
// {
//   string range = " ";
//   if (N==1)
//   {
//     range = "x>0, y>0";
//   }
//   else if (N==2)
//   {
//     range = "x<0, y>0";
//   }
//   else if (N==3)
//   {
//     range = "x<0, y<0";
//   }
//   else
//   {
//     range = "x>0, y<0";
//   }
//   return range;
// }

// Console.Write("Введите номер четверти: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int QuaterFind = Quater (N);
// Console.WriteLine (QuaterFind);

string[] quaters = {
  "x>0, y>0",
  "x<0, y>0",
  "x<0, y<0",
  "x>0, y<0",
};

Console.Write("Введите номер четверти: ");
int quater = Convert.ToInt32(Console.ReadLine());
if (quater >= 1 && quater <= 4)
{
  Console.WriteLine(quaters[quater-1]);
}
else
{
  System.Console.WriteLine("Неправильный номер четверти");
}