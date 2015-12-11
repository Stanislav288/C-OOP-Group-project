using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Lonely_Wolf
{
    public abstract class Enemy:Characters
    {
        private static List<Enemy> enemiesList=new List<Enemy>();

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
        public virtual Animation CurrentEnemy { get; set; }
       
    }
}
