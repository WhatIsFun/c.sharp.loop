using System.Diagnostics.CodeAnalysis;

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

//Do - While Loop
/*int a = 1;
do
{
    Console.WriteLine(a);
    a++;
} while (a < 4);
*/


// Odd numbers scanner between two numbers input from user ex: 2, 6
/*Console.WriteLine("Hello, programmer");
Console.WriteLine("Enter your first number:");
int fN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your last number:");
int lN = Convert.ToInt32(Console.ReadLine());


for (int i = fN; i <= (lN - i); i++)
{

    if (i < lN)
    {
        Console.WriteLine(i + (i - 1));

    }

}*/






/*Console.WriteLine("Hello, programmer");
Console.WriteLine("Enter your number:");
int i, factorial = 1;
int N = Convert.ToInt32(Console.ReadLine());
for (i = 1; i <= N; i++)
{
    factorial *= i;

    //Console.Write(i);
}
Console.WriteLine(" factorial of " + N + " is " + factorial);*/

//jhghg


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

Console.WriteLine("Welcome to sum program"); // Sum the numbers from n to 1
Console.WriteLine("Enter your number:");
int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of the first number "+ n +" is " + sum);

}
}
}