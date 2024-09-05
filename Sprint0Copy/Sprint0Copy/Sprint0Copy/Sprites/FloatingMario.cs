using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Diagnostics;

namespace Sprint0Copy.Sprites
{
    public class FloatingMario : ISprite
    {
        private int XPos;
        private int YPos;
        private int marioHeight;
        private int velocity = 1;
        private Texture2D texture;
        private int width;
        private int height;
        public FloatingMario(Texture2D texture, Vector2 spriteLocation, int width, int height, int startingLocation)
        {
            this.texture = texture;
            XPos = (int)spriteLocation.X;
            YPos = (int)(spriteLocation.Y);
            this.width = width;
            this.height = height;

            marioHeight = startingLocation;

        }

        public void Update(GameTime gameTime)
        {
            marioHeight += velocity;
            if (marioHeight >= 250 || marioHeight <= 150)
            {
                velocity *= -1;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle SourceRect = new Rectangle(XPos, YPos, width, height);
            Rectangle DestRect = new Rectangle((int)location.X, marioHeight, width * 4, height * 4);

            spriteBatch.Draw(texture, DestRect, SourceRect, Color.White);
        }
    }
}
