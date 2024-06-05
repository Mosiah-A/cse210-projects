using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Oaks Street", "New York City", "NY", "USA");
        Lecture lecture = new Lecture("Mosiah", 50, "Lecture of true", "This is the LEcture", "02/20/2024", "12:00", address, 20);
        lecture.GetStandardDetails();
        Console.WriteLine();
        Console.WriteLine(lecture.GetType());
        lecture.GetFullDetails();
        Console.WriteLine();
        lecture.GetShortDescription();

        Console.WriteLine();
        Console.WriteLine("=============================");
        Console.WriteLine();

        Address address1 = new Address("45 corner Avenue", "Paulista", "Pernambuco", "Brazil");
        Reception reception = new Reception("mosiah@example.com", "Mosiah Party", "The Best party of your Life", "1/29/2025", "07:30pm", address1, 200);
        reception.GetStandardDetails();
        Console.WriteLine();
        Console.WriteLine(reception.GetType());
        reception.GetFullDetails();
        Console.WriteLine();
        reception.GetShortDescription();

        Console.WriteLine();
        Console.WriteLine("=============================");
        Console.WriteLine();

        Address address2 = new Address("257 oxford Avenue", "City of Mexico", "Taxas", "USA");
        OutdoorGatherubg outdoorGatherubg = new OutdoorGatherubg("Clean", "Outdoor", "outdoor description", "10/06/2021", "03:30pm", address2, 200);
        outdoorGatherubg.GetStandardDetails();
        Console.WriteLine();
        Console.WriteLine(outdoorGatherubg.GetType());
        outdoorGatherubg.GetFullDetails();
        Console.WriteLine();
        outdoorGatherubg.GetShortDescription();


        
    }
}