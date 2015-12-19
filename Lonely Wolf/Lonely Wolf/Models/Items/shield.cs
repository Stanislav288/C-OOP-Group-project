using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Lonely_Wolf.Models.Items
{
   public class Shield:Items,IItem
    {
        public Shield(int x, int y):base(x,y)
        {
            this.ActionPoints = 10;
        }

        public override void LoadItemContent(ContentManager Content)
        {
            this.Animation = Content.Load<Texture2D>("Shield");
        }

        public override void Get(MainCharacter mainCharacter)
        {

            mainCharacter.DefensePoints += this.ActionPoints;
            base.Get(mainCharacter);
        }
    }
}

