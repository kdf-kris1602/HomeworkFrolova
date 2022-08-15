Console.WriteLine("Введите 3-х значное число");
string y = Console.ReadLine();
ThirdNumber(y);

void ThirdNumber(string someInt)
{
    if (someInt.Length == 3)
    {
        Console.WriteLine(someInt.Trim(someInt[0], someInt[1]));
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
        someInt = Console.ReadLine();
        ThirdNumber(someInt);
    }
}
