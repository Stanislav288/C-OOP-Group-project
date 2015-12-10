using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lonely_Wolf
{

   public class Animation
    {
        Texture2D animation;
        private Rectangle sourceRectangle;
        //private Vector2 position;
        private float elapsed;
        private float frameTime;
        private int numberOfFrames;
        private int currentFrame;
        private int frameWidth;
        private int frameHeight;
        private bool looping;
        private int x;
        private int y;
        private GameObject gameObject;
        public Animation(ContentManager Content,GameObject gameObject,string asset,float frameSpeed,int numberOfFrames,bool looping)
        {
            this.frameTime = frameSpeed;
            this.NumberOfFrames = numberOfFrames;
            this.looping = looping;
            this.animation = Content.Load<Texture2D>(asset);
            this.FrameWidth = (animation.Width / numberOfFrames);
            //this.frameHeight = (animation.Height/numberOfFrames);
            this.frameHeight = animation.Height;
            this.gameObject = gameObject;
        }
       
       public  int  X
       {
           get { return this.gameObject.X; }
           set { gameObject.X = value; }
       }
       public  int Y
       {
           get { return this.gameObject.Y; }
           set { gameObject.Y = value; }
       }
       
       public int NumberOfFrames
       {
           get { return this.numberOfFrames; }
           private set { this.numberOfFrames = value; }

       }

        public int FrameWidth
        {
            get { return this.frameWidth; }
           private set { this.frameWidth = value; }
        }

        public int FrameHeight
        {
            get { return this.frameHeight; }
            private set { this.frameHeight = value; }
        }

       public Rectangle SourceRectangle
       {
           get { return this.sourceRectangle; }
           set { this.sourceRectangle = value; }
       }
        public void PlayAnimation(GameTime gameTime)
        {
            elapsed += (float) gameTime.ElapsedGameTime.TotalMilliseconds;
            sourceRectangle=new Rectangle(currentFrame*frameWidth,0,frameWidth,frameHeight);

            if (elapsed >= frameTime)
            {
                if (currentFrame >= numberOfFrames - 1)
                {
                    if (looping)
                    {
                        currentFrame = 0;
                    }

                }
                else
                {
                    currentFrame++;
                }
                elapsed = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(animation, new Vector2(gameObject.X,gameObject.Y), sourceRectangle, Color.White, 0f, new Vector2(0, 0), 1f, SpriteEffects.None, 1f);
        }
    }
}
