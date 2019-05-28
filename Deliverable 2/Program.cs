using System;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Friends, what are you in the mood for?");
            Console.WriteLine("Here are your options: ");

            int activity;
            int num;

            string act = "";
            string recommend = "";
            string travel = "";

            Console.WriteLine("1) Action");
            Console.WriteLine("2) Chill times");
            Console.WriteLine("3) Danger");
            Console.WriteLine("4) Good food");
            activity = Convert.ToInt16(Console.ReadLine());

            while (activity < 1 || activity > 4)
            {
                Console.Write("The input does not match, please enter 1-4:");
                activity = Convert.ToInt16(Console.ReadLine());
            }
            if (activity == 1)
            {
                recommend = "Stock Car Racing";
                act = "Action";
            }
            else if (activity == 1)
            {
                recommend = "Hiking";
                act = "Chilling";
            }
            else if (activity == 3)
            {
                recommend = "Skydiving";
                act = "Danger";
            }
            else if (activity == 4)
            {
                recommend = "Taco Bell";
                act = "Good food";
            }
            Console.WriteLine("How many people are you bringing with you?");
            num = Convert.ToInt16(Console.ReadLine());
            if (num == 0)
            {

            }
            else if (num >= 1 && num <= 4)
            {
                travel = "a sedan";
            }
            else if (num >= 5 && num <= 10)
            {
                travel = "a Volkswagen bus";
            }
            else if (num >= 11)
            {
                travel = "an airplane";
            }

            Console.WriteLine("Okay if you’re in the mood for " + act + ", then you should go to " + recommend + " and travel in" + travel);
            Console.WriteLine("Have a Great Day.");
            Console.ReadLine();





        }
    }
}
