using GameLib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace AVRGame
{
    public class Game : GameLib.AVRGame
    {


        private readonly GraphicsDeviceManager _graphics;
        //private SpriteBatch _spriteBatch;
        private GameManager _gameManager;
        // private background _backgroundclass;
        private Texture2D _backGround;


        RasterizerState rasterizerState = new RasterizerState() { MultiSampleAntiAlias = true };
        public Game()
        {
            this.ScreenWidth = 1000;
            this.ScreenHeight = 800;
            Global.Content = this.Content;
            Global.SpriteBatch = this.spriteBatch;
            
        }

        /// <summary>
        /// Initilizes the game.
        /// Create all your non-graphic content here
        /// </summary>
        protected override void __Initialize()
        {
            
        }

        /// <summary>
        /// Here you can load all the content you need.
        /// Example: Load textures, sounds or texture effects
        /// </summary>
        protected override void __LoadContent()
        {
           _gameManager = new GameManager();
            _backGround = Global.Content.Load<Texture2D>("Background");


        }

        /// <summary>
        /// Sometimes you need to unload content.
        /// This is called once if you exit the game
        /// </summary>
        protected override void __UnloadContent()
        {
          
        }

        /// <summary>
        /// Here you place your update logic.
        /// </summary>
        /// <param name="gameTime"></param>
        protected override void __Update(GameTime gameTime)
        {
            _gameManager.Update();

        }

        /// <summary>
        /// Here you place your draw logic. This drawing is in the world space.
        /// The camera follows an object.
        /// </summary>
        /// <param name="spriteBatch"></param>
        /// <param name="gameTime"></param>
        protected override void __DrawGame(SpriteBatch spriteBatch, GameTime gameTime)
        {
            Global.SpriteBatch = spriteBatch;
            //Refresh your frame, should not be deleted. Color can be changed.
            GraphicsDevice.Clear(Color.CornflowerBlue);

            //Begin your spritebatch.
            spriteBatch.Begin(rasterizerState: this.rasterizerState, transformMatrix: Camera.TransformMatrix);


            spriteBatch.Draw(_backGround, new Vector2(-500,-400), null, Color.White, 0,  new Vector2(0,0), 2, SpriteEffects.None, 1);
        
            _gameManager.Draw();

            //_backgroundclass.Draw();

            //Place your world drawing logic here.

            //End the spritebatch
            spriteBatch.End();
        }

        /// <summary>
        /// This function is for drawing on the UI elements
        /// </summary>
        /// <param name="spriteBatch"></param>
        /// <param name="gameTime"></param>
        protected override void __DrawUI(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin(rasterizerState: this.rasterizerState);

            //Place your non-camera related drawing logic here, for example the UI

            spriteBatch.End();
        }
    }
}