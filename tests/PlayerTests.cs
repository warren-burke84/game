using Xunit;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using game;

namespace game.Tests
{
    public class PlayerTests
    {
        private Player _player;
        private GraphicsDevice _graphicsDevice;

        public PlayerTests()
        {
            var graphicsDeviceManager = new GraphicsDeviceManager(new Game());
            _graphicsDevice = graphicsDeviceManager.GraphicsDevice;
            _player = new Player(null, Vector2.Zero, _graphicsDevice);
        }

        [Fact]
        public void HandleInput_ShouldMovePlayerLeft()
        {
            var initialPosition = _player.Position;
            KeyboardState keyboardState = new KeyboardState(Keys.Left);
            _player.HandleInput(keyboardState);
            Assert.True(_player.Position.X < initialPosition.X);
        }

        [Fact]
        public void HandleInput_ShouldMovePlayerRight()
        {
            var initialPosition = _player.Position;
            KeyboardState keyboardState = new KeyboardState(Keys.Right);
            _player.HandleInput(keyboardState);
            Assert.True(_player.Position.X > initialPosition.X);
        }

        [Fact]
        public void HandleInput_ShouldMovePlayerUp()
        {
            var initialPosition = _player.Position;
            KeyboardState keyboardState = new KeyboardState(Keys.Up);
            _player.HandleInput(keyboardState);
            Assert.True(_player.Position.Y < initialPosition.Y);
        }

        [Fact]
        public void HandleInput_ShouldMovePlayerDown()
        {
            var initialPosition = _player.Position;
            KeyboardState keyboardState = new KeyboardState(Keys.Down);
            _player.HandleInput(keyboardState);
            Assert.True(_player.Position.Y > initialPosition.Y);
        }

        [Fact]
        public void Draw_ShouldNotThrowException()
        {
            var spriteBatch = new SpriteBatch(_graphicsDevice);
            _player.Draw(spriteBatch);
        }
    }
}
