// Задача №17. Напишите программу, которая принимает на вход координаты
// точки (X и Y), причём X≠0 и Y≠0 и выдаёт номер четверти плоскости, в которой
// находится эта точка. 

void QuatersFind (int x, int y)
{
  if (x>0 && y>0)
  {
    Console.Write("Точка лежит в I (первой) четверти");
  }
  else if (x<0 && y>0)
  {
    Console.Write("Точка лежит во II (второй) четверти");
  }
  else if (x<0 && y<0)
  {
    Console.Write("Точка лежит в III (третьей) четверти");
  }
  else
  {
    Console.Write("Точка лежит в IV (четвёртой) четверти");
  }
}

string QuatersFindWithReturn (int x, int y)
{
  string result = " ";
  if (x>0 && y>0)
  {
    result = "Точка лежит в I (первой) четверти";
  }
  else if (x<0 && y>0)
  {
    result = "Точка лежит во II (второй) четверти";
  }
  else if (x<0 && y<0)
  {
    result = "Точка лежит в III (третьей) четверти";
  }
  else
  {
    result = "Точка лежит в IV (четвёртой) четверти";
  }
  return result;
}

Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
QuatersFind(x, y);

Console.WriteLine();

string quater = QuatersFindWithReturn(x, y);
Console.WriteLine (quater);