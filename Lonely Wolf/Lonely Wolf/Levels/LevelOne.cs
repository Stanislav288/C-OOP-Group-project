using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lonely_Wolf
{
    public  class LevelOne : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public  Texture2D collisionExample;
        Vector2 collisionExamplePosition = new Vector2(300,300);

        KeyboardState inputHandler;
        public Crusader crusader1 = new Crusader(100, 100, 50, 50, new Rectangle(100, 100, 75, 110));
        public Enemy enemy1 = new Skeleton(400, 400, 81, 87, new Rectangle(400, 400, 81, 87));
        public Enemy enemy2 = new Skeleton(200, 200, 81, 87, new Rectangle(200, 200, 81, 87));
       
        public LevelOne()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
      
        protected override void Initialize()
        {
           
            // TODO: Add your initialization logic here

            base.Initialize();
        }
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            //collisionExample = Content.Load<Texture2D>("collision");
            crusader1.LoadCharacterContent(Content);

           enemy1.LoadCharacterContent(Content);
           enemy2.LoadCharacterContent(Content);
        }


        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }
            CollisionEngine.DetectCollision(gameTime);
            inputHandler = Keyboard.GetState();
          InputHandler.InputHandlerMethod(
              inputHandler,   
              crusader1,
              gameTime);
         //enemy1.CurrentAnimation.PlayAnimation(gameTime);

          crusader1.Update(gameTime);

          enemy1.Update(gameTime);
          enemy2.Update(gameTime);

            base.Update(gameTime);           
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);

            crusader1.CurrentAnimation.Draw(spriteBatch);
            crusader1.HealthBar.Draw(spriteBatch);
            //spriteBatch.Draw(collisionExample,collisionExamplePosition);
            enemy1.CurrentAnimation.Draw(spriteBatch);
            enemy1.HealthBar.Draw(spriteBatch);

            enemy2.CurrentAnimation.Draw(spriteBatch);
            enemy2.HealthBar.Draw(spriteBatch);
            //spriteBatch.Draw(spriteTexture, SpriteREct, SpriteColor);
           // crusader1.Rectangle.
            spriteBatch.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
