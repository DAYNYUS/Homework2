//Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа (456->5, 782->8, 918->1)

Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

int a = number /= 10;
int b = a % 10;


Console.WriteLine("Вторая цифра этого числа: " + b);
