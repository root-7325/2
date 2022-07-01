using System;
using System.Collections.Generic;
class Phone
{
    public string сommand;
    internal string probel;
    internal string сall;
}

class PhoneMenu
{
    static void Initialize()
    {

        Console.WriteLine("               phone   ");
        Console.WriteLine("Write add to add new contact");
        Console.WriteLine("Write call to call someone");
        Console.WriteLine("Write sms to text someone");
        Console.WriteLine("Write list to show each message, which you have sent");
    }
    static void Main()
    {
        Phone Menu = new Phone();
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        Dictionary<string, string> phoneSms = new Dictionary<string, string>();
        PhoneMenu.Initialize();
        do
        {
            Menu.сommand = Console.ReadLine();
            string call = "";
            switch (Menu.сommand)
            {
                case "add":

                case "call":
                    Console.WriteLine("Choose contact or number to call\n");

                    foreach (var Count in phoneBook)
                    {
                        Console.WriteLine($"{Count.Key}");
                        Menu.сall = Console.ReadLine();

                        if (Menu.сall == Count.Key)
                        {
                            Console.WriteLine($"Calling {Count.Key}...");
                            Console.WriteLine("No respond...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Calling " + Menu.сall);
                            Console.WriteLine("No respond...");
                            break;
                        }
                    }
                    break;

                case "sms":
                    Console.WriteLine("Choose contact or number to send sms\n");

                    foreach (var Count in phoneBook)
                    {

                        Console.WriteLine($"{Count.Key}");
                        Menu.сall = Console.ReadLine();

                        if (Menu.сall == Count.Key)
                        {
                            Console.WriteLine($"Type message for {Count.Key}:");
                            phoneSms.Add(Console.ReadLine() + $" - to {Count.Key}", DateTime.Now.ToString("HH:mm:ss tt"));
                            Console.WriteLine("Message sent.");
                            break;
                        }

                        if (Menu.сall == Count.Value)
                        {
                            Console.WriteLine($"Type message for {Count.Key}:");
                            phoneSms.Add(Console.ReadLine() + $" - to {Count.Key}", DateTime.Now.ToString("HH:mm:ss tt"));
                            Console.WriteLine("Message sent.");
                            break;
                        }

                        if (Menu.сall == Menu.probel)
                        {
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Type message for " + call);
                            phoneSms.Add(Console.ReadLine() + "+7" + call, DateTime.Now.ToString("HH:mm:ss tt"));
                            Console.WriteLine("Message sent.");
                        }
                        break;

                    }
                    break;


                case "":
                    break;

                case "list":
                    foreach (var Count in phoneSms)
                    {
                        Console.WriteLine($"{Count.Key} {Count.Value}");
                    }
                    break;

                default:
                    Console.WriteLine("Uknown command!\n");
                    continue;

            }
        } while (true);
    }
}

