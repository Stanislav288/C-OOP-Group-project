using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Lonely_Wolf
{
    class Skeleton : Enemy
    {
        private Animation _currentEnemy;
        public Skeleton(int x, int y, int width, int height, Rectangle rectangle)
            : base(x, y, width, height, rectangle)
        {
            this.HealthPoints = (int)Enums.SkeletonStats.Health;
            this.AttackPoints = (int)Enums.SkeletonStats.Attack;
            this.DefensePoints = (int)Enums.SkeletonStats.Defense;
            this.CurrentHealth = this.HealthPoints;
        }

        public override Animation CurrentEnemy
        {
            get { return this._currentEnemy; }
            set { this._currentEnemy = value; }
        }



        public override void LoadCharacterContent(ContentManager Content)
        {
            _currentEnemy = new Animation(Content, this, "Skeleton_collision", 150f, 1, false);
            this.HealthBar = new HealthBar(Content, this);
        }
    }
}
