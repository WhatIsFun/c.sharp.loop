namespace c.sharp.loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i < 10; i++)      //For Loop test write 0 to 9
            {
                Console.Write("H");
                
            }
            Console.WriteLine("");*/

            /*for (int i = 1; i <= 5; i++) // Star Square
            {
                Console.Write("*"); // to print *****
            }
            Console.WriteLine();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("*   *"); // to print *    *
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("*"); // to print *****
            }*/

            // While Loop
            int a = 2;
            while (a > 1)
            {
                Console.WriteLine(a);
                a++;
                if (a == 20)
                {
                    break;
                }
               
            }
        









            /*// test Star pattern part 1
            //*
            //**
            //***
            //****
            //*****

            for (int i = 1; i <= 6; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                //Part 2  
                if (i == 6)
                {
                    //Console.WriteLine("Test");

                    for (i = 6; i >= 1; --i)
                    {
                        for (int j = 1; j <= i; ++j)
                        {
                            Console.Write("*");

                            // Part 3 
                            // star line 
                            //******
                            if (i == 1)
                            {
                                Console.WriteLine("******");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                }


            }*/

        }
    }
}