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
        Dictionary<string, string> phoneSms = new Dictionary<string, string>();
        int merlok = 0;
        Phone Menu = new Phone();
        var сall = "";
        Console.WriteLine("               phone   ");
        Console.WriteLine("Write add to add new contact");
        Console.WriteLine("Write call to call someone");
        Console.WriteLine("Write sms to text someone");
        Console.WriteLine("Write list/ to show each message, which you have sent");

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
                        else
                        {
                            Console.WriteLine("Calling " + сall); //a tyt che
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
                        сall = Console.ReadLine();

                        if (сall == Count.Key)
                        {

                            Console.WriteLine($"Type message for {Count.Key}:");
                            phoneSms.Add(Console.ReadLine() + $"{Count.Key}", DateTime.Now.ToString("HH:mm:ss tt"));
                            Console.WriteLine("Message sent.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Type message for " + call); //call doesn't exist in this kontekst
                            phoneSms.Add(Console.ReadLine() + call, DateTime.Now.ToString("HH:mm:ss tt")); //tyt tozhe
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
                        Console.WriteLine($"{Count.Key}  +  {Count.Value}");
                    }
                    break;

                default:
                    Console.WriteLine("Uknown command!\n");
                    continue;

            }
        } while (merlok == 0);
    }
}

