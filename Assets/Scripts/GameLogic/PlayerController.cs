namespace GameLogic
{
    public class PlayerController
    {
        protected Referee referee;

        public void Initialize(Referee referee)
        {
            this.referee = referee;
        }

        public void OnPlayerInput(int column)
        {
            referee.PlayMove(column);
        }
    }
}