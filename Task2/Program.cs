//ДЗ2 Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру числа (456->46, 782->72, 98->8)
//ДЗ4 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным (6->да, 7->да, 1->нет)

int Number = new Random().Next(99, 1000);
int Max = 0;

int NumberA = Number / 10;
int NumberB = Number % 10;

if (NumberA > NumberB) Max = NumberA;
else Max = NumberB;

Console.Write("Наибольшая цифра числа ");
Console.Write(Number);
Console.Write(" является ");
Console.Write(Max);

