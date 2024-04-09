using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new();
        LectureEvent event1 = new("How to get girls", "Learn how to pick up chics from a master.", "04/18/2024", "4:20 p.m.", new Address("8556 Covington Place", "Rigby", "ID"), "Cassanova Joe", 300);
        ReceptionEvent event2 = new("Wedding 2071", "Join the wedding reception for Mckay Smith and Madi Johnson", "05/25/2024", "2:00 p.m.", new Address("1298 Brigham Court", "Provo", "UT"), "madijohnson@gmail.com");
        OutdoorGatheringEvent event3 = new("Avalanche Rescue", "Learn how to save people and pets from avalanches.", "06/21/2024", "11.00 a.m.", new Address("6 Main St", "Fairbanks", "AK"), "snowing");
        events.Add(event1);
        events.Add(event2);
        events.Add(event3);

        int i = 1;
        foreach(Event e in events)
        {
            Console.WriteLine($"Event {i}: (Standard Details, Full Details, and a Short Description)");
            Console.WriteLine();
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();
            if (e is LectureEvent lectureEvent)
            {
                Console.WriteLine(lectureEvent.GetFullDetails());
                Console.WriteLine();
                Console.WriteLine(lectureEvent.GetShortDesc("lecture event"));
                Console.WriteLine();
            }
            else if (e is ReceptionEvent receptionEvent)
            {
                Console.WriteLine(receptionEvent.GetFullDetails());
                Console.WriteLine();
                Console.WriteLine(receptionEvent.GetShortDesc("reception event"));
                Console.WriteLine();
            }
            else if (e is OutdoorGatheringEvent outdoorGatheringEvent)
            {
                Console.WriteLine(outdoorGatheringEvent.GetFullDetails());
                Console.WriteLine();
                Console.WriteLine(outdoorGatheringEvent.GetShortDesc("outdoor gathering event"));
                Console.WriteLine();
            }
            i++;
        }
    }
}