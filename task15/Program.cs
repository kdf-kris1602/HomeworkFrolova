Console.WriteLine("Введите номер дня недели (1.2.3.4.5.6.7)");
 
string dayOfAWeek = Console.ReadLine();
if (dayOfAWeek.Equals("6") || dayOfAWeek == "7")
{                                                   
    Console.WriteLine("Выходной день");
}
else Console.WriteLine("Будний день");