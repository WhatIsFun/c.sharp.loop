namespace c.sharp.loops
{
    internal class Program
    {
        static void Main(string[] args)    
        {
            /*for (int i = 0; i < 10; i++)      //Loop test write 0 to 9
            {
                Console.WriteLine(i);
                
            }
            Console.WriteLine("");*/

            // test Star pattern part 1
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
                    //Console.WriteLine("GOOD");

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


            }

        }
    }
}