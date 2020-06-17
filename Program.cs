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
                Console.Write("Awesome! I'll have you pick a time slot for Friday ");
                //string time = Console.ReadLine();
            }

            if (ordered == "N");
            {
                Console.Write("Maybe next time, Have a great day!");
            }

        
            
        }
   
    
    
    }
}



    
    