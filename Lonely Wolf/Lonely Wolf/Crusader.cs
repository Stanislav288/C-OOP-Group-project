using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Lonely_Wolf
{
   public  class Crusader:MainCharacter
   {
       private static Animation crusaderRightWalk;
       private static Animation crusaderLeftWalk;
       private static Animation crusaderAttack_Right_Mid;
       private static Animation crusaderAttack_Left_Mid;
       private static Animation currentAnimation;
      

     
           /*
       public sta Crusader(Rectangle rectangle, int x, int y, int width, int height) : base(rectangle, x, y, width, height)
       {
       }*/

       public Crusader(Rectangle rectangle, int x, int y, int width, int height) : base(rectangle, x, y, width, height)
       {
       }

       public static Animation CurrentAnimation
       {
           get { return currentAnimation; }
           set { currentAnimation = value; }
       }
       public static Animation CrusaderAttack_Right_Mid
       {
           get { return crusaderAttack_Right_Mid; }
       }
       public static Animation CrusaderAttack_Left_Mid
       {
           get { return crusaderAttack_Left_Mid; }
       }
       public static Animation CrusaderRightWalk
       {
           get { return crusaderRightWalk; }
       }
       public static Animation CrusaderLeftWalk
       {
           get { return crusaderLeftWalk; }
       }


       public static void LoadCharacterContent(ContentManager Content)
       {
           crusaderLeftWalk = new Animation(Content, "Crusader-walking_left", 150f, 12, true);
           crusaderRightWalk = new Animation(Content, "Crusader-walking_right", 150f, 12, true);
           crusaderAttack_Right_Mid = new Animation(Content, "Crusader-attack_right_mid", 150f, 7, true);
           crusaderAttack_Left_Mid = new Animation(Content, "Crusader-attack_left_mid", 150f, 7, true);
           currentAnimation = crusaderLeftWalk;
       }
      
   }
}
