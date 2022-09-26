namespace Sprint_0
{
    class MarioStandStillCommand : ICommand
    {
        private Game1 myGame;

        public MarioStandStillCommand(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            //update mario sprite
            myGame.marioSprite = new StandingInPlaceMario(myGame.Content);
        }
    }
}
