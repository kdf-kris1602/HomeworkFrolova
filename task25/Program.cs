Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень ");
int b = Convert.ToInt32(Console.ReadLine());
int number = a * a;
int c = 3;
while  (c <= b)
{
    number = number * a;
    c++;
}
    Console.Write(a + " в степени " + b + " = " + number);