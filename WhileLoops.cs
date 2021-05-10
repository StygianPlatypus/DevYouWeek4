using System;
using System.Threading;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //// print numbers from 1 to n

            //int x = 1;
            //Console.WriteLine("Enter any whole number. Preferably not something terribly large!");
            //int n = Int16.Parse(Console.ReadLine());
            //while (x <= n)
            //{
            //    Console.WriteLine($"{x}");
            //    x++;
            //    Thread.Sleep(25);
            //}





            ////print numbers from n to 1

            //Console.WriteLine("Enter any whole number. Preferably not something terribly large!");
            //int n = Int32.Parse(Console.ReadLine());
            //while (n >= 1)
            //{
            //    Console.WriteLine($"{n}");
            //    n--;
            //    Thread.Sleep(0);
            //}






            ////Print the alphabet starting with A. This could probably be more elegant.
            //int x = 1;
            //while (x <= 26)
            //{
            //    if (x == 1)
            //    {
            //        Console.WriteLine("A");
            //        x++;
            //    }
            //    if (x == 2) 
            //    {
            //        Console.WriteLine("B");
            //        x++;
            //    }
            //    if (x == 3)
            //    {
            //        Console.WriteLine("C");
            //        x++;
            //    }
            //    if (x == 4)
            //    {
            //        Console.WriteLine("D");
            //        x++;
            //    }
            //    if (x == 5)
            //    {
            //        Console.WriteLine("E");
            //        x++;
            //    }
            //    if (x == 6)
            //    {
            //        Console.WriteLine("F");
            //        x++;
            //    }
            //    if (x == 7)
            //    {
            //        Console.WriteLine("G");
            //        x++;
            //    }
            //    if (x == 8)
            //    {
            //        Console.WriteLine("H");
            //        x++;
            //    }
            //    if (x == 9)
            //    {
            //        Console.WriteLine("I");
            //        x++;
            //    }
            //    if (x == 10)
            //    {
            //        Console.WriteLine("J");
            //        x++;
            //    }
            //    if (x == 11)
            //    {
            //        Console.WriteLine("K");
            //        x++;
            //    }
            //    if (x == 12)
            //    {
            //        Console.WriteLine("L");
            //        x++;
            //    }
            //    if (x == 13)
            //    {
            //        Console.WriteLine("M");
            //        x++;
            //    }
            //    if (x == 14)
            //    {
            //        Console.WriteLine("N");
            //        x++;
            //    }
            //    if (x == 15)
            //    {
            //        Console.WriteLine("O");
            //        x++;
            //    }
            //    if (x == 16)
            //    {
            //        Console.WriteLine("P");
            //        x++;
            //    }
            //    if (x == 17)
            //    {
            //        Console.WriteLine("Q");
            //        x++;
            //    }
            //    if (x == 18)
            //    {
            //        Console.WriteLine("R");
            //        x++;
            //    }
            //    if (x == 19)
            //    {
            //        Console.WriteLine("S");
            //        x++;
            //    }
            //    if (x == 20)
            //    {
            //        Console.WriteLine("T");
            //        x++;
            //    }
            //    if (x == 21)
            //    {
            //        Console.WriteLine("U");
            //        x++;
            //    }
            //    if (x == 22)
            //    {
            //        Console.WriteLine("V");
            //        x++;
            //    }
            //    if (x == 23)
            //    {
            //        Console.WriteLine("W");
            //        x++;
            //    }
            //    if (x == 24)
            //    {
            //        Console.WriteLine("X");
            //        x++;
            //    }
            //    if (x == 25)
            //    {
            //        Console.WriteLine("Y");
            //        x++;
            //    }
            //    if (x == 26)
            //    {
            //        Console.WriteLine("Z");
            //        x++;
            //    }





            ////Print all even numbers 1 to 100

            //int n = 0;
            //while (n <= 100)
            //{
            //    string binary = Convert.ToString(n, 2);
            //    string lsb = binary.Substring(binary.Length - 1, 1);
            //    int x = Int16.Parse(lsb);
            //    if (n == 0)
            //    {
            //        n++;
            //        n++;              
            //    }
            //    if (x == 0)
            //    {
            //        Console.WriteLine($"{n}");
            //        n++;
            //        Thread.Sleep(50);
            //    }
            //    else
            //    {
            //        n++;
            //    }
            //}







            ////Print all odd numbers 1 to 100

            //int n = 0;
            //while (n <= 100)
            //{
            //    string binary = Convert.ToString(n, 2);
            //    string lsb = binary.Substring(binary.Length - 1, 1);
            //    int x = Int16.Parse(lsb);
            //    if (n == 0)
            //    {
            //        n++;
            //        Console.WriteLine($"{n}");
            //        Thread.Sleep(50);
            //    }
            //    if (x == 1)
            //    {
            //        Console.WriteLine($"{n}");
            //        n++;
            //        Thread.Sleep(50);
            //    }
            //    else
            //    {
            //        n++;
            //    }
            //}


            ////Prints only prime numbers lower than the user inputs

            //Console.WriteLine("Please enter a number to know the prime numbers that fit between 1 and your number. The higher the better.");
            //int x = Int32.Parse(Console.ReadLine());
            //while (x > 1)
            //{
            //    int y = (x - 1);
            //    int n = x;

            //    while (n == x)
            //    {
            //        if ((y > 1) && ((x % y) == 0))
            //        {
            //            x--;
            //        }
            //        if (y == 1)
            //        {
            //            Console.WriteLine($"{x}");
            //            x--;
            //        }
            //        else
            //        {
            //            y--;
            //        }
            //    }
            //}







            ////Prints the sum of all whole numbers between 1 and n
            //Console.WriteLine("Enter a number to get the sum of all whole numbers between 1 and your number.");
            //int n = Int32.Parse(Console.ReadLine());            
            //int x = 0;
            //int y = 0;
            //while (n > 0)
            //{
            //    x = (n + (n - 1));
            //    y = (y + x);
            //    n = (n - 2);
            //}
            //Console.WriteLine($"{y}");


            
            
            
            
            
            ////Prints out the multiplication tables from 1 up to the user input, n
            //Console.WriteLine("Enter a number to get a multiplication table that goes as high as the number itself.");
            //int n = Int32.Parse(Console.ReadLine());
            //int x = 1;
            //while (x <= n)
            //{
            //    int y = (n * x);
            //    Console.WriteLine($"{n} times {x} is equal to {y}");
            //    x++;
            //}
            










        }
    }
}
