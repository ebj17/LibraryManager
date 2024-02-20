namespace ContactManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize new FileContactStorage and ContactBook.
            List<String> ContactNumbers = new List<String>();

            // Implement user interaction loop here:
            // Display menu options, take user input, and call corresponding ContactBook methods
            while (true)
            {
                Console.WriteLine("\nContact Book Application");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. View Contacts");
                Console.WriteLine("3. Update Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":

                        Console.WriteLine("Create a contact: ");
                        string number = Console.ReadLine();
                        ContactNumbers.Add(number);
                        break;
                    case "2":

                        Console.WriteLine("\nView Contacts: ");
                        if (ContactNumbers.Count == 0)
                        {
                            Console.WriteLine("Contact Library Empty");
                        }
                        else
                        {
                            foreach (string num in ContactNumbers)
                        {
                                Console.WriteLine(num);
                        }

                        }
                        break;
                    case "3":
                        // Update contact flow
                        Console.WriteLine("Update Contacts: ");
                        break;
                    case "4":
                        Console.WriteLine("Delete a Contact: ");
                        string contacts = Console.ReadLine();
                        ContactNumbers.Remove(contacts);
                        break;
                    case "5":
                        // Exit application
                        Console.WriteLine("Exiting application...");
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }

}