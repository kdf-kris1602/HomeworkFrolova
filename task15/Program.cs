Console.WriteLine("Введите номер дня недели (1.2.3.4.5.6.7)");
int dayOfAWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfAWeek <= 7)
{
    if (dayOfAWeek >= 6)
    {                                                   
        Console.WriteLine("Выходной день");
    }
    else Console.WriteLine("Будний день");
}
else Console.WriteLine("Такого номера дня недели не существует");