// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int num1, num2, rem;
  
  Console.WriteLine("Введите 1-е число");
  num1 = Convert.ToInt32(Console.ReadLine());
  
  Console.WriteLine("Введите 2-е число");
  num2 = Convert.ToInt32(Console.ReadLine());
  
  
  if (num1 % num2 == 0)
  {
    Console.WriteLine($"Число {num2} кратно числу {num1}");
  }

  else 
  {
    rem = num1 % num2;
    Console.WriteLine($"Число {num2} не кратно числу {num1}, остаток равен {rem}");
  }
