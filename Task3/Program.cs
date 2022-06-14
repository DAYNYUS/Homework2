//ДЗ 3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным (6->да, 7->да, 1->нет)

string day1 = "Понедельник";
string day2 = "Вторник";
string day3 = "Среда";
string day4 = "Четверг";
string day5 = "Пятница";
string day6 = "Суббота";
string day7 = "Воскресенье";


Console.WriteLine("Введите число от 1 до 7:");

string input = Console.ReadLine();
int number = Convert.ToInt32(input);

if (number == 1)
{
  Console.WriteLine(day1 + " нет");
}
else 
    if (number == 2)
    {
        Console.WriteLine(day2 + " нет");
    }
    else 
     if (number == 3)
        {
        Console.WriteLine(day3 + " нет");
        }
     else 
        if (number == 4)
        {
        Console.WriteLine(day4 + " нет");
        } 
         else 
            if (number == 5)
                {
                 Console.WriteLine(day5 + " нет");
                } 
            else 

                if (number == 6)
                {
                 Console.WriteLine(day6 + " да");
                } 

                else 
                
                if (number == 7)
                {
                 Console.WriteLine(day7 + " да");
                } 

                else {
                 Console.WriteLine("ОШИБКА! Введите число в заданном диапазоне от 1 до 7");
                    } 
