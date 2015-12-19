using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Lonely_Wolf.Models.Items
{
   public class HealthPortion:Items,IItem
    {
        public HealthPortion(int x, int y):base(x,y)
        {

            this.ActionPoints = (int) Enums.CrusaderStats.Health;
        }

        public override void LoadItemContent(ContentManager Content)
        {
            this.Animation = Content.Load<Texture2D>("HealthPortion");
        }

        public override void Get(MainCharacter mainCharacter)
        {
           
            mainCharacter.CurrentHealth = this.ActionPoints;
            base.Get(mainCharacter);
        }
    }
}
