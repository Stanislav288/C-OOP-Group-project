using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lonely_Wolf.Interfaces;
using Microsoft.Xna.Framework;

namespace Lonely_Wolf.Models
{
    public static class AI
    {
        public static void Attack(Characters enemy)
        {
            throw new NotImplementedException();
        }

        public  static void Move(Characters enemy,MainCharacter mainCharacter)
        {
            bool reachMainCharacther=false;

            MoveLeft(enemy, mainCharacter, ref reachMainCharacther);

            MoveRight(enemy, mainCharacter, ref reachMainCharacther);

            MoveDown(enemy, mainCharacter, ref reachMainCharacther);

            MoveUp(enemy, mainCharacter, ref reachMainCharacther);
           

            if (!reachMainCharacther)
            {
                enemy.CurrentAnimation.SourceRectangle = new Rectangle(0, 0, enemy.CurrentAnimation.FrameWidth,
                    enemy.CurrentAnimation.FrameHeight);
            }            
        }

        public static void MoveUp(Characters enemy, MainCharacter mainCharacter, ref bool reachMainCharacther)
        {

            if (mainCharacter.Y + (mainCharacter.CurrentAnimation.FrameHeight - enemy.CurrentAnimation.FrameHeight) < enemy.Y)
            {
                enemy.CurrentAnimation = enemy.CurrentAnimation == enemy.WalkingLeft ? enemy.WalkingLeft : enemy.WalkingRight;
                reachMainCharacther = true;
                enemy.Y -= 1;
            }
        }

        public static void MoveDown(Characters enemy, MainCharacter mainCharacter, ref bool reachMainCharacther)
        {
            if (mainCharacter.Y + (mainCharacter.CurrentAnimation.FrameHeight - enemy.CurrentAnimation.FrameHeight) > enemy.Y)
            {
                enemy.CurrentAnimation = enemy.CurrentAnimation == enemy.WalkingLeft ? enemy.WalkingLeft : enemy.WalkingRight;
                reachMainCharacther = true;
                enemy.Y += 1;
            }
        }

        public static void MoveRight(Characters enemy, MainCharacter mainCharacter, ref bool reachMainCharacther)
        {
            if (mainCharacter.X - 50 < enemy.X)
            {
                enemy.X -= 1;
                reachMainCharacther = true;
                enemy.CurrentAnimation = enemy.WalkingLeft;
            }
        }

        public static void MoveLeft(Characters enemy, MainCharacter mainCharacter, ref bool reachMainCharacther)
        {
            if (mainCharacter.X + 50 > enemy.X)
            {
                enemy.X += 1;
                reachMainCharacther = true;
                enemy.CurrentAnimation = enemy.WalkingRight;
            }
        }
    }
}
