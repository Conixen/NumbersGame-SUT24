using System;

namespace NumbersGame_SUT24
{
    internal class Program
    {
                        // Leon Johansson SUT24 The Nummbers Game
        static void Main(string[] args)
        {
      
            bool gameOn = true;         // Main game loop boolean

            while (gameOn)    // Main game loop
            {

                // Variables for the winning number, user's guess, and guess count
                int winNumb = 0;
                int userGuess = 0;
                int userGuessCount = 1;

                // Booleans that controls easy or hardmodes
                bool gameOnEasy = true;
                bool gameOnHard = true;

                Console.Clear();        // Clear console to start fresh each time


                Console.WriteLine("Välkmommen till The Nummbers game" +     // Menu
               "\nVälj ett av de följande alternativen:" +
               "\n1. Spela Nummbers game (Easy Mode)" +
               "\n2. Hard Mode" +
               "\n3. Avsluta");

                // Read user's choice from the menu
                string menuChoice = Console.ReadLine();


                // Handle the user's choice using a switch statement
                switch (menuChoice)
                {

                    case "1":   // EasyMode
                                
                        // Generate a random number for the user to guess and nummber of guesses that they have
                        winNumb = CheckGuess(userGuess);
                        Console.WriteLine("Jag tänker på ett nummer... ");
                        Console.WriteLine("\nKan du gissa talet? (ledtråd mellan 1 - 20)" +
                        "\nDu får 5 försök");

                        while (gameOnEasy)      // Easy mode loop
                        {
                            // Check if the user's input is a valid integer
                            if (Int32.TryParse(Console.ReadLine(), out userGuess))
                            {
                                if (userGuess == winNumb && userGuessCount < 6)     // If the guess is correct and under 5 attempts
                                {
                                    // Congratulation message and nummber of tries
                                    Console.WriteLine("Wohoo! Du gjorde det!" +
                                       $"\nDu gjorde det på {userGuessCount} försök");
                                    Console.ReadKey();
                                    gameOnEasy = false;     // End the easy mode loop
                                }

                                else if (userGuessCount == 5)                       // If the user has used all 5 attempts
                                {
                                    Console.WriteLine($"Tyvärr bättre lycka nästa gång, du har använt alla dina försök" +
                                        $"\nDet talet jag var ute efter var {winNumb}");            // Tells the user the correct nummber
                                    Console.ReadKey();
                                    gameOnEasy = false;     // End the easy mode loop

                                }

                                else if (userGuess < winNumb && userGuessCount < 6)     // If the guess is too low and under 5 attempts
                                {

                                    Console.WriteLine("\nDu gissade för lågt!" +
                                        $"Detta är ditt {userGuessCount} försök");
                                    userGuessCount++;                               // Increasing the attempt counter

                                }

                                else if (userGuess > winNumb && userGuessCount < 6)     // If the guess is too high and under 5 attempts
                                {

                                    Console.WriteLine("\nDu gissade för högt!" +
                                        $"Detta är ditt {userGuessCount} försök");
                                    userGuessCount++;                               // Increasing the attempt counter

                                }

                                else
                                {

                                    Console.WriteLine("\nNågot blev fel, testa igen");

                                }

                            }
                            else   // If (or "else") invalid input
                            {

                                Console.WriteLine("Något blev fel, testa tryck på en siffra");

                            }
                        }
                        break;

                    case "2":   // Hard Mode
                        // More or less same as easy mode... code wise
                        // but its a random nummber between 1 - 50 and you have 6 attempts
                        winNumb = CheckGuessHard(winNumb);
                        Console.WriteLine("Jag tänker på ett nummer... ");
                        Console.WriteLine("\nKan du gissa talet? (ledtråd mellan 1 - 50)" +
                        "\nDu får 6 försök");

                        while (gameOnHard)
                        {

                            if (Int32.TryParse(Console.ReadLine(), out userGuess))
                            {
                                if (userGuess == winNumb && userGuessCount < 7)
                                {

                                    Console.WriteLine("\nWohoo! Du gjorde det!" +
                                       $"\nDu gjorde det på {userGuessCount} försök");
                                    Console.ReadKey();
                                    gameOnHard = false; // End the hard mode loop
                                }

                                else if (userGuessCount == 6)
                                {
                                    Console.WriteLine("\nTyvärr bättre lycka nästa gång, du har använt alla dina försök" +
                                        $"\nDet talet jag var ute efter var {winNumb} ");
                                    gameOnHard = false; // End the hard mode loop

                                }

                                else if (userGuess < winNumb && userGuessCount < 7)
                                {

                                    Console.WriteLine("\nDu gissade för lågt!" +
                                        $"Detta är ditt {userGuessCount} försök");
                                    userGuessCount++;            // Increasing the attempt counter


                                }

                                else if (userGuess > winNumb && userGuessCount < 7)
                                {

                                    Console.WriteLine("\nDu gissade för högt!" +
                                        $"Detta är ditt {userGuessCount} försök");
                                    userGuessCount++;           // Increasing the attempt counter

                                }

                                else
                                {
                                    Console.WriteLine("\nNågot blev fel, testa igen" +
                                        "\nTesta igen");

                                }


                            }
                            else
                            {

                                Console.WriteLine("Fel på hm");

                            }
                        }
                        break;
                    // Close the programm
                    case "3":

                        Console.WriteLine("Tack och hej leverpastej");
                        gameOn = false;     // Turns of Main game Loop
                        break;
                    // invalid menu choices
                    default:

                        Console.WriteLine("Något blev fel, testa igen eller välj en siffra");
                        Console.ReadLine();
                        break;        
                        

                }
            }

        }

        // Method to generate a random number for Easy mode(1-20)
        public static int CheckGuess(int randNumb) // EASY
        {
            Random random = new Random();
            randNumb = random.Next(1, 21);  // Generate random number between 1 and 20
            return randNumb;

        }

        // Method to generate a random number for Hard mode (1-50)
        public static int CheckGuessHard(int randNumbHard)  // HardMode
        {

            Random random = new Random();
            randNumbHard = random.Next(1, 51); // Generate random number between 1 and 50
            return randNumbHard;

        }

    }
}

    

