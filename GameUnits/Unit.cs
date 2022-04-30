using System;

namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public virtual int Health { get; set; }
        public abstract float Value { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }
        
        public abstract string Move();

        public override string ToString() => 
            $"Health - {Health}, \nValue - {Value}";
    }
}