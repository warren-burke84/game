using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace game;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    private Vector2 _circlePosition;
    private Vector2 _circleVelocity;
    private float _circleRadius;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        _circlePosition = new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2);
        _circleVelocity = new Vector2(150f, 150f);
        _circleRadius = 20f;

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        _circlePosition += _circleVelocity * (float)gameTime.ElapsedGameTime.TotalSeconds;

        if (_circlePosition.X - _circleRadius < 0 || _circlePosition.X + _circleRadius > GraphicsDevice.Viewport.Width)
        {
            _circleVelocity.X *= -1;
        }

        if (_circlePosition.Y - _circleRadius < 0 || _circlePosition.Y + _circleRadius > GraphicsDevice.Viewport.Height)
        {
            _circleVelocity.Y *= -1;
        }

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();
        _spriteBatch.DrawCircle(_circlePosition, _circleRadius, 100, Color.Red, _circleRadius);
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
