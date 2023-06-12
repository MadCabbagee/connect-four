namespace GameLogic
{
    public class AIReferee : Referee
    {
        private AIController aiController;
        private int currentPlayer = 1;

        public AIReferee(AIController aiController)
        {
            this.aiController = aiController;
        }

        public override void PlayMove(int column)
        {
            // Perform game logic for playing against AI
            // ...
            // Update the game board based on the move
            // ...
            // Switch the player
            currentPlayer = (currentPlayer == 1) ? 2 : 1;

            // Let the AI controller make its move
            aiController.MakeMove();
        }
    }
}