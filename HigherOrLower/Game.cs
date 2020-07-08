using System;
using System.Collections.Generic;

namespace HigherOrLower
{
    public class Game
    {
        private readonly Stack<int> Numbers;
        private Scoreboard Scoreboard;
        private int PreviousNumber;
        private int CurrentNumber;

        /**
         * When the game is initialised we will pop
         * the first number from the stack to 
         * get the flow started properly.
         */
        public Game(Stack<int> numbers)
        {
            this.Numbers = numbers;
            this.PreviousNumber = this.Numbers.Pop();
            this.CurrentNumber = 0;
            this.Scoreboard = new Scoreboard();
        }

        public void Run()
        {
            while (this.Numbers.Count > 0)
            {
                this.CurrentNumber = this.Numbers.Pop();
                Console.WriteLine($"Will {this.PreviousNumber} be higher or lower than the next number?");

                try
                {
                    bool GuessResult = this.ProcessGuess();

                    if (GuessResult)
                    {
                        this.Scoreboard.IncrementScore();
                    }

                    if (!GuessResult)
                    {
                        this.Scoreboard.DecrementScore();
                    }

                    Console.WriteLine(this.DisplayResult(GuessResult));
                    this.PreviousNumber = this.CurrentNumber;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(this.Scoreboard.GetScoreAndStreak());
        }

        private bool ProcessGuess()
        {
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "higher":
                    return this.CurrentNumber > this.PreviousNumber;
                case "lower":
                    return this.CurrentNumber < this.PreviousNumber;
                default:
                    throw new ArgumentOutOfRangeException("You can only select higher or lower as an option");
            }
        }

        private string DisplayResult(bool GuessResult)
        {
            string ResultAdjective = GuessResult ? "Correct" : "Incorrect";
            return $"{ResultAdjective}!, The number was {this.CurrentNumber}";
        }
    }
}