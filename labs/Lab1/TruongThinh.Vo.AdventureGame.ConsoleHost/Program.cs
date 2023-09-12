/*
 * Truong Thinh Vo
 * ITSE 1430 
 * Lab 1
 */

class Program
{
    static void Main ( string[] args )
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear(); // Clear the console for a clean display.
            DisplayMenu();

            // Read player input and convert it to lowercase for case insensitivity.
            string userInput = Console.ReadLine().ToLower();

            // Handle player input.
            switch (userInput)
            {
                case "a":
                // Call the function to perform the action for option 'a'.
                HandleOptionA();
                break;
                case "b":
                // Call the function to perform the action for option 'b'.
                HandleOptionB();
                break;
                case "q":
                // Quit the game loop.
                isRunning = false;
                break;
                default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
            }

            // Wait for the user to press Enter before displaying the menu again.
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }

        Console.WriteLine("Thank you for playing!");
    }

    static void DisplayMenu ()
    {
        Console.WriteLine("=== Game Menu ===");
        Console.WriteLine("a) Option A");
        Console.WriteLine("b) Option B");
        Console.WriteLine("q) Quit");
        Console.Write("Enter your choice: ");
    }

    static void HandleOptionA ()
    {
        Console.WriteLine("You chose Option A. Implement the logic for this option here.");
    }

    static void HandleOptionB ()
    {
        Console.WriteLine("You chose Option B. Implement the logic for this option here.");
    }
}