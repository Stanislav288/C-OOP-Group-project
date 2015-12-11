using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lonely_Wolf.Interfaces;
using Microsoft.Xna.Framework;

namespace Lonely_Wolf
{
   public  abstract class MainCharacter:Characters
    {
       public MainCharacter(int x, int y, int width, int height, Rectangle rectangle, int healthPoint, int attackPoins, int defensePoints, int range)
           : base(x, y, width, height, rectangle, healthPoint, attackPoins, defensePoints, range)
       {
       }
    }
}
