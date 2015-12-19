using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Lonely_Wolf.Models.Items
{
   public class Herb:TemporaryItem,IItem,ITemporary
    {
       public Herb(int x ,int y):base(x,y)
       {
           
       }

       protected override void Action()
       {
            this.Character.CurrentHealth = (int)Enums.CrusaderStats.Health;
            
        }

       public override void LoadItemContent(ContentManager Content)
       {
            this.Animation = Content.Load<Texture2D>("Herb");
       }
    }
}
