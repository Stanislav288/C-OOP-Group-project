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
       private static List<MainCharacter> mainCharactersList = new List<MainCharacter>();
      



       protected MainCharacter(int x, int y, int width, int height, Rectangle rectangle)
           : base(x, y, width, height, rectangle)
       {
           AddMainCharacter();
       }
       public static List<MainCharacter> MainCharactersList
       {
           get { return mainCharactersList; }
       }
       private void AddMainCharacter()
       {
           MainCharactersList.Add(this);
       }/*
       public bool IsAttackAvaible
       {
           get { return this.isAttackAvaible; }
       }*/
       public override void Update(GameTime gameTime)
       {
           base.Update(gameTime);

       }
    }
}
