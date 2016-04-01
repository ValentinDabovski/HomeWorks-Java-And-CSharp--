using System;
class LoanCalculator
{
    static void Main()
    {
        double priceTV = double.Parse(Console.ReadLine());
        double termYears = double.Parse(Console.ReadLine());
        double loanRateBank = double.Parse(Console.ReadLine());
        double loanRateFriend = double.Parse(Console.ReadLine());
        double bankLoan = 0;
        double friendLoan = 0;


        bankLoan = priceTV * Math.Pow((1 + loanRateBank), termYears);
        friendLoan = priceTV * (1 + loanRateFriend);

        if (bankLoan > friendLoan)
        {
            Console.WriteLine("{0:0.00} Friend", Math.Round(friendLoan, 2));
        }

        else if (bankLoan < friendLoan)
        {
            Console.WriteLine("{0:0.00} Bank", bankLoan);
        }

        else if (bankLoan == friendLoan)
        {
            Console.WriteLine("{0:} Friend", friendLoan);
        }


    }
}

