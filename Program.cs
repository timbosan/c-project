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
                Console.Write("Awesome! I'll have you pick a time slot for Friday.\n\n\n");
                
                timelist();
                
                Toppings_Menu();

    
            }

            else
            {
                Console.Write("Maybe next time, Have a great day!");
            }

        
            
        }
   
        public static void timelist( )
        {
            string Userchoice;
            string[] TimeSlots = {"6:00 - 6:15 ", "6:15 - 6:30", "6:30 - 6:45", "6:45 - 7:00"};
            for(int i = 0; i < TimeSlots.Length; i++)
            {
              int displayCounter = i+1;
              Console.WriteLine( displayCounter.ToString() + ").  " + TimeSlots[i].ToString());
            }
            Console.WriteLine("Please select a time for your Pizza");
            Userchoice = Console.ReadLine();
            int UserChoiceasNUM = Int32.Parse(Userchoice);
            Console.WriteLine("You chose the time slot: " + TimeSlots[UserChoiceasNUM -1] + ". \n\n\n".ToString());
        }

        public static void Toppings_Menu( )
        {
        string UserChoicetoppings;
        string[] Toppings_Menu = {"Basil", "Hot Honey", "Italian Sausage", "Pepperoni", "Mushrooms", "Jalapenos", "Just Cheese"}; 
        for(int i = 0; i < Toppings_Menu.Length; i++)
            {
              int displayCountertoppings = i+1;
              Console.WriteLine( displayCountertoppings.ToString() + "). " + Toppings_Menu[i].ToString());
            }
              Console.WriteLine("Please select toppings for your Pizza!");
            UserChoicetoppings = Console.ReadLine();
            int UserChoicetoppingsasNUM = Int32.Parse(UserChoicetoppings);
            Console.WriteLine("You these toppings: " + Toppings_Menu[UserChoicetoppingsasNUM -1].ToString());
            
        }
    }
}



