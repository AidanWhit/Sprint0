using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0Copy.Sprites
{
    public class WalkingInPlaceSprite : ISprite
    {
        private int FirstFrameOffset;
        private int LastFrameOffset;
        private int Frames;
        private int currentFrame = 0;

        private Texture2D texture;
        private int Width, Height;
        public WalkingInPlaceSprite(Texture2D texture, int firstFrameOffset, int lastFramePosOffset, int columns, int width, int height)
        {
            this.texture = texture;
            FirstFrameOffset = firstFrameOffset;
            LastFrameOffset = lastFramePosOffset;
            Frames = columns;
            Width = width;
            Height = height;
        }

        public void Update(GameTime gameTime)
        {
            //Allows for smooth animation
            double timePerFrame = 0.2;
            currentFrame = (int)(gameTime.TotalGameTime.TotalSeconds / timePerFrame);
            currentFrame = currentFrame % Frames;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int distBetweenFrames = (LastFrameOffset - FirstFrameOffset) / Frames;

            Rectangle SourceRect = new Rectangle(FirstFrameOffset + (currentFrame * distBetweenFrames), 0, Width, Height);
            Rectangle DestRect = new Rectangle((int)location.X, (int)location.Y, Width * 4, Height * 4);

            spriteBatch.Draw(texture, DestRect, SourceRect, Color.White);
        }
    }
}
