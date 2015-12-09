using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lonely_Wolf.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Lonely_Wolf
{
    public abstract class Characters:GameObject,IAttackable,IMovable
    {
        private int x;
        private int y;
        public Characters(Rectangle rectangle, int x, int y, int width, int height)
            : base(rectangle, x, y, width, height)
        {

        }

        public double Attack { get; set; }
                       
        public Vector2 Move()
        {
            throw new NotImplementedException();
        }

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public virtual void LoadCharacterContent(ContentManager Content)
        {
            
        }
    }
}
