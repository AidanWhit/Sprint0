using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0Copy.Sprites
{
    public class StandingStillSprite : ISprite
    {
        private int XPos;
        private int YPos;
        private Texture2D texture;
        private int Width;
        private int Height;
        public StandingStillSprite(Texture2D texture, Vector2 offset, int width, int height)
        {
            this.texture = texture;
            Width = width;
            Height = height;

            XPos = (int)offset.X;
            YPos = (int)offset.Y;
        }
        public void Update(GameTime gameTime)
        {

        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle SourceRect = new Rectangle(XPos, YPos, Width, Height);
            Rectangle DestRect = new Rectangle((int)location.X, (int)location.Y, 4 * Width, 4 * Height);

            spriteBatch.Draw(texture, DestRect, SourceRect, Color.White);
        }
        
    }
}
