//Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа (456->5, 782->8, 918->1)

//System.Console.WriteLine();
//int number = new Random().Next(100, 1000);

//System.Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");

//System.Console.WriteLine(); 



Console.Write("Введите трехзначное число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

int a = number /= 10;
int b = a % 10;


Console.WriteLine("Вторая цифра этого числа: " + b);
