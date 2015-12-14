using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Web.UI.WebControls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

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

                        if (enemy.CurrentAnimation == enemy.WalkingRight || enemy.CurrentAnimation == enemy.Attack_Right_Mid)
                        {
                           enemy.CurrentAnimation = enemy.Attack_Right_Mid;
                           enemy.CurrentAnimation.PlayAnimation(gameTime);
                        }
                        if (enemy.CurrentAnimation == enemy.WalkingLeft || enemy.CurrentAnimation == enemy.Attack_Left_Mid)
                        {
                            enemy.CurrentAnimation = enemy.Attack_Left_Mid;
                            enemy.CurrentAnimation.PlayAnimation(gameTime);
                        }
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
                            enemy.CurrentAnimation = enemy.Attack_Right_Mid;
                            mainCharacter.CurrentHealth = mainCharacter.CurrentHealth - enemy.AttackPoints;
                        }  
                                // MessageBox(new IntPtr(0), enemy.CurrentHealth + "", "Warning", 3);                      
                            
                        }
                    }
                }
            }
        /*
        public Animation CurrentEnemyAnimation()
        {
            
        }*/
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
