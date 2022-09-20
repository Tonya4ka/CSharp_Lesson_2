Console.Clear();
Console.Write("Type a 3-digit number: ");
int number = int.Parse(Console.ReadLine());
if ((number >= 100) && (number < 1000))
{
    int secondDigit = ((number/10)%10);
    Console.Write(secondDigit);
}
else
{
    Console.Write("The number is not 3-digital");
}
