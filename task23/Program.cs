Console.WriteLine("Введите число для возведения в куб");
int i = Convert.ToInt32(Console.ReadLine());

for (int a = 1; a <= i; a++) // указываем пероначальное значение, дальше говорим, пока этот и < =10
// мы будем увеличивать и 
{
        Console.WriteLine($"{a} * {a} * {a}= {a * a * a}");
}
