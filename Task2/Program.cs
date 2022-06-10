//не ДЗ Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру числа (456->46, 782->72, 98->8)


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

