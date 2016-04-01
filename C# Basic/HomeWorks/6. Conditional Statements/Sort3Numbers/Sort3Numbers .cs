using System;


namespace Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if ( a > b && a > c )
            {
                Console.WriteLine("{0}  {1}  {2}",a,b,c);
            }

            else if (b > a && b > c )
            {
                Console.WriteLine("{0}  {1}  {2}",b,a,c);
            }
            else if ( c > a && c > b)
            {
                Console.WriteLine("{0}  {1}  {2}",c,a,b);
            }
        }
    }
}
