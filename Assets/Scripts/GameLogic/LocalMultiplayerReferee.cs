namespace GameLogic
{
    public class LocalMultiplayerReferee : Referee
    {
        private int currentPlayer = 1;

        public override void PlayMove(int column)
        {
            // Perform game logic for local multiplayer mode
            // ...
            // Update the game board based on the move
            // ...
            // Switch the player
            currentPlayer = (currentPlayer == 1) ? 2 : 1;
        }
    }
}