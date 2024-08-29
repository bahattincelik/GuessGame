using System;

namespace GuessingGame.Data
{

    public class GameService
    {
        private int _targetNumber;
        private int _attempts;

        public void StartNewGame()
        {
            _targetNumber = new Random().Next(1, 101);
            _attempts = 0;

        }

        public string MakeGuess(int guess)
        {
            _attempts++;
            if (guess < _targetNumber)
            {
                return "Too Low";
            }
            else if (guess > _targetNumber)
            {
                return "Too High";
            }
            else { return $"Correct!!! You guessed it in {_attempts} _attempts"; }
        }

        public int GetAttempts() => _attempts;
    }
}
