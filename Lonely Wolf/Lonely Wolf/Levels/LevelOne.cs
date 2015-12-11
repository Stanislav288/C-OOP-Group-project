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
        public Enemy enemy1 = new Skeleton(200, 200, 53, 84, new Rectangle(200, 200, 53, 84));

        public Crusader crusader1 = new Crusader(100, 100, 50, 50, new Rectangle(100, 100, 75, 110));
        public LevelOne()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        public  Texture2D CollisionExample
        {
            get { return collisionExample; }
            set { collisionExample = value; }
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
            inputHandler = Keyboard.GetState();
          crusader1.CurrentAnimation= InputHandler.InputHandlerMethod(
              inputHandler,   
              crusader1,
              enemy1,
              crusader1.CurrentAnimation,
              crusader1.CrusaderLeftWalk,
              crusader1.CrusaderAttack_Left_Mid,
              crusader1.CrusaderAttack_Right_Mid,
              crusader1.CrusaderRightWalk,
              gameTime);
         enemy1.CurrentEnemy.PlayAnimation(gameTime);

            crusader1.Update();
            enemy1.Update();
            base.Update(gameTime);           
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            crusader1.CurrentAnimation.Draw(spriteBatch);
            //spriteBatch.Draw(collisionExample,collisionExamplePosition);
            enemy1.CurrentEnemy.Draw(spriteBatch);
            enemy1.HealthBar.Draw(spriteBatch);
            crusader1.HealthBar.Draw(spriteBatch);
           
            //spriteBatch.Draw(spriteTexture, SpriteREct, SpriteColor);
           // crusader1.Rectangle.
            spriteBatch.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
