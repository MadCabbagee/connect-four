namespace GameLogic
{
    public abstract class Referee
    {
        protected GameBoard gameBoard;

        public void StartGame()
        {
            // Initialize the game board
            gameBoard = new GameBoard();
            // ...
        }

        public abstract void PlayMove(int column);
    }
}