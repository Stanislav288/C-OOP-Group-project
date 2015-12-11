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

    public   class Collision
    {
        
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern uint MessageBox(IntPtr hWnd, String text, String caption, uint type);
         
        public static void DetectCollision(Crusader crusader1)
        {
           
            foreach (var enemy in Enemy.EnemiesList)
            {
                /*
                (crusader1.Rectangle).Intersects(enemy.Rectangle)
                && ((crusader1.CurrentAnimation.Equals(crusader1.CrusaderAttack_Left_Mid) && crusader1.CurrentAnimation.CurrentFrame.Equals(4))
                || (crusader1.CurrentAnimation .Equals(crusader1.CrusaderAttack_Right_Mid) && crusader1.CurrentAnimation.CurrentFrame.Equals(4) ))
                 */
                if ((crusader1.Rectangle).Intersects(enemy.Rectangle)
                && ((crusader1.CurrentAnimation.Equals(crusader1.CrusaderAttack_Left_Mid) && crusader1.CurrentAnimation.CurrentFrame.Equals(4))
                || (crusader1.CurrentAnimation.Equals(crusader1.CrusaderAttack_Right_Mid) && crusader1.CurrentAnimation.CurrentFrame.Equals(4))))
                {
                    
                    enemy.CurrentHealth =enemy.CurrentHealth - crusader1.AttackPoints;
                    /*
                    MessageBox( new IntPtr(0), ((crusader1.Rectangle).Intersects(enemy.Rectangle))+"", "Warning", 3);
                    MessageBox(
                       new IntPtr(0),
                       String.Format("crusader {0}  {1}  {2}  {3}", crusader1.Rectangle.X, crusader1.Rectangle.Y, crusader1.Rectangle.Width, crusader1.Rectangle.Height),
                       "Warning", 3);
                    MessageBox(
                    new IntPtr(0),
                    String.Format("enemy {0}  {1}  {2}  {3}", enemy.Rectangle.X, enemy.Rectangle.Y, enemy.Rectangle.Width, enemy.Rectangle.Height),
                    "Warning", 3);
                    /*
                    crusader1.X = 0;
                    crusader1.Y = 0;
                     */
                    /*
                    MessageBox(
                        new IntPtr(0),
                        String.Format("attack"+enemy.AttackPoints+"hp"+enemy.HealthPoints+"def"+enemy.DefensePoints+"currentHp"+enemy.CurrentHealth+"  "+enemy.HealthBar.IHaveToDeleteThisBar), 
                        "Warning", 3);
                    Thread.Sleep(10000);
                    */
                }

            }                                   
        }
    }
}