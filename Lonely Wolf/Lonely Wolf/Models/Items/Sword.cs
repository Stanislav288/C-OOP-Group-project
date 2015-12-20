
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Lonely_Wolf.Models.Items
{
   public class Sword:Items,IItem
    {
        
        public Sword(int x, int y):base(x,y)
       {
           this.ActionPoints = 6;
            
        }

       public override void LoadItemContent(ContentManager Content)
       {
           this.Animation = Content.Load<Texture2D>("Sword");
       }

       public override void Get(MainCharacter mainCharacter)
       {
           base.Get(mainCharacter);
           mainCharacter.AttackPoints += this.ActionPoints;
        }
    }
}
