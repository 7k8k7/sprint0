namespace Sprint_0
{
    class MarioRunningLeftCommand : ICommand
    {
        private Game1 myGame;

        public MarioRunningLeftCommand(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            //update mario sprite
            myGame.marioSprite = new RunningLeftMario(myGame.Content);
        }
    }
}
