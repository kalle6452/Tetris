//Potentiell guide för Tetris
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template//Den här ska vara Tetris hemma och Template i skolan.
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Vector2 buttonPos;
        Texture2D button;
       // public Texture2D crono;
     // Texture2D rect = new Texture2D(graphics.GraphicsDevice, 80, 30);
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            buttonPos = new Vector2(30, 30);
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            button = Content.Load<Texture2D>("button_temp");
            // TODO: use this.Content to load your game content here
            // crono = Content.Load<Texture2D>("crono");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
           /* spriteBatch.Begin();
            GraphicsDevice.Clear(Color.CornflowerBlue);*/
            spriteBatch.Begin();
            // draw our button
            int buttonWidth = 214;
            int buttonHeight = 101;
            spriteBatch.Draw(button, new Rectangle(buttonPos.X, buttonPos.Y, buttonWidth, buttonHeight), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
            // spriteBatch.Draw(crono, new Rectangle(0, 0, 300, 480), Color.White);

         /*   spriteBatch.End();
            base.Draw(gameTime);*/
        }
    }
}
