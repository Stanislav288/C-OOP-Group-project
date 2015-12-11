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
        private static List<Characters> charactersList = new List<Characters>();
        private List<Characters> targetsList = new List<Characters>();
        private int healthPoints;
        private int attackPoints;
        private int defensePoints;
        private HealthBar currentHealth;
        private Rectangle rangeRec;
        private bool isAlive = true;
        protected Characters(int x, int y, int width, int height,Rectangle rectangle,int healthPoint,int attackPoins,int defensePoints,int range)
            : base(x, y, width, height, rectangle)
        {
            this.Health = healthPoint;
            this.Defense = defensePoints;
            this.rangeRec=new Rectangle(this.X-range,this.Y-range,this.Width+2*range,this.Height+2*range);
             AddCharacter();
        }

        public List<Characters> TargetsList
        {
            get { return this.targetsList; }
        }

        public Rectangle Range
        {
            get { return this.rangeRec; }
        }
      
        public int Defense { get; set; }
        public double Attack { get; set; }
                        
        public Vector2 Move()
        {
            throw new NotImplementedException();
        }
        public HealthBar HealthBar { get; set; }
        public int Health { get; set; }
        

        public static List<Characters> CharactersList
        {
            get { return charactersList; }          
        }
        private void AddCharacter()
        {
            CharactersList.Add(this);
        }
        public virtual void LoadCharacterContent(ContentManager Content)
        {
         
        }
        public virtual void GetTargets()
        {
            foreach (var target in charactersList)
            {
                if (this.Range.Intersects(target.Rectangle)&&target != this)
                {
                   this.TargetsList.Add(target);
                }
            }
        }
    }
}
