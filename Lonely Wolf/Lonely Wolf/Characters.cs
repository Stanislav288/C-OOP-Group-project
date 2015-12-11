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
        private int x;
        private int y;
        private int healthPoints;
        private int attackPoints;
        private int defensePoints;
        private HealthBar currentHealth;
        private bool isAlive = true;
        protected Characters(int x, int y, int width, int height,Rectangle rectangle,int healthPoint,int attackPoins,int defensePoints,int range)
            : base(x, y, width, height, rectangle)
        {
            this.Health = healthPoint;
            this.Defense = defensePoints;
            this.Range = range;
             AddCharacter();
        }


        public int Range { get; set; }
        public int Defense { get; set; }
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
    }
}
