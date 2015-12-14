using System.Web.UI.WebControls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace Lonely_Wolf
{

    public class InputHandler
    {


        public static void InputHandlerMethod(
            KeyboardState inputHandler,
           MainCharacter crusader,
            GameTime gameTime)
        {

            if (inputHandler.IsKeyDown(Keys.Right))
            {

                crusader.CurrentAnimation.X += 2;
                crusader.CurrentAnimation = crusader.WalkingRight;
                crusader.CurrentAnimation.PlayAnimation(gameTime);
            }
            else if (inputHandler.IsKeyDown(Keys.Left))
            {
                crusader.CurrentAnimation.X -= 2;
                crusader.CurrentAnimation = crusader.WalkingLeft;
                crusader.CurrentAnimation.PlayAnimation(gameTime);
            }
            else if (inputHandler.IsKeyDown(Keys.Down))
            {
                crusader.CurrentAnimation = crusader.CurrentAnimation == crusader.WalkingLeft ? crusader.WalkingLeft : crusader.WalkingRight;
                crusader.CurrentAnimation.Y += 2;
                crusader.CurrentAnimation.PlayAnimation(gameTime);
                // currentAnimation = crusaderLeftWalk;
            }
            else if (inputHandler.IsKeyDown(Keys.Up))
            {
                crusader.CurrentAnimation = crusader.CurrentAnimation == crusader.WalkingLeft ? crusader.WalkingLeft : crusader.WalkingRight;
                crusader.CurrentAnimation.Y -= 2;
                crusader.CurrentAnimation.PlayAnimation(gameTime);
                // currentAnimation = crusaderLeftWalk;
            }
            else if (inputHandler.IsKeyDown(Keys.Space))
            {
                if (crusader.CurrentAnimation == crusader.WalkingRight || crusader.CurrentAnimation == crusader.Attack_Right_Mid)
                {
                    crusader.CurrentAnimation = crusader.Attack_Right_Mid;
                    crusader.CurrentAnimation.PlayAnimation(gameTime);
                }
                else
                {
                    crusader.CurrentAnimation = crusader.Attack_Left_Mid;
                    crusader.CurrentAnimation.PlayAnimation(gameTime);
                }
            }
            else
            {
                crusader.CurrentAnimation.SourceRectangle = new Rectangle(0, 0, crusader.CurrentAnimation.FrameWidth,
                     crusader.CurrentAnimation.FrameHeight);
            }

            //return currentAnimation;

        }


    }

}