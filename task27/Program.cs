Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int i = Convert.ToString(number).Length;
int count = 0;
int sum = 0;
int b = 0;

while (count <= i)
{
    b = number - number % 10;
    sum = sum + (number - b);
    number = number / 10;
    count++;
}

Console.WriteLine(sum);