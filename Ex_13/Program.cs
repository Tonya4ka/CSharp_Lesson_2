Console.Clear();
Console.Write("Type a number: ");
int number = int.Parse(Console.ReadLine()!);
if (number >= 100)
{
    string thirdDigit = number.ToString();
    Console.Write($"3-digit of this number is {thirdDigit[2]}");
}
else
{
    Console.Write("No third digit in this number");
}
