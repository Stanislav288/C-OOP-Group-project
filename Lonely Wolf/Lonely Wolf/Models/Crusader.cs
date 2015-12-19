using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Lonely_Wolf
{
    public class Crusader : MainCharacter
    {
       

        public Crusader(int x, int y, int width, int height, Rectangle rectangle)
            : base(x, y, width, height, rectangle)
        {

            this.HealthPoints = (int)Enums.CrusaderStats.Health;
            this.AttackPoints = (int)Enums.CrusaderStats.Attack;
            this.DefensePoints = (int)Enums.CrusaderStats.Defense;
            this.CurrentHealth = this.HealthPoints;
        }
   
        public void LoadCharacterContent(ContentManager Content)
        {
            WalkingRight = new Animation(Content, this, "Crusader-walking_right", 150f, 12, true);
            WalkingLeft = new Animation(Content, this, "Crusader-walking_left", 150f, 12, true);
            Attack_Right_Mid = new Animation(Content, this, "Crusader-attack_right_mid", 150f, 7, true);
            Attack_Left_Mid = new Animation(Content, this, "Crusader-attack_left_mid", 150f, 7, true);
            CurrentAnimation = WalkingLeft;
            this.HealthBar = new HealthBar(Content, this);

        }
    }
}
