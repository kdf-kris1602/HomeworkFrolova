//является ли пятизначное число палиндомом

        Console.WriteLine("Введите пятизначное число");
        string y = Console.ReadLine();
        Number(y);

        void Number(string a)
        {
            if (a.Length == 5)
            {
                if ((a[0] == a[4]) & (a[1] == a[3]))
                {
                    Console.WriteLine(y + " - число палиндром");
                } 
                else 
                {
                    Console.WriteLine(y + " не является числом палиндромом");
                }
            }
            else 
            {
                Console.WriteLine(y + " не пятизначное число");
            }
        }

