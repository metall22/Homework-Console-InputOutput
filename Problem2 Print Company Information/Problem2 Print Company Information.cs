using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Print_Company_Information
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            Console.Write("Company Name:");
            string companyName = Console.ReadLine();

            Console.Write("Company Adress:");
            string companyAdress = Console.ReadLine();

            Console.Write("Phone Number:");
            int phoneNumber=  int.Parse(Console.ReadLine());

            Console.Write("Fax Number:");
            int faxNumber = int.Parse(Console.ReadLine());

            Console.Write("Website:");
            string website = Console.ReadLine();

            Console.Write("Manager First Name:");
            string managetFName = Console.ReadLine();

            Console.Write("Manager Last Name:");
            string managerLName = Console.ReadLine();

            Console.Write("Manager Age:");
            int managerAge = int.Parse(Console.ReadLine());

            Console.Write("Manager Phone Number:");
            int managerPhone = int.Parse(Console.ReadLine());

            Console.WriteLine("Company Name:{0}\nCompany Adress:{1}\n Phone Number:{2}\n Fax Number:{3}\n Website:{4}\n Manager First Name:{5}\n Manager Last Name:{6}\n Manage Age:{7}\n Manager Phone number:{8}", companyName, companyAdress, phoneNumber, faxNumber, website, managetFName, managerLName, managerAge, managerPhone);









            


        }
    }
}
