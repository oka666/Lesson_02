using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the program you want to execute:");

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Press '1' if you want to run program 'CanYouHaveAnyDiscount'");
                Console.WriteLine("Press '2' if you want to run program 'CanYouBuyExpensiveBeer'");
                Console.WriteLine("Press '3' to close the application");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        Discount();
                        break;
                    case "2":
                        Beer();
                        break;
                    case "3":
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("Please make your choice");
                        break;
                }

            }
        }

        enum BeerExamples
        {
            Leffe = 80,
            Hoegarden = 70,
            Stella = 60,
            Obolon = 7
        }

        public static void Beer()
        {
            Console.WriteLine("How much money do you have? ");

            while (true)
            {
                var moneyString = Console.ReadLine().Replace('.', ',');
                float myMoney = 0;

                if (!float.TryParse(moneyString, out myMoney))
                {
                    Console.WriteLine("Please enter numeric values");
                }
                else if (myMoney < 0)
                {
                    Console.WriteLine("Please enter positive amount of your money");
                }
                else
                {
                    BeerExamples yourBeer = BeerExamples.Obolon;

                    if (myMoney >= 7 && myMoney < 60) yourBeer = BeerExamples.Obolon;
                    else if (myMoney >= 60 && myMoney < 70) yourBeer = BeerExamples.Stella;
                    else if (myMoney >= 70 && myMoney < 80) yourBeer = BeerExamples.Hoegarden;
                    else if (myMoney >= 80) yourBeer = BeerExamples.Leffe;

                    var change = myMoney - (int)yourBeer;

                    Console.WriteLine($"The most expensive beer you can buy {yourBeer} and your change is {change}");
                    break;
                }
            }
        }

        public static void Discount()
        {
            Console.WriteLine("Please enter total amount on your bill:");

            while (true)
            {
                var billString = Console.ReadLine().Replace('.', ',');
                float bill = 0;

                if (!float.TryParse(billString, out bill))
                {
                    Console.WriteLine("Please enter numeric values");
                }
                else if (bill < 0)
                {
                    Console.WriteLine("Please enter positive amount from your bill");
                }
                else
                {
                    float discountPercentage = 0;

                    if (bill >= 300 && bill < 400) discountPercentage = 2;
                    else if (bill >= 400 && bill < 500) discountPercentage = 3;
                    else if (bill >= 500) discountPercentage = 5;

                    float discount = (discountPercentage / 100) * bill;
                    float priceWithDiscount = bill - discount;

                    Console.WriteLine($"You payment amount is {priceWithDiscount} which already includes discount percentage {discountPercentage}%");

                    break;
                }
            }
        }
    }
}
