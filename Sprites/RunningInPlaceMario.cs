using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Sprint_0
{
    public class RunningInPlaceMario : ISprite
    {
        Texture2D texture;
        int spriteSheetImageWidth;
        int spriteSheetImageHeight;
        int drawPosX = 400;
        int drawPosY = 358;
        int origin = 0;
        int spriteDrawScale = 2;
        int totalSpriteFrames = 2;
        int currentSpriteFrame;
        int updateSpriteAnimation;
        int updateSpriteAnimationThreshold = 3;

        public RunningInPlaceMario(ContentManager content)
        {
            this.texture = content.Load<Texture2D>("mario_running_inplace");
            spriteSheetImageWidth = texture.Width / totalSpriteFrames;
            spriteSheetImageHeight = texture.Height;
            currentSpriteFrame = 0;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            int column = currentSpriteFrame % totalSpriteFrames;
            Rectangle sourceRectangle = new Rectangle(spriteSheetImageWidth * column, origin, spriteSheetImageWidth, spriteSheetImageHeight);
            Rectangle destinationRectangle = new Rectangle(drawPosX, drawPosY, spriteSheetImageWidth * spriteDrawScale, spriteSheetImageHeight * spriteDrawScale);
            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public void Update()
        {
            //animate mario
            updateSpriteAnimation++;
            if (updateSpriteAnimation == updateSpriteAnimationThreshold)
            {
                updateSpriteAnimation = 0;
                currentSpriteFrame++;
                if (currentSpriteFrame == totalSpriteFrames)
                    currentSpriteFrame = 0;
            }

        }
    }
}


