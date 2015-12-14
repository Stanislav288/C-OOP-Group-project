using System;
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
        private Animation walkingRight;
        private Animation walkingLeft;
        private Animation attack_Right_Mid;
        private Animation attack_Left_Mid;
        private Animation currentAnimation;
        private bool isAttackAvaible;
        private bool isFirstAttack = true;

        protected Characters(int x, int y, int width, int height, Rectangle rectangle)
            : base(x, y, width, height, rectangle)
        {

        }
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
        public Animation CurrentAnimation
        {
            get { return  this.currentAnimation; }
            set { this.currentAnimation = value; }
        }
        public Animation WalkingRight
        {
            get { return this.walkingRight; }
            set { this.walkingRight = value; }
        }
        public Animation WalkingLeft
        {
            get { return this.walkingLeft; }
            set { this.walkingLeft = value; }
        }
        public Animation Attack_Right_Mid
        {
            get { return attack_Right_Mid; }
            set { this.attack_Right_Mid = value; }
        }
        public Animation Attack_Left_Mid
        {
            get { return attack_Left_Mid; }
            set { this.attack_Left_Mid = value; }
        }

        public HealthBar HealthBar { get; set; }

        public bool IsAttackAvaibleMethod()
        {
            if (this.CurrentAnimation.CurrentFrame != 4)
            {
                this.isFirstAttack = true;
            }
            if (this.CurrentAnimation.CurrentFrame == 4 && this.isFirstAttack)
            {
                this.isFirstAttack = false;
                return true;
            }

            return false;
        }
        public virtual void Update(GameTime gameTime)
        {
            this.HealthBar.Update();
            this.Rectangle = new Rectangle(this.X, this.Y, base.Rectangle.Width, base.Rectangle.Height);
            //this.CurrentAnimation.PlayAnimation(gameTime);
        }     
        public virtual void LoadCharacterContent(ContentManager Content)
        {

        }

       
    }
}
