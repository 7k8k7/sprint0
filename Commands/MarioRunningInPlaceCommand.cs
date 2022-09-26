namespace Sprint_0
{
    public class MarioRunningInPlaceCommand : ICommand
    {
        private Game1 myGame;

        public MarioRunningInPlaceCommand(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            //update mario sprite
            myGame.marioSprite = new RunningInPlaceMario(myGame.Content);
        }
    }
}
