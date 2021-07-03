using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = 6666;

            Console.WriteLine(" Welcome to FinanceBank ATM!");

            Console.WriteLine("Please select an option...");
            Console.WriteLine("1 - View Budget");
            Console.WriteLine("2 - Withdraw Money");
            Console.WriteLine("3 - Deposit Money");
            Console.WriteLine("4 - Exit");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine(" Your Updated Budget:" + budget);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("Enter the amount of money you want you want to withdraw.");
                    int withdrawn_amount = Convert.ToInt32(Console.ReadLine());

                    if (withdrawn_amount > budget)
                    {
                        Console.WriteLine("You can't withdraw more money than your current budget!");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("Your Remaining Budget:" + (budget - withdrawn_amount));
                        Console.ReadLine();
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter the amount of money you want to deposit.");
                    int deposited_amount = Convert.ToInt32(Console.ReadLine());

                    {
                        Console.WriteLine("Your Updated Budget:" + (budget + deposited_amount));
                        Console.ReadLine();
                    }
                    break;

                case "4":
                    Console.WriteLine("Checking Out from your Account...");
                    Console.WriteLine(" Check Out Completed,Have a good day");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Please select a valid option.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}

