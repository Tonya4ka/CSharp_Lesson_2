// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Clear();
Console.Write("Type a number corresponding to a day of the week: ");
int number = int.Parse(Console.ReadLine()!);
if (number >= 1 && number <= 5)
{
    Console.Write("This day is not week end");
}
else if (number == 6 || number == 7)
{
    Console.Write("This day is a week end");
}
else if (number > 7)
{
    Console.Write("Not correct number, there are 7 days in a week");
}
