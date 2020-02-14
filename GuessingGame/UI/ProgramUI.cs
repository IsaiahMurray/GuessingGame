using GuessingGameRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame.UI
{
    class ProgramUI
    {
        private readonly GameRepository _gameRepository = new GameRepository();
        public void Run()
        {
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Select an option number:\n" +
                    "1. Play Game\n" +
                    "2. Exit");
                string userInput = Console.ReadLine();
                userInput = userInput.Replace(" ", "");
                switch (userInput)
                {
                    case "1":
                        PlayGame();
                        break;
                    case "2":
                        continueToRun = false;
                        break;
                    default:
                        break;
                }
            }
        }
        public void PlayGame()
        {
            GameRepository gameRepository = new GameRepository();
            Animal animal = gameRepository.AddAnimals();
            string userGuessCapital;
            string userGuess;
            int attemptCount = 1;
            int hintCount = 0;
            string animalNameCapital = animal.Name;
            string animalName = animalNameCapital.ToLower();
            string animalLocation = animal.Location;
            string animalSkinType = animal.SkinType;
            string animalTravelType = animal.TravelType;
            string animalHint = animal.Hint;
            int noMoreHints = 0;
            List<string> _wrongGuess = new List<string>();
            do
            {
                // Console.WriteLine($"The animal is {animalNameCapital}.");
                Console.WriteLine("Guess an Animal: \n");
                userGuessCapital = Console.ReadLine();
                userGuess = userGuessCapital.ToLower();
                if (userGuess == animalName)
                {
                    Console.WriteLine($"You're right! The animal is a {animalNameCapital}");
                    Console.WriteLine($"It took you {attemptCount} tries to guess it correctly.\n");
                    Console.WriteLine("Press any key to continue");
                    string playAgain = Console.ReadLine();
                }
                else if (_wrongGuess.Contains(userGuess))
                {
                    Console.WriteLine("You already guessed this. Try again.\n");
                }
                else
                {
                    Console.WriteLine($"That is incorrect.  The animal is not a {userGuessCapital}.  Guess again.\n");
                    attemptCount += 1;
                    _wrongGuess.Add(userGuess);
                    if (attemptCount == 25)
                    {
                        Console.WriteLine($"Alright I can't take it anymore.  The animal is {animalNameCapital}.\n");
                    }
                    else if (attemptCount == 10)
                    {
                        Console.WriteLine($"This is getting hard to watch.  Here is some help.  This animal is {animalHint}.\n");
                    }
                    else if (hintCount >= 3 && noMoreHints == 0)
                    {
                        Console.WriteLine("Sorry you've gotten all your hints!\n");
                        noMoreHints += 1;
                    }
                    else
                    {
                        Console.WriteLine("Would you like a hint? Enter 1 for Yes or 2 for No\n");
                        string answer = Console.ReadLine();
                        switch (answer)
                        {
                            case "1":
                                if (hintCount == 0)
                                {
                                    Console.WriteLine($"This animal lives in the {animalLocation}\n");
                                    hintCount += 1;
                                }
                                else if (hintCount == 1)
                                {
                                    Console.WriteLine($"This animal has {animalSkinType}\n");
                                    hintCount += 1;
                                }
                                else if (hintCount == 2)
                                {
                                    Console.WriteLine($"This animal {animalTravelType}\n");
                                    hintCount += 1;
                                }
                                break;
                            case "2":
                                Console.WriteLine("Good Luck!\n");
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            while (userGuess != animalName);
        }
    }
}