// При введении числа нужно получить день недели 

Console.Clear();

// int number;

// Console.WriteLine("Введите число");
// number = Convert.ToInt32(Console.ReadLine());

// if (number<1 | number>7)

// {
//   Console.WriteLine("Измените число");
// }

// if (number == 1)

// {
//   Console.WriteLine("Понедельник");
// }

// else if (number == 2)

// {
//   Console.WriteLine("Вторник");
// }

// else if (number == 3)

// {
//   Console.WriteLine("Среда");
// }

// else if (number == 4)

// {
//   Console.WriteLine("Четверг");
// }

// else if (number == 5)

// {
//   Console.WriteLine("Пятница");
// }

// else if (number == 6)

// {
//   Console.WriteLine("Суббота");
// }

// else if (number == 7)

// {
//   Console.WriteLine("Воскресенье");
// }

int day = 0;

Console.WriteLine("Введите день недели");

day = Convert.ToInt32(Console.ReadLine());

switch(day)
{
    case 1:
      {
          Console.WriteLine("Понедельник");
          Console.WriteLine();
          break;
      }

    case 2:
      {
          Console.WriteLine("Вторник");
          Console.WriteLine();
          break;
      }

    case 3:
      {
          Console.WriteLine("Среда");
          Console.WriteLine();
          break;
      }

    case 4:
      {
          Console.WriteLine("Четверг");
          Console.WriteLine();
          break;
      }

    case 5:
      {
          Console.WriteLine("Пятница");
          Console.WriteLine();
          break;
      }

    case 6:
      {
          Console.WriteLine("Суббота");
          Console.WriteLine();
          break;
      }

    case 7:
      {
          Console.WriteLine("Воскресенье");
          Console.WriteLine();
          break;
      }
    
    default:
      {
          Console.WriteLine("Нет такого дня недели");
          Console.WriteLine();
          break;
      }



}// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
