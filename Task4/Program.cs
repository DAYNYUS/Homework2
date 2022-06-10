//ДЗ 3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным (6->да, 7->да, 1->нет)

//System.Console.WriteLine();

//int dayNumber = new Random().Next(1, 8);
//string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
//string txtResult = "";

//if (dayNumber > 5) txtResult = $". Ура! Это выходной день!";
//else txtResult = $", рабочий день.";

//System.Console.WriteLine();
//System.Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{txtResult}");
//System.Console.WriteLine();





string day1 = "Понедельник";
string day2 = "Вторник";
string day3 = "Среда";
string day4 = "Четверг";
string day5 = "Пятница";
string day6 = "Суббота";
string day7 = "Воскресенье";


Console.Write("Введите число от 1 до 7:");

string input = Console.ReadLine(); // считывает код пользователя
int number = Convert.ToInt32(input);
