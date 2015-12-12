
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Lonely_Wolf.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Lonely_Wolf
{
    public abstract class Characters : GameObject, IAttackable, IMovable
    {
        private int x;
        private int y;
        private int healthPoints;
        private int attackPoints;
        private int defensePoints;
        private HealthBar healthBar;
        private int currentHealth;

        protected Characters(int x, int y, int width, int height, Rectangle rectangle)
            : base(x, y, width, height, rectangle)
        {

        }
        /*
        protected Characters(int x, int y, int width, int height, Rectangle rectangle, int healthPoints, int attackPoints, int defensePoints)
            : base(x, y, width, height, rectangle)
        {
            this.AttackPoints = attackPoints;
            this.HealthPoints = healthPoints;
            this.DefensePoints = defensePoints;
            this.CurrentHealth = healthPoints;
        }
        */
        public int CurrentHealth
        {
            get { return this.currentHealth; }
            set { this.currentHealth = value; }

        }

        public int AttackPoints
        {
            get { return this.attackPoints; }
            set { this.attackPoints = value; }

        }

        public int HealthPoints
        {
            get { return this.healthPoints; }
            set { this.healthPoints = value; }
        }
        public int DefensePoints
        {
            get { return this.defensePoints; }
            set { this.defensePoints = value; }
        }

        public Vector2 Move()
        {

            throw new NotImplementedException();
        }
        /*
        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        */
        public HealthBar HealthBar { get; set; }

        public virtual void Update()
        {
            this.HealthBar.Update();
            this.Rectangle = new Rectangle(this.X, this.Y, base.Rectangle.Width, base.Rectangle.Height);
        }     
        public virtual void LoadCharacterContent(ContentManager Content)
        {

        }

       
    }
}
