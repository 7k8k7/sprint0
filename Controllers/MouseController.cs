using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace Sprint_0
{
    public class MouseController : IController
    {
        private GraphicsDeviceManager _graphics;
        private Dictionary<int, ICommand> controllerMappings;
        Game1 myGame;
        MouseState currentMouseState;

        public MouseController(Game1 game)
        {
            
            myGame = game;
            _graphics = game.graphics;
            controllerMappings = new Dictionary<int, ICommand>();
            currentMouseState = new MouseState();
            RegisterCommand();
        }

        public void RegisterCommand()
        {
            controllerMappings.Add(0, new MarioQuitCommand(myGame));
            controllerMappings.Add(1, new MarioStandStillCommand(myGame));
            controllerMappings.Add(2, new MarioRunningInPlaceCommand(myGame));
            controllerMappings.Add(3, new MarioKillCommand(myGame));
            controllerMappings.Add(4, new MarioRunningLeftCommand(myGame));

        }

        public void Update()
        {
           
            currentMouseState = Mouse.GetState();
            if (currentMouseState.RightButton.Equals(ButtonState.Pressed))
            {
                //if mouse right clicked 
                controllerMappings[0].Execute();
            }
                if (currentMouseState.LeftButton.Equals(ButtonState.Pressed))
            {
                if (currentMouseState.Position.Y < _graphics.PreferredBackBufferWidth / 2) {
                    if(currentMouseState.Position.X < _graphics.PreferredBackBufferHeight / 2)
                    {
                        //if mouse left clicked in left up corner
                        controllerMappings[1].Execute();
                    }
                    else
                    {
                        //if mouse left clicked in right up corner
                        controllerMappings[2].Execute();
                    }
                }else{
                    if (currentMouseState.Position.X < _graphics.PreferredBackBufferHeight / 2)
                    {
                        //if mouse left clicked in left down corner
                        controllerMappings[3].Execute();
                    }
                    else
                    {
                        //if mouse left clicked in right down corner
                        controllerMappings[4].Execute();
                    }
                }
            
            }
            }
    }
}

