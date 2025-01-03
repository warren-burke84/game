using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace game;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    private Texture2D _ballTexture;
    private Vector2 _ballPosition;
    private Vector2 _ballVelocity;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        _ballPosition = new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2);
        _ballVelocity = new Vector2(150, 150);

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        _ballTexture = Content.Load<Texture2D>("ball");
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        _ballPosition += _ballVelocity * (float)gameTime.ElapsedGameTime.TotalSeconds;

        if (_ballPosition.X < 0 || _ballPosition.X + _ballTexture.Width > GraphicsDevice.Viewport.Width)
        {
            _ballVelocity.X *= -1;
        }

        if (_ballPosition.Y < 0 || _ballPosition.Y + _ballTexture.Height > GraphicsDevice.Viewport.Height)
        {
            _ballVelocity.Y *= -1;
        }

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();
        _spriteBatch.Draw(_ballTexture, _ballPosition, Color.White);
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
