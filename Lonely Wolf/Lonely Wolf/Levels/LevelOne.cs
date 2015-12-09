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

        public static Texture2D collisionExample;
        Vector2 collisionExamplePosition = new Vector2(300,300);

        KeyboardState inputHandler;
        public Enemy enemy1=new Skeleton(new Rectangle(300,300,53,84),300,300,53,84 );
      
           
        public LevelOne()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        public static Texture2D CollisionExample
        {
            get { return collisionExample; }
            set { collisionExample = value; }
        }/*
        public static Animation CurrentAnimation
        {
            get {return currentAnimation; }
        }
        public static Animation CrusaderAttack_Right_Mid
        {
            get { return crusaderAttack_Right_Mid; }
        }
        public static Animation CrusaderAttack_Left_Mid
        {
            get { return crusaderAttack_Left_Mid; }
        }
       */
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
           Crusader.LoadCharacterContent(Content);
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
          Crusader.CurrentAnimation= InputHandler.InputHandlerMethod(
              inputHandler,
              Crusader.CurrentAnimation,
              Crusader.CrusaderLeftWalk,
              Crusader.CrusaderAttack_Left_Mid,
              Crusader.CrusaderAttack_Right_Mid,
              Crusader.CrusaderRightWalk,
              gameTime);
         
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            Crusader.CurrentAnimation.Draw(spriteBatch);
            //spriteBatch.Draw(collisionExample,collisionExamplePosition);
            enemy1.CurrentEnemy.Draw(spriteBatch);
            spriteBatch.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
