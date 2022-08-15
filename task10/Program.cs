Console.WriteLine("Enter some 3-x number ");
string x = Console.ReadLine();
threeInOneOut(x);

        void threeInOneOut(string someInt)
        {
            if (someInt.Length == 3)
            {
                Console.WriteLine(someInt.Trim(someInt[0], someInt[2]));
            }
            else
            {
                Console.WriteLine("wrong data,try again");
                someInt = Console.ReadLine();
                threeInOneOut(someInt);
            }
        }



