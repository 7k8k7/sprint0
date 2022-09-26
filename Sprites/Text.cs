using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Sprint_0
{
    class Text : ISprite
    {

        Texture2D texture;
        int spriteSheetImageWidth;
        int spriteSheetImageHeight;
        int originX = 0;
        int originY = 0;
        public SpriteFont font;
        public Text(ContentManager content)
        {
            font = content.Load<SpriteFont>("myfont");
            texture = content.Load<Texture2D>("blue");
            spriteSheetImageWidth = texture.Width;
            spriteSheetImageHeight = texture.Height;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(originX, originY, spriteSheetImageWidth, spriteSheetImageHeight);
            Rectangle destinationRectangle = new Rectangle(originX, originY, spriteSheetImageWidth, spriteSheetImageHeight);
            //draw background and text
            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.DrawString(this.font, "Credits\nProgram made by Xiaoxiao Shi\nSprites and reference From https://github.com/bpershon/Game_Sprint_0", new Vector2(200, 400), Color.Black);
            spriteBatch.End();
        }

        public void Update()
        {
        }

    }
}
