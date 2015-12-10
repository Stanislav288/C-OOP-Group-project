using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private int fullHealth;
        private int currentHealth;
        private Color barColor;
        private GameObject gameObject;
        public HealthBar(ContentManager content,GameObject gameObject)
        {
            position = new Vector2(gameObject.X, gameObject.Y);
            LoadContent(content);
            fullHealth=lifeBar.Width;
            currentHealth = fullHealth;
            this.gameObject = gameObject;
        }

        /*
        public GameObject GameObject
        {
            get { return this.gameObject; }
            private set { this.gameObject = value; }
        }*/
        public int X
        {
            get { return this.gameObject.X; }
            set { gameObject.X = value; }
        }
        public int Y
        {
            get { return this.gameObject.Y; }
            set { gameObject.Y = value; }
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
            if (currentHealth >= 0)
            {
                currentHealth--;
            }
            this.Position=new Vector2(X,Y);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(lifeBar, Position, new Rectangle(X, Y, currentHealth, lifeBar.Height), barColor);
            spriteBatch.Draw(container, Position, Color.White);
        }

        public void HealthColor()
        {
            if (currentHealth >= lifeBar.Width*0.75)
            {
                barColor=Color.Green;
            }
            else if (currentHealth >= lifeBar.Width*0.25)
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
