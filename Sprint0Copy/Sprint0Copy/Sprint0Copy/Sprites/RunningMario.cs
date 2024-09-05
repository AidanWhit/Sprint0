using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0Copy.Sprites
{
    public class RunningMario : ISprite
    {
        private int FirstFrameOffset;
        private int LastFrameOffset;
        private int Frames;
        private int marioXPos;
        private int currentFrame;

        private Texture2D texture;
        private int Width, Height;
        public RunningMario(Texture2D texture, int firstFrameOffset, int lastFramePosOffset, int columns, int width, int height)
        {
            this.texture = texture;
            FirstFrameOffset = firstFrameOffset;
            LastFrameOffset = lastFramePosOffset;
            Frames = columns;
            Width = width;
            Height = height;
            marioXPos = firstFrameOffset;
        }

        public void Update(GameTime gameTime)
        {
            //Creates a smooth animation
            double timePerFrame = 0.2;
            currentFrame = (int)(gameTime.TotalGameTime.TotalSeconds / timePerFrame);
            currentFrame = currentFrame % Frames;

            marioXPos += 3;
            if (marioXPos >= 800)
            {
                //Reset Mario to the left side of the screen
                marioXPos = 0 - Width;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int distBetweenFrames = (LastFrameOffset - FirstFrameOffset) / Frames;
            Rectangle SourceRect = new Rectangle(FirstFrameOffset + (currentFrame * distBetweenFrames), 0, Width, Height);
            Rectangle DestRect = new Rectangle(marioXPos, (int)location.Y, Width * 4, Height * 4);

            spriteBatch.Draw(texture, DestRect, SourceRect, Color.White);

        }
    }
}
