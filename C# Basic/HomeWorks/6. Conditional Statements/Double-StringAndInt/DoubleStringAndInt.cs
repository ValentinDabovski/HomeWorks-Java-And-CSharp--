using System;


    class DoubleStringAndInt
{
        static void Main()
   {
          Console.WriteLine("1 --> int");
          Console.WriteLine("2 --> double");
          Console.WriteLine("3 --> string");
        int choice = int.Parse(Console.ReadLine());


        if (choice == 1 )
        {
            Console.WriteLine("Enter Int");
            int intnumber = int.Parse(Console.ReadLine());
            intnumber = intnumber + 1;
            Console.WriteLine(intnumber);
           
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter Double");
            double doubleNum = double.Parse(Console.ReadLine());
            doubleNum = doubleNum + 1;
            Console.WriteLine(doubleNum);
           
        }
        else if (choice == 3 )
        {
            Console.WriteLine("Enter String");
            string s = Console.ReadLine();
            s = s += "*";
            Console.WriteLine(s);
           
        }

        else
        {
            Console.WriteLine("Invalid Input");
            Console.ReadLine();
        }











        //switch (choice)
        //{
        //    case 1:
        //        Console.WriteLine("Enter Int");
        //        break;
        //    case 2:
        //        Console.WriteLine("Enter Double");
        //        break;
        //    case 3:
        //        Console.WriteLine("Enter string");
        //        break;
        //    default:
        //        Console.WriteLine("invalid input");
        //        break;
            
        }
    
    

     }
 //}

