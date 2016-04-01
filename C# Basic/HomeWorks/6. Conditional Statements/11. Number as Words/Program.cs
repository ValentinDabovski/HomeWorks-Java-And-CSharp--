using System;
class NumberWords
{
    static void Main()
    {
        int userNum = int.Parse(Console.ReadLine());

        if (userNum < 0 || userNum > 999)
        {
            Console.WriteLine("Invalid number!");
        }
        else if (userNum < 10)
        {
            switch (userNum)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
            }

        }
        else if (userNum < 20)
        {
            switch (userNum)
            {
                case 10:
                    Console.WriteLine("Ten");
                    break;
                case 11:
                    Console.WriteLine("Eleven");
                    break;
                case 12:
                    Console.WriteLine("Twelve");
                    break;
                case 13:
                    Console.WriteLine("Thirteen");
                    break;
                case 14:
                    Console.WriteLine("Fourteen");
                    break;
                case 15:
                    Console.WriteLine("Fifteen");
                    break;
                case 16:
                    Console.WriteLine("Sixteen");
                    break;
                case 17:
                    Console.WriteLine("Seventeen");
                    break;
                case 18:
                    Console.WriteLine("Eighteen");
                    break;
                case 19:
                    Console.WriteLine("Nineteen");
                    break;
            }

        }
        else if (userNum < 100)
        {
            switch (userNum / 10)
            {
                case 2:
                    Console.Write("Twenty ");
                    break;
                case 3:
                    Console.Write("Thirty ");
                    break;
                case 4:
                    Console.Write("Fourty ");
                    break;
                case 5:
                    Console.Write("Fifty ");
                    break;
                case 6:
                    Console.Write("Sixty ");
                    break;
                case 7:
                    Console.Write("Seventy ");
                    break;
                case 8:
                    Console.Write("Eighty ");
                    break;
                case 9:
                    Console.Write("Ninety ");
                    break;
            }
            switch (userNum % 10)
            {
                case 0:
                    Console.WriteLine();
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
            }
        }

        else if (userNum < 1000)
        {
            switch (userNum / 100)
            {
                case 1:
                    Console.Write("One hundred ");
                    break;
                case 2:
                    Console.Write("Two hundred ");
                    break;
                case 3:
                    Console.Write("Tree hundred ");
                    break;
                case 4:
                    Console.Write("Four hundred ");
                    break;
                case 5:
                    Console.Write("Five hundred ");
                    break;
                case 6:
                    Console.Write("Six hundred ");
                    break;
                case 7:
                    Console.Write("Seven hundred ");
                    break;
                case 8:
                    Console.Write("Eight hundred ");
                    break;
                case 9:
                    Console.Write("Nine hundred ");
                    break;
            }
            if (userNum % 100 < 20)
            {
                switch (userNum % 100)
                {
                    case 00:
                        Console.WriteLine();
                        break;
                    case 01:
                        Console.WriteLine("and one");
                        break;
                    case 02:
                        Console.WriteLine("and two");
                        break;
                    case 03:
                        Console.WriteLine("and three");
                        break;
                    case 04:
                        Console.WriteLine("and four");
                        break;
                    case 05:
                        Console.WriteLine("and five");
                        break;
                    case 06:
                        Console.WriteLine("and six");
                        break;
                    case 07:
                        Console.WriteLine("and seven");
                        break;
                    case 08:
                        Console.WriteLine("and eight");
                        break;
                    case 09:
                        Console.WriteLine("and nine");
                        break;
                    case 10:
                        Console.WriteLine("and ten");
                        break;
                    case 11:
                        Console.WriteLine("and eleven");
                        break;
                    case 12:
                        Console.WriteLine("and twelve");
                        break;
                    case 13:
                        Console.WriteLine("and thirteen");
                        break;
                    case 14:
                        Console.WriteLine("and fourteen");
                        break;
                    case 15:
                        Console.WriteLine("and fifteen");
                        break;
                    case 16:
                        Console.WriteLine("and sixteen");
                        break;
                    case 17:
                        Console.WriteLine("and seventeen");
                        break;
                    case 18:
                        Console.WriteLine("and eighteen");
                        break;
                    case 19:
                        Console.WriteLine("and nineteen");
                        break;
                }
            }
            else
            {
                switch (userNum / 10 % 10)
                {
                    case 2:
                        Console.Write("and twenty ");
                        break;
                    case 3:
                        Console.Write("and thirty ");
                        break;
                    case 4:
                        Console.Write("and fourty ");
                        break;
                    case 5:
                        Console.Write("and fifty ");
                        break;
                    case 6:
                        Console.Write("and sixty ");
                        break;
                    case 7:
                        Console.Write("and seventy ");
                        break;
                    case 8:
                        Console.Write("and eighty ");
                        break;
                    case 9:
                        Console.Write("and ninety ");
                        break;
                }
                if (userNum / 10 % 10 != 0)
                {
                    switch (userNum % 10)
                    {
                        case 0:
                            Console.WriteLine();
                            break;
                        case 1:
                            Console.WriteLine("one");
                            break;
                        case 2:
                            Console.WriteLine("two");
                            break;
                        case 3:
                            Console.WriteLine("three");
                            break;
                        case 4:
                            Console.WriteLine("four");
                            break;
                        case 5:
                            Console.WriteLine("five");
                            break;
                        case 6:
                            Console.WriteLine("six");
                            break;
                        case 7:
                            Console.WriteLine("seven");
                            break;
                        case 8:
                            Console.WriteLine("eight");
                            break;
                        case 9:
                            Console.WriteLine("nine");
                            break;
                    }
                }
            }
        }
    }
}