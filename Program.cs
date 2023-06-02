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
            string st = "*";

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("*");
                st += i;
                if (i == 4)
                {
                    Console.WriteLine(" ");
                    st += "*";

                    if (i == 1)
                    {
                        Console.WriteLine("*****");
                    }



                }


            }

        }
    }
}