using System;
using GuessingGameRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuessingGameTests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void TestMethod1()
        {

            GameRepository gameRepository = new GameRepository();
            Animal animal = gameRepository.GetRandomAnimal();

            Console.WriteLine($"Your animal is {animal}");


            
        }
    }
}
