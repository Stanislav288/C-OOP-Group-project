using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using Lonely_Wolf.Models;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Lonely_Wolf
{
    class Skeleton : Enemy
    {
      
        public Skeleton(int x, int y, int width, int height, Rectangle rectangle)
            : base(x, y, width, height, rectangle)
        {
            this.HealthPoints = (int)Enums.SkeletonStats.Health;
            this.AttackPoints = (int)Enums.SkeletonStats.Attack;
            this.DefensePoints = (int)Enums.SkeletonStats.Defense;
            this.CurrentHealth = this.HealthPoints;
        }


       
        
        public override void LoadCharacterContent(ContentManager Content)
        {
           // CurrentEnemy = new Animation(Content, this, "Skeleton_collision", 150f, 1, false);
            WalkingRight = new Animation(Content, this, "Skeleton-walking_right", 150f, 6, true);
            WalkingLeft = new Animation(Content, this, "Skeleton-walking_left", 150f, 6, true);
            Attack_Right_Mid = new Animation(Content, this, "Skeleton-attack_right_mid", 250f, 8, true);
            Attack_Left_Mid = new Animation(Content, this, "Skeleton-attack_left_mid", 250f, 8, true);
            CurrentAnimation = WalkingRight;
            this.HealthBar = new HealthBar(Content, this);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            //AI.Move(this,MainCharacter.MainCharactersList[0]);
            
        }
    }
}
