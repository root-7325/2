using System;
class Phone
{
    public int Number;
    public string Name = "";
    public string Command;
}
class PhoneMenu
{
    static void Main()
    {
        int a1 = 0;
        Phone Menu = new Phone();
        Console.WriteLine("            phone   \n");
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
                    Phone Contact = new Phone();
                    Console.WriteLine("Adding new contact...\n");
                    Console.WriteLine("Write name of contact: ");
                    Contact.Name = Console.ReadLine();
                    Console.WriteLine("\nWrite number to contact in format +7<10 numbers next>: \n+7");
                    Contact.Number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Succesfully added new contact.\n");
                    break;
                case "call":
                    Console.WriteLine("Choose contact or number to call\n");
                    while (Contacts > 0)
                    {
                        Console.WriteLine(Contact.Name + " " + Contact.Phone); //<----
                        Contacts--;
                    }
                    break;
                case "sms":
                    Console.WriteLine("Choose contact or number to send sms\n");
                    break;
                default:
                    Console.WriteLine("Uknown command!\n");
                    continue;

            }
        } while (a1 == 0);

        Console.ReadKey(true);
    }
}

