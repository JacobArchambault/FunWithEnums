using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Enums *****");
            // Make an EmpType Variable.
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);

            // Print storage for the enum.
            Console.WriteLine("EmpType uses a {0} for storage",
                Enum.GetUnderlyingType(typeof(EmpType)));
            Console.ReadLine();
        }
        // Enum as parameters
        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }
        enum EmpType
        {
            Manager, // = 0
            Grunt, // = 1
            Contractor, // = 2
            VicePresident // = 3
        }
    }
}
