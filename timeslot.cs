 /*logic for selecting a timeslot*/
 
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