using System;

namespace PizzaParty
{
    class Program
    {
        public static void Main()
        {
            Console.Write("What is your name?  ");
            string name = Console.ReadLine();

            Console.Write("Hello " + name + " do you want to order a pizza?  Y/N  ");
            string ordered = (Console.ReadLine()).ToUpper();
            

            if (ordered == "Y")
            {   
                timelist();
                Toppings_Menu();
            
          
            }

            else
            {
                Console.Write("\nMaybe next time, Have a great day!");
            }

        
            
        }
   
        public static void timelist( )
        {
            string Userchoice;
            string[] TimeSlots = {"6:00 - 6:15 ", "6:15 - 6:30", "6:30 - 6:45", "6:45 - 7:00"};
            Console.Write("\nAwesome! I'll have you pick a time slot for Friday.\n\n\n");
            Console.WriteLine("\nPlease select a time to pick up your Pizza\n");
            for(int i = 0; i < TimeSlots.Length; i++)
            {
              int displayCounter = i+1;
              Console.WriteLine('\n' + displayCounter.ToString() + ").  " + TimeSlots[i].ToString());
            }
            Userchoice = Console.ReadLine();
            int UserChoiceasNUM = Int32.Parse(Userchoice);
            Console.WriteLine("\nYou chose the time slot: " + TimeSlots[UserChoiceasNUM -1] + ". \n\n\n".ToString());
        }

        public static void Toppings_Menu( )
        {
        string UserChoicetoppings;
        string[] Toppings_Menu = {"Basil", "Hot Honey", "Italian Sausage", "Pepperoni", "Mushrooms", "Jalapenos", "Just Cheese"}; 
        Console.WriteLine("\nPlease select toppings for your Pizza!");
        for(int i = 0; i < Toppings_Menu.Length; i++)
            {
              int displayCountertoppings = i+1;
              Console.WriteLine('\n' + displayCountertoppings.ToString() + "). " + Toppings_Menu[i].ToString());
            }
            UserChoicetoppings = Console.ReadLine();
            int UserChoicetoppingsasNUM = Int32.Parse(UserChoicetoppings);
            Console.WriteLine("\nYou these toppings: " + Toppings_Menu[UserChoicetoppingsasNUM -1].ToString());
            
        }
    }
}



