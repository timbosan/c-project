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
                Console.Write("Awesome! I'll have you pick a time slot for Friday.");
                //string time = Console.ReadLine();

    
            }

            else
            {
                Console.Write("Maybe next time, Have a great day!");
            }

        
            
        }
   
        public static void list( )
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
            Console.WriteLine("you chose the time slot: " + TimeSlots[UserChoiceasNUM -1].ToString());
        }
    
    }
}



 /*logic for selecting a timeslot
 
 public static void list( )
        {
            string Userchoice;
            string[] TimeSlots = {"1:00 - 2:00 ", "2:00 - 3:00", "3:00 - 4:00", "4:00 - 5:00"};
            for(int i = 0; i < TimeSlots.Length; i++)
            {
              int displayCounter = i+1;
              Console.WriteLine( displayCounter.ToString() + ").  " + TimeSlots[i].ToString());
            }
            Console.WriteLine("Please select a time for your Pizza");
            Userchoice = Console.ReadLine();
            int UserChoiceasNUM = Int32.Parse(Userchoice);
            Console.WriteLine("you chose the time slot: " + TimeSlots[UserChoiceasNUM -1].ToString());
        }

        */