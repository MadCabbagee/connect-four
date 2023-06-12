using UnityEngine;

namespace GameLogic
{
    public class AIController : MonoBehaviour
    {
        protected Referee referee;

        public void Initialize(Referee referee)
        {
            this.referee = referee;
        }

        public void MakeMove()
        {
            // Calculate the next move for the AI
            int column = CalculateNextMove();
            referee.PlayMove(column);
        }

        private int CalculateNextMove()
        {
            // Perform AI logic to determine the next move
            // ...
            return 0;
        }
    }
}