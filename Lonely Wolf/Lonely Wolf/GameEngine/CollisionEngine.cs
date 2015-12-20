using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Lonely_Wolf.Models;
using Microsoft.Xna.Framework;
<<<<<<< HEAD
using Lonely_Wolf.Enums;
=======
using Microsoft.Xna.Framework.Graphics;
using Lonely_Wolf.Models.Items;
>>>>>>> origin/master

namespace Lonely_Wolf
{

    public class CollisionEngine
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern uint MessageBox(IntPtr hWnd, String text, String caption, uint type);

        //private static bool isAttackPerformed = true;
        /*
        public static bool IsFirstTime
        {
            get { return isFirstTime; }
            set { isFirstTime = value; }
        }*/

        public static void DetectCollision(GameTime gameTime)
        {
            foreach (var mainCharacter in MainCharacter.MainCharactersList)
            {
                foreach (var enemy in Enemy.EnemiesList)
                {
                    if ((mainCharacter.Rectangle).Intersects(enemy.Rectangle))
                    {

                        if (enemy.CurrentAnimation == enemy.WalkingRight ||
                            enemy.CurrentAnimation == enemy.Attack_Right_Mid)
                        {
                            enemy.CurrentAnimation = enemy.Attack_Right_Mid;
                            enemy.CurrentAnimation.PlayAnimation(gameTime);
                        }
                        if (enemy.CurrentAnimation == enemy.WalkingLeft ||
                            enemy.CurrentAnimation == enemy.Attack_Left_Mid)
                        {
                            enemy.CurrentAnimation = enemy.Attack_Left_Mid;
                            enemy.CurrentAnimation.PlayAnimation(gameTime);
                        }
<<<<<<< HEAD

=======
                        /*
                        else
                        {
                            enemy.CurrentAnimation = enemy.Attack_Left_Mid;
                           // currentAnimation.PlayAnimation(gameTime);
                        }
                        /*
                        enemy.CurrentAnimation =
                            enemy.CurrentAnimation == enemy.WalkingLeft
                                ? enemy.Attack_Left_Mid
                                : enemy.Attack_Right_Mid;
                        */
>>>>>>> origin/master
                        if (mainCharacter.IsAttackAvaibleMethod()
                            && ((mainCharacter.CurrentAnimation.Equals(mainCharacter.Attack_Left_Mid)
                                 && mainCharacter.CurrentAnimation.CurrentFrame.Equals(4))
                                || (mainCharacter.CurrentAnimation.Equals(mainCharacter.Attack_Right_Mid)
                                    && mainCharacter.CurrentAnimation.CurrentFrame.Equals(4))))
                        {
                            enemy.CurrentHealth = enemy.CurrentHealth - mainCharacter.AttackPoints;
                        }

                        if (enemy.IsAttackAvaibleMethod()
                            && ((enemy.CurrentAnimation.Equals(enemy.Attack_Left_Mid)
                                 && enemy.CurrentAnimation.CurrentFrame.Equals(4))
                                || (enemy.CurrentAnimation.Equals(enemy.Attack_Right_Mid)
                                    && enemy.CurrentAnimation.CurrentFrame.Equals(4))))
                        {
                            // enemy.CurrentAnimation = enemy.Attack_Right_Mid;
                            mainCharacter.CurrentHealth = mainCharacter.CurrentHealth - enemy.AttackPoints;
                        }
                        // MessageBox(new IntPtr(0), enemy.CurrentHealth + "", "Warning", 3);                      

                    }
                }
            }
<<<<<<< HEAD

            for (int i = 0; i < Enemy.EnemiesList.Count; i++)
            {
                for (int k = i + 1; k < Enemy.EnemiesList.Count; k++)
                {
                    Enemy firstEnemy = Enemy.EnemiesList[i];
                   Enemy secondEnemy= Enemy.EnemiesList[k];

                    Rectangle firstEnemyRectangle = new Rectangle(firstEnemy.X+firstEnemy.CurrentAnimation.FrameWidth/2,firstEnemy.Y-10,10,10);

                    Rectangle secondEnemyRectangle = new Rectangle(firstEnemy.X -10, firstEnemy.Y+ firstEnemy.CurrentAnimation.FrameHeight/2 , 10, 10);
                    
                    Rectangle thirdEnemyRectangle = new Rectangle(firstEnemy.X + firstEnemy.CurrentAnimation.FrameWidth / 2, firstEnemy.Y+ firstEnemy.CurrentAnimation.FrameHeight + 10, 10, 10);
                   
                    Rectangle fourthEnemyRectangle = new Rectangle(firstEnemy.X +firstEnemy.CurrentAnimation.FrameWidth+10, firstEnemy.Y + firstEnemy.CurrentAnimation.FrameHeight / 2, 10, 10);
                    bool boolExample = true;

                    if (!firstEnemy.Rectangle.Intersects(secondEnemy.Rectangle))
                    {
                        AI.Move(firstEnemy, MainCharacter.MainCharactersList[0]);
                       
                    }
                   else if (!firstEnemy.Rectangle.Intersects(secondEnemy.Rectangle))
                   {
                        AI.Move(secondEnemy, MainCharacter.MainCharactersList[0]);
                    }
                   else
                   {/*
                       if (!firstEnemyRectangle.Intersects(secondEnemy.Rectangle))
                       {
                           AI.MoveUp(firstEnemy, MainCharacter.MainCharactersList[0], ref boolExample);
                           //AI.Move(secondEnemy, MainCharacter.MainCharactersList[0]);
                       }
                       else if (!secondEnemyRectangle.Intersects(secondEnemy.Rectangle))
                       {
                           AI.MoveLeft(firstEnemy, MainCharacter.MainCharactersList[0], ref boolExample);
                          // AI.Move(secondEnemy, MainCharacter.MainCharactersList[0]);
                       }
                       else if (!thirdEnemyRectangle.Intersects(secondEnemy.Rectangle))
                       {
                           AI.MoveDown(firstEnemy, MainCharacter.MainCharactersList[0], ref boolExample);
                          // AI.Move(secondEnemy, MainCharacter.MainCharactersList[0]);
                       }
                       else if (!fourthEnemyRectangle.Intersects(secondEnemy.Rectangle))
                       {
                           AI.MoveRight(firstEnemy, MainCharacter.MainCharactersList[0], ref boolExample);
                         //  AI.Move(secondEnemy, MainCharacter.MainCharactersList[0]);
                       }
                       */
                        AI.Move(secondEnemy, MainCharacter.MainCharactersList[0]);
                    }


                }
            }
        }
/// <summary>
/// /////////////////
/// </summary>
/// <param name="x"></param>
/// <param name="y"></param>
/// <param name="direction"></param>
/// <param name="length"></param>
/// <param name="widthOfTheRay"></param>
/// <returns></returns>
/// 
/*
        public List<GameObject> RayCast(int x, int y, Directions direction, int length, int widthOfTheRay)
=======
            foreach (var mainCharacter in MainCharacter.MainCharactersList)
            {
                foreach (var items in Items.ItemsList)
                {
                    if ((mainCharacter.Rectangle).Intersects(items.Rectangle))
                    {
                        items.Get(mainCharacter);
                       
                    }
                }
            }
            /*

        public Animation CurrentEnemyAnimation()
>>>>>>> origin/master
        {
            List<GameObject> result = new List<GameObject>();

            int width = 0;
            int height = 0;

            switch (direction)
            {
                case Directions.Down:

                    width = widthOfTheRay;
                    height = length;

                    x -= width / 2;

                    break;

                case Directions.Up:

                    width = widthOfTheRay;
                    height = length;

                    y -= length;
                    x -= widthOfTheRay / 2;

                    break;

                case Directions.Left:

                    width = length;
                    x -= length;
                    height = widthOfTheRay;

                    y -= height / 2;

                    break;

                case Directions.Right:

                    width = length;
                    height = widthOfTheRay;

                    y -= height / 2;

                    break;
            }

            Rectangle rayCastLineRect = new Rectangle(x, y, width, height);
            GameObject rayCastObj = new GameObject();

            rayCastObj.rectangle = rayCastLineRect;

            result = GetCollidingObjects(allGameObjects, rayCastObj);

            somethingToDebug.Add(rayCastObj.rectangle);

            return result;
        }*/
<<<<<<< HEAD
    }
}
=======
            /*
            * if (enemy.IsAttackAvaibleMethod()
                            && ((enemy.CurrentAnimation.Equals(enemy.Attack_Left_Mid)
                                 && enemy.CurrentAnimation.CurrentFrame.Equals(4))
                                || (enemy.CurrentAnimation.Equals(enemy.Attack_Right_Mid)
                                    && enemy.CurrentAnimation.CurrentFrame.Equals(4))))
                        {
                            enemy.CurrentAnimation = enemy.Attack_Right_Mid;
                            mainCharacter.CurrentHealth = mainCharacter.CurrentHealth - enemy.AttackPoints;
                        }  
            * 
            * 
            * 
            */
        }
    }
}
>>>>>>> origin/master
