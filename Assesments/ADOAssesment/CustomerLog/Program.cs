using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLog
{
    class Program
    {
        static void Main(string[] args)
        {
            GetData obj = new GetData();
            //obj.GetProductDetails();
            //obj.GetSupplierDetails();
            //obj.GetSupplierByProduct();
            //obj.GetCustomer();

            bool check = true;

            while (check)
            {
                Console.WriteLine("1.View Products Details\n2.View Suppliers Details\n3.View Suppliers for Products\n4.Add Customer\n5.View Customer Details\n6.Exit\n");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:obj.GetProductDetails();break;
                    case 2:obj.GetSupplierDetails();break;
                    case 3:obj.GetSupplierByProduct();break;
                    case 4:obj.AddCustomer();break;
                    case 5:obj.GetCustomer();break;
                    case 6: check = false;break;
                    default:
                        Console.WriteLine("Invalid Input!" +
                            "" +
                            "");
                        break;
                }
            }


            Console.ReadLine();
        }
    }
}
