using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receipt
{
    class Program
    {
        static int[] serial = { 1, 2, 3, 4, 5 };
        static string[] items = { "Notebook", "Pen", "Pencil", "Compass", "Scale" };
        static int[] price = { 50, 20, 5, 30, 12 };
        static int amt,c=0;
        static int[] count= new int[30];
        static int[] quantity=new int[30];
        static void getAmt(int id,int qty) {
            for (int i = 0; i < 5; i++)
            {
                if (id == i)
                {
                    amt = amt + (qty * price[i]);
                    break;
                }
            }

}
static void Main(string[] args)
        {
            
            Console.Write("ID\t");
            Console.Write("Items\t\t");
            Console.Write("Price in Rs.");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}\t{1}\t\t{2}",serial[i],items[i], price[i]);

            }

            int exit = 0;
            while (exit != 1)
            {
            Console.WriteLine("Would you like to order? Y/N");
            string ans = Console.ReadLine();
            if(ans == "Y")
            {
               
                    Console.WriteLine("\nSelect Item ID and Quantity");

                    int id = int.Parse(Console.ReadLine());
                    int qty = int.Parse(Console.ReadLine());
                    

                Program.getAmt(id, qty);

                    count[c] = id;
                    quantity[c] = qty;

                    c += 1;
                    

                }
                else if(ans == "N")
            {
                Console.WriteLine("Goodbye!");
                 exit = 1;
            }

            }


            Console.WriteLine("\nYour reciept\n___________________\n");
            Console.WriteLine("Item Name\tQuantity\tPrice");
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", items[count[i]], quantity[i], price[count[i]]);
            }

            Console.WriteLine("Your total bill amount is:"+amt);
            

            Console.ReadLine();
        }
    }
}
