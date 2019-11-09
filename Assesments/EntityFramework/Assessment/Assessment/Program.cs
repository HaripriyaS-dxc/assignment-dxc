using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpDept call = new EmpDept();
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("Select an option:\n1.Display all Employees by Department\n2.Select Department to display Employees\n3.Exit");
                int choice1 = int.Parse(Console.ReadLine());
                switch (choice1)
                {
                    case 1: call.DisplayAllEmp(); break;
                    case 2:
                        {
                            Console.WriteLine("\nEnter the Department Id:");
                            call.ViewDepts();
                            int choice2 = int.Parse(Console.ReadLine());
                            call.DisplayEmpByDept(choice2);
                            break;
                        }
                    case 3: condition = false; break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

        }
    }
}
