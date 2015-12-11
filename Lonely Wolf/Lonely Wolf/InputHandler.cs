using System.Web.UI.WebControls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace Lonely_Wolf
{

    public  class InputHandler
    {


        public static Animation InputHandlerMethod(
            KeyboardState inputHandler,
            Crusader crusader1,
            Enemy enemy1
            , Animation currentAnimation
            , Animation crusaderLeftWalk
            , Animation crusaderAttack_Left_Mid
            , Animation crusaderAttack_Right_Mid,
            Animation crusaderRightWalk,
            GameTime gameTime)
        {
            Collision.DetectCollision(crusader1,enemy1);
                if (inputHandler.IsKeyDown(Keys.Right))
                {
                    
                   currentAnimation.X += 2;
                    currentAnimation = crusaderRightWalk;
                    currentAnimation.PlayAnimation(gameTime);
                }
                else if (inputHandler.IsKeyDown(Keys.Left))
                {
                    currentAnimation.X -= 2;
                    currentAnimation = crusaderLeftWalk;
                    currentAnimation.PlayAnimation(gameTime);
                }
                else if (inputHandler.IsKeyDown(Keys.Down))
                {
                    currentAnimation = currentAnimation == crusaderLeftWalk ? crusaderLeftWalk : crusaderRightWalk;
                    currentAnimation.Y += 2;
                    currentAnimation.PlayAnimation(gameTime);
                    // currentAnimation = crusaderLeftWalk;
                }
                else if (inputHandler.IsKeyDown(Keys.Up))
                {
                    currentAnimation = currentAnimation == crusaderLeftWalk ? crusaderLeftWalk : crusaderRightWalk;
                    currentAnimation.Y -= 2;
                    currentAnimation.PlayAnimation(gameTime);
                    // currentAnimation = crusaderLeftWalk;
                }
                else if (inputHandler.IsKeyDown(Keys.Space))
                {
                    if (currentAnimation == crusaderRightWalk || currentAnimation == crusaderAttack_Right_Mid)
                    {
                        currentAnimation = crusaderAttack_Right_Mid;
                        currentAnimation.PlayAnimation(gameTime);
                    }
                    else
                    {
                        currentAnimation = crusaderAttack_Left_Mid;
                        currentAnimation.PlayAnimation(gameTime);
                    }
                }
                else
                {
                    currentAnimation.SourceRectangle = new Rectangle(0, 0, currentAnimation.FrameWidth,
                        currentAnimation.FrameHeight);
                }
            
            return currentAnimation;
            
        }

       
    }
    
}