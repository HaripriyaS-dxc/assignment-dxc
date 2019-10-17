using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Data
    {
        static int[] accounts = new int[20];
        static int[] amount = new int[20];
        static int idx = 5;
        static int index;

        public void account()
        {
            int act = 12301;
            for (int i = 0; i < 5; i++)
            {
                accounts[i] = act;
                act += 1;
            }
            amount[0] = 10000;
            amount[1] = 5000;
            amount[2] = 25000;
            amount[3] = 18765;
            amount[4] = 350;

            Console.WriteLine("Enter the account number (format:123xx)");
            int data = int.Parse(Console.ReadLine());
            int exit = 0;
            for (int i = 0; i < idx; i++)
            {
                if (data == accounts[i])
                {
                    exit = 1;
                    Console.WriteLine("Account exists!");
                    index = i;
                    options(index);
                    break;
                }
            }
            if (exit==0)
            {
                createact(data);
            }

        }

        public void createact(int x)
        {
            Console.WriteLine("Account does not exist!");
            Console.WriteLine("Would you like to create an account? (y/n)");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                index = idx;
                accounts[idx] = x;
                Console.WriteLine("Enter an opening deposit.(Minimum amount:500)");
                int amt = int.Parse(Console.ReadLine());
                amount[idx] = amt;
                idx += 1;
                options(index);
            }
            else if (ans == "n")
            {
                Console.WriteLine("End of session");
            }
        }
        public void options(int x)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1.WITHDRAWL");
            Console.WriteLine("2.DEPOSIT");
            Console.WriteLine("3.CHECK BALANCE");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: withdrawl(x);break;
                case 2: deposit(x); break;
                case 3: balance(x); break;
                default: Console.WriteLine("Invalid option"); ; break;

            }
        }
        public void withdrawl(int x)
        {
            if (amount[x] > 500)
            {
                Console.WriteLine("Enter amount:");
                int amt = int.Parse(Console.ReadLine());
                if ((amount[x] - amt) >= 500)
                {
                    Console.WriteLine("Withdrawl successful");
                    Console.WriteLine("Remaining balance:"+(amount[x] - amt));
                    amount[x] -= amt;
                }
                else if ((amount[x] - amt) < 500)
                {
                    Console.WriteLine("Minimum balance cannot be maintained");
                }
            }
            else
            {
                Console.WriteLine("Insufficient balance to withdraw");
            }
        }
        public void deposit(int x)
        {
            Console.WriteLine("Enter the deposit amount:");
            int amt = int.Parse(Console.ReadLine());
            amount[x] += amt;
            Console.WriteLine("deposit succesful!");
        }
        public void balance(int x)
        {
            Console.WriteLine("Your account balance is: "+amount[x]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int quit = 0;
            while (quit == 0)
            {
                Console.WriteLine("Start new transaction: (y/n)");
                string ans = Console.ReadLine();
                if (ans == "y")
                {
                    Data get = new Data();
                    get.account();
                }
                else
                {
                    Console.WriteLine("End of session!");
                    quit = 1;
                    break;
                }
               
            }
            Console.ReadLine();
            
        }
    }
}
