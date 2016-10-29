using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Company
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string companyFaxNumber = Console.ReadLine();
        string companyPhoneNumber = Console.ReadLine();
        string companyWebAddress = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine(companyAddress);
        Console.WriteLine(companyPhoneNumber);
        Console.WriteLine(companyFaxNumber);
        Console.WriteLine(companyWebAddress);
        Console.WriteLine();
        Console.WriteLine("{0} {1}", managerFirstName, managerLastName);
        Console.WriteLine(managerPhoneNumber);
    }
}
