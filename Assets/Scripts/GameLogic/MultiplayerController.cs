using UnityEngine;

namespace GameLogic
{
    public class MultiplayerController : MonoBehaviour
    {
        protected Referee referee;

        public void Initialize(Referee referee)
        {
            this.referee = referee;
        }

        public void OnOpponentMoveReceived(int column)
        {
            referee.PlayMove(column);
        }
    }
}