using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0Copy.Sprites
{
    public interface ISprite
    {
        void Draw(SpriteBatch spriteBatch, Vector2 location);
        void Update(GameTime gameTime);
    }
}
