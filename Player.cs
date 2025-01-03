using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace game
{
    public class Player
    {
        private Texture2D _texture;
        private Vector2 _position;

        public Player(Texture2D texture, Vector2 initialPosition)
        {
            _texture = texture;
            _position = initialPosition;
        }

        public void HandleInput(KeyboardState keyboardState)
        {
            if (keyboardState.IsKeyDown(Keys.Left))
            {
                _position.X -= 5f;
            }
            if (keyboardState.IsKeyDown(Keys.Right))
            {
                _position.X += 5f;
            }
            if (keyboardState.IsKeyDown(Keys.Up))
            {
                _position.Y -= 5f;
            }
            if (keyboardState.IsKeyDown(Keys.Down))
            {
                _position.Y += 5f;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, Color.White);
        }
    }
}
