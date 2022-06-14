//ДЗ2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет(645->5, 78->третьей цифры нет, 32679->6)

Console.Write("Введите любое число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

if (number < 1000)
{
  if (number / 100 > 0) Console.WriteLine($"Третья цифра этого числа {number % 10}");
    
  else Console.WriteLine("Третьей цифры нет");
}
else while (number > 1000) number = number / 10;
{
  if (number / 100 > 0) Console.WriteLine($"Третья цифра этого числа {number % 10}");
    
  else Console.WriteLine("Третьей цифры нет");
}
