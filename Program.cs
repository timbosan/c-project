using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PizzaParty
{
    class Program
    {
        public static void Main()
        
        { 
            int orderNumber = 1;
            while (true)
            {

            Console.Write("\nWhat is your name?  \n\nType 'EXIT' at anytime to exit the ordering app.\n>>");
            string name = Console.ReadLine();
            //check each var at a read line for an exit
            CheckForExit(name);

            Console.Write("Hello " + name + " do you want to order a pizza?  Y/N\n>>");
            string ordered = (Console.ReadLine()).ToUpper();
            CheckForExit(ordered);


            if (ordered == "Y")
            {
                
                var CustomerTimeChoice = timelist();
                var Overview = new PizzaOrder();
                Overview.Name = name;
                Overview.TimeSlot = CustomerTimeChoice;
                Overview.Pizzas = new List<Pizza>();
                while (true)
                { 
                    var Pizza = new Pizza();
                    var CustomerToppingChoices = Toppings_Menu();
                    Pizza.Toppings = CustomerToppingChoices;
                    Console.Write("Do you want to order another pizza?    Y/N\n>>");
                    string AnotherPizza = (Console.ReadLine()).ToUpper();
                    Overview.Pizzas.Add(Pizza);
                    if (AnotherPizza == "N")
                        break;
                }
                 var Json = JsonConvert.SerializeObject(Overview);
                    System.IO.File.WriteAllText("order_" + orderNumber + ".json", Json);
                Environment.Exit(1);
            }

            else
            {
                Console.Write("\nMaybe next time, Have a great day!");
            }
               
                orderNumber++;
            }

        }


        // Functions
        public static string timelist()
        {
            string UserChoice;
            string[] TimeSlots = { "6:00 - 6:15 ", "6:15 - 6:30", "6:30 - 6:45", "6:45 - 7:00" };
            Console.Write("\nAwesome! I'll have you pick a time slot for Friday.\n\n\n");
            Console.WriteLine("\nPlease select a time to pick up your Pizza\n");
            for (int i = 0; i < TimeSlots.Length; i++)
            {
                int displayCounter = i + 1;
                Console.WriteLine('\n' + displayCounter.ToString() + ").  " + TimeSlots[i].ToString());
            }
            UserChoice = Console.ReadLine();
            CheckForExit(UserChoice);
            int UserChoiceasNUM = Int32.Parse(UserChoice);
            Console.WriteLine("\nYou chose the time slot: " + TimeSlots[UserChoiceasNUM - 1] + ". \n\n\n".ToString());
            return TimeSlots[UserChoiceasNUM - 1];
        }

        public static List<string> Toppings_Menu()
        {
            List<string> CustomerToppingChoices = new List<string>();
            string UserChoicetoppings;
            string[] Toppings_Menu = { "Basil", "Hot Honey", "Italian Sausage", "Pepperoni", "Mushrooms", "Jalapenos", "Just Cheese", "Finished Adding Toppings" };
            int toppingOption = 0;
            while (toppingOption != 8)
            {
                Console.WriteLine("\nPlease select toppings for your Pizza!");
                for (int i = 0; i < Toppings_Menu.Length; i++)
                {
                    int displayCountertoppings = i + 1;
                    Console.WriteLine('\n' + displayCountertoppings.ToString() + "). " + Toppings_Menu[i].ToString());
                }
                UserChoicetoppings = Console.ReadLine();
                CheckForExit(UserChoicetoppings);
                toppingOption = Int32.Parse(UserChoicetoppings);
                CustomerToppingChoices.Add(Toppings_Menu[toppingOption - 1]);
                string CustomerToppingChoicesCombined = string.Join(", ", CustomerToppingChoices);
                Console.WriteLine("\n>>These are your toppings so far: " + CustomerToppingChoicesCombined);
                //Console.WriteLine("\nYou picked these toppings: " + Toppings_Menu[toppingOption - 1].ToString());
            }
            return CustomerToppingChoices;
        }

        // if user enters exit close program 
        public static void CheckForExit(string checker)
        {
            if (checker.ToUpper() == "EXIT")
            {
                Environment.Exit(1);
            }
            else
            {
                return;

            }
        }
    }
    public class PizzaOrder
    {
        public string Name { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public string TimeSlot { get; set; }
    }

    public class Pizza
    {
        public List<string> Toppings { get; set; }
    }
}




