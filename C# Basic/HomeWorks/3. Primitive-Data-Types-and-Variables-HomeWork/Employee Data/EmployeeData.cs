using System;


    class  EmployeeData
   {
  

            static void Main()
        {
            Console.WriteLine("Enter First Name of Employee");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name of Employee");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter Age of Employee");
            string Age = Console.ReadLine();
            Console.WriteLine("Enter Gender of Employee M-for Male ; F-for Female");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter Personal ID Number of Employee");
            long personalID = long.Parse(Console.ReadLine());
            int UniqueNumber = 0;
            do
            {
                Console.WriteLine("Enter Unique Employee Number within scope 27560000-27569999");
                
                UniqueNumber = int.Parse(Console.ReadLine());

            } while (UniqueNumber < 27560000 || UniqueNumber > 27569999);
            Console.WriteLine("{0}", firstName);
            Console.WriteLine("{0}",lastname);
            Console.WriteLine("{0}",Age);
            Console.WriteLine("{0}",gender);
            Console.WriteLine("{0}", personalID);
            Console.WriteLine("{0}", UniqueNumber);


        }
    
                
  }

        
    

