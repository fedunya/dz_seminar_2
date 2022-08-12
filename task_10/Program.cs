Console.Write("Введите целое трехзначное число: ");
string? numberString = Console.ReadLine();
int lenght = numberString!.Length;
while (lenght != 3)
{
    Console.Write("Число введено не верно, повторите ввод: ");
    numberString = Console.ReadLine();
    lenght = numberString!.Length;
}
int number = int.Parse(numberString!);
int secondDiqit = number / 10 % 10;
Console.WriteLine("Вторая цифра числа: " + secondDiqit);
