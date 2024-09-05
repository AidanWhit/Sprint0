using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint0Copy.Commands;
using Sprint0Copy.Controllers;
using Sprint0Copy.Sprites;

namespace Sprint0Copy
{
    public class Game1 : Game
    {
        
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        public StandingStillSprite IdleMario {  get; set; }
        public WalkingInPlaceSprite WalkingMario { get; set; }
        public RunningMario RunningMario { get; set; }
        public FloatingMario FloatingMario { get; set; }

        private IController keyboardController;
        private IController mouseController;

        public ISprite CurrentSprite { get; set; }

        public ICommand CurrentCommand { get; set; }

        private SpriteFont font;
        private ISprite text;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Texture2D texture = Content.Load<Texture2D>("SuperMarioSprites");
            font = Content.Load<SpriteFont>("Credits");

            //Create Sprites
            IdleMario = new StandingStillSprite(texture, new Vector2(211, 0), 13, 16);
            WalkingMario = new WalkingInPlaceSprite(texture, 241, 331, 3, 16, 16);
            FloatingMario = new FloatingMario(texture, new Vector2(0, 16), 15, 14, 200);
            RunningMario = new RunningMario(texture, 241, 331, 3, 16, 16);

            CurrentSprite = IdleMario;

            //Create Text class to draw text
            text = new Text(font);

            CurrentCommand = new StandInPlaceCommand(IdleMario);
            
            //Create input controllers
            keyboardController = new KeyboardController(this);
            mouseController = new MouseController(this, new QuitCommand(this));

        }

        protected override void Update(GameTime gameTime)
        {      
            mouseController.Update(this);
            keyboardController.Update(this);

            CurrentSprite.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            CurrentSprite.Draw(spriteBatch, new Vector2(400, 200));
            text.Draw(spriteBatch, new Vector2(350, 300));

            spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}
