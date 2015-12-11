﻿using System;
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
       private  Animation crusaderRightWalk;
       private  Animation crusaderLeftWalk;
       private  Animation crusaderAttack_Right_Mid;
       private  Animation crusaderAttack_Left_Mid;
       private  Animation currentAnimation;
      

     
           /*
       public sta Crusader(Rectangle rectangle, int x, int y, int width, int height) : base(rectangle, x, y, width, height)
       {
       }*/

       public Crusader(int x, int y, int width, int height, Rectangle rectangle, int healthPoint, int attackPoins, int defensePoints, int range)
           : base( x, y, width, height,rectangle ,healthPoint, attackPoins, defensePoints, range)
       {
       }

       public  Animation CurrentAnimation
       {
           get { return currentAnimation; }
           set { currentAnimation = value; }
       }
       public  Animation CrusaderAttack_Right_Mid
       {
           get { return crusaderAttack_Right_Mid; }
       }
       public  Animation CrusaderAttack_Left_Mid
       {
           get { return crusaderAttack_Left_Mid; }
       }
       public  Animation CrusaderRightWalk
       {
           get { return crusaderRightWalk; }
       }
       public  Animation CrusaderLeftWalk
       {
           get { return crusaderLeftWalk; }
       }


       public  void LoadCharacterContent(ContentManager Content)
       {
           crusaderLeftWalk = new Animation(Content, this, "Crusader-walking_left", 150f, 12, true);
           crusaderRightWalk = new Animation(Content, this, "Crusader-walking_right", 150f, 12, true);
           crusaderAttack_Right_Mid = new Animation(Content, this, "Crusader-attack_right_mid", 150f, 7, true);
           crusaderAttack_Left_Mid = new Animation(Content, this, "Crusader-attack_left_mid", 150f, 7, true);
           currentAnimation = crusaderLeftWalk;
        this.HealthBar = new HealthBar(Content, this);
       }
      
   }
}
