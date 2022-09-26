using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Sprint_0
{
    public class DeadMarioMovingUpAndDown : ISprite
    {
        Texture2D texture;
        int spriteSheetImageWidth;
        int spriteSheetImageHeight;
        int drawPosX = 400;
        int drawPosY = 358;
        int originX = 0;
        int originY = 0;
        int spriteDrawScale = 2;
        bool reachedMaxYCoord = false;
        int maxYCoord = 200;
        int currentYCoord;

        public DeadMarioMovingUpAndDown(ContentManager content)
        {
            this.texture = content.Load<Texture2D>("mario_dead");
            spriteSheetImageWidth = texture.Width; 
            spriteSheetImageHeight = texture.Height;
            currentYCoord = drawPosY;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //draw mario
            Rectangle sourceRectangle = new Rectangle(originX, originY, spriteSheetImageWidth, spriteSheetImageHeight);
            Rectangle destinationRectangle = new Rectangle(drawPosX, currentYCoord, spriteSheetImageWidth * spriteDrawScale, spriteSheetImageHeight * spriteDrawScale);
            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void Update()
        {
            //make it up and down
            if (currentYCoord == maxYCoord)
            {
                reachedMaxYCoord = true;
            }
            else if (currentYCoord == drawPosY)
            {
                reachedMaxYCoord = false;
            }

            if (reachedMaxYCoord)
            {
                currentYCoord++;
            }
            else
            {
                currentYCoord--;
            }
        }
    }
}
