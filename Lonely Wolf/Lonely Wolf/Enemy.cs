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

        public Enemy(int x, int y, int width, int height, Rectangle rectangle,int healthPoint, int attackPoins, int defensePoints, int range)
            : base(x, y, width, height, rectangle,healthPoint,attackPoins,defensePoints,range)
        {
            
        }
     
        public virtual Animation CurrentEnemy { get; set; }
       
    }
}
