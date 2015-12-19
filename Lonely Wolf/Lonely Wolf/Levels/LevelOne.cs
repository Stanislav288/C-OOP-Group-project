using System;
using System.Collections.Generic;
using System.Linq;

using Lonely_Wolf.Models.Items;
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
        public Enemy enemy1 = new Skeleton(200, 200, 53, 84, new Rectangle(200, 200, 53, 84));
        Sword sword = new Sword(300, 300);
        HealthPortion health = new HealthPortion(400, 400);
        Shield shield=new Shield(500,100);
        Herb herb=new Herb(500,200);
        Ring ring =new Ring(450 ,50);
        private List<ITemporary> temporary = Items.ItemsList.OfType<ITemporary>().ToList();
       
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
            foreach (var item in Items.ItemsList)
            {
                item.LoadItemContent(Content);
            }
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
            foreach (var item in temporary)
            {
                if (!item.IsFinished&&!item.IsAvalable)
                {
                    item.Update(gameTime);
                }
               
            }
          crusader1.Update(gameTime);
          enemy1.Update(gameTime);
          
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            crusader1.CurrentAnimation.Draw(spriteBatch);
            //spriteBatch.Draw(collisionExample,collisionExamplePosition);
            enemy1.CurrentAnimation.Draw(spriteBatch);
            enemy1.HealthBar.Draw(spriteBatch);
            crusader1.HealthBar.Draw(spriteBatch);
            foreach (var item in Items.ItemsList.Where(i=>i.IsAvalable==true))
            {
                item.Draw(spriteBatch);
            }
            
            //spriteBatch.Draw(spriteTexture, SpriteREct, SpriteColor);
           // crusader1.Rectangle.
            spriteBatch.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
