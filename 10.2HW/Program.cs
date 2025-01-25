using System;
using System.Text;

StringBuilder report = new StringBuilder();

string title;
string dateInput;
string eventInput;

Console.WriteLine("Введіть заголовок звіту:");
title = Console.ReadLine();
report.AppendLine(title);

Console.WriteLine("Введіть дату звіту: ");
dateInput = Console.ReadLine();
report.AppendLine($"Дата створення: {dateInput}");

while (true)
{
    Console.WriteLine("Введіть події: ");
    eventInput = Console.ReadLine();

    if (string.IsNullOrEmpty(eventInput))
    {
        break;
    }
    report.AppendLine(eventInput);
}

Console.WriteLine($"Ваш звіт: {report} ");