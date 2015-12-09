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
        
        public Enemy(Rectangle rectangle, int x, int y, int width, int height) : base(rectangle, x, y, width, height)
        {
            AddEnemy();
        }

        public static List<Enemy> EnemiesList
        {
            get {return enemiesList; }          
        }

        public virtual Animation CurrentEnemy { get; set; }
        private  void AddEnemy()
        {
            EnemiesList.Add(this);
        }
    }
}
