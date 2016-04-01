using System;

    class RandomNumbersInGivenRange
    {
      static void Main()
      {
        Console.WriteLine("Enter numbers for n, min and max where (min < max): ");
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        if (min > max)
        {
            Console.WriteLine("invalid input");
            return;
        }
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            int randomNumb = rnd.Next(min, max+1);
            Console.WriteLine("{0}",randomNumb);
        }

      }
    }

