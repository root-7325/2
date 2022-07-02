using System;
using System.Collections.Generic;
using System.Linq;
internal class Phone
{
    protected static string сommand = "";
    protected static string probel = "";
    protected static string Name = "";
    protected static string Number = "";
    protected static Dictionary<string, string> phoneBook = new Dictionary<string, string>();
    protected static Dictionary<string, string> phoneSms = new Dictionary<string, string>();
}

internal class PhoneMenu : Phone
{

    static private void Initialize()
    {

        Console.WriteLine("\tphone");
        Console.WriteLine("Write 'add' to add new contact");
        Console.WriteLine("Write 'call' to call someone");
        Console.WriteLine("Write 'sms' to text someone");
        Console.WriteLine("Write 'list' to show each message, which you have sent");
    }
    static private void Add()
    {
        Console.WriteLine("Adding new contact...\n");
        Console.WriteLine("Write name of contact & number in +7<10 numbers> format. ");
        Phone.Name = Console.ReadLine();
        Phone.Number = Console.ReadLine();
        if (Phone.Number.All(char.IsDigit) == false || Phone.Number.Length > 9 || Phone.Number.Length < 9)
        {
            Console.WriteLine("An error was made when entering the number!");
        }

        else
        {
            Phone.phoneBook.Add(Phone.Name, Phone.Number);
            Console.WriteLine("Succesfully added new contact.\n");
        }

    }
    static private void Call()
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

            if (сall == Count.Value)
            {
                Console.WriteLine($"Calling {Count.Key}...");
                Console.WriteLine("No respond...");
                break;
            }

            if (сall.All(char.IsDigit) == false || сall.Length > 9 || сall.Length < 9)
            {
                Console.WriteLine("An error was made when entering the number!");
                break;
            }

            else
            {
                Console.WriteLine("Calling +7" + сall);
                Console.WriteLine("No respond...");
                break;
            }

        }
    }

    static string сall = "";
    static private void Sms()
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

            if (сall == Phone.probel)
            {
                break;
            }

            if (сall.All(char.IsDigit) == false || сall.Length > 9 || сall.Length < 9)
            {
                Console.WriteLine("An error was made when entering the number!");
                break;
            }

            else
            {
                Console.WriteLine("Type message for +7" + сall);
                Phone.phoneSms.Add(Console.ReadLine() + " - to +7" + сall, DateTime.Now.ToString("HH:mm:ss tt"));
                Console.WriteLine("Message sent.");
            }
            break;

        }
    }
    static private void List()
    {
        foreach (var Count in Phone.phoneSms)
        {
            Console.WriteLine($"{Count.Key} {Count.Value}");
        }
    }
    static public void Main()
    {
        PhoneMenu.Initialize();
        do
        {
            Phone.сommand = Console.ReadLine();
            switch (Phone.сommand)
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