//ДЗ3 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет(645->5, 78->третьей цифры нет, 32679->6)

Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

int a = number % 10;

Console.WriteLine("Последняя цифра этого числа: " + a);
