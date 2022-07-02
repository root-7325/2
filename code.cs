using System;
using System.Collections.Generic;
class Phone
{
    public string сommand;
    public static Dictionary<string, string> phoneBook = new Dictionary<string, string>();
    public static Dictionary<string, string> phoneSms = new Dictionary<string, string>();
    public string сall;
}

class PhoneMenu
{
    private static string probel;

    static void Initialize()
    {

        Console.WriteLine("               phone   ");
        Console.WriteLine("Write add to add new contact");
        Console.WriteLine("Write call to call someone");
        Console.WriteLine("Write sms to text someone");
        Console.WriteLine("Write list to show each message, which you have sent");
    }
    static void Add()
    {
        Console.WriteLine("Adding new contact...\n");
        Console.WriteLine("Write name of contact & number in +7<10 numbers> format. ");
        Phone.phoneBook.Add(Console.ReadLine(), Console.ReadLine());
        Console.WriteLine("Succesfully added new contact.\n");
    }
    static void Call()
    {
        Console.WriteLine("Choose contact or number to call\n");

        foreach (var Count in Phone.phoneBook)
        {
            Console.WriteLine($"{Count.Key}");
            сall = Console.ReadLine();

            if (сall == Count.Key)
            {
                Console.WriteLine($"Calling {Count.Key}...");
                Console.WriteLine("No respond...");
                break;
            }
            else
            {
                Console.WriteLine("Calling " + сall);
                Console.WriteLine("No respond...");
                break;
            }
        }
    }

    static string сall = "";
    static void Sms()
    {
        Console.WriteLine("Choose contact or number to send sms\n");

        foreach (var Count in Phone.phoneBook)
        {
            Console.WriteLine($"{Count.Key}");
            сall = Console.ReadLine();

            if (сall == Count.Key)
            {
                Console.WriteLine($"Type message for {Count.Key}:");
                Phone.phoneSms.Add(Console.ReadLine() + $" - to {Count.Key}", DateTime.Now.ToString("HH:mm:ss tt"));
                Console.WriteLine("Message sent.");
                break;
            }

            if (сall == Count.Value)
            {
                Console.WriteLine($"Type message for {Count.Key}:");
                Phone.phoneSms.Add(Console.ReadLine() + $" - to {Count.Key}", DateTime.Now.ToString("HH:mm:ss tt"));
                Console.WriteLine("Message sent.");
                break;
            }

            if (сall == probel)
            {
                break;
            }

            break;

        }
    }
    static void List()
    {
        foreach (var Count in Phone.phoneSms)
        {
            Console.WriteLine($"{Count.Key} {Count.Value}");
        }
    }
    static void Main()
    {
        Phone Menu = new Phone();
        PhoneMenu.Initialize();
        do
        {
            Menu.сommand = Console.ReadLine();
            switch (Menu.сommand)
            {
                case "add":
                    PhoneMenu.Add();
                    break;
                case "call":
                    PhoneMenu.Call();
                    break;

                case "sms":
                    PhoneMenu.Sms();
                    break;

                case "":
                    break;

                case "list":
                    PhoneMenu.List();
                    break;

                default:
                    Console.WriteLine("Uknown command!\n");
                    continue;

            }
        } while (true);
    }
}
