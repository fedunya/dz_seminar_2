Console.Write("Введите порядковый номер дня недели: ");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);
while (number > 7 || number < 1)
{
    Console.Write("Число введено не верно, повторите ввод: ");
    numberString = Console.ReadLine();
    number = int.Parse(numberString!);
}
Console.WriteLine("Это выходной день?");
if (number == 6 || number == 7)
{
    Console.WriteLine("Да");
} 
else
{
    Console.WriteLine("Нет");
}
