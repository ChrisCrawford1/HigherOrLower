using System;
namespace HigherOrLower
{
    public class Scoreboard
    {
        private int Score { get; set; }
        private int Streak { get; set; }

        public Scoreboard()
        {
            this.Score = 0;
            this.Streak = 0;
        }

        public void IncrementScore()
        {
            this.Score++;
            this.Streak++;
        }

        public void DecrementScore()
        {
            this.Score--;
            this.Streak = 0;
        }

        public void ResetSteak()
        {
            this.Streak = 0;
        }

        public string GetScoreAndStreak()
        {
            return $"You scored {this.Score} with a streak of {this.Streak}";
        }
    }
}
