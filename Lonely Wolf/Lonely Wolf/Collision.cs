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

    public class Collision
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern uint MessageBox(IntPtr hWnd, String text, String caption, uint type);

        private static bool isAttachPerformed = true;
        /*
        public static bool IsFirstTime
        {
            get { return isFirstTime; }
            set { isFirstTime = value; }
        }*/
        public static void DetectCollision(Crusader crusader1)
        {

            foreach (var enemy in Enemy.EnemiesList)
            {
                /*
                (crusader1.Rectangle).Intersects(enemy.Rectangle)
                && ((crusader1.CurrentAnimation.Equals(crusader1.CrusaderAttack_Left_Mid) && crusader1.CurrentAnimation.CurrentFrame.Equals(4))
                || (crusader1.CurrentAnimation.Equals(crusader1.CrusaderAttack_Right_Mid) && crusader1.CurrentAnimation.CurrentFrame.Equals(4)))
                 */

                if (crusader1.IsAttackAvaibleMethod() && (crusader1.Rectangle).Intersects(enemy.Rectangle)
                && ((crusader1.CurrentAnimation.Equals(crusader1.CrusaderAttack_Left_Mid) && crusader1.CurrentAnimation.CurrentFrame.Equals(4))
                || (crusader1.CurrentAnimation.Equals(crusader1.CrusaderAttack_Right_Mid) && crusader1.CurrentAnimation.CurrentFrame.Equals(4))))
                {

                       // MessageBox(new IntPtr(0), crusader1.CurrentAnimation.CurrentFrame +"", "Warning", 3);
                
                        enemy.CurrentHealth = enemy.CurrentHealth - crusader1.AttackPoints;
                       // MessageBox(new IntPtr(0), enemy.CurrentHealth + "", "Warning", 3);
                    //enemy.HealthBarUpdate();
                       /* MessageBox(new IntPtr(0), String.Format("enemyHP={0}  isAttackAvaible={1}  currentFrame={2} "
                            , enemy.CurrentHealth, crusader1.IsAttackAvaibleMethod(), crusader1.CurrentAnimation.CurrentFrame), "Warning", 3);
                    */
                   
                   
                }
            }
        }
    }
}