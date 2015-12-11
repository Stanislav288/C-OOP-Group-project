using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Lonely_Wolf
{

    public   class Collision
    {
       

        public static void DetectCollision(Crusader crusader1,
            Enemy enemy1)
        {
            
            //Rectangle rect1 = new Rectangle(Crusader.CurrentAnimation.X, Crusader.CurrentAnimation.Y,
            //Crusader.CurrentAnimation.FrameWidth, Crusader.CurrentAnimation.FrameHeight);
            //Rectangle rect2 = new Rectangle(300,300,237, 109);

            if ((crusader1.Rectangle).Intersects(enemy1.Rectangle) 
                && (crusader1.CurrentAnimation == crusader1.CrusaderAttack_Left_Mid 
                || crusader1.CurrentAnimation == crusader1.CrusaderAttack_Right_Mid))
            {   
                crusader1.X = 0;
                crusader1.Y = 0;
            }
             
        }
    }
}