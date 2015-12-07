using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lonely_Wolf
{
    public class LevelOne : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Texture2D imageMoveExample;
        Vector2 imageMoveExamplePosition = Vector2.Zero;

        KeyboardState inputHandler;

        private Animation crusaderRightWalk;
        private Animation crusaderLeftWalk;
        private Animation crusaderAttack_Right_Mid;
        private Animation crusaderAttack_Left_Mid;
        private Animation currentAnimation;

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

            crusaderLeftWalk = new Animation(Content, "Crusader-walking_left", 150f, 12, true);
            crusaderRightWalk = new Animation(Content, "Crusader-walking_right", 150f, 12, true);
            crusaderAttack_Right_Mid = new Animation(Content, "Crusader-attack_right_mid", 150f, 7, true);
            crusaderAttack_Left_Mid = new Animation(Content, "Crusader-attack_left_mid", 150f, 7, true);
            currentAnimation = crusaderLeftWalk;
           

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
          currentAnimation= InputHandler.InputHandlerMethod(inputHandler,currentAnimation,crusaderLeftWalk,crusaderAttack_Left_Mid,crusaderAttack_Right_Mid,crusaderRightWalk,gameTime);
          
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            currentAnimation.Draw(spriteBatch);
            spriteBatch.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
