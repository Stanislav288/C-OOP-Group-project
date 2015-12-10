using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Lonely_Wolf
{
    class Skeleton:Enemy
    {
        private Animation currentEnemy;
        public Skeleton(int x, int y, int width, int height, Rectangle rectangle)
            : base(x, y, width, height, rectangle)
        {
        }

        public override Animation CurrentEnemy
        {
            get { return this.currentEnemy; }
            set { this.currentEnemy = value; }
        }
        
        public override void LoadCharacterContent(ContentManager Content)
        {
            currentEnemy = new Animation(Content,this, "Skeleton_collision", 150f, 1, false);
           
        }
    }
}
