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
       public MainCharacter(Rectangle rectangle, int x, int y, int width, int height) : base(rectangle, x, y, width, height)
       {
       }
    }
}
