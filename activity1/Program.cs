using System;

class Program
{
    static void Main()
    {
        char reply; // Declare outside so the while loop can see it


        Console.Write("-------------------------------------------------------------\n\n");
        Console.Write("                  EVEN & ODD NUMBER CHECKER                  \n");
        Console.Write("                  by: Josef Karol A. Velayo                  \n");
        
        do
        {
        Console.Write("\n-------------------------------------------------------------\n\n");
            Console.Write("Enter a number: ");
            // Added a check to prevent crashing if the user enters a non-number
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("> " + num + " is an even number!");
                }
                else
                {
                    Console.WriteLine("> " + num + " is an odd number!");
                } 
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // Ask to continue
            Console.Write("\nContinue [Y/N]? ");
            reply = char.Parse(Console.ReadLine());

            // Simple validation: If it's NOT any of the valid options, ask again
            while (reply != 'Y' && reply != 'y' && reply != 'N' && reply != 'n')
            {
                Console.Write("\nInvalid entry! Please type [Y/N] only: ");
                reply = char.Parse(Console.ReadLine());

            }

        } while (reply == 'Y' || reply == 'y');
        

        Console.Write("\n-------------------------------------------------------------\n");
        Console.Write("Thank you for using the checker!");
        Console.Write("\n-------------------------------------------------------------\n\n");
    }
}