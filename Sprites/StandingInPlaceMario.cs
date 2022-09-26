using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Sprint_0
{
    public class StandingInPlaceMario : ISprite
    {

        Texture2D texture;
        int spriteSheetImageWidth;
        int spriteSHeetImageHeight;
        int drawPosX = 400;
        int drawPosY = 358;
        int originX = 0;
        int originY = 0;
        int spriteDrawScale = 2;

        public StandingInPlaceMario(ContentManager content)
        {
            this.texture = content.Load<Texture2D>("mario_standing");
            spriteSheetImageWidth = texture.Width;
            spriteSHeetImageHeight = texture.Height;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(originX, originY, spriteSheetImageWidth, spriteSHeetImageHeight);
            Rectangle destinationRectangle = new Rectangle(drawPosX, drawPosY, spriteSheetImageWidth * spriteDrawScale, spriteSHeetImageHeight * spriteDrawScale);
            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void Update()
        {
        }
    }
}
