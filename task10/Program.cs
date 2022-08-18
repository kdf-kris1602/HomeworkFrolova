Console.WriteLine("Enter some 3-x number ");
string x = Console.ReadLine();
number(x);

        void number(string b)
        {
            if (b.Length == 3)
            {
                Console.WriteLine(b.Trim(b[0], b[2]));
            }
            else
            {
                Console.WriteLine("wrong data,try again");
                b = Console.ReadLine();
                number(b);
            }
        }


