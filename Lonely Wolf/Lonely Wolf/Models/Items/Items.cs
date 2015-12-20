using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Lonely_Wolf.Models;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Lonely_Wolf.Models.Items
{
  public abstract class Items:GameObject,IItem
  {
        int number=0;
        private bool isAvailable = true;
        private int actionPoints;
        private static List<Items>itemsList = new List<Items>();
        private Texture2D animation;
        public Items(int x, int y ) 
            : base(x, y, 25, 25, new Rectangle(x,y,25,25))
        {
            
            AddItem();
        }

      public bool IsAvalable { get { return this.isAvailable; } set { this.isAvailable = value; } }
      public int ActionPoints
        {
            get { return this.actionPoints; }
            set { this.actionPoints = value; }
        }

      protected Texture2D Animation
        {
          get { return this.animation; }
          set { this.animation = value; }
        }
        public virtual void LoadItemContent(ContentManager Content)
        {

        }
        public  void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Animation, new Vector2(this.X, this.Y), Color.White);
        }
        public virtual void Get(MainCharacter mainCharacter)
        {
            this.IsAvalable = false;
        }
        public static List<Items> ItemsList
        {
            get { return itemsList; }
        }
        private void AddItem()
        {
          ItemsList.Add(this);
        }
        protected void RemoveItem()
        {
            ItemsList.Remove(this);
        }
    }
}
