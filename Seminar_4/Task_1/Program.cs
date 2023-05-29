// Задача 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString(); // Convert.ToString(number);
bool isPalindrom = true;
for (int i = 0; i < str.Length/2; i++)
{
  if (str[i] != str[str.Length - i - 1])
  {
    isPalindrom = false;
    break;
  }
}

if (isPalindrom)
{
  System.Console.WriteLine("Палиндром");
}

else 
{
  System.Console.WriteLine("Не палиндром");
}