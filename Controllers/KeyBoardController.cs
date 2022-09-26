using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Sprint_0
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> controllerMappings;
        Game1 myGame;

        public KeyboardController(Game1 game)
        {
            myGame = game;
            controllerMappings = new Dictionary<Keys, ICommand>();
            RegisterCommand();
        }

        public void RegisterCommand()
        {
            //different keys for different command
            controllerMappings.Add(Keys.D0, new MarioQuitCommand(myGame));
            controllerMappings.Add(Keys.D1, new MarioStandStillCommand(myGame));
            controllerMappings.Add(Keys.D2, new MarioRunningInPlaceCommand(myGame));
            controllerMappings.Add(Keys.D3, new MarioKillCommand(myGame));
            controllerMappings.Add(Keys.D4, new MarioRunningLeftCommand(myGame));
        }

        public void Update()
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();

            foreach (Keys key in pressedKeys)
            {
                if (controllerMappings.ContainsKey(key))
                {
                    controllerMappings[key].Execute();
                }
            }
        }
    }
}
