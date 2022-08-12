Console.Write("Введите целое число: ");
string? numberString = Console.ReadLine();
int lenght = numberString!.Length;
if (lenght > 2)
{
    Console.WriteLine("Третья цифра числа: " + numberString[2]);
}
else
{
    Console.WriteLine("В этом числе третьей цифры нет");
}
