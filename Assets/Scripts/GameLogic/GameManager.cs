using UnityEngine;

namespace GameLogic
{
    public class GameManager : MonoBehaviour
    {
        public VisualBoard visualBoard;
        public PlayerController playerController;
        public AIController aiController;
        public MultiplayerController multiplayerController;

        private Referee referee;

        private void Start()
        {
            // Initialize the desired game mode
            referee = new LocalMultiplayerReferee();
            // Or, for AI mode: referee = new AIReferee(aiController);
            // ...

            // Initialize components
            visualBoard.Initialize(referee);
            playerController.Initialize(referee);
            aiController.Initialize(referee);
            multiplayerController.Initialize(referee);

            // Start the game
            referee.StartGame();
        }

        public void OnPlayerInput(int column)
        {
            // Pass player input to the player controller
            playerController.OnPlayerInput(column);
        }

        public void OnOpponentMoveReceived(int column)
        {
            // Pass opponent move to the multiplayer controller
            multiplayerController.OnOpponentMoveReceived(column);
        }
    }
}