using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Lonely_Wolf.Models.Items
{
  public abstract class TemporaryItem:Items,IItem,ITemporary
   {
        private bool isFinished = false;
        private int startAction=0;
        private int endAction ;
        private MainCharacter character;

        public TemporaryItem(int x ,int y):base(x,y)
       {
           
       }

       public bool IsFinished
       {
           get { return this.isFinished; }
            set { this.isFinished = value; }
       }

       protected MainCharacter Character
       {
            get { return this.character; }
       }
        public override void Get(MainCharacter mainCharacter)
       {
           base.Get(mainCharacter);
           this.character = mainCharacter;
       }

       public void Update(GameTime gameTime)
       {
           if (this.startAction==0)
           {
               this.startAction = (int)gameTime.TotalGameTime.Seconds;
               this.endAction = this.startAction + 10;
           }
           if (gameTime.TotalGameTime.Seconds <= endAction)
           {
                this.Action();
               
                
           }
           else
           {
               IsFinished = true;
           }
        
        }

       protected virtual void Action()
       {
           
       }
    }
}
