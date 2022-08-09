int a = 22;
int b = 3;
int c = 9;

if (a > b) 
{
    if (a > c)
    {
        Console.WriteLine( a );
    }
    else if (c > b)
    {
        Console.WriteLine( c );
    }
    else 
    {
        Console.WriteLine( b );
    }

} else if (b > a) 
{
    if (b > c)
    {
        Console.WriteLine( b );
    }
    else 
    {
        Console.WriteLine( c );
    }
}