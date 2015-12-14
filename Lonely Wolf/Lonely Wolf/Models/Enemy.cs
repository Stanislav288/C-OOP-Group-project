using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lonely_Wolf.Models;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Lonely_Wolf
{
    public abstract class Enemy:Characters
    {
        private static List<Enemy> enemiesList=new List<Enemy>();
        //private Animation currentAnimation
      

        protected Enemy(int x, int y, int width, int height, Rectangle rectangle)
            : base(x, y, width, height, rectangle)
        {
            AddEnemy();
        }

        public static List<Enemy> EnemiesList
        {
            get {return enemiesList; }          
        }
        
        private void AddEnemy()
        {
            EnemiesList.Add(this);
        }
       // public virtual Animation CurrentEnemy { get; set; }
        public Animation CurrentAnimationMethod(Animation currentAnimation)
        {
            return currentAnimation;
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            this.CurrentAnimation.PlayAnimation(gameTime);
        }
    }
}
