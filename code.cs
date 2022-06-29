using System;
using System.Collections.Generic;
class Phone
{
    public string сommand;
}

class PhoneMenu
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        int merlok = 0;
        Phone Menu = new Phone();
        var сall = "";
        String Message = "";
        Console.WriteLine("             phone   \n");
        Console.WriteLine("Write add to add new contact\n");
        Console.WriteLine("Write call to call someone\n");
        Console.WriteLine("Write sms to text someone\n");

        do
        {
            int Contacts = 0;
            Menu.сommand = Console.ReadLine();
            switch (Menu.сommand)
            {
                case "add":
                    Contacts++;
                    Console.WriteLine("Adding new contact...\n");
                    Console.WriteLine("Write name of contact & number in +7<10 numbers> format. ");
                    phoneBook.Add(Console.ReadLine(), Console.ReadLine());
                    Console.WriteLine("Succesfully added new contact.\n");
                    break;

                case "call":
                    Console.WriteLine("Choose contact or number to call\n");

                    foreach (var Count in phoneBook)
                    {
                        Console.WriteLine($"{Count.Key}");
                        сall = Console.ReadLine();

                        if (сall == Count.Key)
                        {
                            Console.WriteLine($"Calling {Count.Key}...");
                            Console.WriteLine("No respond...");
                            break;
                        }

                        Console.WriteLine("Calling " + сall);
                        Console.WriteLine("No respond...");
                    }
                    break;

                case "sms":
                    Console.WriteLine("Choose contact or number to send sms\n");

                    foreach (var Count in phoneBook)
                    {

                        Console.WriteLine($"{Count.Key}");
                        сall = Console.ReadLine();

                        if (сall == Count.Key)
                        {

                            Console.WriteLine($"Type message for {Count.Key}:");
                            Message = Console.ReadLine();
                            Console.WriteLine("Message sent.");
                            break;
                        }
                        break;
                    }
                    break;

                case "":
                    break;

                default:
                    Console.WriteLine("Uknown command!\n");
                    continue;

            }
        } while (merlok == 0);
    }
}

