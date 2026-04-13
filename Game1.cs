using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame_Lesson_2___Scaling_Using_Rectangles_and_Text
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D circleTexture, rectangleTexture;
        Rectangle circle1;
        Rectangle rect1;
        Rectangle topRect;
        Rectangle Window;
        Rectangle halfRect, centerRect, bottomRect;
        SpriteFont textFont;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Window = new Rectangle(0,0,800,600);
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            rect1 = new Rectangle(50, 50, 200, 200);
            circle1 = new Rectangle(50, 50, 200, 200);
            topRect = new Rectangle(0,0, Window.Width/2, 50);
            halfRect = new Rectangle(0, 0, Window.Width, 15);
            centerRect = new Rectangle(Window.Width/2 - 25, Window.Height / 2 - 25, 50, 50);
            bottomRect = new Rectangle(0, Window.Height - 20, Window.Width, 20);
            _graphics.ApplyChanges();
           
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");

            textFont = Content.Load<SpriteFont>("TextFont");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(rectangleTexture,rect1,Color.Pink);
            _spriteBatch.Draw(circleTexture, circle1 , Color.Blue);
            _spriteBatch.Draw(rectangleTexture, topRect, Color.Yellow);
            _spriteBatch.Draw(rectangleTexture, halfRect, Color.Green);
            _spriteBatch.Draw(rectangleTexture,centerRect, Color.Red);
            _spriteBatch.Draw(rectangleTexture, bottomRect, Color.Orange);
            _spriteBatch.DrawString(textFont, "You Rule", new Vector2(80,280),Color.Black);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
