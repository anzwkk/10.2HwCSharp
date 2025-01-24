using System;
using System.Text;

StringBuilder report = new StringBuilder();

Console.WriteLine("Введіть заголовок звіту:");
string title = Console.ReadLine();

Console.WriteLine("Введіть дату звіту: ");
string dateInput = Console.ReadLine();

while (true)
{
    Console.WriteLine("Введіть події: ");
    string eventInput = Console.ReadLine();

    if (string.IsNullOrEmpty(eventInput));
    {
        break;
    }
}
