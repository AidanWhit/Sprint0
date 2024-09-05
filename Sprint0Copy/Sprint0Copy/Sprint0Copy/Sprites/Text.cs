using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0Copy.Sprites
{
    internal class Text : ISprite
    {
        private SpriteFont font;
        public Text(SpriteFont font)
        {
            this.font = font;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {

            spriteBatch.DrawString(font, "Credits", new Vector2(location.X - 350, location.Y), Color.Black);
            spriteBatch.DrawString(font, "Program Made By: Aidan Whitlatch", new Vector2(location.X - 350, location.Y + 24), Color.Black);
            spriteBatch.DrawString(font, "Sprites from: https://www.mariouniverse.com/wp-content/img/sprites/nes/smb/mario.png", new Vector2(location.X - 350, location.Y + 48), Color.Black);

        }

        public void Update(GameTime gameTime)
        {

        }
    }
}
