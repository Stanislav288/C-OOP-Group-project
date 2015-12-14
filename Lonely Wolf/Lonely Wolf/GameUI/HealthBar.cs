using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Web.UI.WebControls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Lonely_Wolf
{
    public class HealthBar
    {
        private Texture2D container, lifeBar;
        private Vector2 position;
        // private int fullHealth;
        // private int currentHealth;
        private int healthBarWidth;
        private Color barColor;
        private Characters currentCharacters;
        private int previousHealth;

        public HealthBar(ContentManager content, Characters currentCharacters)
        {
            position = new Vector2(currentCharacters.X, currentCharacters.Y);
            LoadContent(content);
            healthBarWidth = lifeBar.Width;
            // currentHealth = fullHealth;
            this.CurrentCharacters = currentCharacters;
        }


        public Characters CurrentCharacters
        {
            get { return this.currentCharacters; }
            private set { this.currentCharacters = value; }
        }

        public int X
        {
            get { return this.CurrentCharacters.X; }
            private set { CurrentCharacters.X = value; }
        }

        public int Y
        {
            get { return this.CurrentCharacters.Y-10; }
            private set { CurrentCharacters.Y = value; }
        }

        //public Vector2 Position { get; set; }

        private int PreviousHealth
        {
            get { return this.previousHealth; }
            set { this.previousHealth = value; }
        }
        public void LoadContent(ContentManager content)
        {
            container = content.Load<Texture2D>("healthBar");
            lifeBar = content.Load<Texture2D>("healthGauge");
        }


        public void Update()
        {
            HealthColor();
            /*
            if (currentHealth >= 0)
            {
                currentHealth--;
            }
             * */
            //this.Position = new Vector2(X, Y);
        }
    
        public void Draw(SpriteBatch spriteBatch)
        {
           
            spriteBatch.Draw(this.lifeBar, new Rectangle(this.X,this. Y,
                this.healthBarWidth, this.lifeBar.Height)
                , barColor);
            spriteBatch.Draw(container, new Vector2(this.X,this.Y), Color.White);
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern uint MessageBox(IntPtr hWnd, String text, String caption, uint type);
        public void HealthColor()
        {
            if (CurrentCharacters.CurrentHealth != this.PreviousHealth)
            {
                this.healthBarWidth = (int)(lifeBar.Width * (this.CurrentCharacters.CurrentHealth / (decimal)this.CurrentCharacters.HealthPoints));
               // MessageBox(new IntPtr(0), this.healthBarWidth + "healthbarwidth", "Warning", 3);
                this.PreviousHealth = CurrentCharacters.CurrentHealth;
            }
            if (healthBarWidth >= lifeBar.Width * 0.75)
            {
                barColor = Color.Green;
            }
            else if (healthBarWidth >= lifeBar.Width * 0.25)
            {
                barColor = Color.Yellow;
            }
            else
            {
                barColor = Color.Red;
            }
        }
    }
}
