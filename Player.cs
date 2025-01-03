using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace game
{
    public class Player
    {
        private Texture2D _texture;
        private Vector2 _position;
        private GraphicsDevice _graphicsDevice;

        public Player(Texture2D texture, Vector2 initialPosition, GraphicsDevice graphicsDevice)
        {
            _texture = texture;
            _position = initialPosition;
            _graphicsDevice = graphicsDevice;
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

            ClampPosition();
        }

        private void ClampPosition()
        {
            _position.X = MathHelper.Clamp(_position.X, 0, _graphicsDevice.Viewport.Width - _texture.Width);
            _position.Y = MathHelper.Clamp(_position.Y, 0, _graphicsDevice.Viewport.Height - _texture.Height);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, Color.White);
        }
    }
}
