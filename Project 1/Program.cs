using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;
using static System.Console;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            welcomeStatement();
            double bagPrice = getBagsData();
            WriteLine("Your bag total is {0}", bagPrice.ToString("C"));
            double seatPrice = getSeatsData();
            WriteLine("Your seat total is {0}", seatPrice.ToString("C"));
            double total = bagPrice + seatPrice;           
            double taxtotal = total * .05;
            double grandtotal = taxtotal + total;
            WriteLine("**************");
            WriteLine("Your subtotal is {0}",total.ToString("C"));           
            WriteLine("Your tax rate is 5%"); 
            WriteLine("Your tax total is {0}", taxtotal.ToString("C"));
            WriteLine("Your grand total is {0}", grandtotal.ToString("C"));
            WriteLine("**************");



        }

        static void welcomeStatement()
        {

            WriteLine("Welcome to AirLine Reynolds");
            WriteLine("Please enter your first name");
            ReadLine();
            WriteLine("Please enter your address");
            ReadLine();
            WriteLine("Please enter your Date of travel");
            ReadLine();


        }
        static double getBagsData()
        {


            WriteLine("Are you checking in bags today?");
            string hasbags = Console.ReadLine();
            if (hasbags == "yes")
            {
                WriteLine("How many bags are you checking in today?");
                double bags = Convert.ToInt32(Console.ReadLine());
                return 25 * bags;
            }
            else
                return 0;







        }
        static double getSeatsData() 
        {
            WriteLine("Will you be needing a seat today?");
            string getSeats = Console.ReadLine();
            if (getSeats == "yes")
            {
                WriteLine("How many seats do you need today?");
                double seats = Convert.ToInt32(Console.ReadLine());
                return 30 * seats;
            }
            else
            return 0;
        }
       



    }
}
