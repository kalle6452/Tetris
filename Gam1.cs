using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Tetris
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        public KeyboardState keyboardState;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D Bakgrund;
        private Texture2D ram;
        private SpriteFont font;
        private int Score = 0;
        public int windowWidth = 1280, windowHeight = 720;
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
            graphics.PreferredBackBufferWidth = windowWidth;
            graphics.PreferredBackBufferHeight = windowHeight;
            graphics.IsFullScreen = false;
            graphics.ApplyChanges();
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

            // TODO: use this.Content to load your game content here
            Bakgrund = Content.Load<Texture2D>("bakgrund");
            ram = Content.Load<Texture2D>("ram");
            font = Content.Load<SpriteFont>("Score");
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

            keyboardState = Keyboard.GetState;  // get the newest state
          
            // handle the input
            if (keyboardState.IsKeyDown(Keys.Enter));
            {
                // do something here
                // this will only be called when the key if first pressed
            }

            //oldState = newState;  // set the new state as the old state for next time


          //  Keys[] pressedKeys = state.GetPressedKeys();



            // TODO: Add your update logic here
            Score++;
            base.Update(gameTime);
           
    }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
           // GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            spriteBatch.Draw(Bakgrund, new Rectangle(0, 0, 1280, 720), Color.Black);
            
            spriteBatch.Draw(ram, new Rectangle(490, 107, 320, 500), Color.Turquoise);
            spriteBatch.End();
            spriteBatch.Begin();

            spriteBatch.DrawString(font, "Score: " + Score, new Vector2(100, 100), Color.Black);
            
        spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
