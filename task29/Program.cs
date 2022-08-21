using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] a = Console.ReadLine().Split(", ");
        foreach (var elem in a) 
        {
            Console.WriteLine("[{0}]", string.Join(", ", a));        
        }
    }
}
