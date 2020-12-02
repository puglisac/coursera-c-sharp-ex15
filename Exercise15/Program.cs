using System;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            startGame();            
        }

        //handle the user input and respond with appropriate message
        //using 'if' statement
        public static void makeResponseIf(int choice)
        {
            if (choice == 1||choice == 2)
            {
                Console.WriteLine("Loading...");
            }
            else if (choice == 3)
            {
                startGame();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine("Invalid selection");
                startGame();
            }
        }

        //handle the user input and respond with appropriate message
        //using 'switch' statement
        public static void makeResponseSwitch(int choice)
        {
            switch (choice)
            {
                case 1:
                case 2:
                    Console.WriteLine("Loading...");
                    break;
                case 3:
                    startGame();
                    break;
                case 4:
                    Console.WriteLine("Goodbye");
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    startGame();
                    break;
            }
        }
        //Start the game with menu options and read user input
        public static void startGame()
        {
            Console.WriteLine("Menu:\n1 - New Game\n2 - Load Game\n3 - Options\n4 - Quit");
            int menuChoice = int.Parse(Console.ReadLine());
            makeResponseSwitch(menuChoice);
        }
    }
}
