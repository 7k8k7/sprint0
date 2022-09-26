namespace Sprint_0
{
    public class MarioQuitCommand : ICommand
    {
        private Game1 myGame;

        public MarioQuitCommand(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            //exit game
            myGame.Exit();
        }
    }
}
