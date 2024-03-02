class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            string activityChoice = Console.ReadLine();
            Console.WriteLine();
            if (activityChoice == "4")
            {
                // Quit the program
                break;
            }
            Console.Write("How long, in seconds, would you like for your session? ");
            string durationChoice = Console.ReadLine();
            Console.WriteLine();
            int duration;
            if (!int.TryParse(durationChoice, out duration))
            {
                Console.WriteLine("Invalid input for duration. Please enter a valid integer value.");
                continue; // Restart the loop to display the menu again
            }

            // Create an instance of the appropriate activity class based on user choice
            switch (activityChoice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", duration);
                    breathingActivity.StartBreathing();
                    breathingActivity.End();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", duration);
                    reflectionActivity.StartReflection();
                    reflectionActivity.End();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", duration);
                    listingActivity.Startlisting();
                    listingActivity.End();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid activity.");
                    continue; // Restart the loop to display the menu again
            }
        }
    }
}