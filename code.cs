using System;
using System.Collections.Generic;
class Phone
{
    public string Command;
}

class PhoneMenu
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        int a1 = 0;
        Phone Menu = new Phone();
        var Call = "";
        String Message = "";
        Console.WriteLine("             phone   \n");
        Console.WriteLine("Write add to add new contact\n");
        Console.WriteLine("Write call to call someone\n");
        Console.WriteLine("Write sms to text someone\n");
        do
        {
            int Contacts = 0;
            Menu.Command = Console.ReadLine();
            switch (Menu.Command)
            {
                case "add":
                    Contacts++;
                    //Phone Contact = new Phone();
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
                        Call = Console.ReadLine();
                        if (Call == Count.Key)
                        {
                            Console.WriteLine($"Calling {Count.Key}...");
                            Console.WriteLine("No respond...");
                            break;
                        }
                        Console.WriteLine("Calling " + Call);
                        Console.WriteLine("No respond...");
                    }
                    break;
                case "sms":
                    Console.WriteLine("Choose contact or number to send sms\n");
                    foreach (var Count in phoneBook)
                    {
                        Console.WriteLine($"{Count.Key}");
                        Call = Console.ReadLine();
                        if (Call == Count.Key)
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
        } while (a1 == 0);
    }
}

