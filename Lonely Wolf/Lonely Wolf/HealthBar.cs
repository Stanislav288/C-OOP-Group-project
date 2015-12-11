using System;
using System.Collections.Generic;
using System.Linq;
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
            get { return this.CurrentCharacters.Y; }
            private set { CurrentCharacters.Y = value; }
        }

        public Vector2 Position { get; set; }
        /*
        public int X
        {
            get { return (int)this.GameObject.X; }
            // set {this.position=new Vector2(value,this.position.Y); }
        }
        public int Y
        {
            get { return (int)this.GameObject.Y - 50; }
            //set { this.position = new Vector2((int)this.position.X, value); }
        }
        */

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
            this.Position = new Vector2(X, Y);
        }

        public int IHaveToDeleteThisBar
        {
            get { return (int)(this.healthBarWidth * (this.CurrentCharacters.CurrentHealth / (float)this.CurrentCharacters.HealthPoints)); }
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            
            spriteBatch.Draw(this.lifeBar, Position, new Rectangle(X, Y,
                this.healthBarWidth, this.lifeBar.Height)
                , barColor);
            spriteBatch.Draw(container, Position, Color.White);
        }

        public void HealthColor()
        {
            this.healthBarWidth = (int)(healthBarWidth * (this.CurrentCharacters.CurrentHealth / (double)this.CurrentCharacters.HealthPoints));
            if (healthBarWidth >= lifeBar.Width * 0.75)
            {
                barColor=Color.Green;              
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
