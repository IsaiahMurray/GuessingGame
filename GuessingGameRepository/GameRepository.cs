using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GuessingGameRepository
{
    public class GameRepository
    {
        List<Animal> _animals = new List<Animal>();
        public Animal AddAnimals()
        {
            Animal bear = new Animal("Jungle", "fur", "runs", "can climb a tree", "Bear");
            _animals.Add(bear);
            Animal lion = new Animal("Jungle", "fur", "runs", "is king of the jungle", "Lion");
            _animals.Add(lion);
            Animal giraffe = new Animal("Sahara", "fur", "runs", "has a long neck", "Giraffe");
            _animals.Add(giraffe);
            Animal turtle = new Animal("Ocean", "shell", "swims and runs", "can live for hundreds of years", "Turtle");
            _animals.Add(turtle);
            Animal rat = new Animal("Sewers", "fur", "runs", "is a chef", "Rat");
            _animals.Add(rat);
            Animal lizard = new Animal("Jungle", "scales", "runs", "can grow a new tail", "Lizard");
            _animals.Add(lizard);
            Animal snake = new Animal("Jungle", "scales", "slithers", "doesn't have any arms or legs", "Snake");
            _animals.Add(snake);
            Animal whale = new Animal("Ocean", "skin", "swims", "Baluga, Man-eating, Killer", "Whale");
            _animals.Add(whale);
            Animal dragon = new Animal("Mountain", "scales", "flys", "Known to breathe fire and likes gold", "Dragon");
            _animals.Add(dragon);
            Animal satyr = new Animal("Forest", "fur and skin", "Runs", "Goat-man", "Satyr");
            _animals.Add(satyr);
            Animal panther = new Animal("Jungle", "fur", "Runs", "De strength of de black ___ will now be stripped eweh..", "Panther");
            _animals.Add(panther);
            Animal ogre = new Animal("Swamp", "skin", "Runs", "Get out of ma swamp", "Ogre");
            _animals.Add(ogre);
            Animal gorilla = new Animal("Jungle", "fur", "Walks", "Its a big primate", "Gorilla");
            _animals.Add(gorilla);
            Animal tiger = new Animal("Jungle", "fur", "Runs", "Is a predator with an unnecessary amount of advantages...", "Tiger");
            _animals.Add(tiger);
            Animal eagle = new Animal("Trees", "feathers", "Flys", "#Merica'", "Eagle");
            _animals.Add(eagle);
            Animal chicken = new Animal("Farms.. Because domestication", "feathers", "Walks/Flys", "General Tso, Orange, Kung Pao..", "Chicken");
            _animals.Add(chicken);
            Animal zebra = new Animal("Sahara", "fur", "Runs", "It's what and black", "Zebra");
            _animals.Add(zebra);
            Random random = new Random();
            int randomIndex = random.Next(0, 3);
            Animal animal = _animals[randomIndex];
            return animal;
        }
        /*public void PlayGame()
        {
            GameRepository gameRepository = new GameRepository();
            Animal animal = gameRepository.AddAnimals();
            Console.WriteLine("Guess an Animal: ");
            string userGuessCapital = Console.ReadLine();
            string userGuess = userGuessCapital.ToLower();
            int attemptCount = 0;
            int hintCount = 0;
            string animalNameCapital = animal.Name;
            string animalName = animalNameCapital.ToLower();
            string animalLocation = animal.Location;
            string animalSkinType = animal.SkinType;
            string animalTravelType = animal.TravelType;
            string animalHint = animal.Hint;
            List<string> _wrongGuess = new List<string>();
            do
            {
                if (animalName == userGuess)
                {
                    Console.WriteLine($"You're right! The animal is a {animalName}");
                    Console.WriteLine($"It took you {attemptCount} tries to guess it correctly.");
                    Console.WriteLine("Enter 1 to play again");
                    string playAgainInput = Console.ReadLine();
                    int playAgain = Int32.Parse(playAgainInput);
                    if (playAgain == 1)
                    {
                    }
                }
                else if (_wrongGuess.Contains(userGuess))
                {
                    Console.WriteLine("You already guessed this. Try again.");
                }
                else
                {
                    Console.WriteLine($"That is incorrect.  The animal is not a {userGuessCapital}.  Guess again.");
                    attemptCount += 1;
                    _wrongGuess.Add(userGuess);
                    if (attemptCount == 15)
                    {
                        Console.WriteLine($"Alright I can't take it anymore.  The animal is {animalNameCapital}.");
                    }
                    else if (attemptCount == 10)
                    {
                        Console.WriteLine($"This is getting hard to watch.  Here is some help.  This animal is {animalHint}.");
                    }
                    else
                    {
                        Console.WriteLine("Would you like a hint? Enter 1 for Yes or 2 for No");
                        string input = Console.ReadLine();
                        int answer = Int32.Parse(input);
                        if (answer == 1)
                        {
                            if (hintCount == 0)
                            {
                                Console.WriteLine($"This animal lives in the {animalLocation}");
                            }
                            else if (hintCount == 1)
                            {
                                Console.WriteLine($"This animal has {animalSkinType}");
                            }
                            else if (hintCount == 2)
                            {
                                Console.WriteLine($"This animal {animalTravelType}");
                            }
                            else
                            {
                                Console.WriteLine("Sorry you've gotten all your hints!");
                            }
                        }
                        else if (answer == 2)
                        {
                            Console.WriteLine("Good Luck!");
                        }
                        else
                        {
                            Console.WriteLine("That was not a 1 or a 2");
                        }
                    }
                }
            }
            while (animalName != userGuess);
        }*/
    }
}