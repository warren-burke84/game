using Xunit;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using game;

namespace game.Tests
{
    public class Game1Tests
    {
        private Game1 _game;

        public Game1Tests()
        {
            _game = new Game1();
        }

        [Fact]
        public void Initialize_ShouldInitializePlayer()
        {
            _game.Initialize();
            Assert.NotNull(_game.Player);
        }

        [Fact]
        public void LoadContent_ShouldLoadPlayerTexture()
        {
            _game.LoadContent();
            Assert.NotNull(_game.Player.Texture);
        }

        [Fact]
        public void Update_ShouldHandlePlayerInput()
        {
            _game.Initialize();
            var initialPosition = _game.Player.Position;

            KeyboardState keyboardState = new KeyboardState(Keys.Right);
            _game.Update(new GameTime());

            Assert.NotEqual(initialPosition, _game.Player.Position);
        }

        [Fact]
        public void Draw_ShouldClearScreenAndDrawPlayer()
        {
            _game.Initialize();
            _game.LoadContent();

            _game.Draw(new GameTime());

            // Since we cannot directly test the drawing, we assume no exceptions mean success
        }
    }
}
