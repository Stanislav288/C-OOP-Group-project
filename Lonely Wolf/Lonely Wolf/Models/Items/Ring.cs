
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Lonely_Wolf.Models.Items
{
   public  class Ring:TemporaryItem,IItem,ITemporary
    {
        public Ring(int x, int y):base(x,y)
       {

        }

        protected override void Action()
        {
            int def = this.Character.DefensePoints;
            int attack = this.Character.AttackPoints;
            if (!IsFinished)
            {
                this.Character.DefensePoints = 100;
                this.Character.AttackPoints = 100;
            }
            else
            {
                this.Character.DefensePoints =def;
                this.Character.AttackPoints = attack;
            }

        }

        public override void LoadItemContent(ContentManager Content)
        {
            this.Animation = Content.Load<Texture2D>("Ring");
        }
    }
}
