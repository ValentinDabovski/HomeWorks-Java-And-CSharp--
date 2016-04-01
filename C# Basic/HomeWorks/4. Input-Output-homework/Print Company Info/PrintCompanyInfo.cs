using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Company_Info
{
    class PrintCompanyInfo
    {
        static void Main()
        {
            Console.WriteLine("Enter Company Name: ");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter Compnay Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter fax number or press enter to continue: ");
            string faxNumber = Console.ReadLine();
            if (faxNumber==string.Empty)
            {
                Console.WriteLine("No Fax");
            }
            Console.WriteLine("Enter Company Web Site: ");
            string webSite = Console.ReadLine();
            Console.WriteLine("Enter Manager First Name: ");
            string mFirstName = Console.ReadLine();
            Console.WriteLine("Enter Manager Last Name: ");
            string mLastName = Console.ReadLine();
            Console.WriteLine("Enter Manager Age: ");
            string mAge = Console.ReadLine();
            Console.WriteLine("Enter Manager Phone: ");
            string mPhone = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Company Name: {0} ", companyName);
            Console.WriteLine("Adress: {0} ", address);
            Console.WriteLine("Phone Number: {0} ", phoneNumber);
            Console.WriteLine("Fax Number: {0} ", faxNumber);
            Console.WriteLine("Web Site: {0} ", webSite);
            Console.Write("Manager: {0} ", mFirstName);
            Console.Write("{0}", mLastName);
            Console.WriteLine(", age: {0} ", mAge);
            Console.WriteLine("Manager Phone Number: {0} ",mPhone);
        }
    }
}
