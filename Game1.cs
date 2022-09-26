using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections;
using System.Runtime.CompilerServices;

//author Xiaoxiao Shi
//reference: https://github.com/bpershon/Game_Sprint_0
namespace Sprint_0
{
    public class Game1 : Game
    {
        //create graphics device manager, spritebatch, two sprite and one list of command
        public GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public ISprite marioSprite;
        private ISprite textSprite;
        ArrayList controllerList;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            //fill the dictionary with commands
            controllerList = new ArrayList();
            controllerList.Add(new KeyboardController(this));
            controllerList.Add(new MouseController(this));
            base.Initialize();
            
        }

        protected override void LoadContent()
        {
            //load contents
            spriteBatch = new SpriteBatch(GraphicsDevice);
            textSprite = new Text(this.Content);
            marioSprite = new StandingInPlaceMario(this.Content);

        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            // update the commands
            foreach (IController controller in controllerList)
            {
                controller.Update();
            }
            marioSprite.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            //draw things again and again to create game
            textSprite.Draw(spriteBatch);
            marioSprite.Draw(spriteBatch);
            base.Draw(gameTime);
        }
    }
}