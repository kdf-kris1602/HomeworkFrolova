Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b) 
{
    if (a > c)
    {
        Console.WriteLine("самое большое " + a );
    }
    else if (c > b)
    {
        Console.WriteLine("самое большое " + c );
    }
    else 
    {
        Console.WriteLine("самое большое " + b );
    }

} else if (b > a) 
{
    if (b > c)
    {
        Console.WriteLine("самое большое " + b );
    }
    else 
    {
        Console.WriteLine("самое большое " + c );
    }
}